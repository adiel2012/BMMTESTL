using BMMTestLabs.Model;
using BMMTestLabs.Model.Abstractions;
using BMMTestLabs.Model.DAO;
using BMMTestLabs.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private static HashRepositoryController ctrl_repo = null;
        private static HashResultController ctrl_result = null;

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
                mainform.btn_result_compare.Enabled = ( ctrl_result!=null && ctrl_repo!=null);
            };

            mainform.btn_result_repository.Click += delegate(object sender, EventArgs e)
            {
                select_repository_hash();
                mainform.btn_result_compare.Enabled = (ctrl_result != null && ctrl_repo != null);
            };

            mainform.btn_result_compare .Click += delegate(object sender, EventArgs e)
            {
                do_compare_hash();
            };
        }

       public enum Match_result
        {
            MATCH,
            NO_MATCH,
            NO_FILE
        };

        private static void do_compare_hash()
        {
           // throw new NotImplementedException();

            Match_result[] result = ctrl_result.compare(ctrl_repo);
            decorate(mainform.DGV_Results,result);
            
        }

        private static void decorate_white(DataGridView dgv)
        {

            if (mainform.DGV_Results.Columns.Count == 5)
                mainform.DGV_Results.Columns.RemoveAt(0);
            Color c = Color.White;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {


                for (int j = 0; j < 4; j++)
                {
                    dgv.Rows[i].Cells[1].Style.BackColor = c;
                }
            }

        }


        private static void decorate(DataGridView dgv, Match_result[] result)
        {
            
            //dgv.Paint += dgv_Paint;
            if (mainform.DGV_Results.Columns.Count < 5)
                mainform.DGV_Results.Columns.Add("colmatching", "MATCHING");
            Color c = Color.White;
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] == Match_result.MATCH)
                {
                    c = Color.Green;
                    mainform.DGV_Results.Rows[i].Cells[4].Value = "MATCH";

                }
                else if (result[i] == Match_result.NO_MATCH)
                {
                    c = Color.Red;
                    mainform.DGV_Results.Rows[i].Cells[4].Value = "NO MATCH";
                }
                else
                {
                    c = Color.White;
                    mainform.DGV_Results.Rows[i].Cells[4].Value = "NO FILE";
                }
               // for (int j = 0; j < 5; j++)
                //{
                    dgv.Rows[i].Cells[4].Style.BackColor = c;
                //}




            }
    
        }



        private static void select_repository_hash()
        {
            string filename = null;
            if ((filename = MainFrameMDIParent.askforCVS()) != null)
            {
                ctrl_repo = new HashRepositoryController(new HashRepositoryHandlerFileCVS(filename), mainform);
                ctrl_repo.Display(filename);
                decorate_white(mainform.DGV_Results);
            }
        }

        private static void select_result_hash()
        {
            string filename = null;
            if ((filename = MainFrameMDIParent.askforCVS()) != null)
            {
                ctrl_result =
               new HashResultController(
                   new HashResultHandlerFileCVS(filename), mainform);

                ctrl_result.Display(filename);
                decorate_white(mainform.DGV_Results);
            }
        }

    }
}
