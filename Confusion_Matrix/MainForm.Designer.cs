﻿namespace Confusion_Matrix
{
    partial class MainForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTopBorder = new System.Windows.Forms.Panel();
            this.pnlNavMenu = new System.Windows.Forms.Panel();
            this.pnlRibon = new System.Windows.Forms.Panel();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.btnNavTutorials = new System.Windows.Forms.Button();
            this.btnNavMultiple = new System.Windows.Forms.Button();
            this.btnNavBinary = new System.Windows.Forms.Button();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pageHome1 = new Confusion_Matrix.UserControles.PageHome();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlNavMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBorder
            // 
            this.pnlTopBorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.pnlTopBorder, BunifuAnimatorNS.DecorationType.None);
            this.pnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBorder.Name = "pnlTopBorder";
            this.pnlTopBorder.Size = new System.Drawing.Size(1030, 16);
            this.pnlTopBorder.TabIndex = 0;
            // 
            // pnlNavMenu
            // 
            this.pnlNavMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlNavMenu.Controls.Add(this.pnlRibon);
            this.pnlNavMenu.Controls.Add(this.btnNavSettings);
            this.pnlNavMenu.Controls.Add(this.btnNavTutorials);
            this.pnlNavMenu.Controls.Add(this.btnNavMultiple);
            this.pnlNavMenu.Controls.Add(this.btnNavBinary);
            this.pnlNavMenu.Controls.Add(this.btnNavHome);
            this.bunifuTransition1.SetDecoration(this.pnlNavMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlNavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavMenu.Location = new System.Drawing.Point(0, 16);
            this.pnlNavMenu.Name = "pnlNavMenu";
            this.pnlNavMenu.Size = new System.Drawing.Size(130, 600);
            this.pnlNavMenu.TabIndex = 1;
            // 
            // pnlRibon
            // 
            this.pnlRibon.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.pnlRibon, BunifuAnimatorNS.DecorationType.None);
            this.pnlRibon.Location = new System.Drawing.Point(0, 0);
            this.pnlRibon.Name = "pnlRibon";
            this.pnlRibon.Size = new System.Drawing.Size(10, 100);
            this.pnlRibon.TabIndex = 6;
            // 
            // btnNavSettings
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSettings.ForeColor = System.Drawing.Color.White;
            this.btnNavSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnNavSettings.Image")));
            this.btnNavSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavSettings.Location = new System.Drawing.Point(0, 400);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Size = new System.Drawing.Size(130, 100);
            this.btnNavSettings.TabIndex = 2;
            this.btnNavSettings.Text = "Settings";
            this.btnNavSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNavSettings.UseVisualStyleBackColor = true;
            this.btnNavSettings.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavTutorials
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavTutorials, BunifuAnimatorNS.DecorationType.None);
            this.btnNavTutorials.FlatAppearance.BorderSize = 0;
            this.btnNavTutorials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTutorials.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTutorials.ForeColor = System.Drawing.Color.White;
            this.btnNavTutorials.Image = ((System.Drawing.Image)(resources.GetObject("btnNavTutorials.Image")));
            this.btnNavTutorials.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavTutorials.Location = new System.Drawing.Point(0, 300);
            this.btnNavTutorials.Name = "btnNavTutorials";
            this.btnNavTutorials.Size = new System.Drawing.Size(130, 100);
            this.btnNavTutorials.TabIndex = 2;
            this.btnNavTutorials.Text = "Measures";
            this.btnNavTutorials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNavTutorials.UseVisualStyleBackColor = true;
            this.btnNavTutorials.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavMultiple
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavMultiple, BunifuAnimatorNS.DecorationType.None);
            this.btnNavMultiple.FlatAppearance.BorderSize = 0;
            this.btnNavMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMultiple.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMultiple.ForeColor = System.Drawing.Color.White;
            this.btnNavMultiple.Image = ((System.Drawing.Image)(resources.GetObject("btnNavMultiple.Image")));
            this.btnNavMultiple.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavMultiple.Location = new System.Drawing.Point(0, 200);
            this.btnNavMultiple.Name = "btnNavMultiple";
            this.btnNavMultiple.Size = new System.Drawing.Size(130, 100);
            this.btnNavMultiple.TabIndex = 2;
            this.btnNavMultiple.Text = "Multiple Classes";
            this.btnNavMultiple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNavMultiple.UseVisualStyleBackColor = true;
            this.btnNavMultiple.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavBinary
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavBinary, BunifuAnimatorNS.DecorationType.None);
            this.btnNavBinary.FlatAppearance.BorderSize = 0;
            this.btnNavBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBinary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavBinary.ForeColor = System.Drawing.Color.White;
            this.btnNavBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnNavBinary.Image")));
            this.btnNavBinary.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavBinary.Location = new System.Drawing.Point(0, 100);
            this.btnNavBinary.Name = "btnNavBinary";
            this.btnNavBinary.Size = new System.Drawing.Size(130, 100);
            this.btnNavBinary.TabIndex = 2;
            this.btnNavBinary.Text = "Binary Classes Calculator";
            this.btnNavBinary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNavBinary.UseVisualStyleBackColor = true;
            this.btnNavBinary.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavHome
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavHome, BunifuAnimatorNS.DecorationType.None);
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.ForeColor = System.Drawing.Color.White;
            this.btnNavHome.Image = ((System.Drawing.Image)(resources.GetObject("btnNavHome.Image")));
            this.btnNavHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavHome.Location = new System.Drawing.Point(0, 0);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(130, 100);
            this.btnNavHome.TabIndex = 2;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNavHome.UseVisualStyleBackColor = true;
            this.btnNavHome.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlTopBorder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1002, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(16, 16);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 73);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(152, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 100);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "DR. MURAT KÖKLÜ";
            // 
            // label2
            // 
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(313, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONFUSION MATRIX";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(975, 22);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pageHome1);
            this.bunifuTransition1.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContainer.Location = new System.Drawing.Point(130, 116);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(900, 500);
            this.pnlContainer.TabIndex = 5;
            // 
            // pageHome1
            // 
            this.pageHome1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTransition1.SetDecoration(this.pageHome1, BunifuAnimatorNS.DecorationType.None);
            this.pageHome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHome1.Location = new System.Drawing.Point(0, 0);
            this.pageHome1.Margin = new System.Windows.Forms.Padding(0);
            this.pageHome1.Name = "pageHome1";
            this.pageHome1.Size = new System.Drawing.Size(900, 500);
            this.pageHome1.TabIndex = 0;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 3;
            this.bunifuTransition1.MaxAnimationTime = 750;
            this.bunifuTransition1.TimeStep = 0.03F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 616);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlNavMenu);
            this.Controls.Add(this.pnlTopBorder);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confusion Matrix";
            this.pnlNavMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBorder;
        private System.Windows.Forms.Panel pnlNavMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavTutorials;
        private System.Windows.Forms.Button btnNavMultiple;
        private System.Windows.Forms.Button btnNavBinary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlRibon;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private UserControles.PageHome pageHome1;
    }
}

