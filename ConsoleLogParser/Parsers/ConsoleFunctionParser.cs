using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleLogParser.ConsoleStructures;

namespace ConsoleLogParser.Parsers
{
   internal class ConsoleFunctionParser : ConsoleParser
   {
      public static List<ConsoleFunction> parse(string content)
      {
         List<ConsoleFunction> retList = new List<ConsoleFunction>();
         StringReader SR = new StringReader(content);
         string line;
         string currentComment = null;
         while ((line = SR.ReadLine()) != null)
         {
            line = line.Trim();
            if (Patterns.LineStartsAMultilineComment(line))
            {
               throw new NotImplementedException();
            }
            if (Patterns.LineStartsANamespace(line))
            {
               ReadNamespace(SR, line, retList);
            }
            else
            {
               if (line.Length > 0)
               {
                  throw new NotImplementedException();
               }
            }
         }
         return retList;
      }

      private static void ReadNamespace(StringReader SR, string line, List<ConsoleFunction> retList)
      {
         Match declarationMatch = Patterns.MatchNamespace(line);
         string namespaceName = declarationMatch.Groups[1].Value;
         string currentComment = null;
         line = SR.ReadLine();
         while (!Patterns.LineEndsABody(line))
         {
            if (Patterns.LineStartsAMultilineComment(line))
            {
               currentComment = ReadComment(SR, line);
            }
            else if (Patterns.LineContainsAFunction(line))
            {
               ConsoleFunction function = ReadFunction(SR, line, currentComment);
               currentComment = null;
               function.Namespace = namespaceName;
               retList.Add(function);
            }

            line = SR.ReadLine();
         }
      }
   }
}