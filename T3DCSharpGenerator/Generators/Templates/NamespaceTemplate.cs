using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class NamespaceTemplate : Template
   {
      public NamespaceTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/NamespaceTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}