using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class FunctionInternalsRegionTemplate : Template
   {
      public FunctionInternalsRegionTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/FunctionInternalsRegionTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}