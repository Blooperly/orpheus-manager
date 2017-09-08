using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;

namespace OrpheusManager
{
    public static class CDATA
    {
        public static byte version = 0x01;
        public static string cName = "Rodrigo Ledesma";
        public static int cLevel = 1;
        public static string cArch1 = "Wendigo";
        public static string cArch2 = "Weapon Bearer";
        public static string cArch3 = "";
        public static int[] cAttributes = { 2, 2, 1, 5, 1, 4 };
    }

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
            Application.Run(new CharacterSheet());
        }
    }
}
