namespace WinFormsKR3
{
    partial class FunctionSolutionForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
#region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leftBorder_TextBox = new System.Windows.Forms.TextBox();
            this.rightBorder_TextBox = new System.Windows.Forms.TextBox();
            this.buildChart_Button = new System.Windows.Forms.Button();
            this.chartTraktris_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diapazonY_Label = new System.Windows.Forms.Label();
            this.step_TextBox = new System.Windows.Forms.TextBox();
            this.step_Label = new System.Windows.Forms.Label();
            this.valueA_Label = new System.Windows.Forms.Label();
            this.valueA_TextBox = new System.Windows.Forms.TextBox();
            this.funcValue_Table = new System.Windows.Forms.DataGridView();
            this.columnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftBorder_Label = new System.Windows.Forms.Label();
            this.rightBorder_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.task_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.information_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStart_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFromFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChart_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInitialData_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tractrix_pictureBox = new System.Windows.Forms.PictureBox();
            this.specialPoint_Label = new System.Windows.Forms.Label();
            this.initialData_Button = new System.Windows.Forms.Button();
            this.clearChart_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTraktris_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcValue_Table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tractrix_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftBorder_TextBox
            // 
            this.leftBorder_TextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorder_TextBox.Location = new System.Drawing.Point(40, 282);
            this.leftBorder_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.leftBorder_TextBox.Name = "leftBorder_TextBox";
            this.leftBorder_TextBox.Size = new System.Drawing.Size(76, 29);
            this.leftBorder_TextBox.TabIndex = 3;
            // 
            // rightBorder_TextBox
            // 
            this.rightBorder_TextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorder_TextBox.Location = new System.Drawing.Point(155, 284);
            this.rightBorder_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rightBorder_TextBox.Name = "rightBorder_TextBox";
            this.rightBorder_TextBox.Size = new System.Drawing.Size(77, 29);
            this.rightBorder_TextBox.TabIndex = 4;
            // 
            // buildChart_Button
            // 
            this.buildChart_Button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildChart_Button.Location = new System.Drawing.Point(286, 654);
            this.buildChart_Button.Name = "buildChart_Button";
            this.buildChart_Button.Size = new System.Drawing.Size(222, 53);
            this.buildChart_Button.TabIndex = 6;
            this.buildChart_Button.Text = "Построить график";
            this.buildChart_Button.UseVisualStyleBackColor = true;
            this.buildChart_Button.Click += new System.EventHandler(this.buildChart_Button_Click);
            // 
            // chartTraktris_Chart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chartTraktris_Chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "legendTractrix_Legend";
            legend1.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartTraktris_Chart.Legends.Add(legend1);
            this.chartTraktris_Chart.Location = new System.Drawing.Point(286, 138);
            this.chartTraktris_Chart.Name = "chartTraktris_Chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "legendTractrix_Legend";
            series1.LegendText = "Трактриса";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartTraktris_Chart.Series.Add(series1);
            this.chartTraktris_Chart.Size = new System.Drawing.Size(930, 492);
            this.chartTraktris_Chart.TabIndex = 7;
            this.chartTraktris_Chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "title";
            title1.Text = "График функции : Трактирса";
            this.chartTraktris_Chart.Titles.Add(title1);
            // 
            // diapazonY_Label
            // 
            this.diapazonY_Label.AutoSize = true;
            this.diapazonY_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diapazonY_Label.Location = new System.Drawing.Point(5, 253);
            this.diapazonY_Label.Name = "diapazonY_Label";
            this.diapazonY_Label.Size = new System.Drawing.Size(194, 21);
            this.diapazonY_Label.TabIndex = 8;
            this.diapazonY_Label.Text = "Диапазон значения \"y\"";
            // 
            // step_TextBox
            // 
            this.step_TextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_TextBox.Location = new System.Drawing.Point(9, 214);
            this.step_TextBox.Name = "step_TextBox";
            this.step_TextBox.Size = new System.Drawing.Size(100, 29);
            this.step_TextBox.TabIndex = 11;
            // 
            // step_Label
            // 
            this.step_Label.AutoSize = true;
            this.step_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_Label.Location = new System.Drawing.Point(5, 190);
            this.step_Label.Name = "step_Label";
            this.step_Label.Size = new System.Drawing.Size(44, 21);
            this.step_Label.TabIndex = 10;
            this.step_Label.Text = "Шаг";
            // 
            // valueA_Label
            // 
            this.valueA_Label.AutoSize = true;
            this.valueA_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueA_Label.Location = new System.Drawing.Point(5, 138);
            this.valueA_Label.Name = "valueA_Label";
            this.valueA_Label.Size = new System.Drawing.Size(146, 21);
            this.valueA_Label.TabIndex = 12;
            this.valueA_Label.Text = "Коффициент \"A\"";
            // 
            // valueA_TextBox
            // 
            this.valueA_TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueA_TextBox.Location = new System.Drawing.Point(9, 162);
            this.valueA_TextBox.Name = "valueA_TextBox";
            this.valueA_TextBox.Size = new System.Drawing.Size(100, 26);
            this.valueA_TextBox.TabIndex = 13;
            // 
            // funcValue_Table
            // 
            this.funcValue_Table.AllowUserToAddRows = false;
            this.funcValue_Table.AllowUserToDeleteRows = false;
            this.funcValue_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.funcValue_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.funcValue_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcValue_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnY,
            this.ColumnX});
            this.funcValue_Table.Location = new System.Drawing.Point(9, 330);
            this.funcValue_Table.Margin = new System.Windows.Forms.Padding(2);
            this.funcValue_Table.Name = "funcValue_Table";
            this.funcValue_Table.RowHeadersVisible = false;
            this.funcValue_Table.RowHeadersWidth = 51;
            this.funcValue_Table.RowTemplate.Height = 24;
            this.funcValue_Table.Size = new System.Drawing.Size(222, 377);
            this.funcValue_Table.TabIndex = 14;
            // 
            // columnY
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnY.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnY.HeaderText = "y";
            this.columnY.MinimumWidth = 6;
            this.columnY.Name = "columnY";
            this.columnY.ReadOnly = true;
            this.columnY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnX
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnX.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnX.HeaderText = "x";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // leftBorder_Label
            // 
            this.leftBorder_Label.AutoSize = true;
            this.leftBorder_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorder_Label.Location = new System.Drawing.Point(5, 284);
            this.leftBorder_Label.Name = "leftBorder_Label";
            this.leftBorder_Label.Size = new System.Drawing.Size(32, 21);
            this.leftBorder_Label.TabIndex = 15;
            this.leftBorder_Label.Text = "От";
            // 
            // rightBorder_Label
            // 
            this.rightBorder_Label.AutoSize = true;
            this.rightBorder_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorder_Label.Location = new System.Drawing.Point(120, 287);
            this.rightBorder_Label.Name = "rightBorder_Label";
            this.rightBorder_Label.Size = new System.Drawing.Size(33, 21);
            this.rightBorder_Label.TabIndex = 16;
            this.rightBorder_Label.Text = "До";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task_ToolStripMenuItem,
            this.downloadFromFile_ToolStripMenuItem,
            this.saveChart_ToolStripMenuItem,
            this.saveInitialData_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1324, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // task_ToolStripMenuItem
            // 
            this.task_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.information_ToolStripMenuItem,
            this.showStart_ToolStripMenuItem});
            this.task_ToolStripMenuItem.Name = "task_ToolStripMenuItem";
            this.task_ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.task_ToolStripMenuItem.Text = "О задании";
            // 
            // information_ToolStripMenuItem
            // 
            this.information_ToolStripMenuItem.Name = "information_ToolStripMenuItem";
            this.information_ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.information_ToolStripMenuItem.Text = "Информация";
            this.information_ToolStripMenuItem.Click += new System.EventHandler(this.information_ToolStripMenuItem_Click);
            // 
            // showStart_ToolStripMenuItem
            // 
            this.showStart_ToolStripMenuItem.Name = "showStart_ToolStripMenuItem";
            this.showStart_ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.showStart_ToolStripMenuItem.Text = "Показывать информацию при запуске";
            this.showStart_ToolStripMenuItem.Click += new System.EventHandler(this.showStart_ToolStripMenuItem_Click);
            // 
            // downloadFromFile_ToolStripMenuItem
            // 
            this.downloadFromFile_ToolStripMenuItem.Name = "downloadFromFile_ToolStripMenuItem";
            this.downloadFromFile_ToolStripMenuItem.Size = new System.Drawing.Size(234, 20);
            this.downloadFromFile_ToolStripMenuItem.Text = "Загрузить начальные данные из файла";
            this.downloadFromFile_ToolStripMenuItem.Click += new System.EventHandler(this.downloadFromFile_ToolStripMenuItem_Click);
            // 
            // saveChart_ToolStripMenuItem
            // 
            this.saveChart_ToolStripMenuItem.Name = "saveChart_ToolStripMenuItem";
            this.saveChart_ToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.saveChart_ToolStripMenuItem.Text = "Сохранить график";
            this.saveChart_ToolStripMenuItem.Click += new System.EventHandler(this.saveChart_ToolStripMenuItem_Click);
            // 
            // saveInitialData_ToolStripMenuItem
            // 
            this.saveInitialData_ToolStripMenuItem.Name = "saveInitialData_ToolStripMenuItem";
            this.saveInitialData_ToolStripMenuItem.Size = new System.Drawing.Size(186, 20);
            this.saveInitialData_ToolStripMenuItem.Text = "Сохранить начальные данные";
            this.saveInitialData_ToolStripMenuItem.Click += new System.EventHandler(this.saveInitialData_ToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tractrix_pictureBox
            // 
            this.tractrix_pictureBox.Image = global::WinFormsKR3.Properties.Resources.Трактриса_Урезанная;
            this.tractrix_pictureBox.Location = new System.Drawing.Point(9, 24);
            this.tractrix_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.tractrix_pictureBox.Name = "tractrix_pictureBox";
            this.tractrix_pictureBox.Size = new System.Drawing.Size(537, 95);
            this.tractrix_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tractrix_pictureBox.TabIndex = 18;
            this.tractrix_pictureBox.TabStop = false;
            // 
            // specialPoint_Label
            // 
            this.specialPoint_Label.AutoSize = true;
            this.specialPoint_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialPoint_Label.Location = new System.Drawing.Point(551, 62);
            this.specialPoint_Label.Name = "specialPoint_Label";
            this.specialPoint_Label.Size = new System.Drawing.Size(415, 21);
            this.specialPoint_Label.TabIndex = 19;
            this.specialPoint_Label.Text = "При x = 0 трактриса имеет особую точку возврата";
            // 
            // initialData_Button
            // 
            this.initialData_Button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialData_Button.Location = new System.Drawing.Point(514, 654);
            this.initialData_Button.Name = "initialData_Button";
            this.initialData_Button.Size = new System.Drawing.Size(202, 53);
            this.initialData_Button.TabIndex = 20;
            this.initialData_Button.Text = "Вернуться к начальным условиям";
            this.initialData_Button.UseVisualStyleBackColor = true;
            this.initialData_Button.Click += new System.EventHandler(this.initialData_Button_Click);
            // 
            // clearChart_Button
            // 
            this.clearChart_Button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearChart_Button.Location = new System.Drawing.Point(722, 654);
            this.clearChart_Button.Name = "clearChart_Button";
            this.clearChart_Button.Size = new System.Drawing.Size(202, 53);
            this.clearChart_Button.TabIndex = 21;
            this.clearChart_Button.Text = "Отчистить график";
            this.clearChart_Button.UseVisualStyleBackColor = true;
            this.clearChart_Button.Click += new System.EventHandler(this.clearChart_Button_Click);
            // 
            // FunctionSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1324, 857);
            this.Controls.Add(this.clearChart_Button);
            this.Controls.Add(this.initialData_Button);
            this.Controls.Add(this.specialPoint_Label);
            this.Controls.Add(this.tractrix_pictureBox);
            this.Controls.Add(this.rightBorder_Label);
            this.Controls.Add(this.leftBorder_Label);
            this.Controls.Add(this.funcValue_Table);
            this.Controls.Add(this.valueA_TextBox);
            this.Controls.Add(this.valueA_Label);
            this.Controls.Add(this.step_Label);
            this.Controls.Add(this.step_TextBox);
            this.Controls.Add(this.diapazonY_Label);
            this.Controls.Add(this.chartTraktris_Chart);
            this.Controls.Add(this.buildChart_Button);
            this.Controls.Add(this.rightBorder_TextBox);
            this.Controls.Add(this.leftBorder_TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FunctionSolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FunctionSolution_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartTraktris_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcValue_Table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tractrix_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox leftBorder_TextBox;
        private System.Windows.Forms.TextBox rightBorder_TextBox;
        private System.Windows.Forms.Button buildChart_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTraktris_Chart;
        private System.Windows.Forms.Label diapazonY_Label;
        private System.Windows.Forms.TextBox step_TextBox;
        private System.Windows.Forms.Label step_Label;
        private System.Windows.Forms.Label valueA_Label;
        private System.Windows.Forms.TextBox valueA_TextBox;
        private System.Windows.Forms.DataGridView funcValue_Table;
        private System.Windows.Forms.Label leftBorder_Label;
        private System.Windows.Forms.Label rightBorder_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem task_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem information_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStart_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFromFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChart_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInitialData_ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox tractrix_pictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.Label specialPoint_Label;
        private System.Windows.Forms.Button initialData_Button;
        private System.Windows.Forms.Button clearChart_Button;
    }
}

