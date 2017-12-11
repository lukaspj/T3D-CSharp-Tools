using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleLogParser.ConsoleStructures;

namespace ConsoleLogParser.Parsers
{
   internal class ConsoleParser
   {
      protected static ConsoleFunction ReadFunction(StringReader sr, string line, string methodComment)
      {
         ConsoleFunction method = new ConsoleFunction();
         Match methodMatches = Patterns.MatchMethod(line);
         string type = methodMatches.Groups[1].Value.Trim();
         string name = methodMatches.Groups[2].Value.Trim();
         method.Type = type;
         method.Name = name;
         if (!string.IsNullOrEmpty(methodMatches.Groups[4].Value)) method.IsStringlyTyped = true;
         if (type.Trim().Length == 0)
            throw new NotImplementedException();
         if (methodMatches.Groups.Count == 2) return method;
         string parameters = methodMatches.Groups[3].Value.Trim();
         MatchCollection paramMatches = Patterns.MatchMethodParameters(parameters);
         foreach (Match param in paramMatches)
         {
            string pType = param.Groups[1].Value.Trim();
            string pName = param.Groups[2].Value.Trim();
            ConsoleParameter cParam = new ConsoleParameter
            {
               VarArgs = Patterns.IsParamVariadic(pName),
               Type = pType,
               Name = pName.Replace("...", "")
            };
            if (param.Groups[3].Length > 0)
            {
               string defaultValue = param.Groups[3].Value.Trim();
                if (defaultValue.StartsWith("nullAsType<"))
                    defaultValue = "null";
                cParam.DefaultValue = defaultValue.Trim();
            }
            method.Parameters.Add(cParam);
         }
         method.Comment = methodComment;
         return method;
      }

      protected static string ReadComment(StringReader SR, string line)
      {
         string currentComment = line;
         while (!line.Contains("*/"))
         {
            line = SR.ReadLine();
            currentComment += line;
         }

         return currentComment;
      }
   }
}