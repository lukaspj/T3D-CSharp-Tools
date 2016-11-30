namespace ConsoleLogParser.ConsoleStructures
{
   internal class ConsoleField
   {
      public ConsoleField()
      {
         ElementCount = 1;
      }

      public string Type { get; set; }
      public string Name { get; set; }
      public int ElementCount { get; set; }
   }
}