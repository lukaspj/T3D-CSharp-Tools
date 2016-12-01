using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class MethodInternalTemplate : Template
   {
      public MethodInternalTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/MethodInternalTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}