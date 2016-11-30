using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleLogParser.ConsoleStructures;

namespace ConsoleLogParser.Parsers
{
   internal class ConsoleClassParser : ConsoleParser
   {
      public static List<ConsoleClass> parse(string content)
      {
         List<ConsoleClass> retList = new List<ConsoleClass>();
         StringReader SR = new StringReader(content);
         string line;
         string currentComment = null;

         // We read the whole contents of the console class dump
         while ((line = SR.ReadLine()) != null)
         {
            line = line.Trim();
            // We read comments and save them for later
            if (Patterns.LineStartsAMultilineComment(line))
            {
               currentComment = ReadComment(SR, line);
            }
            // If we find a class, we parse it and assign the current comment to it.
            if (Patterns.LineStartsAClass(line))
            {
               ConsoleClass currentClass = ReadClass(SR, line, currentComment);
               currentComment = null;
               retList.Add(currentClass);
            }
         }
         return retList;
      }

      private static ConsoleClass ReadClass(StringReader SR, string line, string classComment)
      {
         ConsoleClass retClass = new ConsoleClass();
         // Make sure that we are actually able to parse the class and fetch the className and parentClassName
         Match declarationMatch = Patterns.MatchClassDeclaration(line);
         if (!declarationMatch.Success)
         {
            declarationMatch = Patterns.MatchSimObjectClassDeclaration(line);
            if (!declarationMatch.Success)
            {
               Console.WriteLine("Error parsing class: " + line);
               throw new ArgumentException("Error parsing class: " + line);
            }
            retClass.ClassName = declarationMatch.Groups[1].Value.Trim();
         }
         else
         {
            retClass.ClassName = declarationMatch.Groups[1].Value.Trim();
            retClass.ParentClassName = declarationMatch.Groups[3].Value.Trim();
         }
         // Set the comment
         retClass.Comment = classComment;
         string currentComment = null;
         line = SR.ReadLine();
         // Until we come to the end of the class
         while (!Patterns.LineEndsABody(line))
         {
            // Read class comments, methods and fields
            if (Patterns.LineStartsAMultilineComment(line))
            {
               currentComment = ReadComment(SR, line);
            }
            else if (Patterns.LineContainsAFunction(line))
            {
               ConsoleFunction method = ReadFunction(SR, line, currentComment);
               currentComment = null;
               retClass.Methods.Add(method);
            }
            else if (Patterns.LineContainsACallback(line))
            {
               //TODO Read callback here
            }
            else if (Patterns.LineContainsAField(line))
            {
               ConsoleField field = ReadField(SR, line, currentComment);
               currentComment = null;
               retClass.Fields.Add(field);
            }
            line = SR.ReadLine();
         }
         return retClass;
      }

      private static ConsoleField ReadField(StringReader sr, string line, string fieldComment)
      {
         ConsoleField field = new ConsoleField();
         Match fieldMatches = Patterns.MatchField(line);
         string type = fieldMatches.Groups[1].Value.Trim();
         string name = fieldMatches.Groups[2].Value.Trim();
         if (fieldMatches.Groups[3].Value != string.Empty)
         {
            field.ElementCount = int.Parse(fieldMatches.Groups[3].Value);
         }
         field.Type = type;
         field.Name = name;
         return field;
      }
   }
}