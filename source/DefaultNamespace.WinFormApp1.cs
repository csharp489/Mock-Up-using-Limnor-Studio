//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Limnor Studio.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DefaultNamespace
{
    using System;
    using System.Xml;
    using System.Text;
    using System.Collections.Generic;
    using System.Drawing;
    
    public class WinFormApp1
    {
        /// <summary>
        /// Command line arguments
        /// </summary>
        public static string[] CommandArguments
        {
            get
            {
                return System.Environment.GetCommandLineArgs();
            }
        }
        private static void InitializeComponent()
        {
            // 
            // WinFormApp1
            // 
        }
        [STAThread()]
        public static void Main()
        {
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.EnableVisualStyles();
            InitializeComponent();
            System.Windows.Forms.Application.Run(Form1.DefaultForm);
        }
    }
}