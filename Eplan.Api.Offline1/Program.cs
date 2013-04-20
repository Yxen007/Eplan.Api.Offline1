using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eplan.EplApi.Starter;

namespace Eplan.Api.Offline1
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

            // Use the finder to find the correct eplan version if not yet known
            EplanFinder oEplanFinder = new EplanFinder();
            String strBinPath = oEplanFinder.SelectEplanVersion();

            // Check if user has selected P8 version
            if (String.IsNullOrEmpty(strBinPath))
            {
                return;
            }

            // Now use the Assemblyresolver to let the program know where all eplan assemblies can be found.
            AssemblyResolver oResolver = new AssemblyResolver();
            oResolver.SetEplanBinPath(strBinPath);
            // Pin to eplan does the actual preparation. All referenced eplan assemblies are loaded from the bin path.
            oResolver.PinToEplan();

            Application.Run(new Form1());
        }
    }
}