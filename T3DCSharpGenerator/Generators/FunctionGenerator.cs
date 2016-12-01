using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using T3DCSharpGenerator.Generators.Templates;
using T3DCSharpGenerator.TorqueStructures;

namespace T3DCSharpGenerator.Generators
{
   class FunctionGenerator : Generator
   {
      public override IEnumerable<KeyValuePair<string, Template>> GenerateFor(JArray functions)
      {
         IEnumerable<TorqueFunction> torqueFunctions = functions.Select(x => new TorqueFunction((JObject) x));
         Dictionary<string, List<TorqueFunction>> namespacedFunctions = new Dictionary<string, List<TorqueFunction>>();
         torqueFunctions.ToList().ForEach(x =>
         {
            if (!namespacedFunctions.ContainsKey(x.Namespace))
            {
               namespacedFunctions[x.Namespace] = new List<TorqueFunction>();
            }
            namespacedFunctions[x.Namespace].Add(x);
         });
         return namespacedFunctions.ToList().Select(x => OutputNamespaceFunctions(x.Key, x.Value));
      }

      private static KeyValuePair<string, Template> OutputNamespaceFunctions(string namespaceName,
         List<TorqueFunction> functions)
      {
         FunctionInternalsRegionTemplate functionInternals = FunctionsToInternals(functions);
         FunctionDeclarationRegionTemplate functionDecls = FunctionsToDeclarations(functions);

         NamespaceTemplate nsTemplate = new NamespaceTemplate();
         nsTemplate.ReplaceField("namespaceName", namespaceName);
         nsTemplate.ReplaceField("functionInternals", functionInternals.Indent(2).Content);
         nsTemplate.ReplaceField("functionDecls", functionDecls.Indent(2).Content);

         return new KeyValuePair<string, Template>(namespaceName, nsTemplate);
      }

      private static FunctionDeclarationRegionTemplate FunctionsToDeclarations(IEnumerable<TorqueFunction> functions)
      {
         IEnumerable<string> functionDeclarations =
            functions.Select(function => new FunctionDeclarationTemplate(function).Indent().Content);
         string functionDecls = functionDeclarations.Aggregate("", (x, y) => x + "\n" + y).Substring(1);
         FunctionDeclarationRegionTemplate regionTemplate = new FunctionDeclarationRegionTemplate();
         regionTemplate.ReplaceField("functionDecls", functionDecls);
         return regionTemplate;
      }

      private static FunctionInternalsRegionTemplate FunctionsToInternals(List<TorqueFunction> functions)
      {
         IEnumerable<FunctionInternalTemplate> functionInternals = functions.Select(FunctionToInternal);
         string internals = functionInternals.Aggregate("", (x, y) => x + "\n" + y.Indent().Content).Substring(1);

         FunctionInternalsRegionTemplate regionTemplate = new FunctionInternalsRegionTemplate();
         regionTemplate.ReplaceField("functionInternals", internals);
         return regionTemplate;
      }

      public static FunctionInternalTemplate FunctionToInternal(TorqueFunction torqueFunction)
      {
         FunctionInternalTemplate template = new FunctionInternalTemplate();

         template.ReplaceField("Name", torqueFunction.Name);
         template.ReplaceField("C-Name", torqueFunction.RealName);
         template.ReplaceField("NativeReturnType", torqueFunction.Type.NativeReturnType);
         template.ReplaceField("NativeParametersString", torqueFunction.GetNativeParametersString());
         template.ReplaceField("NativeArgsString", torqueFunction.GetNativeArgsString());
         template.ReplaceField("Return", torqueFunction.Type.IsVoid ? "" : "return ");

         return template;
      }
   }
}