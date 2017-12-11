using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using T3DCSharpGenerator.Generators;
using T3DCSharpGenerator.Generators.Templates;
using T3DCSharpGenerator.TorqueStructures;

namespace T3DCSharpGenerator
{
   class Program
   {
      [STAThread]
      static void Main(string[] args)
      {
         string outputDir;
         if (args.Length < 1)
         {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult fbdResult = fbd.ShowDialog();
            if (fbdResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
               outputDir = fbd.SelectedPath;
            }
            else
            {
               return;
            }
         }
         else
         {
            outputDir = args[0];
         }

         JObject result;
         using (StreamReader SR = new StreamReader("EngineMetaData.json"))
         using (JsonReader reader = new JsonTextReader(SR))
            result = JObject.Load(reader);

         JArray functions = JArray.FromObject(result["functions"]);
         JArray classes = JArray.FromObject(result["classes"]);

         // First we register all the classes into our type system
         TorqueType.RegisterClasses(classes);

         // Then we generate all the classes
         IEnumerable<KeyValuePair<string, Template>> classTemplates = new ClassGenerator().GenerateFor(classes);

         // Lastly we generate all the functions
         IEnumerable<KeyValuePair<string, Template>> functionTemplates = new FunctionGenerator().GenerateFor(functions);

         // Output everything to corresponding files
         foreach (KeyValuePair<string, Template> nameTemplatePair in classTemplates.Concat(functionTemplates))
         {
            string fileName = outputDir + $"/{nameTemplatePair.Key}.cs";
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            using (StreamWriter SW = new StreamWriter(fileName))
            {
               SW.Write(nameTemplatePair.Value.Content);
            }
         }
      }
   }
}