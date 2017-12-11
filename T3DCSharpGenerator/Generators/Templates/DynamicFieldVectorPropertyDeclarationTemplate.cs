using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class DynamicFieldVectorPropertyDeclarationTemplate : Template
   {
      public DynamicFieldVectorPropertyDeclarationTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/DynamicFieldVectorPropertyDeclarationTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}