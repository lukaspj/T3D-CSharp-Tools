using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class SimClassTemplate : Template
   {
      public SimClassTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/SimClassTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}