
namespace Tyuiu.SokolovaAA.Sprint6.Task5.V30
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_SAA = new System.Windows.Forms.Panel();
            this.panelRes_SAA = new System.Windows.Forms.Panel();
            this.panelFunction_SAA = new System.Windows.Forms.Panel();
            this.splitterSplinter_SAA = new System.Windows.Forms.Splitter();
            this.groupBoxRes_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_SAA = new System.Windows.Forms.DataGridView();
            this.chartRes_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonFile_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.panelTask_SAA.SuspendLayout();
            this.panelRes_SAA.SuspendLayout();
            this.panelFunction_SAA.SuspendLayout();
            this.groupBoxRes_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SAA)).BeginInit();
            this.groupBoxTask_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTask_SAA
            // 
            this.panelTask_SAA.BackColor = System.Drawing.Color.Thistle;
            this.panelTask_SAA.Controls.Add(this.buttonDone_SAA);
            this.panelTask_SAA.Controls.Add(this.buttonFile_SAA);
            this.panelTask_SAA.Controls.Add(this.buttonHelp_SAA);
            this.panelTask_SAA.Controls.Add(this.groupBoxTask_SAA);
            this.panelTask_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SAA.Location = new System.Drawing.Point(5, 5);
            this.panelTask_SAA.Name = "panelTask_SAA";
            this.panelTask_SAA.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_SAA.Size = new System.Drawing.Size(968, 100);
            this.panelTask_SAA.TabIndex = 0;
            // 
            // panelRes_SAA
            // 
            this.panelRes_SAA.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panelRes_SAA.Controls.Add(this.groupBoxRes_SAA);
            this.panelRes_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRes_SAA.Location = new System.Drawing.Point(5, 105);
            this.panelRes_SAA.Name = "panelRes_SAA";
            this.panelRes_SAA.Padding = new System.Windows.Forms.Padding(5);
            this.panelRes_SAA.Size = new System.Drawing.Size(200, 334);
            this.panelRes_SAA.TabIndex = 1;
            // 
            // panelFunction_SAA
            // 
            this.panelFunction_SAA.BackColor = System.Drawing.Color.Plum;
            this.panelFunction_SAA.Controls.Add(this.chartRes_SAA);
            this.panelFunction_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_SAA.Location = new System.Drawing.Point(205, 105);
            this.panelFunction_SAA.Name = "panelFunction_SAA";
            this.panelFunction_SAA.Padding = new System.Windows.Forms.Padding(5);
            this.panelFunction_SAA.Size = new System.Drawing.Size(768, 334);
            this.panelFunction_SAA.TabIndex = 2;
            // 
            // splitterSplinter_SAA
            // 
            this.splitterSplinter_SAA.Location = new System.Drawing.Point(205, 105);
            this.splitterSplinter_SAA.Name = "splitterSplinter_SAA";
            this.splitterSplinter_SAA.Size = new System.Drawing.Size(3, 334);
            this.splitterSplinter_SAA.TabIndex = 3;
            this.splitterSplinter_SAA.TabStop = false;
            // 
            // groupBoxRes_SAA
            // 
            this.groupBoxRes_SAA.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxRes_SAA.Controls.Add(this.dataGridViewRes_SAA);
            this.groupBoxRes_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_SAA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxRes_SAA.Name = "groupBoxRes_SAA";
            this.groupBoxRes_SAA.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxRes_SAA.Size = new System.Drawing.Size(190, 324);
            this.groupBoxRes_SAA.TabIndex = 0;
            this.groupBoxRes_SAA.TabStop = false;
            this.groupBoxRes_SAA.Text = "Вывод данных:";
            // 
            // dataGridViewRes_SAA
            // 
            this.dataGridViewRes_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_SAA.ColumnHeadersVisible = false;
            this.dataGridViewRes_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_SAA.Location = new System.Drawing.Point(5, 24);
            this.dataGridViewRes_SAA.Name = "dataGridViewRes_SAA";
            this.dataGridViewRes_SAA.ReadOnly = true;
            this.dataGridViewRes_SAA.RowHeadersVisible = false;
            this.dataGridViewRes_SAA.RowHeadersWidth = 62;
            this.dataGridViewRes_SAA.RowTemplate.Height = 28;
            this.dataGridViewRes_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRes_SAA.Size = new System.Drawing.Size(180, 295);
            this.dataGridViewRes_SAA.TabIndex = 0;
            // 
            // chartRes_SAA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRes_SAA.ChartAreas.Add(chartArea5);
            this.chartRes_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartRes_SAA.Legends.Add(legend5);
            this.chartRes_SAA.Location = new System.Drawing.Point(5, 5);
            this.chartRes_SAA.Name = "chartRes_SAA";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartRes_SAA.Series.Add(series5);
            this.chartRes_SAA.Size = new System.Drawing.Size(758, 324);
            this.chartRes_SAA.TabIndex = 0;
            this.chartRes_SAA.Text = "chart1";
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(594, 90);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие:";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(581, 58);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Прочитать данные из файла InPutFileTask5V30.txt. Вывести в dataGridView.\r\nВывести" +
    " все числа от 2 до 7. Построить диаграмму по этим значениям.";
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonHelp_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(604, 30);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(110, 49);
            this.buttonHelp_SAA.TabIndex = 1;
            this.buttonHelp_SAA.Text = "Справка";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonFile_SAA
            // 
            this.buttonFile_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonFile_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonFile_SAA.Location = new System.Drawing.Point(720, 30);
            this.buttonFile_SAA.Name = "buttonFile_SAA";
            this.buttonFile_SAA.Size = new System.Drawing.Size(110, 49);
            this.buttonFile_SAA.TabIndex = 2;
            this.buttonFile_SAA.Text = "Открыть файл";
            this.buttonFile_SAA.UseVisualStyleBackColor = false;
            this.buttonFile_SAA.Click += new System.EventHandler(this.buttonFile_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonDone_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDone_SAA.Location = new System.Drawing.Point(836, 30);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(110, 49);
            this.buttonDone_SAA.TabIndex = 3;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // FormMain_SAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 444);
            this.Controls.Add(this.splitterSplinter_SAA);
            this.Controls.Add(this.panelFunction_SAA);
            this.Controls.Add(this.panelRes_SAA);
            this.Controls.Add(this.panelTask_SAA);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FormMain_SAA";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 30 | Логинов М.В.";
            this.panelTask_SAA.ResumeLayout(false);
            this.panelRes_SAA.ResumeLayout(false);
            this.panelFunction_SAA.ResumeLayout(false);
            this.groupBoxRes_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SAA)).EndInit();
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonFile_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.Panel panelRes_SAA;
        private System.Windows.Forms.GroupBox groupBoxRes_SAA;
        private System.Windows.Forms.DataGridView dataGridViewRes_SAA;
        private System.Windows.Forms.Panel panelFunction_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_SAA;
        private System.Windows.Forms.Splitter splitterSplinter_SAA;

    }

}

