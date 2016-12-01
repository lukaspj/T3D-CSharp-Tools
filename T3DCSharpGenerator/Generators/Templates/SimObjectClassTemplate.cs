using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class SimObjectClassTemplate : Template
   {
      public SimObjectClassTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/SimObjectClassTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}