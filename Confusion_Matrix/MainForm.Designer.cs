namespace Confusion_Matrix
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlNavMenu = new System.Windows.Forms.Panel();
            this.pnlRibon = new System.Windows.Forms.Panel();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.btnNavTutorials = new System.Windows.Forms.Button();
            this.btnNavMultiple = new System.Windows.Forms.Button();
            this.btnNavBinary = new System.Windows.Forms.Button();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTopBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlNavMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBorder
            // 
            this.pnlTopBorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTopBorder.Controls.Add(this.pictureBox2);
            this.pnlTopBorder.Controls.Add(this.cmbLanguage);
            this.pnlTopBorder.Controls.Add(this.lblTitle);
            this.pnlTopBorder.Controls.Add(this.btnExit);
            this.pnlTopBorder.Controls.Add(this.btnMinimize);
            this.bunifuTransition1.SetDecoration(this.pnlTopBorder, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pnlTopBorder, "pnlTopBorder");
            this.pnlTopBorder.Name = "pnlTopBorder";
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // cmbLanguage
            // 
            this.bunifuTransition1.SetDecoration(this.cmbLanguage, BunifuAnimatorNS.DecorationType.Custom);
            this.cmbLanguage.DisplayMember = "0";
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            resources.GetString("cmbLanguage.Items"),
            resources.GetString("cmbLanguage.Items1")});
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.ValueMember = "0";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.bunifuTransition1.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            resources.ApplyResources(this.pnlNavMenu, "pnlNavMenu");
            this.pnlNavMenu.Name = "pnlNavMenu";
            // 
            // pnlRibon
            // 
            this.pnlRibon.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.pnlRibon, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pnlRibon, "pnlRibon");
            this.pnlRibon.Name = "pnlRibon";
            // 
            // btnNavSettings
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNavSettings, "btnNavSettings");
            this.btnNavSettings.ForeColor = System.Drawing.Color.White;
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.UseVisualStyleBackColor = true;
            this.btnNavSettings.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavTutorials
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavTutorials, BunifuAnimatorNS.DecorationType.None);
            this.btnNavTutorials.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNavTutorials, "btnNavTutorials");
            this.btnNavTutorials.ForeColor = System.Drawing.Color.White;
            this.btnNavTutorials.Name = "btnNavTutorials";
            this.btnNavTutorials.UseVisualStyleBackColor = true;
            this.btnNavTutorials.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavMultiple
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavMultiple, BunifuAnimatorNS.DecorationType.None);
            this.btnNavMultiple.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNavMultiple, "btnNavMultiple");
            this.btnNavMultiple.ForeColor = System.Drawing.Color.White;
            this.btnNavMultiple.Name = "btnNavMultiple";
            this.btnNavMultiple.UseVisualStyleBackColor = true;
            this.btnNavMultiple.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavBinary
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavBinary, BunifuAnimatorNS.DecorationType.None);
            this.btnNavBinary.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNavBinary, "btnNavBinary");
            this.btnNavBinary.ForeColor = System.Drawing.Color.White;
            this.btnNavBinary.Name = "btnNavBinary";
            this.btnNavBinary.UseVisualStyleBackColor = true;
            this.btnNavBinary.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnNavHome
            // 
            this.bunifuTransition1.SetDecoration(this.btnNavHome, BunifuAnimatorNS.DecorationType.None);
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNavHome, "btnNavHome");
            this.btnNavHome.ForeColor = System.Drawing.Color.White;
            this.btnNavHome.Name = "btnNavHome";
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
            // pnlContainer
            // 
            this.bunifuTransition1.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pnlContainer, "pnlContainer");
            this.pnlContainer.Name = "pnlContainer";
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
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNavMenu);
            this.Controls.Add(this.pnlTopBorder);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBorder.ResumeLayout(false);
            this.pnlTopBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlNavMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlRibon;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

