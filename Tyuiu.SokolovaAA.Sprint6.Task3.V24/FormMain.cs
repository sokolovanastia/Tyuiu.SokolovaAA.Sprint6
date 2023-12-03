using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task3.V24.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-17, -6, 10, 5, 3},
                                      {-10, -14, 10, -7, -3},
                                      {-19, 9, 8, -17, -9},
                                      {-19, -5, -9, -18, 14},
                                      {17, 12, 11, 12, 2} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_SAA.ColumnCount = mtrx.GetLength(1);
            dataGridViewMatrix_SAA.RowCount = mtrx.GetLength(0);

            for (int i = 0; i < dataGridViewMatrix_SAA.ColumnCount; i++)
            {
                dataGridViewMatrix_SAA.Columns[i].Width = 52;
            }

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix_SAA.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix_SAA.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }
        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студент группы АСОиУб-23-3 Соколова Анастасия Александровна", "Вам пришло новое сообщение", MessageBoxButtons.OK);
        }

        private void dataGridViewMatrix_SAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
