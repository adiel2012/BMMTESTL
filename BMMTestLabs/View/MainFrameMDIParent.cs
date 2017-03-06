using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMMTestLabs.View
{
    public partial class MainFrameMDIParent : Form
    {
        public MainFrameMDIParent()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public void fill_HashResults(Model.HashResultRecord[] list)
        {
            DGV_Results.DataSource = list;
        }
        public void fill_HashRepository(Model.HashRepositoryRecord[] list)
        {
            DGV_Repository.DataSource = list;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        public static string askforCVS()
        {

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return null;
        }

        private void MainFrameMDIParent_ResizeEnd(object sender, EventArgs e)
        {
            organize_components();
        }

        void organize_components()
        {
            int gap = 6;
            int large = (panel3.Width - 4 * gap - btn_result_compare.Width) / 2;
            btn_export.Location = new Point(panel3.Width / 2 - btn_export.Width / 2, btn_export.Location.Y);
            
            DGV_Results.Height =  DGV_Repository.Height = panel3.Height;
            DGV_Results.Width = large;
            DGV_Repository.Width = large;
            DGV_Results.Location = new Point(gap,0);
            btn_result_compare.Location = new Point(large+2*gap,panel3.Height / 2 - btn_result_compare.Height/2);

            
            DGV_Repository.Location = new Point(large + btn_result_compare.Width+3*gap, 0);
            btn_result_repository.Location = new Point(DGV_Repository.Location.X, btn_result_repository.Location.Y);

            lbl_result.Location = new Point(btn_result_hash.Location.X + btn_result_hash.Width+gap, lbl_result.Location.Y);
            lbl_repository.Location = new Point(btn_result_repository.Location.X + btn_result_repository.Width + gap, lbl_repository.Location.Y);
        }

        private void MainFrameMDIParent_Load(object sender, EventArgs e)
        {
            organize_components();
        }

        private void MainFrameMDIParent_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            organize_components();
        }

        private void MainFrameMDIParent_SizeChanged(object sender, EventArgs e)
        {
            organize_components();
        }

    }
}
