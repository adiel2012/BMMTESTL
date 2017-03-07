using BMMTestLabs.Model;
using BMMTestLabs.Model.Abstractions;
using BMMTestLabs.Model.DAO;
using BMMTestLabs.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMMTestLabs.Controller;
using System.Reflection;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace BMMTestLabs
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App app = App.GetInstance();
            Application.Run(app.run());
        }

        
    }
}
