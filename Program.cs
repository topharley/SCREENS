using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens
{
    static class Program
    {
        public static StartMode StartMode { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetStartMode();
            Start();
            Application.Run();
        }

        private static void Start()
        {
            if (StartMode == Screens.StartMode.Capture)
                Clipper.Clip(new Processor());
            else if (StartMode == Screens.StartMode.Tray)
                Tray.Run();
            else
                throw new NotImplementedException();
        }

        private static void SetStartMode()
        {
            StartMode = Screens.StartMode.Capture;
            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && args[1] == "/tray") 
                StartMode = Screens.StartMode.Tray;
        }
    }
}
