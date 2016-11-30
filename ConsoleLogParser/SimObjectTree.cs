using System.Collections.Generic;
using ConsoleLogParser.ConsoleStructures;

namespace ConsoleLogParser
{
   class SimObjectTree
   {
      public static List<ConsoleClass> BuildAsList(List<ConsoleClass> classes)
      {
         Dictionary<ConsoleClass, List<ConsoleClass>> subclassDictionary =
            new Dictionary<ConsoleClass, List<ConsoleClass>>();
         Dictionary<string, ConsoleClass> classNameDictionary = new Dictionary<string, ConsoleClass>();

         // Create a mapping from classname to class objects
         classes.ForEach(x => classNameDictionary[x.ClassName] = x);

         // Map parent class names to their respective objects
         classes.ForEach(x => x.ParentClass = x.ParentClassName == null ? null : classNameDictionary[x.ParentClassName]);

         classes.ForEach(x =>
         {
            // First, filter out non-simclasses
            if (x.ParentClass == null) return; 
            // Insert the current simclass as a subclass to the parent
            if (!subclassDictionary.ContainsKey(x.ParentClass))
            {
               subclassDictionary[x.ParentClass] = new List<ConsoleClass>();
            }
            subclassDictionary[x.ParentClass].Add(x);
         });

         List<ConsoleClass> simClasses = new List<ConsoleClass>();

         // Locate the top-level class
         ConsoleClass simObjectClass = classes.Find(x => x.ClassName == "SimObject");

         // Insert all sim classes into the simClasses list
         AddClassAndSubclasses(subclassDictionary, simClasses, simObjectClass);
         return simClasses;
      }

      private static void AddClassAndSubclasses(Dictionary<ConsoleClass, List<ConsoleClass>> subclassDictionary,
         List<ConsoleClass> simClasses, ConsoleClass simObjectClass)
      {
         // Add this class to the simClasses
         simClasses.Add(simObjectClass);
         // If this class has no subclasses, return
         if (!subclassDictionary.ContainsKey(simObjectClass)) return;
         // Add the class and all subclasses
         subclassDictionary[simObjectClass].ForEach(x => AddClassAndSubclasses(subclassDictionary, simClasses, x));
      }
   }
}