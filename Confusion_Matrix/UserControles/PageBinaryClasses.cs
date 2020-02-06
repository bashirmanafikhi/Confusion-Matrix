using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confusion_Matrix.UserControles
{
    public partial class PageBinaryClasses : UserControl
    {
        public PageBinaryClasses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tp = (double)numericTP.Value;
            double tn = (double)numericTN.Value;
            double fp = (double)numericFP.Value;
            double fn = (double)numericFN.Value;

            Confusion_Matrix_Library.BinaryConfusionMatrix confusion = new Confusion_Matrix_Library.BinaryConfusionMatrix(tp, tn, fp, fn);

            lblAccuracy.Text = confusion.Accuracy.ToString("0.0000");
            lblErrorRate.Text = confusion.ErrorRate.ToString("0.0000");
            lblRecall.Text = confusion.Recall.ToString("0.0000");
            lblSpecificity.Text = confusion.Specificity.ToString("0.0000");
            lblPrecision.Text = confusion.Precision.ToString("0.0000");
            lblF1Score.Text = confusion.F1Score.ToString("0.0000");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string message = "";

            message += "Accuracy : " + lblAccuracy.Text + "\n";
            message += "Error Rate : " + lblErrorRate.Text + "\n";
            message += "Recall : " + lblRecall.Text + "\n"; 
            message += "Specifity : " + lblSpecificity.Text + "\n";
            message += "Precision : " + lblPrecision.Text + "\n";
            message += "F1 Score : " + lblF1Score.Text;



            System.Windows.Forms.Clipboard.SetText(message);
            Toast.ShowMessage("Coppied!");
        }
    }
}
