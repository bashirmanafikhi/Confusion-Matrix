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
            double tp = (double)numericUpDown1.Value;
            double tn = (double)numericUpDown2.Value;
            double fp = (double)numericUpDown3.Value;
            double fn = (double)numericUpDown4.Value;

            Confusion_Matrix_Library.BinaryConfusionMatrix confusion = new Confusion_Matrix_Library.BinaryConfusionMatrix(tp, tn, fp, fn);
            MessageBox.Show(confusion.Accuracy.ToString());
        }
    }
}
