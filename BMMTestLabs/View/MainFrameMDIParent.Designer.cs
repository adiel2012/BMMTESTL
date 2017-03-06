namespace BMMTestLabs.View
{
    partial class MainFrameMDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Repository = new System.Windows.Forms.DataGridView();
            this.btn_result_hash = new System.Windows.Forms.Button();
            this.btn_result_repository = new System.Windows.Forms.Button();
            this.btn_result_compare = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_repository = new System.Windows.Forms.Label();
            this.DGV_Results = new System.Windows.Forms.DataGridView();
            this.btn_export = new System.Windows.Forms.Button();
            this.saveFileDialog_export = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Repository
            // 
            this.DGV_Repository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Repository.Location = new System.Drawing.Point(480, 5);
            this.DGV_Repository.Name = "DGV_Repository";
            this.DGV_Repository.ReadOnly = true;
            this.DGV_Repository.Size = new System.Drawing.Size(163, 92);
            this.DGV_Repository.TabIndex = 4;
            // 
            // btn_result_hash
            // 
            this.btn_result_hash.Location = new System.Drawing.Point(6, 4);
            this.btn_result_hash.Name = "btn_result_hash";
            this.btn_result_hash.Size = new System.Drawing.Size(106, 23);
            this.btn_result_hash.TabIndex = 6;
            this.btn_result_hash.Text = "Load Hash Results";
            this.btn_result_hash.UseVisualStyleBackColor = true;
            // 
            // btn_result_repository
            // 
            this.btn_result_repository.Location = new System.Drawing.Point(625, 4);
            this.btn_result_repository.Name = "btn_result_repository";
            this.btn_result_repository.Size = new System.Drawing.Size(124, 23);
            this.btn_result_repository.TabIndex = 7;
            this.btn_result_repository.Text = "Load Hash Repository";
            this.btn_result_repository.UseVisualStyleBackColor = true;
            // 
            // btn_result_compare
            // 
            this.btn_result_compare.Enabled = false;
            this.btn_result_compare.Location = new System.Drawing.Point(295, 60);
            this.btn_result_compare.Name = "btn_result_compare";
            this.btn_result_compare.Size = new System.Drawing.Size(75, 23);
            this.btn_result_compare.TabIndex = 8;
            this.btn_result_compare.Text = "Validate";
            this.btn_result_compare.UseVisualStyleBackColor = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(87, 8);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 9;
            // 
            // lbl_repository
            // 
            this.lbl_repository.AutoSize = true;
            this.lbl_repository.Location = new System.Drawing.Point(706, 9);
            this.lbl_repository.Name = "lbl_repository";
            this.lbl_repository.Size = new System.Drawing.Size(0, 13);
            this.lbl_repository.TabIndex = 10;
            // 
            // DGV_Results
            // 
            this.DGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Results.Location = new System.Drawing.Point(34, 21);
            this.DGV_Results.Name = "DGV_Results";
            this.DGV_Results.ReadOnly = true;
            this.DGV_Results.Size = new System.Drawing.Size(104, 62);
            this.DGV_Results.TabIndex = 3;
            // 
            // btn_export
            // 
            this.btn_export.Enabled = false;
            this.btn_export.Location = new System.Drawing.Point(500, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(130, 56);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Export CSV";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_result_hash);
            this.panel1.Controls.Add(this.btn_result_repository);
            this.panel1.Controls.Add(this.lbl_result);
            this.panel1.Controls.Add(this.lbl_repository);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 31);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 65);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_result_compare);
            this.panel3.Controls.Add(this.DGV_Results);
            this.panel3.Controls.Add(this.DGV_Repository);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 378);
            this.panel3.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainFrameMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 496);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainFrameMDIParent";
            this.Text = "Hash Enterprise LLC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximizedBoundsChanged += new System.EventHandler(this.MainFrameMDIParent_MaximizedBoundsChanged);
            this.Load += new System.EventHandler(this.MainFrameMDIParent_Load);
            this.ResizeEnd += new System.EventHandler(this.MainFrameMDIParent_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainFrameMDIParent_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Repository;
        public System.Windows.Forms.Button btn_result_hash;
        public System.Windows.Forms.Button btn_result_repository;
        public System.Windows.Forms.Button btn_result_compare;
        public System.Windows.Forms.Label lbl_result;
        public System.Windows.Forms.Label lbl_repository;
        public System.Windows.Forms.DataGridView DGV_Results;
        public System.Windows.Forms.Button btn_export;
        public System.Windows.Forms.SaveFileDialog saveFileDialog_export;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}