﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task7.V14.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task7.V14
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
