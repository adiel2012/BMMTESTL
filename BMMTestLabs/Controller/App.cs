using System;
using System.Linq;
using System.Text;
using BMMTestLabs.View;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BMMTestLabs.DependencyInjection;


namespace BMMTestLabs.Controller
{
    public class App
    {

        private static App __instance = new App();

        public static App GetInstance()
        {
            return __instance;
            ;
        }

        private App()
        {
        }

        public MainFrameMDIParent run()
        {
            mainform = new MainFrameMDIParent();
            suscribe();
            return mainform;
        }


        public  MainFrameMDIParent mainform;
        public  HashRepositoryController ctrl_repo = null;
        public  HashResultController ctrl_result = null;

        private  void suscribe()
        {

            mainform.BtnResultHash.Click += delegate(object sender, EventArgs e)
            {
                select_result_hash();
                mainform.BtnResultCompare.Enabled = (ctrl_result != null && ctrl_repo != null);
            };

            mainform.BtnResultRepository.Click += delegate(object sender, EventArgs e)
            {
                select_repository_hash();
                mainform.BtnResultCompare.Enabled = (ctrl_result != null && ctrl_repo != null);
            };

            mainform.BtnResultCompare.Click += delegate(object sender, EventArgs e)
            {
                do_compare_hash();
            };
            mainform.BtnExport.Click += delegate(object sender, EventArgs e)
            {
                do_exportcsv(mainform.DGvResults);
            };
            mainform.saveFileDialog_export.FileOk += delegate(object sender, CancelEventArgs e)
            {
                do_saveFileDialog_export_FileOk(mainform.DGvResults);
            };

        }

        private  void do_saveFileDialog_export_FileOk(DataGridView mainformDgvResults)
        {
            string filename = mainform.saveFileDialog_export.FileName;

            if (File.Exists(filename))
                File.Delete(filename);
            var sb = new StringBuilder();

            var headers = mainformDgvResults.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

            foreach (DataGridViewRow row in mainformDgvResults.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            file.WriteLine(sb.ToString());
            file.Close();


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = filename;
            proc.Start();
        }

        private void do_exportcsv(DataGridView mainformDgvResults)
        {
            mainform.saveFileDialog_export.Filter = "CSV (*.csv)|*.csv";
            mainform.saveFileDialog_export.ShowDialog();
        }

        private void do_compare_hash()
        {
            Match_result[] result = ctrl_result.compare(ctrl_repo);
            decorate(mainform.DGvResults, result);
            mainform.BtnExport.Enabled = true;
        }

        private void decorate_white(DataGridView dgv)
        {

            if (mainform.DGvResults.Columns.Count == 5)
                mainform.DGvResults.Columns.RemoveAt(0);
            Color c = Color.White;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {


                for (int j = 0; j < 4; j++)
                {
                    dgv.Rows[i].Cells[1].Style.BackColor = c;
                }
            }

        }

        private void decorate(DataGridView dgv, Match_result[] result)
        {

            //dgv.Paint += dgv_Paint;
            if (mainform.DGvResults.Columns.Count < 5)
                mainform.DGvResults.Columns.Add("colmatching", "MATCHING");
            Color c = Color.White;
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] == Match_result.MATCH)
                {
                    c = Color.Green;
                    mainform.DGvResults.Rows[i].Cells[4].Value = "MATCH";

                }
                else if (result[i] == Match_result.NO_MATCH)
                {
                    c = Color.Red;
                    mainform.DGvResults.Rows[i].Cells[4].Value = "NO MATCH";
                }
                else
                {
                    c = Color.White;
                    mainform.DGvResults.Rows[i].Cells[4].Value = "NO FILE";
                }

                dgv.Rows[i].Cells[4].Style.BackColor = c;


            }

        }

        public void select_repository_hash()
        {
            string filename = null;
            if ((filename = MainFrameMDIParent.askforCVS()) != null)
            {
                create_control_repository(filename);
            }
        }

        public void create_control_repository(string filename)
        {
            ctrl_repo = new HashRepositoryController(Injector.getIstance().getIHashRepositoryHandler(filename), mainform);
            ctrl_repo.Display(filename);
            decorate_white(mainform.DGvResults);
            mainform.BtnResultCompare.Enabled = (ctrl_result != null && ctrl_repo != null);
        }



        public void select_result_hash()
        {
            string filename = null;   
            if ((filename = MainFrameMDIParent.askforCVS()) != null)
            {
               create_control_result(filename);
            }
        }

        public void create_control_result(string filename)
        {
            ctrl_result =
              new HashResultController(Injector.getIstance().getIHashResultHandler(filename), mainform);

            ctrl_result.Display(filename);
            decorate_white(mainform.DGvResults);
            mainform.BtnExport.Enabled = false;
            mainform.BtnResultCompare.Enabled = (ctrl_result != null && ctrl_repo != null);

        }
    }

    public enum Match_result
    {
        MATCH,
        NO_MATCH,
        NO_FILE
    };
}
