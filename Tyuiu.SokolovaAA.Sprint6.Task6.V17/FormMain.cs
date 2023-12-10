using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SokolovaAA.Sprint6.Task6.V17.Lib;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonOpenFileDialog_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAA.ShowDialog();
            openFilePath = openFileDialogTask_SAA.FileName;
            textBoxIn_SAA.Text = File.ReadAllText(openFilePath);
            groupBoxOut_SAA.Text = groupBoxOut_SAA.Text + " " + openFileDialogTask_SAA.FileName;
            buttonUp_SAA.Enabled = true;
        }

        private void buttonUp_SAA_Click(object sender, EventArgs e)
        {
            textBoxOut_SAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
