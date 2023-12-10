using Tyuiu.SokolovaAA.Sprint6.Task4.V3.Lib;
namespace Tyuiu.SokolovaAA.Sprint6.Task4.V3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelMenu_SAA = new System.Windows.Forms.Panel();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonSave_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxInput_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SAA = new System.Windows.Forms.TextBox();
            this.labelStopStep_SAA = new System.Windows.Forms.Label();
            this.labelStartStep_SAA = new System.Windows.Forms.Label();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.panelResult_SAA = new System.Windows.Forms.Panel();
            this.groupBoxResult_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.panelChart_SAA = new System.Windows.Forms.Panel();
            this.chartResult_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelMenu_SAA.SuspendLayout();
            this.groupBoxInput_SAA.SuspendLayout();
            this.groupBoxTask_SAA.SuspendLayout();
            this.panelResult_SAA.SuspendLayout();
            this.groupBoxResult_SAA.SuspendLayout();
            this.panelChart_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu_SAA
            // 
            this.panelMenu_SAA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu_SAA.Controls.Add(this.buttonHelp_SAA);
            this.panelMenu_SAA.Controls.Add(this.buttonSave_SAA);
            this.panelMenu_SAA.Controls.Add(this.buttonDone_SAA);
            this.panelMenu_SAA.Controls.Add(this.groupBoxInput_SAA);
            this.panelMenu_SAA.Controls.Add(this.groupBoxTask_SAA);
            this.panelMenu_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu_SAA.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_SAA.Name = "panelMenu_SAA";
            this.panelMenu_SAA.Size = new System.Drawing.Size(1482, 117);
            this.panelMenu_SAA.TabIndex = 0;
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonHelp_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SAA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(1344, 3);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(135, 108);
            this.buttonHelp_SAA.TabIndex = 1;
            this.buttonHelp_SAA.Text = "Справка";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonSave_SAA
            // 
            this.buttonSave_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSave_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SAA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_SAA.Location = new System.Drawing.Point(1182, 2);
            this.buttonSave_SAA.Name = "buttonSave_SAA";
            this.buttonSave_SAA.Size = new System.Drawing.Size(142, 109);
            this.buttonSave_SAA.TabIndex = 1;
            this.buttonSave_SAA.Text = "Сохранить";
            this.buttonSave_SAA.UseVisualStyleBackColor = false;
            this.buttonSave_SAA.Click += new System.EventHandler(this.buttonSave_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SAA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAA.Location = new System.Drawing.Point(1037, 3);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(139, 108);
            this.buttonDone_SAA.TabIndex = 1;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // groupBoxInput_SAA
            // 
            this.groupBoxInput_SAA.Controls.Add(this.textBoxStopStep_SAA);
            this.groupBoxInput_SAA.Controls.Add(this.textBoxStartStep_SAA);
            this.groupBoxInput_SAA.Controls.Add(this.labelStopStep_SAA);
            this.groupBoxInput_SAA.Controls.Add(this.labelStartStep_SAA);
            this.groupBoxInput_SAA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SAA.Location = new System.Drawing.Point(783, 0);
            this.groupBoxInput_SAA.Name = "groupBoxInput_SAA";
            this.groupBoxInput_SAA.Size = new System.Drawing.Size(248, 117);
            this.groupBoxInput_SAA.TabIndex = 0;
            this.groupBoxInput_SAA.TabStop = false;
            this.groupBoxInput_SAA.Text = "Ввод данных";
            // 
            // textBoxStopStep_SAA
            // 
            this.textBoxStopStep_SAA.Location = new System.Drawing.Point(134, 64);
            this.textBoxStopStep_SAA.Name = "textBoxStopStep_SAA";
            this.textBoxStopStep_SAA.Size = new System.Drawing.Size(100, 25);
            this.textBoxStopStep_SAA.TabIndex = 1;
            // 
            // textBoxStartStep_SAA
            // 
            this.textBoxStartStep_SAA.Location = new System.Drawing.Point(8, 64);
            this.textBoxStartStep_SAA.Name = "textBoxStartStep_SAA";
            this.textBoxStartStep_SAA.Size = new System.Drawing.Size(100, 25);
            this.textBoxStartStep_SAA.TabIndex = 1;
            // 
            // labelStopStep_SAA
            // 
            this.labelStopStep_SAA.AutoSize = true;
            this.labelStopStep_SAA.Location = new System.Drawing.Point(131, 38);
            this.labelStopStep_SAA.Name = "labelStopStep_SAA";
            this.labelStopStep_SAA.Size = new System.Drawing.Size(86, 17);
            this.labelStopStep_SAA.TabIndex = 0;
            this.labelStopStep_SAA.Tag = " ";
            this.labelStopStep_SAA.Text = "Конец шага";
            // 
            // labelStartStep_SAA
            // 
            this.labelStartStep_SAA.AutoSize = true;
            this.labelStartStep_SAA.Location = new System.Drawing.Point(6, 38);
            this.labelStartStep_SAA.Name = "labelStartStep_SAA";
            this.labelStartStep_SAA.Size = new System.Drawing.Size(85, 17);
            this.labelStartStep_SAA.TabIndex = 0;
            this.labelStartStep_SAA.Tag = " ";
            this.labelStartStep_SAA.Text = "Старт шага";
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(777, 117);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(3, 21);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(771, 93);
            this.textBoxTask_SAA.TabIndex = 0;
            // 
            // panelResult_SAA
            // 
            this.panelResult_SAA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelResult_SAA.Controls.Add(this.groupBoxResult_SAA);
            this.panelResult_SAA.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResult_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_SAA.Location = new System.Drawing.Point(0, 117);
            this.panelResult_SAA.Name = "panelResult_SAA";
            this.panelResult_SAA.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_SAA.Size = new System.Drawing.Size(320, 686);
            this.panelResult_SAA.TabIndex = 0;
            // 
            // groupBoxResult_SAA
            // 
            this.groupBoxResult_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxResult_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SAA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SAA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            this.groupBoxResult_SAA.Size = new System.Drawing.Size(310, 676);
            this.groupBoxResult_SAA.TabIndex = 0;
            this.groupBoxResult_SAA.TabStop = false;
            this.groupBoxResult_SAA.Text = "Вывод данных";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SAA.Location = new System.Drawing.Point(3, 21);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(304, 652);
            this.textBoxResult_SAA.TabIndex = 0;
            // 
            // panelChart_SAA
            // 
            this.panelChart_SAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChart_SAA.Controls.Add(this.chartResult_SAA);
            this.panelChart_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_SAA.Location = new System.Drawing.Point(320, 117);
            this.panelChart_SAA.Name = "panelChart_SAA";
            this.panelChart_SAA.Size = new System.Drawing.Size(1162, 686);
            this.panelChart_SAA.TabIndex = 0;
            // 
            // chartResult_SAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_SAA.ChartAreas.Add(chartArea1);
            this.chartResult_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_SAA.Legends.Add(legend1);
            this.chartResult_SAA.Location = new System.Drawing.Point(0, 0);
            this.chartResult_SAA.Name = "chartResult_SAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_SAA.Series.Add(series1);
            this.chartResult_SAA.Size = new System.Drawing.Size(1162, 686);
            this.chartResult_SAA.TabIndex = 0;
            this.chartResult_SAA.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title F(x)";
            title1.Text = "График функции F(x)";
            this.chartResult_SAA.Titles.Add(title1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(320, 117);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 686);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelChart_SAA);
            this.Controls.Add(this.panelResult_SAA);
            this.Controls.Add(this.panelMenu_SAA);
            this.MinimumSize = new System.Drawing.Size(1488, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 3 | Соклова А.А.";
            this.panelMenu_SAA.ResumeLayout(false);
            this.groupBoxInput_SAA.ResumeLayout(false);
            this.groupBoxInput_SAA.PerformLayout();
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.panelResult_SAA.ResumeLayout(false);
            this.groupBoxResult_SAA.ResumeLayout(false);
            this.groupBoxResult_SAA.PerformLayout();
            this.panelChart_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu_SAA;
        private System.Windows.Forms.Panel panelResult_SAA;
        private System.Windows.Forms.Panel panelChart_SAA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxResult_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxInput_SAA;
        private System.Windows.Forms.TextBox textBoxStopStep_SAA;
        private System.Windows.Forms.TextBox textBoxStartStep_SAA;
        private System.Windows.Forms.Label labelStopStep_SAA;
        private System.Windows.Forms.Label labelStartStep_SAA;
        private System.Windows.Forms.Button buttonSave_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SAA;
    }

}

        

