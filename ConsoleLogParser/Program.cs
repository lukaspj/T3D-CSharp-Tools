using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleLogParser.ConsoleStructures;
using ConsoleLogParser.Parsers;
using Newtonsoft.Json;

namespace ConsoleLogParser
{
   class Program
   {
      static void Main(string[] args)
      {
         // Read the content
         StreamReader SR = new StreamReader(args[0]);
         string content = SR.ReadToEnd();
         SR.Close();

         // Extract the dumps, assume start and end message exists
         Match classMatch = Regex.Match(content,
            "------CONSOLE CLASSES BEGIN------((?:\\n|.)*)------CONSOLE CLASSES END------");
         Match functionMatch = Regex.Match(content,
            "------CONSOLE FUNCTIONS BEGIN------((?:\\n|.)*)------CONSOLE FUNCTIONS END------");

         // Parse the classes
         List<ConsoleClass> classes = ConsoleClassParser.parse(classMatch.Groups[1].Value.Trim());

         // Log all the fields in the classes, in case it's needed for a later implementation of fields
         StreamWriter SW = new StreamWriter("fields.txt");
         classes.ForEach(x => x.Fields.ForEach(y => SW.WriteLine($"{x.ClassName}:{y.Name}:{y.Type}:{y.ElementCount}")));
         SW.Close();

         // Build the inheritance information
         List<ConsoleClass> simObjectTree = SimObjectTree.BuildAsList(classes);
         
         // Parse the function
         List<ConsoleFunction> functions = ConsoleFunctionParser.parse(functionMatch.Groups[1].Value.Trim());
         
         // Output to a JSON file
         SW = new StreamWriter("EngineMetaData.json");
         JsonTextWriter writer = new JsonTextWriter(SW);
         JsonSerializer serializer = new JsonSerializer();
         // We want it indented and prettified, performance is not important at this point
         serializer.Formatting = Formatting.Indented;
         serializer.Serialize(writer,
            new Dictionary<string, object> {{"functions", functions}, {"classes", simObjectTree}});
         writer.Close();
         SW.Close();
      }
   }
}