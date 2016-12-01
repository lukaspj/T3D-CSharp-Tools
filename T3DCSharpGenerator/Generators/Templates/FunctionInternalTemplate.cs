using System.IO;

namespace T3DCSharpGenerator.Generators.Templates
{
   class FunctionInternalTemplate : Template
   {
      public FunctionInternalTemplate()
      {
         using (StreamReader SR = new StreamReader("CSTemplates/FunctionInternalTemplate.cstmpl"))
            Content = SR.ReadToEnd();
      }
   }
}