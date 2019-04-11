using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Hit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
        public static Stream GetResourceStream(string filename)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string resname = asm.GetName().Name + "." + filename;
            return asm.GetManifestResourceStream(resname);
        }
    }
}
