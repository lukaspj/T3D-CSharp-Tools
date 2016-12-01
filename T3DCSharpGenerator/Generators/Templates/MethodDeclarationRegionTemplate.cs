using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class MethodDeclarationRegionTemplate : Template
   {
      public MethodDeclarationRegionTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/MethodDeclarationRegionTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}