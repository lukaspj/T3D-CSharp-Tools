using System.Linq;
using T3DCSharpGenerator.TorqueStructures;

namespace T3DCSharpGenerator.Generators.Templates
{
   class MethodDeclarationTemplate : Template
   {
      public MethodDeclarationTemplate(TorqueFunction torqueFunction)
      {
         string header = GetFunctionHeader(torqueFunction, false);
         string body = GetFunctionBody(torqueFunction);
         Content = $"{header}\n" +
                   $"{{\n" +
                   $"{Utils.Indent(1)}{body}\n" +
                   $"}}";
      }

      private static string GetFunctionBody(TorqueFunction torqueFunction)
      {
         // Handle all the special-case marshallings here.
         string prefix = "";
         // First handle the fact that C++ use :: for namespaces while C# uses .
         torqueFunction.Parameters.ToList().ForEach(x =>
         {
            if (x.DefaultValue.Contains("::"))
            {
               prefix += $"if ({x.Name} == null) {x.Name} = {x.DefaultValue.Replace("::", ".")};\n{Utils.Indent(3)}";
            }
         });

         string argsString = torqueFunction.GetArgsString();
         // Prepend a comma to the argsString if necessary
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value)
            argsString = ", " + argsString;
         // Generate the return statement
         string returnStr = GetReturn(torqueFunction.Type,
            $"InternalUnsafeMethods.{torqueFunction.Name}(ObjectPtr->RefPtr->ObjPtr{argsString})");

         // Handle a return of an array of strings
         torqueFunction.Parameters.ToList().ForEach(x =>
         {
            if (x.Type.ManagedType == "string[]")
            {
               prefix += $"IntPtr[] tmp_{x.Name} = StringMarshal.StringArrayToIntPtrArray({x.Name});\n" +
                         $"{Utils.Indent(3)}{torqueFunction.Type.ManagedType} _retVal = {returnStr.Substring(7)};\n" +
                         $"{Utils.Indent(3)}StringMarshal.FreeIntPtrArray(tmp_{x.Name});\n{Utils.Indent(3)}";
               returnStr = "_retVal";
            }
         });

         // If the function _is not_ stringly typed, then we can just return whatever we have up untill now
         if (torqueFunction.IsStringlyTyped == null || !torqueFunction.IsStringlyTyped.Value)
         {
            return prefix + returnStr + ";";
         }

         // If the function _is_ stringly typed, then we have to convert all parameters to an array of 
         //  string-parameters and a parameter count.
         prefix += $"List<string> tmp_arg_list = new List<string> {{\"\"}};\n{Utils.Indent(3)}";
         torqueFunction.Parameters.ToList().ForEach(x =>
         {
            if (TorqueType.ClassNames.Contains(x.Type.ManagedType) && x.VarArgs)
            {
               prefix += $"tmp_arg_list.AddRange({x.Name}.Select(x => x.getName()));\n{Utils.Indent(3)}";
            }
            else if (TorqueType.ClassNames.Contains(x.Type.ManagedType))
            {
               prefix += $"tmp_arg_list.Add({x.Name}.getName());\n{Utils.Indent(3)}";
            }
            else if (x.Type.ManagedType == "string[]" || x.VarArgs)
            {
               prefix += $"tmp_arg_list.AddRange({x.Name});\n{Utils.Indent(3)}";
            }
            else
            {
               prefix += $"tmp_arg_list.Add({x.Name}.ToString());\n{Utils.Indent(3)}";
            }
         });
         return prefix +
                GetReturn(torqueFunction.Type,
                   $"InternalUnsafeMethods.{torqueFunction.Name}(ObjectPtr->RefPtr->ObjPtr, tmp_arg_list.Count, tmp_arg_list.ToArray())") +
                ";";
      }

      private static string GetReturn(TorqueType type, string stmt)
      {
         string prefix = "";
         if (!type.IsVoid) prefix = "return ";
         return prefix + type.GetReturnString(stmt);
      }

      private static string GetFunctionHeader(TorqueFunction torqueFunction, bool isStatic = true)
      {
         string _static = isStatic ? "static " : "";

         return
            $"public {_static}{torqueFunction.Type.ManagedType} {torqueFunction.Name}({torqueFunction.GetParametersString()})";
      }
   }
}