using BMMTestLabs.Model;
using BMMTestLabs.Model.Abstractions;
using BMMTestLabs.Model.DAO;
using BMMTestLabs.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMMTestLabs.Controller;

namespace BMMTestLabs
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static MainFrameMDIParent mainform;
        //static List<HashResultController> controllersResults = new List<HashResultController>(); 

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainform = new MainFrameMDIParent();
            suscribe();
            //IHashResultHandler ff = new HashResultHandlerFileCVS(Application.StartupPath+"\\"+ "HashResults.csv");
            //HashResultRecord[] list = ff.getAll();
            Application.Run(mainform);
        }

        private static void suscribe()
        {
            
            mainform.btn_result_hash.Click += delegate(object sender, EventArgs e)
            {
                select_result_hash();
            };

            mainform.btn_result_repository.Click += delegate(object sender, EventArgs e)
            {
                select_repository_hash();
            };
        }

        private static void select_repository_hash()
        {
            string filename = null;
            if ((filename = MainFrameMDIParent.askforCVS()) != null)
            {
                HashRepositoryController ctrl = new HashRepositoryController(new HashRepositoryHandlerFileCVS(filename), mainform);

                ctrl.Display(filename);
            }
        }

        private static void select_result_hash()
        {
            string filename = null;
            if ((filename = MainFrameMDIParent.askforCVS()) != null)
            {
                HashResultController ctrl =
               new HashResultController(
                   new HashResultHandlerFileCVS(filename), mainform);

                ctrl.Display(filename);
            }
        }

    }
}
