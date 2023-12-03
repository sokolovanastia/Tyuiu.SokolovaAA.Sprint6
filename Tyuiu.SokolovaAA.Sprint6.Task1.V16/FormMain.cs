using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task1.V16.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task1.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPerformDSN_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartVar_SAA.Text);
                int stopValue = Convert.ToInt32(textBoxStopVar_SAA.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_SAA.Text = "";
                textBoxResult_SAA.AppendText("+----------+-------------+" + Environment.NewLine);
                textBoxResult_SAA.AppendText("+    X     +     F(x)    |" + Environment.NewLine);
                textBoxResult_SAA.AppendText("+----------+-------------+" + Environment.NewLine);

                string str;
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,5:d}     |  {1, 7:f2}    |", startValue, valueArray[i]);
                    textBoxResult_SAA.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SAA.AppendText("+----------+-------------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravkaDSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы АСОиУб-23-3 Соколова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
