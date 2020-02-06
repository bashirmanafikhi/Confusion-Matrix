using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confusion_Matrix_Library;

namespace Confusion_Matrix.UserControles
{
    public partial class PageMultipleClasses : UserControl
    {

        int classCount;
        ConfusionMatrix confusion;


        public PageMultipleClasses()
        {
            InitializeComponent();
        }

        private void PageMultipleClasses_Load(object sender, EventArgs e)
        {
            Redraw();
        }

        private void Redraw()
        {

            dataGridView.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AllowUserToOrderColumns = false;
            DataGridViewColumn column;
            int index; 
            string[] row;

            // get count of classes
            classCount = (int)numericClassesCount.Value;

            confusion = new ConfusionMatrix(classCount);




            // adding header of grid
            column = new DataGridViewTextBoxColumn();
            column.Name = "column" + 0;
            column.Name = "";
            column.ReadOnly = true;
            column.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView.Columns.Add(column);
            row = new string[classCount + 3];
            row[0] = "";

            for (int i = 1; i <= classCount; i++)
            {
                row[i] = "Class " + i;
                dataGridView.Columns.Add("column" + i, "Class " + i);
                dataGridView.Columns[dataGridView.Columns.Count - 1].DefaultCellStyle.BackColor = Color.White;
            }

            
            column = new DataGridViewTextBoxColumn();
            column.Name = "column" + (classCount + 1);
            column.Name = "Classification";
            column.ReadOnly = true;
            column.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView.Columns.Add(column);
            row[classCount + 1] = "Classification";



            // adding classes rows

            index = dataGridView.Rows.Add(row);
            dataGridView.Rows[index].ReadOnly = true;
            dataGridView.Rows[index].DefaultCellStyle.BackColor = Color.WhiteSmoke;



            for (int i = 1; i <= classCount; i++)
            {
                row = new string[classCount + 2];
                row[0] = "Class " + i;
                for (int j = 1; j <= classCount; j++)
                {
                    row[j] = "";
                }
                dataGridView.Rows.Add(row);
            }


            // adding 'truth overall' row
            row = new string[classCount + 2];
            row[0] = "Truth";
            for (int j = 1; j <= classCount; j++)
            {
                row[j] = "";
                
            }
            index = dataGridView.Rows.Add(row);
            dataGridView.Rows[index].ReadOnly = true;
            dataGridView.Rows[index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            

            // Coloring the table
            for (int i = 1; i <= classCount; i++)
            {
                dataGridView.Rows[i].Cells[i].Style.BackColor = Color.Khaki;
                
                dataGridView.Rows[classCount + 1].Cells[i].Style.ForeColor = Color.MidnightBlue;
                dataGridView.Rows[i].Cells[classCount + 1].Style.ForeColor = Color.MidnightBlue;
            }
            dataGridView.Rows[classCount + 1].Cells[classCount + 1].Style.ForeColor = Color.MidnightBlue;




            lblOverallAccuracy.Text = "";
            lblAccuracy.Text = "";
            lblErrorRate.Text = "";
            lblF1Score.Text = "";
            lblPrecision.Text = "";
            lblRecall.Text = "";

        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {

            double rowSum, columnSum, totalSum = 0;
            for (int i = 0; i < classCount; i++)
            {
                rowSum = 0;
                columnSum = 0;

                for (int j = 0; j < classCount; j++)
                {
                    // row
                    double value = 0;
                    string cell = (string)(dataGridView.Rows[1 + i].Cells[1 + j].Value);
                    _ = double.TryParse(cell, out value);
                    confusion[i, j] = value;
                    rowSum += value;
                    

                    // column
                    value = 0;
                    cell = (string)(dataGridView.Rows[1 + j].Cells[1 + i].Value);
                    _ = double.TryParse(cell, out value);
                    columnSum += value;

                    // total
                    totalSum += value;
                }
                dataGridView.Rows[1 + i].Cells[1 + classCount].Value = rowSum;
                dataGridView.Rows[1 + classCount].Cells[1 + i].Value = columnSum;
            }
            dataGridView.Rows[classCount + 1].Cells[classCount + 1].Value = totalSum;



            lblOverallAccuracy.Text = confusion.OverallAccuracy.ToString("0.00") + "%";
            lblAccuracy.Text = confusion.Accuracy().ToString("0.0000");
            lblErrorRate.Text = confusion.ErrorRate().ToString("0.0000");
            lblF1Score.Text = confusion.F1Score().ToString("0.0000");
            lblPrecision.Text = confusion.Precision().ToString("0.0000");
            lblRecall.Text = confusion.Recall().ToString("0.0000");

        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0 && e.RowIndex < dataGridView.Rows.Count - 1 && e.ColumnIndex < dataGridView.Columns.Count - 1)
            {
                lblCurrentCell.Text = "Actual " + e.ColumnIndex + " - Predicted " + e.RowIndex;
            }
            else
            {
                lblCurrentCell.Text = "";
            }
        }

        private void btnMoreDetails_Click(object sender, EventArgs e)
        {
            Details details = new Details(confusion);
            details.ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string message = "";

            message += "Overall Accuracy : " + lblOverallAccuracy.Text + "\n";
            message += "Accuracy : " + lblAccuracy.Text + "\n";
            message += "Error Rate : " + lblErrorRate.Text + "\n";
            message += "F1 Score : " + lblF1Score.Text + "\n";
            message += "Precision : " + lblPrecision.Text + "\n";
            message += "Recall : " + lblRecall.Text;



            System.Windows.Forms.Clipboard.SetText(message);
            Toast.ShowMessage("Coppied!");
        }
    }
}
