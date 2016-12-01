using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using T3DCSharpGenerator.Generators.Templates;
using T3DCSharpGenerator.TorqueStructures;

namespace T3DCSharpGenerator.Generators
{
   class ClassGenerator : Generator
   {
      public override IEnumerable<KeyValuePair<string, Template>> GenerateFor(JArray classes)
      {
         return classes.ToList().Select(OutputClass);
      }

      private KeyValuePair<string, Template> OutputClass(JToken classObject)
      {
         MethodInternalsRegionTemplate classInternals = GenerateClassInternals(classObject);
         MethodDeclarationRegionTemplate classDecls = GenerateClassDeclarations(classObject);

         Template classTemplate = new SimClassTemplate();
         if (classObject["ClassName"].ToString() == "SimObject")
         {
            classTemplate = new SimObjectClassTemplate();
         }

         string parentString = "";
         if (!string.IsNullOrEmpty(classObject["ParentClassName"].ToString()))
         {
            parentString = ": " + classObject["ParentClassName"];
         }

         classTemplate.ReplaceField("ClassName", classObject["ClassName"].ToString());
         classTemplate.ReplaceField("ParentString", parentString);
         classTemplate.ReplaceField("Internals", classInternals.Indent(2).Content);
         classTemplate.ReplaceField("Declarations", classDecls.Indent(2).Content);

         return new KeyValuePair<string, Template>(classObject["ClassName"].ToString(), classTemplate);
      }

      private MethodInternalsRegionTemplate GenerateClassInternals(JToken classObject)
      {
         MethodInternalsRegionTemplate template = new MethodInternalsRegionTemplate();

         string classInternals =
            classObject["Methods"].Aggregate("", (x, method) => x + "\n" + MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction((JObject)method)).Indent().Content);

         // We append the create function to the rest of the internals, so we can use it in the constructor
         JObject token = new JObject
         {
            ["Type"] = classObject["ClassName"] + "*",
            ["Name"] = $"{classObject["ClassName"]}_create",
            ["Comment"] = "/**/",
            ["Parameters"] = new JArray(),
            ["IsStringlyTyped"] = false
         };

         classInternals += "\n" + FunctionGenerator.FunctionToInternal(new TorqueFunction(token)).Indent().Content;


         if (classObject["ClassName"].ToString() == "SimObject")
         {
            // registerObject is a special method, which is not exposed to TorqueScript, so we have to add it manually here
            JObject registerObjectFunction = new JObject
            {
               ["Type"] = "bool",
               ["Name"] = $"registerObject",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(),
               ["IsStringlyTyped"] = false
            };

            classInternals += MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction(registerObjectFunction)).Indent().Content;
         }
         template.ReplaceField("classInternals", classInternals);
         return template;
      }

      private MethodInternalTemplate MethodToInternal(string className, TorqueFunction torqueFunction)
      {
         string argsString = torqueFunction.GetNativeArgsString();
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value) argsString = ", " + argsString;
         string parameterStringNative = torqueFunction.GetNativeParametersString(true);
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value) parameterStringNative = ", " + parameterStringNative;
         string parameterString = torqueFunction.GetNativeParametersString();
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value) parameterString = ", " + parameterString;

         MethodInternalTemplate template = new MethodInternalTemplate();

         template.ReplaceField("Name", torqueFunction.Name);
         template.ReplaceField("C-Name", torqueFunction.RealName);
         template.ReplaceField("ClassName", className);
         template.ReplaceField("NativeReturnType", torqueFunction.Type.NativeReturnType);
         template.ReplaceField("NativeParametersString", parameterStringNative);
         template.ReplaceField("InternalParametersString", parameterString);
         template.ReplaceField("NativeArgsString", argsString);
         template.ReplaceField("Return", torqueFunction.Type.IsVoid ? "" : "return ");

         return template;
      }

      private MethodDeclarationRegionTemplate GenerateClassDeclarations(JToken classObject)
      {
         IEnumerable<string> classDeclarations =
            classObject["Methods"].Select(method => new MethodDeclarationTemplate(new TorqueFunction((JObject)method)).Indent().Content);
         
         string classDecls = classDeclarations.Aggregate("", (x, y) => x + "\n" + y);

         if (classObject["ClassName"].ToString() == "SimObject")
         {
            // registerObject is a special method, which is not exposed to TorqueScript, so we have to add it manually here
            JObject registerObjectFunction = new JObject
            {
               ["Type"] = "bool",
               ["Name"] = "registerObject",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(),
               ["IsStringlyTyped"] = false
            };

            classDecls += "\n" + new MethodDeclarationTemplate(new TorqueFunction(registerObjectFunction)).Indent().Content;
         }
         MethodDeclarationRegionTemplate regionTemplate = new MethodDeclarationRegionTemplate();
         regionTemplate.ReplaceField("classDecls", classDecls);
         return regionTemplate;
      }
   }
}