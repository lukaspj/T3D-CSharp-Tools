using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class PropertiesDeclarationRegionTemplate : Template
   {
      public PropertiesDeclarationRegionTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/PropertiesDeclarationRegionTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}