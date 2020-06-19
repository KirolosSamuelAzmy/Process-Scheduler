using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProcessSceduler
{
    public partial class Form2 : Form
    {
      
        ToolTip toolTip = new ToolTip();
        double leastPercision = 1;
        int max_length;
        Point lastPoint;
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        static public Color hoveredColor = Color.FromArgb(255, 192,128);
        static double median = (Form1.numProcess + 2) / 2;
        static bool chartGantt = true;
        void switchFunc(bool choiceGantt)
        {
            if (choiceGantt && !chartGantt)
            {
                ganttBtn.BackColor = hoveredColor;
                barBtn.BackColor = Color.AliceBlue;
                gantt.Visible = true;
                barChart.Visible = false;
                chartGantt = true;
            }
            else if(!choiceGantt && chartGantt)
            {
                barBtn.BackColor = hoveredColor;
                ganttBtn.BackColor = Color.AliceBlue;
                barChart.Visible = true;
                gantt.Visible = false;
                chartGantt = false;
            }
        }
        void ganttPlot(int processID, double intervalStart, double intervalEnd)
        {
            int[] pos = new int[Form1.numProcess + 1];
            int count = Form1.numProcess;
            for (int i = 1; i <= Form1.numProcess; ++i)
            {
                pos[i] = count;
                count--;
            }
            gantt.Series[0].Points.AddXY(pos[processID], intervalStart, intervalEnd);
            
        }
        void barPlot(int processID , double intervalStart, double intervalEnd)
        {
            int offset = -(int)Math.Floor((processID-1) / 10.0);

            barChart.Series["P" + processID.ToString()].Font = new Font(barChart.Series["P" + processID.ToString()].Font, FontStyle.Bold);
            barChart.Series["P" + processID.ToString()].LabelForeColor = Color.FromKnownColor(KnownColor.AliceBlue);
            barChart.Series["P" + processID.ToString()].Label = "P" + processID.ToString();
            barChart.Series["P" + processID.ToString()].Points.AddXY(1+(offset*0.05) + (2 * (processID +0.5 - median) / Form1.numProcess), intervalStart, intervalEnd);
        }
        void ReadFileToStringArray(string filename, ref List<string> StrArray, string[] times)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sR = new StreamReader(fs);
            for (int i = 0; true; i++)
            {
                StrArray.Add(sR.ReadLine());
                if (StrArray[i][0] == '&')
                {
                    times[0] = StrArray[StrArray.Count - 1];
                    StrArray.RemoveAt(StrArray.Count - 1);
                    i--;
                }
                else if (StrArray[i][0] == '%')
                {
                    times[1] = StrArray[StrArray.Count - 1];
                    StrArray.RemoveAt(StrArray.Count - 1);
                    sR.Close();
                    fs.Close();
                    return;
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switchFunc(true);

            string[] times = new string[2];
            List<string> lines = new List<string>();
            List<int> process_ID = new List<int>();
            List<double> intervals_begin = new List<double>();
            List<double> intervals_end = new List<double>();

            ReadFileToStringArray(Form1.inputFile,ref lines,times);

            max_length = 0;

            foreach (string line in lines){
                MatchCollection mcID = Regex.Matches(line, @"p\S+:");
                MatchCollection mc_i_b = Regex.Matches(line, @":\S+\s");
                MatchCollection mc_i_e = Regex.Matches(line, @"\s\S+\b");

                Match mID = mcID[0];
                Match m_i_b = mc_i_b[0];
                Match m_i_e = mc_i_e[0];

                if (line.Contains('.'))
                {
                    int i = 0;
                    MatchCollection float_lengths = Regex.Matches(line, @"\.\d+\b");
                    if (m_i_b.ToString().Contains('.'))
                    {
                        if (float_lengths[i].Length > max_length) max_length = float_lengths[i].Length;
                        i++;
                    }
                    if (m_i_e.ToString().Contains('.'))
                        if (float_lengths[i].Length > max_length) max_length = float_lengths[i].Length;
                }

                string begin_line = m_i_b.ToString();
                string end_line = m_i_e.ToString();
                int ID = int.Parse(mID.ToString().Substring(1, mID.ToString().Length - 2));
                double begin = double.Parse(begin_line.Substring(1));
                double end = double.Parse(end_line.Substring(1));
                process_ID.Add(ID);
                intervals_begin.Add(begin);
                intervals_end.Add(end);
            }
            if(max_length!=0)
            max_length--;

            for (int i = 0; i < max_length; ++i) leastPercision /= 10;

            gantt.ChartAreas[0].CursorY.IsUserEnabled = true;
            gantt.ChartAreas[0].CursorY.Interval = leastPercision;
            gantt.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
            gantt.ChartAreas[0].CursorY.LineColor = Color.FromArgb(255,128,0);
            gantt.ChartAreas[0].CursorY.LineWidth = 1;

            barChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            barChart.ChartAreas[0].CursorY.Interval = leastPercision;
            barChart.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
            barChart.ChartAreas[0].CursorY.LineColor = Color.FromArgb(255, 128, 0);
            barChart.ChartAreas[0].CursorY.LineWidth = 1;




            toolTip.UseFading = true;
            toolTip.UseAnimation = false;
            toolTip.AutoPopDelay = 999999;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
            toolTip.ForeColor = Color.FromArgb(255,128,0);
            toolTip.ToolTipTitle = "T = ";
            toolTip.BackColor = hoveredColor;
            

            barChart.Series.Remove(barChart.Series[0]);
            barChart.ChartAreas[0].AxisX.Minimum = 0;
            barChart.ChartAreas[0].AxisX.Maximum = 2;

            int[] pos = new int[Form1.numProcess + 1];
            int count = Form1.numProcess;
            for (int i = 1; i <= Form1.numProcess; ++i)
            {
                pos[i] = count;
                count--;
            }

            for (int i = 0; i < Form1.numProcess ; ++i)
            {
                string pName = "P" + (i + 1).ToString();

                //ganttChart

                System.Windows.Forms.DataVisualization.Charting.CustomLabel label = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
                label.Text = pName;
                label.ToPosition = pos[i+1]*2;
                label.GridTicks = System.Windows.Forms.DataVisualization.Charting.GridTickTypes.All;
                gantt.ChartAreas[0].AxisX.CustomLabels.Add(label);

                //barChart
                System.Windows.Forms.DataVisualization.Charting.Series item = new System.Windows.Forms.DataVisualization.Charting.Series();
                item.Name = pName;
                item.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                barChart.Series.Add(item);
                barChart.Series[i]["PointWidth"] = "2";
                
            }
            if (Form1.numProcess > 40) gantt.ChartAreas[0].AxisY.LabelStyle.Angle = 90;
            gantt.ChartAreas[0].AxisY.LabelStyle.Interval = (int)Math.Ceiling((double)Form1.numProcess / 20);
            gantt.ChartAreas[0].AxisY.Interval = (int)Math.Ceiling((double)Form1.numProcess / 20);
            barChart.ChartAreas[0].AxisY.LabelStyle.Interval = (int)Math.Ceiling((double)Form1.numProcess / 20);
            barChart.ChartAreas[0].AxisY.Interval = (int)Math.Ceiling((double)Form1.numProcess / 20);
            gantt.Series[0]["PointWidth"] = "0.3";
           
            for (int i = 0; i < process_ID.Count; ++i)
            {

                ganttPlot(process_ID[i], intervals_begin[i], intervals_end[i]);
                barPlot(process_ID[i], intervals_begin[i], intervals_end[i]);

            }

            AvgWT.Text += times[0].Substring(1) + " units of time";
            TAT.Text += times[1].Substring(1) + " units of time";
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ganttBtn_Click(object sender, EventArgs e)
        {
            switchFunc(true);
        }

        private void barBtn_Click(object sender, EventArgs e)
        {
            switchFunc(false);

        }
        

        private void barChart_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);

            barChart.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);
        }
        private void gantt_MouseMove(object sender, MouseEventArgs e)
        {
              Point mousePoint = new Point(e.X, e.Y);

              gantt.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);
        }

        private void gantt_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip.Show(""+Math.Round(gantt.ChartAreas[0].CursorY.Position,max_length),gantt);
        }

        private void barChart_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip.Show(""+Math.Round(barChart.ChartAreas[0].CursorY.Position, max_length), barChart);
        }
        
    }
}
