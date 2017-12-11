using System;

namespace T3DCSharpGenerator.TorqueStructures
{
   internal class FieldDeprecatedException : Exception
   {
      public FieldDeprecatedException(string message) : base(message)
      {
      }
   }
}