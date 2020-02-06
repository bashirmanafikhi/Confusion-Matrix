namespace Confusion_Matrix
{
    partial class Details
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMoreDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccuracyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F1ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecisionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Name = "lblTitle";
            // 
            // btnMoreDetails
            // 
            resources.ApplyResources(this.btnMoreDetails, "btnMoreDetails");
            this.btnMoreDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMoreDetails.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMoreDetails.FlatAppearance.BorderSize = 0;
            this.btnMoreDetails.ForeColor = System.Drawing.Color.White;
            this.btnMoreDetails.Name = "btnMoreDetails";
            this.btnMoreDetails.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccuracyColumn,
            this.ErrorRateColumn,
            this.RecallColumn,
            this.F1ScoreColumn,
            this.PrecisionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // AccuracyColumn
            // 
            resources.ApplyResources(this.AccuracyColumn, "AccuracyColumn");
            this.AccuracyColumn.Name = "AccuracyColumn";
            this.AccuracyColumn.ReadOnly = true;
            // 
            // ErrorRateColumn
            // 
            resources.ApplyResources(this.ErrorRateColumn, "ErrorRateColumn");
            this.ErrorRateColumn.Name = "ErrorRateColumn";
            this.ErrorRateColumn.ReadOnly = true;
            // 
            // RecallColumn
            // 
            resources.ApplyResources(this.RecallColumn, "RecallColumn");
            this.RecallColumn.Name = "RecallColumn";
            this.RecallColumn.ReadOnly = true;
            // 
            // F1ScoreColumn
            // 
            resources.ApplyResources(this.F1ScoreColumn, "F1ScoreColumn");
            this.F1ScoreColumn.Name = "F1ScoreColumn";
            this.F1ScoreColumn.ReadOnly = true;
            // 
            // PrecisionColumn
            // 
            resources.ApplyResources(this.PrecisionColumn, "PrecisionColumn");
            this.PrecisionColumn.Name = "PrecisionColumn";
            this.PrecisionColumn.ReadOnly = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Details
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMoreDetails);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMoreDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccuracyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecisionColumn;
    }
}

