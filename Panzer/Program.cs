using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Panzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            Controller_frmMain cf;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            switch (arg.Length)
            {
                case 0: cf = new Controller_frmMain();
                    break;
                case 1: cf = new Controller_frmMain(int.Parse(arg[0]));
                    break;
                case 2: cf = new Controller_frmMain(int.Parse(arg[0]), int.Parse(arg[1]));
                    break;
                case 3: cf = new Controller_frmMain(int.Parse(arg[0]), int.Parse(arg[1]), int.Parse(arg[2]));
                    break;
                case 4: cf = new Controller_frmMain(int.Parse(arg[0]), int.Parse(arg[1]), int.Parse(arg[2]), int.Parse(arg[3]));
                    break;
                default: cf = new Controller_frmMain();
                    break;
            }            
            Application.Run(cf);
        }
    }
}
