namespace Confusion_Matrix.UserControles
{
    partial class PageBinaryClasses
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numericTN = new System.Windows.Forms.NumericUpDown();
            this.numericTP = new System.Windows.Forms.NumericUpDown();
            this.numericFP = new System.Windows.Forms.NumericUpDown();
            this.numericFN = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblErrorRate = new System.Windows.Forms.Label();
            this.lblRecall = new System.Windows.Forms.Label();
            this.lblSpecificity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblF1Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Binary Classes";
            // 
            // numericTN
            // 
            this.numericTN.Location = new System.Drawing.Point(479, 144);
            this.numericTN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTN.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericTN.Name = "numericTN";
            this.numericTN.Size = new System.Drawing.Size(120, 20);
            this.numericTN.TabIndex = 6;
            // 
            // numericTP
            // 
            this.numericTP.Location = new System.Drawing.Point(321, 101);
            this.numericTP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTP.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericTP.Name = "numericTP";
            this.numericTP.Size = new System.Drawing.Size(120, 20);
            this.numericTP.TabIndex = 6;
            // 
            // numericFP
            // 
            this.numericFP.Location = new System.Drawing.Point(479, 101);
            this.numericFP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFP.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericFP.Name = "numericFP";
            this.numericFP.Size = new System.Drawing.Size(120, 20);
            this.numericFP.TabIndex = 6;
            // 
            // numericFN
            // 
            this.numericFN.Location = new System.Drawing.Point(323, 144);
            this.numericFN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFN.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericFN.Name = "numericFN";
            this.numericFN.Size = new System.Drawing.Size(120, 20);
            this.numericFN.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(621, 61);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 104);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.btnCalculate;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(321, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "True Positive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(480, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "True Negative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(127, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Predicted Positive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(111, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Predicted Negative";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(295, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "TP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(295, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "FN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(452, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "TN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(452, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "FP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label10.Location = new System.Drawing.Point(111, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Accuracy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(110, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "ErrorRate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label12.Location = new System.Drawing.Point(110, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Recall";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label13.Location = new System.Drawing.Point(110, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Specificity";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAccuracy.Location = new System.Drawing.Point(222, 221);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(0, 19);
            this.lblAccuracy.TabIndex = 5;
            // 
            // lblErrorRate
            // 
            this.lblErrorRate.AutoSize = true;
            this.lblErrorRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblErrorRate.Location = new System.Drawing.Point(221, 254);
            this.lblErrorRate.Name = "lblErrorRate";
            this.lblErrorRate.Size = new System.Drawing.Size(0, 19);
            this.lblErrorRate.TabIndex = 5;
            // 
            // lblRecall
            // 
            this.lblRecall.AutoSize = true;
            this.lblRecall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecall.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRecall.Location = new System.Drawing.Point(221, 287);
            this.lblRecall.Name = "lblRecall";
            this.lblRecall.Size = new System.Drawing.Size(0, 19);
            this.lblRecall.TabIndex = 5;
            // 
            // lblSpecificity
            // 
            this.lblSpecificity.AutoSize = true;
            this.lblSpecificity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificity.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSpecificity.Location = new System.Drawing.Point(221, 320);
            this.lblSpecificity.Name = "lblSpecificity";
            this.lblSpecificity.Size = new System.Drawing.Size(0, 19);
            this.lblSpecificity.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(142, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label14.Location = new System.Drawing.Point(111, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Precision ";
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecision.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrecision.Location = new System.Drawing.Point(222, 355);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(0, 19);
            this.lblPrecision.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label16.Location = new System.Drawing.Point(111, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "F1-Score";
            // 
            // lblF1Score
            // 
            this.lblF1Score.AutoSize = true;
            this.lblF1Score.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF1Score.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblF1Score.Location = new System.Drawing.Point(222, 390);
            this.lblF1Score.Name = "lblF1Score";
            this.lblF1Score.Size = new System.Drawing.Size(0, 19);
            this.lblF1Score.TabIndex = 5;
            // 
            // PageBinaryClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numericFN);
            this.Controls.Add(this.numericFP);
            this.Controls.Add(this.numericTP);
            this.Controls.Add(this.numericTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblF1Score);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.lblSpecificity);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRecall);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblErrorRate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageBinaryClasses";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.numericTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericTN;
        private System.Windows.Forms.NumericUpDown numericTP;
        private System.Windows.Forms.NumericUpDown numericFP;
        private System.Windows.Forms.NumericUpDown numericFN;
        private System.Windows.Forms.Button btnCalculate;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblErrorRate;
        private System.Windows.Forms.Label lblRecall;
        private System.Windows.Forms.Label lblSpecificity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblF1Score;
    }
}
