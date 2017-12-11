using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class SimDatablockClassTemplate : Template
   {
      public SimDatablockClassTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/SimDatablockClassTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}