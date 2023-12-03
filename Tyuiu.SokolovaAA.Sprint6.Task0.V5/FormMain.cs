﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task0.V5.Lib;

namespace Tyuiu.SokolovaAA.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonClickToSolition_SAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPutX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonFAQ_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнилa студент группы АСОиУб-23-3 Соколова Анастасия Александровна");
        }

       
    }
}
