﻿
using DesktopPet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Merge
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string resource1 = "PDF_Merge.PdfSharp.Charting.dll";
            string resource2 = "PDF_Merge.PdfSharp.dll";
            EmbeddedAssembly.Load(resource1, "PdfSharp.Charting.dll");
            EmbeddedAssembly.Load(resource2, "PdfSharp.dll");

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
