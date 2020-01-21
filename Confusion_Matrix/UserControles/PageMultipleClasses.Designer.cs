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
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericClassesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
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
            this.dataGridView.Location = new System.Drawing.Point(28, 59);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(852, 355);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            // 
            // lblOverallAccuracy
            // 
            this.lblOverallAccuracy.AutoSize = true;
            this.lblOverallAccuracy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallAccuracy.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblOverallAccuracy.Location = new System.Drawing.Point(573, 429);
            this.lblOverallAccuracy.Name = "lblOverallAccuracy";
            this.lblOverallAccuracy.Size = new System.Drawing.Size(0, 19);
            this.lblOverallAccuracy.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label13.Location = new System.Drawing.Point(409, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Overall accuracy ";
            // 
            // btnRedraw
            // 
            this.btnRedraw.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRedraw.FlatAppearance.BorderSize = 0;
            this.btnRedraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedraw.ForeColor = System.Drawing.Color.White;
            this.btnRedraw.Location = new System.Drawing.Point(798, 13);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(82, 37);
            this.btnRedraw.TabIndex = 9;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = false;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(540, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Classes Count";
            // 
            // numericClassesCount
            // 
            this.numericClassesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericClassesCount.Location = new System.Drawing.Point(658, 20);
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
            this.numericClassesCount.Size = new System.Drawing.Size(120, 26);
            this.numericClassesCount.TabIndex = 10;
            this.numericClassesCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(24, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Multiple Classes";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAccuracy.Location = new System.Drawing.Point(116, 429);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(0, 19);
            this.lblAccuracy.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label10.Location = new System.Drawing.Point(24, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Accuracy";
            // 
            // lblF1Score
            // 
            this.lblF1Score.AutoSize = true;
            this.lblF1Score.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF1Score.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblF1Score.Location = new System.Drawing.Point(303, 464);
            this.lblF1Score.Name = "lblF1Score";
            this.lblF1Score.Size = new System.Drawing.Size(0, 19);
            this.lblF1Score.TabIndex = 14;
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecision.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrecision.Location = new System.Drawing.Point(505, 464);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(0, 19);
            this.lblPrecision.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label16.Location = new System.Drawing.Point(216, 464);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 17;
            this.label16.Text = "F1-Score";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label14.Location = new System.Drawing.Point(409, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 18;
            this.label14.Text = "Precision ";
            // 
            // lblRecall
            // 
            this.lblRecall.AutoSize = true;
            this.lblRecall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecall.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRecall.Location = new System.Drawing.Point(303, 429);
            this.lblRecall.Name = "lblRecall";
            this.lblRecall.Size = new System.Drawing.Size(0, 19);
            this.lblRecall.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label12.Location = new System.Drawing.Point(216, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Recall";
            // 
            // lblErrorRate
            // 
            this.lblErrorRate.AutoSize = true;
            this.lblErrorRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblErrorRate.Location = new System.Drawing.Point(116, 464);
            this.lblErrorRate.Name = "lblErrorRate";
            this.lblErrorRate.Size = new System.Drawing.Size(0, 19);
            this.lblErrorRate.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(24, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "ErrorRate";
            // 
            // btnMoreDetails
            // 
            this.btnMoreDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMoreDetails.FlatAppearance.BorderSize = 0;
            this.btnMoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreDetails.ForeColor = System.Drawing.Color.White;
            this.btnMoreDetails.Location = new System.Drawing.Point(658, 429);
            this.btnMoreDetails.Name = "btnMoreDetails";
            this.btnMoreDetails.Size = new System.Drawing.Size(222, 64);
            this.btnMoreDetails.TabIndex = 9;
            this.btnMoreDetails.Text = "More Details";
            this.btnMoreDetails.UseVisualStyleBackColor = false;
            this.btnMoreDetails.Click += new System.EventHandler(this.btnMoreDetails_Click);
            // 
            // lblCurrentCell
            // 
            this.lblCurrentCell.AutoSize = true;
            this.lblCurrentCell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCurrentCell.Location = new System.Drawing.Point(245, 25);
            this.lblCurrentCell.Name = "lblCurrentCell";
            this.lblCurrentCell.Size = new System.Drawing.Size(0, 19);
            this.lblCurrentCell.TabIndex = 8;
            // 
            // PageMultipleClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.btnMoreDetails);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.lblOverallAccuracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentCell);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView);
            this.Name = "PageMultipleClasses";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.PageMultipleClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericClassesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
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
    }
}
