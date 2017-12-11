using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class SimDatablockObjectClassTemplate : Template
   {
      public SimDatablockObjectClassTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/SimDatablockObjectClassTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}