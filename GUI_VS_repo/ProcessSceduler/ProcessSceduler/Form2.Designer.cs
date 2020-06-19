namespace ProcessSceduler
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gantt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ganttBtn = new System.Windows.Forms.Button();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barBtn = new System.Windows.Forms.Button();
            this.AvgWT = new System.Windows.Forms.Label();
            this.TAT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gantt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // gantt
            // 
            this.gantt.BackColor = System.Drawing.Color.AliceBlue;
            this.gantt.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            this.gantt.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.gantt.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGreen;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Processes";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea3.AxisX2.IsLabelAutoFit = false;
            chartArea3.AxisX2.LabelStyle.Angle = 5;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.Interval = 1D;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGreen;
            chartArea3.AxisY.LabelStyle.Interval = 2D;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Time";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea3.AxisY2.LineWidth = 2;
            chartArea3.Name = "ChartArea1";
            this.gantt.ChartAreas.Add(chartArea3);
            this.gantt.Cursor = System.Windows.Forms.Cursors.Cross;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.gantt.Legends.Add(legend3);
            this.gantt.Location = new System.Drawing.Point(19, 211);
            this.gantt.Margin = new System.Windows.Forms.Padding(20);
            this.gantt.Name = "gantt";
            this.gantt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.gantt.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            this.gantt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series";
            series3.YValuesPerPoint = 2;
            this.gantt.Series.Add(series3);
            this.gantt.Size = new System.Drawing.Size(2914, 1467);
            this.gantt.TabIndex = 1;
            this.gantt.Text = "gantt";
            this.gantt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gantt_MouseDown);
            this.gantt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gantt_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(2892, 13);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(41, 64);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click_1);
            // 
            // ganttBtn
            // 
            this.ganttBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ganttBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ganttBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ganttBtn.FlatAppearance.BorderSize = 0;
            this.ganttBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ganttBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ganttBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ganttBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ganttBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.ganttBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ganttBtn.Location = new System.Drawing.Point(19, 13);
            this.ganttBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ganttBtn.Name = "ganttBtn";
            this.ganttBtn.Size = new System.Drawing.Size(519, 64);
            this.ganttBtn.TabIndex = 18;
            this.ganttBtn.Text = "Gantt Chart";
            this.ganttBtn.UseVisualStyleBackColor = false;
            this.ganttBtn.Click += new System.EventHandler(this.ganttBtn_Click);
            // 
            // barChart
            // 
            this.barChart.BackColor = System.Drawing.Color.AliceBlue;
            this.barChart.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            this.barChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.barChart.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX.IsMarksNextToAxis = false;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGreen;
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "Processes";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea4.AxisX2.IsLabelAutoFit = false;
            chartArea4.AxisX2.LabelStyle.Angle = 5;
            chartArea4.AxisX2.LineWidth = 2;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.Interval = 1D;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGreen;
            chartArea4.AxisY.LabelStyle.Interval = 2D;
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.Title = "Time";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea4.AxisY2.LineWidth = 2;
            chartArea4.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea4);
            this.barChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend4.Name = "Legend1";
            legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.barChart.Legends.Add(legend4);
            this.barChart.Location = new System.Drawing.Point(19, 211);
            this.barChart.Margin = new System.Windows.Forms.Padding(20);
            this.barChart.Name = "barChart";
            this.barChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.barChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series";
            series4.YValuesPerPoint = 2;
            this.barChart.Series.Add(series4);
            this.barChart.Size = new System.Drawing.Size(2914, 1467);
            this.barChart.TabIndex = 19;
            this.barChart.Text = "chart1";
            this.barChart.Visible = false;
            this.barChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barChart_MouseDown);
            this.barChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barChart_MouseMove);
            // 
            // barBtn
            // 
            this.barBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.barBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.barBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.barBtn.FlatAppearance.BorderSize = 0;
            this.barBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.barBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.barBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.barBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.barBtn.Location = new System.Drawing.Point(546, 13);
            this.barBtn.Margin = new System.Windows.Forms.Padding(4);
            this.barBtn.Name = "barBtn";
            this.barBtn.Size = new System.Drawing.Size(519, 64);
            this.barBtn.TabIndex = 20;
            this.barBtn.Text = "Bar Chart";
            this.barBtn.UseVisualStyleBackColor = false;
            this.barBtn.Click += new System.EventHandler(this.barBtn_Click);
            // 
            // AvgWT
            // 
            this.AvgWT.AutoSize = true;
            this.AvgWT.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.AvgWT.ForeColor = System.Drawing.Color.AliceBlue;
            this.AvgWT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AvgWT.Location = new System.Drawing.Point(10, 91);
            this.AvgWT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvgWT.Name = "AvgWT";
            this.AvgWT.Size = new System.Drawing.Size(537, 53);
            this.AvgWT.TabIndex = 21;
            this.AvgWT.Text = "Average Waiting Time: ";
            // 
            // TAT
            // 
            this.TAT.AutoSize = true;
            this.TAT.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.TAT.ForeColor = System.Drawing.Color.AliceBlue;
            this.TAT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TAT.Location = new System.Drawing.Point(13, 148);
            this.TAT.Margin = new System.Windows.Forms.Padding(4);
            this.TAT.Name = "TAT";
            this.TAT.Size = new System.Drawing.Size(431, 53);
            this.TAT.TabIndex = 22;
            this.TAT.Text = "Turnaround Time: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(2962, 1693);
            this.Controls.Add(this.TAT);
            this.Controls.Add(this.AvgWT);
            this.Controls.Add(this.barBtn);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.ganttBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.gantt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Gantt Chart";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.gantt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart gantt;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ganttBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.Button barBtn;
        private System.Windows.Forms.Label AvgWT;
        private System.Windows.Forms.Label TAT;
    }
}