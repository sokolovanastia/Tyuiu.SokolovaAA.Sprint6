using Tyuiu.SokolovaAA.Sprint6.Task3.V24.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task3.V24
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInfo_SAA = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_SAA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAA)).BeginInit();
            this.groupBoxResult_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.buttonDone_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.textBox1);
            this.groupBoxTask_SAA.Controls.Add(this.buttonInfo_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(13, 35);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(321, 335);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Location = new System.Drawing.Point(51, 196);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(116, 34);
            this.buttonDone_SAA.TabIndex = 4;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(310, 168);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дана матрица 5 на 5\r\n-17  -6  10   5   3\r\n -10 -14  10  -7  -3\r\n -19   9   8 -17 " +
    " -9\r\n -19  -5  -9 -18  14\r\n  17  12  11  12   2\r\nзаменить четные значения во вто" +
    "рой строке на 0";
            // 
            // buttonInfo_SAA
            // 
            this.buttonInfo_SAA.Location = new System.Drawing.Point(7, 196);
            this.buttonInfo_SAA.Name = "buttonInfo_SAA";
            this.buttonInfo_SAA.Size = new System.Drawing.Size(38, 34);
            this.buttonInfo_SAA.TabIndex = 3;
            this.buttonInfo_SAA.Text = "?";
            this.buttonInfo_SAA.UseVisualStyleBackColor = true;
            this.buttonInfo_SAA.Click += new System.EventHandler(this.buttonInfo_SAA_Click);
            // 
            // dataGridViewMatrix_SAA
            // 
            this.dataGridViewMatrix_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAA.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewMatrix_SAA.Name = "dataGridViewMatrix_SAA";
            this.dataGridViewMatrix_SAA.ReadOnly = true;
            this.dataGridViewMatrix_SAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAA.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SAA.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SAA.Size = new System.Drawing.Size(354, 190);
            this.dataGridViewMatrix_SAA.TabIndex = 1;
            this.dataGridViewMatrix_SAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SAA_CellContentClick);
            // 
            // groupBoxResult_SAA
            // 
            this.groupBoxResult_SAA.Controls.Add(this.dataGridViewMatrix_SAA);
            this.groupBoxResult_SAA.Location = new System.Drawing.Point(336, 35);
            this.groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            this.groupBoxResult_SAA.Size = new System.Drawing.Size(374, 223);
            this.groupBoxResult_SAA.TabIndex = 2;
            this.groupBoxResult_SAA.TabStop = false;
            this.groupBoxResult_SAA.Text = "Вывод данных";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 270);
            this.Controls.Add(this.groupBoxResult_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 3|Вариант 24|Соколова А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAA)).EndInit();
            this.groupBoxResult_SAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAA;
        private System.Windows.Forms.GroupBox groupBoxResult_SAA;
        private System.Windows.Forms.Button buttonInfo_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
    }
}


