using Tyuiu.SokolovaAA.Sprint6.Task6.V17.Lib;
using System.IO;
using System;

namespace Tyuiu.SokolovaAA.Sprint6.Task6.V17
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GroupBox_MainButtons_SAA = new System.Windows.Forms.GroupBox();
            this.Button_Help_SAA = new System.Windows.Forms.Button();
            this.Button_Done_SAA = new System.Windows.Forms.Button();
            this.Button_SearchFiles_SAA = new System.Windows.Forms.Button();
            this.GroupBox_Condition_SAA = new System.Windows.Forms.GroupBox();
            this.TextBox_Condition_SAA = new System.Windows.Forms.TextBox();
            this.GroupBox_Input_SAA = new System.Windows.Forms.GroupBox();
            this.TextBox_Input_SAA = new System.Windows.Forms.TextBox();
            this.GroupBox_Output_SAA = new System.Windows.Forms.GroupBox();
            this.TextBox_Output_SAA = new System.Windows.Forms.TextBox();
            this.OpenFileDialog_SAA = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_SAA = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox_MainButtons_SAA.SuspendLayout();
            this.GroupBox_Condition_SAA.SuspendLayout();
            this.GroupBox_Input_SAA.SuspendLayout();
            this.GroupBox_Output_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_MainButtons_SAA
            // 
            this.GroupBox_MainButtons_SAA.Controls.Add(this.Button_Help_SAA);
            this.GroupBox_MainButtons_SAA.Controls.Add(this.Button_Done_SAA);
            this.GroupBox_MainButtons_SAA.Controls.Add(this.Button_SearchFiles_SAA);
            this.GroupBox_MainButtons_SAA.Location = new System.Drawing.Point(0, 4);
            this.GroupBox_MainButtons_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_MainButtons_SAA.Name = "GroupBox_MainButtons_SAA";
            this.GroupBox_MainButtons_SAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_MainButtons_SAA.Size = new System.Drawing.Size(1065, 70);
            this.GroupBox_MainButtons_SAA.TabIndex = 0;
            this.GroupBox_MainButtons_SAA.TabStop = false;
            // 
            // Button_Help_SAA
            // 
            this.Button_Help_SAA.Image = ((System.Drawing.Image)(resources.GetObject("Button_Help_SAA.Image")));
            this.Button_Help_SAA.Location = new System.Drawing.Point(972, 11);
            this.Button_Help_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Help_SAA.Name = "Button_Help_SAA";
            this.Button_Help_SAA.Size = new System.Drawing.Size(79, 59);
            this.Button_Help_SAA.TabIndex = 2;
            this.ToolTip_SAA.SetToolTip(this.Button_Help_SAA, "Информация о разработчике");
            this.Button_Help_SAA.UseVisualStyleBackColor = true;
            // 
            // Button_Done_SAA
            // 
            this.Button_Done_SAA.Image = ((System.Drawing.Image)(resources.GetObject("Button_Done_SAA.Image")));
            this.Button_Done_SAA.Location = new System.Drawing.Point(115, 11);
            this.Button_Done_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Done_SAA.Name = "Button_Done_SAA";
            this.Button_Done_SAA.Size = new System.Drawing.Size(79, 59);
            this.Button_Done_SAA.TabIndex = 1;
            this.ToolTip_SAA.SetToolTip(this.Button_Done_SAA, " Использовать программу и получить результат");
            this.Button_Done_SAA.UseVisualStyleBackColor = true;
            // 
            // Button_SearchFiles_SAA
            // 
            this.Button_SearchFiles_SAA.Image = ((System.Drawing.Image)(resources.GetObject("Button_SearchFiles_SAA.Image")));
            this.Button_SearchFiles_SAA.Location = new System.Drawing.Point(16, 11);
            this.Button_SearchFiles_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_SearchFiles_SAA.Name = "Button_SearchFiles_SAA";
            this.Button_SearchFiles_SAA.Size = new System.Drawing.Size(79, 59);
            this.Button_SearchFiles_SAA.TabIndex = 0;
            this.ToolTip_SAA.SetToolTip(this.Button_SearchFiles_SAA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.Button_SearchFiles_SAA.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Condition_SAA
            // 
            this.GroupBox_Condition_SAA.Controls.Add(this.TextBox_Condition_SAA);
            this.GroupBox_Condition_SAA.Location = new System.Drawing.Point(0, 81);
            this.GroupBox_Condition_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Condition_SAA.Name = "GroupBox_Condition_SAA";
            this.GroupBox_Condition_SAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Condition_SAA.Size = new System.Drawing.Size(1065, 106);
            this.GroupBox_Condition_SAA.TabIndex = 1;
            this.GroupBox_Condition_SAA.TabStop = false;
            this.GroupBox_Condition_SAA.Text = "Условие";
            // 
            // TextBox_Condition_SAA
            // 
            this.TextBox_Condition_SAA.Location = new System.Drawing.Point(8, 23);
            this.TextBox_Condition_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Condition_SAA.Multiline = true;
            this.TextBox_Condition_SAA.Name = "TextBox_Condition_SAA";
            this.TextBox_Condition_SAA.ReadOnly = true;
            this.TextBox_Condition_SAA.Size = new System.Drawing.Size(1048, 74);
            this.TextBox_Condition_SAA.TabIndex = 0;
            // 
            // GroupBox_Input_SAA
            // 
            this.GroupBox_Input_SAA.Controls.Add(this.TextBox_Input_SAA);
            this.GroupBox_Input_SAA.Location = new System.Drawing.Point(8, 187);
            this.GroupBox_Input_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Input_SAA.Name = "GroupBox_Input_SAA";
            this.GroupBox_Input_SAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Input_SAA.Size = new System.Drawing.Size(507, 352);
            this.GroupBox_Input_SAA.TabIndex = 2;
            this.GroupBox_Input_SAA.TabStop = false;
            this.GroupBox_Input_SAA.Text = "Ввод:";
            // 
            // TextBox_Input_SAA
            // 
            this.TextBox_Input_SAA.Location = new System.Drawing.Point(0, 16);
            this.TextBox_Input_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Input_SAA.Multiline = true;
            this.TextBox_Input_SAA.Name = "TextBox_Input_SAA";
            this.TextBox_Input_SAA.ReadOnly = true;
            this.TextBox_Input_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Input_SAA.Size = new System.Drawing.Size(497, 342);
            this.TextBox_Input_SAA.TabIndex = 0;
            // 
            // GroupBox_Output_SAA
            // 
            this.GroupBox_Output_SAA.Controls.Add(this.TextBox_Output_SAA);
            this.GroupBox_Output_SAA.Location = new System.Drawing.Point(523, 187);
            this.GroupBox_Output_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Output_SAA.Name = "GroupBox_Output_SAA";
            this.GroupBox_Output_SAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Output_SAA.Size = new System.Drawing.Size(507, 359);
            this.GroupBox_Output_SAA.TabIndex = 3;
            this.GroupBox_Output_SAA.TabStop = false;
            this.GroupBox_Output_SAA.Text = "Вывод:";
            // 
            // TextBox_Output_SAA
            // 
            this.TextBox_Output_SAA.Location = new System.Drawing.Point(0, 16);
            this.TextBox_Output_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Output_SAA.Multiline = true;
            this.TextBox_Output_SAA.Name = "TextBox_Output_SAA";
            this.TextBox_Output_SAA.ReadOnly = true;
            this.TextBox_Output_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Output_SAA.Size = new System.Drawing.Size(497, 335);
            this.TextBox_Output_SAA.TabIndex = 1;
            // 
            // OpenFileDialog_SAA
            // 
            this.OpenFileDialog_SAA.FileName = "openFileDialog1";
            // 
            // ToolTip_SAA
            // 
            this.ToolTip_SAA.Tag = "";
            this.ToolTip_SAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_SAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GroupBox_Output_SAA);
            this.Controls.Add(this.GroupBox_Input_SAA);
            this.Controls.Add(this.GroupBox_Condition_SAA);
            this.Controls.Add(this.GroupBox_MainButtons_SAA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 17 | Соколова А.А.";
            this.GroupBox_MainButtons_SAA.ResumeLayout(false);
            this.GroupBox_Condition_SAA.ResumeLayout(false);
            this.GroupBox_Condition_SAA.PerformLayout();
            this.GroupBox_Input_SAA.ResumeLayout(false);
            this.GroupBox_Input_SAA.PerformLayout();
            this.GroupBox_Output_SAA.ResumeLayout(false);
            this.GroupBox_Output_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_MainButtons_SAA;
        private System.Windows.Forms.Button Button_Help_SAA;
        private System.Windows.Forms.Button Button_Done_SAA;
        private System.Windows.Forms.Button Button_SearchFiles_SAA;
        private System.Windows.Forms.GroupBox GroupBox_Condition_SAA;
        private System.Windows.Forms.TextBox TextBox_Condition_SAA;
        private System.Windows.Forms.GroupBox GroupBox_Input_SAA;
        private System.Windows.Forms.TextBox TextBox_Input_SAA;
        private System.Windows.Forms.GroupBox GroupBox_Output_SAA;
        private System.Windows.Forms.TextBox TextBox_Output_SAA;
        private System.Windows.Forms.ToolTip ToolTip_SAA;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_SAA;

        public EventHandler Button_Done_SAA_Click { get; private set; }
        public EventHandler Button_Help_SAA_Click { get; private set; }
        public EventHandler Button_SearchFiles_SAA_Click { get; private set; }
    }
}

       

