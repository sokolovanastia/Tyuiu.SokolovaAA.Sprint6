using Tyuiu.SokolovaAA.Sprint6.Task1.V16.Lib;

namespace Tyuiu.SokolovaAA.Sprint6.Task1.V16
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
            this.groupBoxСondition_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAA = new System.Windows.Forms.GroupBox();
            this.labelStopValue_SAA = new System.Windows.Forms.Label();
            this.textBoxStopVar_SAA = new System.Windows.Forms.TextBox();
            this.labelStartValue_SAA = new System.Windows.Forms.Label();
            this.textBoxStartVar_SAA = new System.Windows.Forms.TextBox();
            this.buttonSpravka_SAA = new System.Windows.Forms.Button();
            this.buttonPerform_SAA = new System.Windows.Forms.Button();
            this.groupBoxConclusionSAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxСondition_SAA.SuspendLayout();
            this.groupBoxInput_SAA.SuspendLayout();
            this.groupBoxConclusionSAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxСondition_SAA
            // 
            this.groupBoxСondition_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxСondition_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxСondition_SAA.Name = "groupBoxСondition_SAA";
            this.groupBoxСondition_SAA.Size = new System.Drawing.Size(467, 337);
            this.groupBoxСondition_SAA.TabIndex = 0;
            this.groupBoxСondition_SAA.TabStop = false;
            this.groupBoxСondition_SAA.Text = "Условие";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Location = new System.Drawing.Point(3, 31);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(307, 42);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Протабулировать функцию F(x) на заданном диапозоне.\r\nРезультат вывести в виде таб" +
    "лицы.\r\n";
            // 
            // groupBoxInput_SAA
            // 
            this.groupBoxInput_SAA.Controls.Add(this.labelStopValue_SAA);
            this.groupBoxInput_SAA.Controls.Add(this.textBoxStopVar_SAA);
            this.groupBoxInput_SAA.Controls.Add(this.labelStartValue_SAA);
            this.groupBoxInput_SAA.Controls.Add(this.textBoxStartVar_SAA);
            this.groupBoxInput_SAA.Location = new System.Drawing.Point(12, 355);
            this.groupBoxInput_SAA.Name = "groupBoxInput_SAA";
            this.groupBoxInput_SAA.Size = new System.Drawing.Size(262, 83);
            this.groupBoxInput_SAA.TabIndex = 1;
            this.groupBoxInput_SAA.TabStop = false;
            this.groupBoxInput_SAA.Text = "Ввод данных:";
            // 
            // labelStopValue_SAA
            // 
            this.labelStopValue_SAA.AutoSize = true;
            this.labelStopValue_SAA.Location = new System.Drawing.Point(132, 31);
            this.labelStopValue_SAA.Name = "labelStopValue_SAA";
            this.labelStopValue_SAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_SAA.TabIndex = 3;
            this.labelStopValue_SAA.Text = "Конец шага:";
            // 
            // textBoxStopVar_SAA
            // 
            this.textBoxStopVar_SAA.Location = new System.Drawing.Point(125, 47);
            this.textBoxStopVar_SAA.Name = "textBoxStopVar_SAA";
            this.textBoxStopVar_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVar_SAA.TabIndex = 2;
            // 
            // labelStartValue_SAA
            // 
            this.labelStartValue_SAA.AutoSize = true;
            this.labelStartValue_SAA.Location = new System.Drawing.Point(6, 31);
            this.labelStartValue_SAA.Name = "labelStartValue_SAA";
            this.labelStartValue_SAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_SAA.TabIndex = 1;
            this.labelStartValue_SAA.Text = "Старт шага:";
            // 
            // textBoxStartVar_SAA
            // 
            this.textBoxStartVar_SAA.Location = new System.Drawing.Point(3, 47);
            this.textBoxStartVar_SAA.Name = "textBoxStartVar_SAA";
            this.textBoxStartVar_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVar_SAA.TabIndex = 0;
            // 
            // buttonSpravka_SAA
            // 
            this.buttonSpravka_SAA.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSpravka_SAA.Location = new System.Drawing.Point(280, 370);
            this.buttonSpravka_SAA.Name = "buttonSpravka_SAA";
            this.buttonSpravka_SAA.Size = new System.Drawing.Size(89, 52);
            this.buttonSpravka_SAA.TabIndex = 2;
            this.buttonSpravka_SAA.Text = "Справка";
            this.buttonSpravka_SAA.UseVisualStyleBackColor = false;
            this.buttonSpravka_SAA.Click += new System.EventHandler(this.buttonSpravkaDSN_Click);
            // 
            // buttonPerform_SAA
            // 
            this.buttonPerform_SAA.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerform_SAA.Location = new System.Drawing.Point(392, 370);
            this.buttonPerform_SAA.Name = "buttonPerform_SAA";
            this.buttonPerform_SAA.Size = new System.Drawing.Size(87, 52);
            this.buttonPerform_SAA.TabIndex = 3;
            this.buttonPerform_SAA.Text = "Выполнить";
            this.buttonPerform_SAA.UseVisualStyleBackColor = false;
            this.buttonPerform_SAA.Click += new System.EventHandler(this.buttonPerformDSN_Click);
            // 
            // groupBoxConclusionSAA
            // 
            this.groupBoxConclusionSAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxConclusionSAA.Location = new System.Drawing.Point(485, 12);
            this.groupBoxConclusionSAA.Name = "groupBoxConclusionSAA";
            this.groupBoxConclusionSAA.Size = new System.Drawing.Size(269, 426);
            this.groupBoxConclusionSAA.TabIndex = 4;
            this.groupBoxConclusionSAA.TabStop = false;
            this.groupBoxConclusionSAA.Text = "Вывод данных:";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(257, 402);
            this.textBoxResult_SAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.groupBoxConclusionSAA);
            this.Controls.Add(this.buttonPerform_SAA);
            this.Controls.Add(this.buttonSpravka_SAA);
            this.Controls.Add(this.groupBoxInput_SAA);
            this.Controls.Add(this.groupBoxСondition_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 16  | Соколова А.А.";
            this.groupBoxСondition_SAA.ResumeLayout(false);
            this.groupBoxСondition_SAA.PerformLayout();
            this.groupBoxInput_SAA.ResumeLayout(false);
            this.groupBoxInput_SAA.PerformLayout();
            this.groupBoxConclusionSAA.ResumeLayout(false);
            this.groupBoxConclusionSAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxСondition_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxInput_SAA;
        private System.Windows.Forms.Label labelStopValue_SAA;
        private System.Windows.Forms.TextBox textBoxStopVar_SAA;
        private System.Windows.Forms.Label labelStartValue_SAA;
        private System.Windows.Forms.TextBox textBoxStartVar_SAA;
        private System.Windows.Forms.Button buttonSpravka_SAA;
        private System.Windows.Forms.Button buttonPerform_SAA;
        private System.Windows.Forms.GroupBox groupBoxConclusionSAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
    }
}

