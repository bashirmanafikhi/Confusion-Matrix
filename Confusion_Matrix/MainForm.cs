using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confusion_Matrix_Library;
using Confusion_Matrix.UserControles;
using System.Threading;
using System.Globalization;
using Confusion_Matrix.Classes;

namespace Confusion_Matrix
{
    public enum Page
    {
        Home,
        Binary,
        Multiple,
        Tutorials,
        Settings
    }
    public partial class MainForm : Form
    {

        private static Page CurrentPage = Page.Home;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            pnlRibon.Location = button.Location;
            
            //pnlRibon.Visible = false;
            //bunifuTransition1.ShowSync(pnlRibon, false, BunifuAnimatorNS.Animation.Scale);

            // show the page
            pnlContainer.Controls.Clear();
            UserControl page;
            switch (button.Name)
            {
                case "btnNavHome":
                    page = new PageHome();
                    CurrentPage = Page.Home;
                    break;
                case "btnNavBinary":
                    page = new PageBinaryClasses();
                    CurrentPage = Page.Binary;
                    break;
                case "btnNavMultiple":
                    page = new PageMultipleClasses();
                    CurrentPage = Page.Multiple;
                    break;
                case "btnNavTutorials":
                    page = new PageTutorials();
                    CurrentPage = Page.Tutorials;
                    break;
                case "btnNavSettings":
                    page = new PageSettings();
                    CurrentPage = Page.Settings;
                    break;
                default:
                    return;
            }

            page.Visible = false;
            pnlContainer.Controls.Add(page);
            bunifuTransition1.Show(page, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnNav_Click(btnNavHome, e);


            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en-US":
                    cmbLanguage.SelectedText = "English";
                    break;
                case "tr-TR":
                    cmbLanguage.SelectedText = "Türkçe";
                    break;
                default:
                    break;
            }
        }






        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLanguage.SelectedItem.ToString())
            {
                case "English":
                    ChangeLanguage("en");
                    break;
                case "Türkçe":
                    ChangeLanguage("tr-TR");
                    break;
                default:
                    break;
            }
        }


        private void ChangeLanguage(string lang)
        {

            var rm = new ComponentResourceManager(this.GetType());
            var culture = CultureInfo.CreateSpecificCulture(lang);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            foreach (Control c in this.AllControls())
            {
                if (c is ToolStrip)
                {
                    var items = ((ToolStrip)c).AllItems().ToList();
                    foreach (var item in items)
                        rm.ApplyResources(item, item.Name);
                }
                rm.ApplyResources(c, c.Name);
            }

            ChangePanelLanguage(lang);
        }


        private void ChangePanelLanguage(string lang)
        {
            /*foreach (Control c in pnlContainer.Controls[0].Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(PageSettings));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }*/
            switch (CurrentPage)
            {
                case Page.Home:
                    btnNav_Click(btnNavHome,null);
                    break;
                case Page.Binary:
                    btnNav_Click(btnNavBinary,null);
                    break;
                case Page.Multiple:
                    btnNav_Click(btnNavMultiple,null);
                    break;
                case Page.Tutorials:
                    btnNav_Click(btnNavTutorials,null);
                    break;
                case Page.Settings:
                    btnNav_Click(btnNavSettings,null);
                    break;
                default:
                    break;
            }
        }


    }
}
