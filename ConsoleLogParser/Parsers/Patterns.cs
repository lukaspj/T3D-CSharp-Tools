using System.Text.RegularExpressions;

namespace ConsoleLogParser.Parsers
{
   public static class Patterns
   {
      public static bool LineStartsAMultilineComment(string line)
      {
         return line.Contains("/*");
      }

      public static bool LineStartsANamespace(string line)
      {
         return line.StartsWith("namespace");
      }

      public static Match MatchNamespace(string line)
      {
         return Regex.Match(line.Trim(), "namespace\\s*(\\w+)\\s*{");
      }

      public static bool LineEndsABody(string line)
      {
         return line.Contains("};");
      }

      public static bool LineStartsAClass(string line)
      {
         return line.StartsWith("class");
      }

      public static Match MatchClassDeclaration(string line)
      {
         return Regex.Match(line, @"class\s+(.+)\s+:\s+(public|private|protected)\s+(.+)\s*{");
      }

      public static Match MatchSimObjectClassDeclaration(string line)
      {
         return Regex.Match(line, @"class\s+(.+)\s*{");
      }

      public static Match MatchField(string line)
      {
         return Regex.Match(line.Trim(), "(\\w+)\\s+(\\w+)\\s*(?:\\[([0-9]+)\\])?;");
      }

      public static Match MatchMethod(string line)
      {
         return Regex.Match(line.Trim(),
            @"(?:virtual)?\s+((?:const\s+)?[\w:]+(?:\s*\*\s*)?)\s+(\w+)\s*\((?:\(((?:[\w,"" =<>\-\.\[\]\(\):\*]|\.\.\.|"".*"")*)\))?(\.\.\.)?\)\s");
      }

      public static MatchCollection MatchMethodParameters(string parameters)
      {
         return Regex.Matches(parameters.Trim(),
            "((?:const\\s+)?[\\w:]+(?:\\s*\\*\\s*)?)\\s+(\\w+(?:\\.\\.\\.)?)\\s*(?:=(\\s*(?:[^,\"\\(\\]]|\"[^\"]*\"|\\([^\\)]*\\))+))?");
      }

      public static bool LineContainsACallback(string line)
      {
         return line.Contains(");");
      }

      public static bool LineContainsAFunction(string line)
      {
         return line.Contains("{");
      }

      public static bool LineContainsAField(string line)
      {
         return line.Contains(";");
      }

      public static bool IsParamVariadic(string pName)
      {
         return pName.Contains("...");
      }
   }
}