using System;
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
         PropertiesDeclarationRegionTemplate classProps = GenerateClassProperties(classObject);

         Template classTemplate = new SimClassTemplate();
         if (classObject["ClassName"].ToString() == "SimObject")
         {
            classTemplate = new SimObjectClassTemplate();
         } else if (classObject["ClassName"].ToString() == "SimDataBlock")
         {
            classTemplate = new SimDatablockClassTemplate();
         } else if (classObject["IsDatablock"].ToObject<bool>())
         {
            classTemplate = new SimDatablockObjectClassTemplate();
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
         classTemplate.ReplaceField("Properties", classProps.Indent(2).Content);

         return new KeyValuePair<string, Template>(classObject["ClassName"].ToString(), classTemplate);
      }

      private MethodInternalsRegionTemplate GenerateClassInternals(JToken classObject)
      {
         MethodInternalsRegionTemplate template = new MethodInternalsRegionTemplate();

         string classInternals =
            classObject["Methods"].Aggregate("",
               (x, method) =>
                  x + "\n" +
                  MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction((JObject) method))
                     .Indent()
                     .Content);

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

            classInternals +=
               MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction(registerObjectFunction))
                  .Indent()
                  .Content;

            JObject copyFromFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = $"CopyFrom",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(new JObject
               {
                  ["Type"] = "SimObject",
                  ["Name"] = "parent",
                  ["DefaultValue"] = null,
                  ["VarArgs"] = false
               }),
               ["IsStringlyTyped"] = false
            };

            classInternals +=
               MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction(copyFromFunction))
                  .Indent()
                  .Content;

            JObject setModsFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "SetMods",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(new JObject
               {
                  ["Type"] = "bool",
                  ["Name"] = "modStaticFields",
                  ["DefaultValue"] = null,
                  ["VarArgs"] = false
               }, new JObject
               {
                  ["Type"] = "bool",
                  ["Name"] = "modDynamicFields",
                  ["DefaultValue"] = null,
                  ["VarArgs"] = false
               }),
               ["IsStringlyTyped"] = false
            };

            classInternals +=
               MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction(setModsFunction))
                  .Indent()
                  .Content;
         }

         if (classObject["ClassName"].ToString() == "SimDataBlock")
         {
            // registerObject is a special method, which is not exposed to TorqueScript, so we have to add it manually here
            JObject assignIdFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "AssignId",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(),
               ["IsStringlyTyped"] = false
            };

            classInternals +=
               MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction(assignIdFunction))
                  .Indent()
                  .Content;

            JObject preloadFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "Preload",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(),
               ["IsStringlyTyped"] = false
            };

            classInternals +=
               MethodToInternal(classObject["ClassName"].ToString(), new TorqueFunction(preloadFunction))
                  .Indent()
                  .Content;
         }
         template.ReplaceField("classInternals", classInternals);
         return template;
      }

      private MethodInternalTemplate MethodToInternal(string className, TorqueFunction torqueFunction)
      {
         string argsString = torqueFunction.GetNativeArgsString();
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value)
            argsString = ", " + argsString;
         string parameterStringNative = torqueFunction.GetNativeParametersString(true);
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value)
            parameterStringNative = ", " + parameterStringNative;
         string parameterString = torqueFunction.GetNativeParametersString();
         if (torqueFunction.Parameters.Count > 0 || torqueFunction.IsStringlyTyped.Value)
            parameterString = ", " + parameterString;

         string returnMarshalling = torqueFunction.Type.GetReturnMarshalling();

         MethodInternalTemplate template = new MethodInternalTemplate();

         template.ReplaceField("Name", torqueFunction.Name);
         template.ReplaceField("C-Name", torqueFunction.RealName);
         template.ReplaceField("ClassName", className);
         template.ReplaceField("NativeReturnType", torqueFunction.Type.NativeReturnType);
         template.ReplaceField("ReturnMarshalling", returnMarshalling == "" ? "" : "\n" + returnMarshalling);
         template.ReplaceField("NativeParametersString", parameterStringNative);
         template.ReplaceField("InternalParametersString", parameterString);
         template.ReplaceField("NativeArgsString", argsString);
         template.ReplaceField("Return", torqueFunction.Type.IsVoid ? "" : "return ");

         return template;
      }

      private MethodDeclarationRegionTemplate GenerateClassDeclarations(JToken classObject)
      {
         IEnumerable<string> classDeclarations =
            classObject["Methods"].Select(
               method => new MethodDeclarationTemplate(new TorqueFunction((JObject) method)).Indent().Content);

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

            classDecls += "\n" +
                          new MethodDeclarationTemplate(new TorqueFunction(registerObjectFunction)).Indent().Content;

            JObject copyFromFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "CopyFrom",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(new JObject
               {
                  ["Type"] = "SimObject",
                  ["Name"] = "parent",
                  ["DefaultValue"] = null,
                  ["VarArgs"] = false
               }),
               ["IsStringlyTyped"] = false
            };

            classDecls += "\n" +
                          new MethodDeclarationTemplate(new TorqueFunction(copyFromFunction)).Indent().Content;

            JObject setModsFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "SetMods",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(new JObject
               {
                  ["Type"] = "bool",
                  ["Name"] = "modStaticFields",
                  ["DefaultValue"] = null,
                  ["VarArgs"] = false
               }, new JObject
               {
                  ["Type"] = "bool",
                  ["Name"] = "modDynamicFields",
                  ["DefaultValue"] = null,
                  ["VarArgs"] = false
               }),
               ["IsStringlyTyped"] = false
            };

            classDecls += "\n" +
                          new MethodDeclarationTemplate(new TorqueFunction(setModsFunction)).Indent().Content;
         }
         if (classObject["ClassName"].ToString() == "SimDataBlock")
         {
            // registerObject is a special method, which is not exposed to TorqueScript, so we have to add it manually here
            JObject assignIdFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "AssignId",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(),
               ["IsStringlyTyped"] = false
            };

            classDecls += "\n" +
                          new MethodDeclarationTemplate(new TorqueFunction(assignIdFunction)).Indent().Content;

            JObject preloadFunction = new JObject
            {
               ["Type"] = "void",
               ["Name"] = "Preload",
               ["Comment"] = "/**/",
               ["Parameters"] = new JArray(),
               ["IsStringlyTyped"] = false
            };

            classDecls += "\n" +
                          new MethodDeclarationTemplate(new TorqueFunction(preloadFunction)).Indent().Content;
         }
         MethodDeclarationRegionTemplate regionTemplate = new MethodDeclarationRegionTemplate();
         regionTemplate.ReplaceField("classDecls", classDecls);
         return regionTemplate;
      }


      private PropertiesDeclarationRegionTemplate GenerateClassProperties(JToken classObject)
      {
         IEnumerable<Template> classProperties = classObject["Fields"].Select(FieldToProperty);
         string classProps = classProperties.Aggregate("", (x, y) => x + "\n" + y.Indent().Content);

         PropertiesDeclarationRegionTemplate template = new PropertiesDeclarationRegionTemplate();
         template.ReplaceField("ClassProperties", classProps);
         return template;
      }

      private Template FieldToProperty(JToken field)
      {
         Template template = new PropertyDeclarationTemplate();

         try
         {
            TorqueType propType = new TorqueType(field["Type"].ToString());

            string fieldName = field["Name"].ToString().First().ToString().ToUpper() +
                               field["Name"].ToString().Substring(1);
            int elementCount = field["ElementCount"].ToObject<int>();
            string fieldArrayIndexArg = elementCount > 1 ? $", {elementCount}" : "";

            string value = $"getFieldValue(\"{fieldName}\"{fieldArrayIndexArg})";

            string returnString = propType.FromString(value);

            if (elementCount > 1)
            {
               template = new DynamicFieldVectorPropertyDeclarationTemplate();
            }
            else
            {
               template = new PropertyDeclarationTemplate();
            }
            template.ReplaceField("FieldType", propType.ManagedType);
            template.ReplaceField("Return", returnString);
            template.ReplaceField("FieldName", fieldName);
            template.ReplaceField("FieldCount", elementCount.ToString());
            template.ReplaceField("Getter", propType.FromString("val"));
            template.ReplaceField("Setter", propType.ToString("obj"));
            template.ReplaceField("Set", propType.ToString("value"));
            template.ReplaceField("FieldArrayIndexArg", elementCount > 1 ? $", {elementCount}" : "");
         }
         catch (FieldDeprecatedException)
         {
            return new EmptyTemplate();
         }
         return template;
      }
   }
}