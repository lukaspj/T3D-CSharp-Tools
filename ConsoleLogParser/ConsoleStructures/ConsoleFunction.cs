using System.Collections.Generic;

namespace ConsoleLogParser.ConsoleStructures
{
   internal class ConsoleFunction
   {
      public ConsoleFunction()
      {
         IsStringlyTyped = false;
         Parameters = new List<ConsoleParameter>();
      }

      public string Namespace { get; set; }
      public string Type { get; set; }
      public string Name { get; set; }
      public string Comment { get; set; }
      public List<ConsoleParameter> Parameters { get; set; }
      public bool IsStringlyTyped { get; set; }
   }
}