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


namespace Confusion_Matrix
{
    public partial class MainForm : Form
    {
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
            pnlRibon.Visible = false;
            bunifuTransition1.ShowSync(pnlRibon, false, BunifuAnimatorNS.Animation.Scale);

            // show the page
            pnlContainer.Controls.Clear();
            UserControl page;
            switch (button.Name)
            {
                case "btnNavHome":
                    page = new PageHome();
                    break;
                case "btnNavBinary":
                    page = new PageBinaryClasses();
                    break;
                case "btnNavMultiple":
                    page = new PageMultipleClasses();
                    break;
                case "btnNavTutorials":
                    page = new PageTutorials();
                    break;
                case "btnNavSettings":
                    page = new PageSettings();
                    break;
                default:
                    return;
            }

            page.Visible = false;
            pnlContainer.Controls.Add(page);
            bunifuTransition1.ShowSync(page, false, BunifuAnimatorNS.Animation.Rotate);
        }
    }
}
