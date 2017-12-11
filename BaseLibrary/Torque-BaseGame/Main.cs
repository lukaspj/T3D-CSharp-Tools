using System.Reflection;
using Torque3D;
using Path = System.IO.Path;

namespace Game
{
    public class Main
    {
        [ScriptEntryPoint]
        public static void main()
        {
            // --- Boilerplate C#-specific setup. Normally Torque uses the main.cs file to set these variables, here we have to do it ourselves.
            string CSDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Replace('\\', '/');
            Global.setMainDotCsDir(CSDir);
            Global.setCurrentDirectory(CSDir);
            // ---

            // Enable console logging, which creates the file console.log each time you run
            // the engine.
            Global.setLogMode(6);

            // Display a splash window immediately to improve app responsiveness before
            // engine is initialized and main window created
            Global.displaySplashWindow("splash.bmp");

            // Disable script trace.
            Global.trace(false);

            // Set the name of our application
            Globals.SetString("appName", "BaseGame");

            Global.echo("Test!");
        }
    }
}