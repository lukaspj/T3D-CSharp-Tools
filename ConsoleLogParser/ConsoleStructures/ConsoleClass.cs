using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleLogParser.ConsoleStructures
{
   internal class ConsoleClass
   {
      public ConsoleClass()
      {
         Fields = new List<ConsoleField>();
         Methods = new List<ConsoleFunction>();
      }

      public string ClassName { get; set; }

      [JsonIgnore]
      public ConsoleClass ParentClass { get; set; }

      public string ParentClassName { get; set; }
      public string Comment { get; set; }
      public List<ConsoleField> Fields { get; set; }
      public List<ConsoleFunction> Methods { get; set; }
   }
}