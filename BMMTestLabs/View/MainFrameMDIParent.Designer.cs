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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DGV_Results = new System.Windows.Forms.DataGridView();
            this.DGV_Repository = new System.Windows.Forms.DataGridView();
            this.DGV_Comparation = new System.Windows.Forms.DataGridView();
            this.btn_result_hash = new System.Windows.Forms.Button();
            this.btn_result_repository = new System.Windows.Forms.Button();
            this.btn_result_compare = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_repository = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Comparation)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1183, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DGV_Results
            // 
            this.DGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Results.Location = new System.Drawing.Point(28, 53);
            this.DGV_Results.Name = "DGV_Results";
            this.DGV_Results.Size = new System.Drawing.Size(471, 150);
            this.DGV_Results.TabIndex = 3;
            // 
            // DGV_Repository
            // 
            this.DGV_Repository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Repository.Location = new System.Drawing.Point(529, 53);
            this.DGV_Repository.Name = "DGV_Repository";
            this.DGV_Repository.Size = new System.Drawing.Size(606, 150);
            this.DGV_Repository.TabIndex = 4;
            // 
            // DGV_Comparation
            // 
            this.DGV_Comparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Comparation.Location = new System.Drawing.Point(165, 236);
            this.DGV_Comparation.Name = "DGV_Comparation";
            this.DGV_Comparation.Size = new System.Drawing.Size(665, 150);
            this.DGV_Comparation.TabIndex = 5;
            // 
            // btn_result_hash
            // 
            this.btn_result_hash.Location = new System.Drawing.Point(28, 27);
            this.btn_result_hash.Name = "btn_result_hash";
            this.btn_result_hash.Size = new System.Drawing.Size(75, 23);
            this.btn_result_hash.TabIndex = 6;
            this.btn_result_hash.Text = "button1";
            this.btn_result_hash.UseVisualStyleBackColor = true;
            // 
            // btn_result_repository
            // 
            this.btn_result_repository.Location = new System.Drawing.Point(529, 27);
            this.btn_result_repository.Name = "btn_result_repository";
            this.btn_result_repository.Size = new System.Drawing.Size(75, 23);
            this.btn_result_repository.TabIndex = 7;
            this.btn_result_repository.Text = "button2";
            this.btn_result_repository.UseVisualStyleBackColor = true;
            // 
            // btn_result_compare
            // 
            this.btn_result_compare.Location = new System.Drawing.Point(463, 207);
            this.btn_result_compare.Name = "btn_result_compare";
            this.btn_result_compare.Size = new System.Drawing.Size(75, 23);
            this.btn_result_compare.TabIndex = 8;
            this.btn_result_compare.Text = "button3";
            this.btn_result_compare.UseVisualStyleBackColor = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(30, 207);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 9;
            // 
            // lbl_repository
            // 
            this.lbl_repository.AutoSize = true;
            this.lbl_repository.Location = new System.Drawing.Point(557, 206);
            this.lbl_repository.Name = "lbl_repository";
            this.lbl_repository.Size = new System.Drawing.Size(0, 13);
            this.lbl_repository.TabIndex = 10;
            // 
            // MainFrameMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 496);
            this.Controls.Add(this.lbl_repository);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_result_compare);
            this.Controls.Add(this.btn_result_repository);
            this.Controls.Add(this.btn_result_hash);
            this.Controls.Add(this.DGV_Comparation);
            this.Controls.Add(this.DGV_Repository);
            this.Controls.Add(this.DGV_Results);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainFrameMDIParent";
            this.Text = "Hash Enterprise LLC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Comparation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView DGV_Results;
        private System.Windows.Forms.DataGridView DGV_Repository;
        private System.Windows.Forms.DataGridView DGV_Comparation;
        public System.Windows.Forms.Button btn_result_hash;
        public System.Windows.Forms.Button btn_result_repository;
        public System.Windows.Forms.Button btn_result_compare;
        public System.Windows.Forms.Label lbl_result;
        public System.Windows.Forms.Label lbl_repository;
    }
}