using System.IO;
using System.Text;

namespace T3DCSharpGenerator.Generators.Templates
{
   abstract class Template
   {
      public string Content { get; set; }

      public Template ReplaceField(string field, string value)
      {
         Content = Content.Replace($"<<{field}>>", value);
         return this;
      }

      public Template Indent(int count = 1)
      {
         StringReader SR = new StringReader(Content);
         StringBuilder SB = new StringBuilder();
         string line;
         while ((line = SR.ReadLine()) != null)
         {
            SB.AppendLine(Utils.Indent(count) + line);
         }
         Content = SB.ToString();
         return this;
      }
   }
}