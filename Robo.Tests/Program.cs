using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gettext;
using Robo.Tasks;
using Robo.Tasks.Files;
using Robo.Tools;

namespace Robo.Tests
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chargement des plugins externes
            AssemblyLoader.LoadFromDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"plugins"));

            var allTasks = RoboTasks.GetThem;
            allTasks[0].Configure();
            allTasks[0].Run();

            
        }
    }
}
