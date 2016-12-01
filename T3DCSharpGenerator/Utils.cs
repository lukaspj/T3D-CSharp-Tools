namespace T3DCSharpGenerator
{
   internal class Utils
   {
      public static string Indent(int i)
      {
         string indent = "";
         for (int j = 0; j < i; j++)
         {
            indent += "   ";
         }
         return indent;
      }
   }
}