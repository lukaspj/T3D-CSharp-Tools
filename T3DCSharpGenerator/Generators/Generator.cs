using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using T3DCSharpGenerator.Generators.Templates;

namespace T3DCSharpGenerator.Generators
{
   abstract class Generator
   {
      public abstract IEnumerable<KeyValuePair<string, Template>> GenerateFor(JArray functions);
   }
}
