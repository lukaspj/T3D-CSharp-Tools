using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class MethodInternalsRegionTemplate : Template
   {
      public MethodInternalsRegionTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/MethodInternalsRegionTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}