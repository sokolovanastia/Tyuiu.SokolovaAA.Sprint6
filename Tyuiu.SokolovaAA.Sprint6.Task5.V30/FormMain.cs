using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task5.V30.Lib;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint6.Task5.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\nassok\source\repos\Tyuiu.SokolovaAA.Sprint6\Tyuiu.SokolovaAA.Sprint6.Task5.V30\bin\Debug\InPutFileTask5V30.txt";
        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_SAA.ColumnCount = 2;
            dataGridViewRes_SAA.Columns[0].Width = 20;
            dataGridViewRes_SAA.Columns[1].Width = 50;
            this.chartRes_SAA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartRes_SAA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartRes_SAA.Series[0].Points.Clear();
            double[] mas = new double[ds.len];
            mas = ds.LoadFromDataFile(path);
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridViewRes_SAA.Rows.Add(Convert.ToString(i), Convert.ToString(mas[i]));
                chartRes_SAA.Series[0].Points.AddXY(i, mas[i]);
            }
        }

        private void buttonFile_SAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-3 Соколова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
