using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class PropertyDeclarationTemplate : Template
   {
      public PropertyDeclarationTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/PropertyDeclarationTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}