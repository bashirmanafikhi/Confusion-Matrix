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
    public partial class Details : Form
    {
        public Details(ConfusionMatrix confusion)
        {
            InitializeComponent();
            for (int i = 0; i < confusion.ClassCount; i++)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.HeaderCell.Value = "Class " + (i+1);


                row.Cells[0].Value = confusion.Accuracy(i).ToString("0.0000");
                row.Cells[1].Value = confusion.ErrorRate(i).ToString("0.0000");
                row.Cells[2].Value = confusion.Recall(i).ToString("0.0000");
                row.Cells[3].Value = confusion.F1Score(i).ToString("0.0000");
                row.Cells[4].Value = confusion.Precision(i).ToString("0.0000");




            }

        }
    }
}
