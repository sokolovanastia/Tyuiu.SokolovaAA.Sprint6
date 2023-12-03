using Tyuiu.SokolovaAA.Sprint6.Task0.V5.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task0.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SAA = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAA = new System.Windows.Forms.GroupBox();
            this.labelInPutX_SAA = new System.Windows.Forms.Label();
            this.textBoxInPutX = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.labelOutPutResult_SAA = new System.Windows.Forms.Label();
            this.buttonClickToSolition_SAA = new System.Windows.Forms.Button();
            this.buttonFAQ_SAA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCondition_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAA)).BeginInit();
            this.groupBoxInPut_SAA.SuspendLayout();
            this.groupBoxOutPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_SAA.Controls.Add(this.pictureBoxFormula_SAA);
            this.groupBoxCondition_SAA.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(12, 30);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(776, 231);
            this.groupBoxCondition_SAA.TabIndex = 0;
            this.groupBoxCondition_SAA.TabStop = false;
            this.groupBoxCondition_SAA.Text = "Условие";
            // 
            // pictureBoxFormula_SAA
            // 
            this.pictureBoxFormula_SAA.Location = new System.Drawing.Point(18, 62);
            this.pictureBoxFormula_SAA.Name = "pictureBoxFormula_SAA";
            this.pictureBoxFormula_SAA.Size = new System.Drawing.Size(752, 150);
            this.pictureBoxFormula_SAA.TabIndex = 1;
            this.pictureBoxFormula_SAA.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(18, 28);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(752, 18);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPut_SAA
            // 
            this.groupBoxInPut_SAA.Controls.Add(this.labelInPutX_SAA);
            this.groupBoxInPut_SAA.Controls.Add(this.textBoxInPutX);
            this.groupBoxInPut_SAA.Location = new System.Drawing.Point(12, 280);
            this.groupBoxInPut_SAA.Name = "groupBoxInPut_SAA";
            this.groupBoxInPut_SAA.Size = new System.Drawing.Size(542, 102);
            this.groupBoxInPut_SAA.TabIndex = 1;
            this.groupBoxInPut_SAA.TabStop = false;
            this.groupBoxInPut_SAA.Text = "Ввод данных";
            // 
            // labelInPutX_SAA
            // 
            this.labelInPutX_SAA.AutoSize = true;
            this.labelInPutX_SAA.Location = new System.Drawing.Point(7, 45);
            this.labelInPutX_SAA.Name = "labelInPutX_SAA";
            this.labelInPutX_SAA.Size = new System.Drawing.Size(84, 13);
            this.labelInPutX_SAA.TabIndex = 2;
            this.labelInPutX_SAA.Text = "Переменная X:";
            // 
            // textBoxInPutX
            // 
            this.textBoxInPutX.Location = new System.Drawing.Point(9, 61);
            this.textBoxInPutX.Name = "textBoxInPutX";
            this.textBoxInPutX.Size = new System.Drawing.Size(82, 20);
            this.textBoxInPutX.TabIndex = 0;
            this.textBoxInPutX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxOutPut_SAA
            // 
            this.groupBoxOutPut_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxOutPut_SAA.Controls.Add(this.labelOutPutResult_SAA);
            this.groupBoxOutPut_SAA.Location = new System.Drawing.Point(570, 281);
            this.groupBoxOutPut_SAA.Name = "groupBoxOutPut_SAA";
            this.groupBoxOutPut_SAA.Size = new System.Drawing.Size(218, 101);
            this.groupBoxOutPut_SAA.TabIndex = 2;
            this.groupBoxOutPut_SAA.TabStop = false;
            this.groupBoxOutPut_SAA.Text = "Вывод данных:";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Location = new System.Drawing.Point(9, 61);
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(103, 20);
            this.textBoxResult_SAA.TabIndex = 1;
            // 
            // labelOutPutResult_SAA
            // 
            this.labelOutPutResult_SAA.AutoSize = true;
            this.labelOutPutResult_SAA.Location = new System.Drawing.Point(6, 44);
            this.labelOutPutResult_SAA.Name = "labelOutPutResult_SAA";
            this.labelOutPutResult_SAA.Size = new System.Drawing.Size(59, 13);
            this.labelOutPutResult_SAA.TabIndex = 0;
            this.labelOutPutResult_SAA.Text = "Результат";
            // 
            // buttonClickToSolition_SAA
            // 
            this.buttonClickToSolition_SAA.Location = new System.Drawing.Point(649, 388);
            this.buttonClickToSolition_SAA.Name = "buttonClickToSolition_SAA";
            this.buttonClickToSolition_SAA.Size = new System.Drawing.Size(139, 50);
            this.buttonClickToSolition_SAA.TabIndex = 3;
            this.buttonClickToSolition_SAA.Text = "Выполнить";
            this.buttonClickToSolition_SAA.UseVisualStyleBackColor = true;
            this.buttonClickToSolition_SAA.Click += new System.EventHandler(this.buttonClickToSolition_SAA_Click);
            // 
            // buttonFAQ_SAA
            // 
            this.buttonFAQ_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFAQ_SAA.Location = new System.Drawing.Point(571, 388);
            this.buttonFAQ_SAA.Name = "buttonFAQ_SAA";
            this.buttonFAQ_SAA.Size = new System.Drawing.Size(64, 50);
            this.buttonFAQ_SAA.TabIndex = 4;
            this.buttonFAQ_SAA.Text = "?";
            this.buttonFAQ_SAA.UseVisualStyleBackColor = true;
            this.buttonFAQ_SAA.Click += new System.EventHandler(this.buttonFAQ_SAA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFAQ_SAA);
            this.Controls.Add(this.buttonClickToSolition_SAA);
            this.Controls.Add(this.groupBoxOutPut_SAA);
            this.Controls.Add(this.groupBoxInPut_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Соколова А.А.";
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAA)).EndInit();
            this.groupBoxInPut_SAA.ResumeLayout(false);
            this.groupBoxInPut_SAA.PerformLayout();
            this.groupBoxOutPut_SAA.ResumeLayout(false);
            this.groupBoxOutPut_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAA;
        private System.Windows.Forms.Label labelInPutX_SAA;
        private System.Windows.Forms.TextBox textBoxInPutX;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.Label labelOutPutResult_SAA;
        private System.Windows.Forms.Button buttonClickToSolition_SAA;
        private System.Windows.Forms.Button buttonFAQ_SAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAA;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

       
    
}

