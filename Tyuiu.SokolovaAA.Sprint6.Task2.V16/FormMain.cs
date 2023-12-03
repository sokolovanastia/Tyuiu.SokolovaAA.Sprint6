using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task2.V16.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SAA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_SAA.Titles.Add("График функции F(x) = Cos(x) / x - 0,4 + Sin(x) * 8x + 2");
                this.chartFunction_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_SAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Blue;
        }

        private void buttonDone_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Red;
        }

        private void buttonDone_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Green;
        }

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студент группы АСОиУб-23-3 Соколова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
