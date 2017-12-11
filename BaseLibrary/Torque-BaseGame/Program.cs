using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using Torque3D;

namespace Game
{
   class Program
   {
      static void Main(string[] args)
      {
         CultureInfo customCulture =
            (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone();
         customCulture.NumberFormat.NumberDecimalSeparator = ".";

         Thread.CurrentThread.CurrentCulture = customCulture;

         Initializer.InitializeTypeDictionaries(Assembly.GetExecutingAssembly().GetTypes());

         Torque3D.Torque3D.Libraries libraries = new Torque3D.Torque3D.Libraries
         {
            Windows32bit = "Full_DEBUG.dll",
            Windows64bit = "Full_DEBUG.dll"
         };

         Torque3D.Torque3D.Initialize(args, libraries);
      }
   }
}