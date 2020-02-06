namespace Confusion_Matrix.UserControles
{
    partial class PageMultipleClasses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageMultipleClasses));
            this.lblOverallAccuracy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericClassesCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblF1Score = new System.Windows.Forms.Label();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRecall = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblErrorRate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMoreDetails = new System.Windows.Forms.Button();
            this.lblCurrentCell = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericClassesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOverallAccuracy
            // 
            resources.ApplyResources(this.lblOverallAccuracy, "lblOverallAccuracy");
            this.lblOverallAccuracy.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblOverallAccuracy.Name = "lblOverallAccuracy";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label13.Name = "label13";
            // 
            // btnRedraw
            // 
            resources.ApplyResources(this.btnRedraw, "btnRedraw");
            this.btnRedraw.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRedraw.FlatAppearance.BorderSize = 0;
            this.btnRedraw.ForeColor = System.Drawing.Color.White;
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.UseVisualStyleBackColor = false;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Name = "label4";
            // 
            // numericClassesCount
            // 
            resources.ApplyResources(this.numericClassesCount, "numericClassesCount");
            this.numericClassesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericClassesCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericClassesCount.Name = "numericClassesCount";
            this.numericClassesCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Name = "label5";
            // 
            // lblAccuracy
            // 
            resources.ApplyResources(this.lblAccuracy, "lblAccuracy");
            this.lblAccuracy.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAccuracy.Name = "lblAccuracy";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label10.Name = "label10";
            // 
            // lblF1Score
            // 
            resources.ApplyResources(this.lblF1Score, "lblF1Score");
            this.lblF1Score.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblF1Score.Name = "lblF1Score";
            // 
            // lblPrecision
            // 
            resources.ApplyResources(this.lblPrecision, "lblPrecision");
            this.lblPrecision.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrecision.Name = "lblPrecision";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label16.Name = "label16";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label14.Name = "label14";
            // 
            // lblRecall
            // 
            resources.ApplyResources(this.lblRecall, "lblRecall");
            this.lblRecall.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRecall.Name = "lblRecall";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label12.Name = "label12";
            // 
            // lblErrorRate
            // 
            resources.ApplyResources(this.lblErrorRate, "lblErrorRate");
            this.lblErrorRate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblErrorRate.Name = "lblErrorRate";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label11.Name = "label11";
            // 
            // btnMoreDetails
            // 
            resources.ApplyResources(this.btnMoreDetails, "btnMoreDetails");
            this.btnMoreDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMoreDetails.FlatAppearance.BorderSize = 0;
            this.btnMoreDetails.ForeColor = System.Drawing.Color.White;
            this.btnMoreDetails.Name = "btnMoreDetails";
            this.btnMoreDetails.UseVisualStyleBackColor = false;
            this.btnMoreDetails.Click += new System.EventHandler(this.btnMoreDetails_Click);
            // 
            // lblCurrentCell
            // 
            resources.ApplyResources(this.lblCurrentCell, "lblCurrentCell");
            this.lblCurrentCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCurrentCell.Name = "lblCurrentCell";
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            // 
            // PageMultipleClasses
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblF1Score);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblRecall);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblErrorRate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericClassesCount);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMoreDetails);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.lblOverallAccuracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentCell);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView);
            this.Name = "PageMultipleClasses";
            this.Load += new System.EventHandler(this.PageMultipleClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericClassesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOverallAccuracy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericClassesCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblF1Score;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRecall;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblErrorRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMoreDetails;
        private System.Windows.Forms.Label lblCurrentCell;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
