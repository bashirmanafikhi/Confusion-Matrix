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
            ConfusionMatrix confusionMatrix = new ConfusionMatrix();


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
            pnlContainer.Controls.Clear();

            switch (button.Name)
            {
                case "btnNavHome":
                    pnlContainer.Controls.Add(new PageHome());
                    break;
                case "btnNavBinary":
                    pnlContainer.Controls.Add(new PageBinaryClasses());
                    break;
                case "btnNavMultiple":
                    pnlContainer.Controls.Add(new PageMultipleClasses());
                    break;
                case "btnNavTutorials":
                    pnlContainer.Controls.Add(new PageTutorials());
                    break;
                case "btnNavSettings":
                    pnlContainer.Controls.Add(new PageSettings());
                    break;
            }
            
        }
    }
}
