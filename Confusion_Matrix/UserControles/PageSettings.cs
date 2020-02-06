using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Confusion_Matrix.UserControles
{
    public partial class PageSettings : UserControl
    {
        public PageSettings()
        {
            InitializeComponent();

            cmbLanguage.Items.Add("English");
            cmbLanguage.Items.Add("Türkçe");


            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en-US":
                    cmbLanguage.SelectedIndex = 0;
                    break;
                case "tr-TR":
                    cmbLanguage.SelectedIndex = 1;
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
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    ChangeLanguage("en");
                    break;
                case "Türkçe":
                    ChangeLanguage("tr-TR");
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

                    break;
                default:
                    break;
            }
        }


        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(PageSettings));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }


        /*private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
                if (c.ToString().StartsWith("System.Windows.Forms.GroupBox"))
                {
                    foreach (Control child in c.Controls)
                    {
                        ComponentResourceManager resources_child = new ComponentResourceManager(typeof(MainForm));
                        resources_child.ApplyResources(child, child.Name, new CultureInfo(lang));
                    }
                }
            }
        }*/
    }
}
