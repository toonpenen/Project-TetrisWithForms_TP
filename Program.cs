using System;
using System.Windows.Forms;
using Tetris.Models;

namespace Tetris
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Collections.LoadScoresFromFile();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormInstances.tetrisMenu = new TetrisMenu();
            Application.Run(FormInstances.tetrisMenu);
        }
    }
}