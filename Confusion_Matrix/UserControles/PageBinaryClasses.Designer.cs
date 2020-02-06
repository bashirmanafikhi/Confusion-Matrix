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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageBinaryClasses));
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Name = "label1";
            // 
            // numericTN
            // 
            resources.ApplyResources(this.numericTN, "numericTN");
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
            // 
            // numericTP
            // 
            resources.ApplyResources(this.numericTP, "numericTP");
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
            // 
            // numericFP
            // 
            resources.ApplyResources(this.numericFP, "numericFP");
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
            // 
            // numericFN
            // 
            resources.ApplyResources(this.numericFN, "numericFN");
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
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.Name = "btnCalculate";
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
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label13.Name = "label13";
            // 
            // lblAccuracy
            // 
            resources.ApplyResources(this.lblAccuracy, "lblAccuracy");
            this.lblAccuracy.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAccuracy.Name = "lblAccuracy";
            // 
            // lblErrorRate
            // 
            resources.ApplyResources(this.lblErrorRate, "lblErrorRate");
            this.lblErrorRate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblErrorRate.Name = "lblErrorRate";
            // 
            // lblRecall
            // 
            resources.ApplyResources(this.lblRecall, "lblRecall");
            this.lblRecall.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRecall.Name = "lblRecall";
            // 
            // lblSpecificity
            // 
            resources.ApplyResources(this.lblSpecificity, "lblSpecificity");
            this.lblSpecificity.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSpecificity.Name = "lblSpecificity";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Name = "panel1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label14.Name = "label14";
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
            // lblF1Score
            // 
            resources.ApplyResources(this.lblF1Score, "lblF1Score");
            this.lblF1Score.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblF1Score.Name = "lblF1Score";
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
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // PageBinaryClasses
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopy);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
