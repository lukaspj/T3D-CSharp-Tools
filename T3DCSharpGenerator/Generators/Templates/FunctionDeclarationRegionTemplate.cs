using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class FunctionDeclarationRegionTemplate : Template
   {
      public FunctionDeclarationRegionTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/FunctionDeclarationRegionTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}