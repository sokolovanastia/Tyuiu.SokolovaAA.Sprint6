
namespace Tyuiu.SokolovaAA.Sprint6.Task2.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxDataInPut_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_SAA = new System.Windows.Forms.TextBox();
            this.labelStartStep_SAA = new System.Windows.Forms.Label();
            this.labelStopStep_SAA = new System.Windows.Forms.Label();
            this.buttonInfo_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxDataOutPut_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_SAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_SAA = new System.Windows.Forms.Label();
            this.groupBoxCondition_SAA.SuspendLayout();
            this.groupBoxDataInPut_SAA.SuspendLayout();
            this.groupBoxDataOutPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxCondition_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(568, 316);
            this.groupBoxCondition_SAA.TabIndex = 0;
            this.groupBoxCondition_SAA.TabStop = false;
            this.groupBoxCondition_SAA.Text = "Условие";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SAA.Location = new System.Drawing.Point(7, 23);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(501, 287);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Протабулировать функцию F(x) = Cos(x) / x - 0,4 + Sin(x) * 8x + 2 на заданном диа" +
    "пазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxDataInPut_SAA
            // 
            this.groupBoxDataInPut_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxDataInPut_SAA.Controls.Add(this.labelStopStep_SAA);
            this.groupBoxDataInPut_SAA.Controls.Add(this.labelStartStep_SAA);
            this.groupBoxDataInPut_SAA.Controls.Add(this.textBoxStop_SAA);
            this.groupBoxDataInPut_SAA.Controls.Add(this.textBoxStart_SAA);
            this.groupBoxDataInPut_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataInPut_SAA.Location = new System.Drawing.Point(12, 335);
            this.groupBoxDataInPut_SAA.Name = "groupBoxDataInPut_SAA";
            this.groupBoxDataInPut_SAA.Size = new System.Drawing.Size(308, 100);
            this.groupBoxDataInPut_SAA.TabIndex = 1;
            this.groupBoxDataInPut_SAA.TabStop = false;
            this.groupBoxDataInPut_SAA.Text = "Ввод данных ";
            // 
            // textBoxStart_SAA
            // 
            this.textBoxStart_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStart_SAA.Location = new System.Drawing.Point(7, 58);
            this.textBoxStart_SAA.Name = "textBoxStart_SAA";
            this.textBoxStart_SAA.Size = new System.Drawing.Size(145, 23);
            this.textBoxStart_SAA.TabIndex = 0;
            // 
            // textBoxStop_SAA
            // 
            this.textBoxStop_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStop_SAA.Location = new System.Drawing.Point(158, 58);
            this.textBoxStop_SAA.Name = "textBoxStop_SAA";
            this.textBoxStop_SAA.Size = new System.Drawing.Size(143, 23);
            this.textBoxStop_SAA.TabIndex = 1;
            // 
            // labelStartStep_SAA
            // 
            this.labelStartStep_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStartStep_SAA.AutoSize = true;
            this.labelStartStep_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartStep_SAA.Location = new System.Drawing.Point(7, 39);
            this.labelStartStep_SAA.Name = "labelStartStep_SAA";
            this.labelStartStep_SAA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_SAA.TabIndex = 2;
            this.labelStartStep_SAA.Text = "Старт шага:";
            // 
            // labelStopStep_SAA
            // 
            this.labelStopStep_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStopStep_SAA.AutoSize = true;
            this.labelStopStep_SAA.Location = new System.Drawing.Point(158, 39);
            this.labelStopStep_SAA.Name = "labelStopStep_SAA";
            this.labelStopStep_SAA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_SAA.TabIndex = 3;
            this.labelStopStep_SAA.Text = "Конец шага:";
            // 
            // buttonInfo_SAA
            // 
            this.buttonInfo_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo_SAA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_SAA.Location = new System.Drawing.Point(335, 355);
            this.buttonInfo_SAA.Name = "buttonInfo_SAA";
            this.buttonInfo_SAA.Size = new System.Drawing.Size(91, 80);
            this.buttonInfo_SAA.TabIndex = 2;
            this.buttonInfo_SAA.Text = "Справка";
            this.buttonInfo_SAA.UseVisualStyleBackColor = false;
            this.buttonInfo_SAA.Click += new System.EventHandler(this.buttonInfo_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_SAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAA.Location = new System.Drawing.Point(432, 355);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(148, 80);
            this.buttonDone_SAA.TabIndex = 3;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            this.buttonDone_SAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SAA_MouseDown);
            this.buttonDone_SAA.MouseEnter += new System.EventHandler(this.buttonDone_SAA_MouseEnter);
            this.buttonDone_SAA.MouseLeave += new System.EventHandler(this.buttonDone_SAA_MouseLeave);
            // 
            // groupBoxDataOutPut_SAA
            // 
            this.groupBoxDataOutPut_SAA.Controls.Add(this.labelResult_SAA);
            this.groupBoxDataOutPut_SAA.Controls.Add(this.chartFunction_SAA);
            this.groupBoxDataOutPut_SAA.Controls.Add(this.dataGridViewFunction_SAA);
            this.groupBoxDataOutPut_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_SAA.Location = new System.Drawing.Point(586, 12);
            this.groupBoxDataOutPut_SAA.Name = "groupBoxDataOutPut_SAA";
            this.groupBoxDataOutPut_SAA.Size = new System.Drawing.Size(652, 423);
            this.groupBoxDataOutPut_SAA.TabIndex = 4;
            this.groupBoxDataOutPut_SAA.TabStop = false;
            this.groupBoxDataOutPut_SAA.Text = "Вывод данных ";
            // 
            // dataGridViewFunction_SAA
            // 
            this.dataGridViewFunction_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_SAA.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewFunction_SAA.Name = "dataGridViewFunction_SAA";
            this.dataGridViewFunction_SAA.RowHeadersVisible = false;
            this.dataGridViewFunction_SAA.Size = new System.Drawing.Size(153, 369);
            this.dataGridViewFunction_SAA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 50;
            // 
            // chartFunction_SAA
            // 
            chartArea9.Name = "ChartArea1";
            this.chartFunction_SAA.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartFunction_SAA.Legends.Add(legend9);
            this.chartFunction_SAA.Location = new System.Drawing.Point(166, 48);
            this.chartFunction_SAA.Name = "chartFunction_SAA";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartFunction_SAA.Series.Add(series9);
            this.chartFunction_SAA.Size = new System.Drawing.Size(480, 369);
            this.chartFunction_SAA.TabIndex = 1;
            this.chartFunction_SAA.Text = "chart1";
            // 
            // labelResult_SAA
            // 
            this.labelResult_SAA.AutoSize = true;
            this.labelResult_SAA.Location = new System.Drawing.Point(7, 29);
            this.labelResult_SAA.Name = "labelResult_SAA";
            this.labelResult_SAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAA.TabIndex = 2;
            this.labelResult_SAA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.groupBoxDataOutPut_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.buttonInfo_SAA);
            this.Controls.Add(this.groupBoxDataInPut_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 16 | Соколова Анастасия Александровна";
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            this.groupBoxDataInPut_SAA.ResumeLayout(false);
            this.groupBoxDataInPut_SAA.PerformLayout();
            this.groupBoxDataOutPut_SAA.ResumeLayout(false);
            this.groupBoxDataOutPut_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.GroupBox groupBoxDataInPut_SAA;
        private System.Windows.Forms.Label labelStopStep_SAA;
        private System.Windows.Forms.Label labelStartStep_SAA;
        private System.Windows.Forms.TextBox textBoxStop_SAA;
        private System.Windows.Forms.TextBox textBoxStart_SAA;
        private System.Windows.Forms.Button buttonInfo_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_SAA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Label labelResult_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
    }
}

      

