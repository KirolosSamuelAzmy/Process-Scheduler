using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace ProcessSceduler
{

    public partial class Form1 : Form
    {
        Point startPoint =  new Point(0,0);
        bool dragging = false;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        

        bool showEx = false;

        public static int numProcess = 0;
        int preemptivity = 0;
        float qntmTime = -1;
        string arrivalTimes = "";
        string burstTimes = "";
        string priority = "";
        int schedulerType = -1;
        string cmdLineArgs = "";
        public const string schedulerBackEnd = "Scheduler\\sched.exe";
        public const string inputFile = "sched_out";

        public static void Wait(int t_ms)
        {
            System.Threading.Thread.Sleep(t_ms);
        }
        void switchExamples()
        {
            if (!showEx)
            {
                exBtn.Text = "- Hide Examples";
                exTabs.Visible = true;
            }
            else
            {
                exBtn.Text = "+ Show Examples";
                exTabs.Visible = false;
            }
            showEx = !showEx;
        }
        void ReadFileToStringArray(string filename, ref List<string> StrArray)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sR = new StreamReader(fs);
            try
            {
                StrArray.Add(sR.ReadLine());
            }
            catch
            {
                sR.Close();
                fs.Close();
                return;
            }
        }
        string setCmd()
        {
            burstTimes = "";
            arrivalTimes = "";
            priority = "";
            for (int i = 0; i < PList.Items.Count; ++i)
            {
                burstTimes += " " + PList.Items[i].SubItems[2].Text;
                arrivalTimes += " " + PList.Items[i].SubItems[1].Text;
                string prt = PList.Items[i].SubItems[3].Text;
                if (prt.Length == 0) prt = "-1";
                priority += " " + prt;
            }
            return schedulerType.ToString() + " " + preemptivity.ToString() + " " + qntmTime.ToString() + " " + numProcess.ToString() + arrivalTimes + burstTimes + priority;
        }
        void cmdToGUI(string cmdString)
        {
            string[] cmd = cmdString.Split(' ');
            PList.Items.Clear();
            int sched = int.Parse(cmd[0]); int preempt = int.Parse(cmd[1]); float qTime = float.Parse(cmd[2]); int prcsNum = int.Parse(cmd[3]);
            List<string> arvT = new List<string>();
            List<string> brstT = new List<string>();
            List<string> prtT = new List<string>();
            for (int i = 0; i < prcsNum; ++i)
            {
                arvT.Add(cmd[i+4]); brstT.Add(cmd[i+4+ prcsNum]);prtT.Add(cmd[i+4 + 2 * prcsNum]);

                PList.Items.Add("Process " + (i + 1).ToString());
                PList.Items[i].SubItems.Add(arvT[i]);
                PList.Items[i].SubItems.Add(brstT[i]);
                if (prtT[i] == "-1") prtT[i] = "";
                PList.Items[i].SubItems.Add(prtT[i]);
            }
            SchedList.SelectedIndex = sched;
            if (preempt == 1) PrEmpRB.Select();else NPrEmpRB.Select();
            QTTB.Text = qTime.ToString();
            

        }
        ListView ResetNames(ListView v)
        {
            for (int i = 0; i < v.Items.Count; ++i)
            {
                v.Items[i].Text = "Process " + (i + 1).ToString();
            }
            return v;
        }
        void RRControls(bool x)
        {
            label4.Visible = x;
            QTTB.Visible = x;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ArvTxt.Text) || string.IsNullOrEmpty(BrstTxt.Text)) return;
            try
            {
                Exception ex = new Exception();
                if (float.Parse(ArvTxt.Text) < 0 || float.Parse(BrstTxt.Text) <= 0) throw ex; if (prtTxt.Text.Length > 0) if(int.Parse(prtTxt.Text)<=0) throw ex;
                
            }
            catch
            {
                MessageBox.Show("Invalid process parameter!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = new ListViewItem("Process " + (PList.Items.Count + 1).ToString());
            item.SubItems.Add(ArvTxt.Text);
            item.SubItems.Add(BrstTxt.Text);
            item.SubItems.Add(prtTxt.Text);

            PList.Items.Add(item);
            ArvTxt.Clear(); BrstTxt.Clear(); prtTxt.Clear();
            ArvTxt.Select();
        }

        private void RmvPBtn_Click(object sender, EventArgs e)
        {
            if (PList.SelectedItems.Count == 0) return;
            for (int i = 0; i < PList.SelectedItems.Count; ++i)
            {
                PList.Items.Remove(PList.SelectedItems[i]);
            }
            PList = ResetNames(PList);
        }

        private void SchedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SchedList.SelectedIndex == 4)
            {
                RRControls(true);
                NPrEmpRB.Enabled = false;
                PrEmpRB.Enabled = false;
                PrEmpRB.Select();
            }
            else if (SchedList.SelectedIndex == 1)
            {
                RRControls(false);
                NPrEmpRB.Enabled = false;
                PrEmpRB.Enabled = false;
                NPrEmpRB.Select();
            }
            else
            {
                NPrEmpRB.Enabled = true;
                PrEmpRB.Enabled = true;
                RRControls(false);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            bool[] errors = new bool[6];
            for (int i = 0; i < 4; ++i) errors[i] = false;
            if (PrEmpRB.Checked == true) preemptivity = 1;
            else if (NPrEmpRB.Checked == true) preemptivity = 0;
            else preemptivity = -1;
            if (preemptivity == -1) { MessageBox.Show("You haven't chosen preemptivity type!", "Missing Info!", MessageBoxButtons.OK, MessageBoxIcon.Error); errors[0] = true; }
            schedulerType = SchedList.SelectedIndex;
            if (schedulerType == 0) { MessageBox.Show("You haven't chosen a scheduler!", "Missing Info!", MessageBoxButtons.OK, MessageBoxIcon.Error); errors[1] = true; }
            numProcess = PList.Items.Count;
            if (numProcess <= 0) { MessageBox.Show("There are no processes in the processes' list!", "Missing Info!", MessageBoxButtons.OK, MessageBoxIcon.Error); errors[2] = true; }
            if (schedulerType == 4) qntmTime = float.Parse(QTTB.Text); else qntmTime = -1;
            if (schedulerType == 4 && qntmTime <= 0) { MessageBox.Show("Invalid quantum time for Roundrobin scheduler!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error); errors[3] = true; }
            int counter = 0;
            for (int j = 0; j < PList.Items.Count; ++j)
                if (PList.Items[j].SubItems[3].Text.Length > 0) counter++;
            if (schedulerType == 3 && PList.Items.Count != counter) { MessageBox.Show("Priority for each process must be provided for Priority scheduler!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error); errors[4] = true; }
            if (SchedList.SelectedIndex > 4 || SchedList.SelectedIndex < 0) { MessageBox.Show("Invalid Scheduler!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error); errors[5] = true; }

            if (errors[0] || errors[1] || errors[2] || errors[3] || errors[4] || errors[5]) return;

            cmdLineArgs = "";
            cmdLineArgs = "\""+setCmd()+"\"";

            var s = Process.Start(schedulerBackEnd, cmdLineArgs);
            while (!(s.HasExited)) Wait(50);

            Form2 f2 = new Form2();
            f2.ShowDialog();




        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void abtBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by:\nKarim Salah Sadek\nKirolos Samuel Azmy\nMahmoud Ahmed\nHassan M. Muhammed\n\nDescription:\nThis project was created for 3rd CSE OS course in ASU FOE.t shows how different scheduling techniques work on a gannt chart and a stacked bar chart.", "Process Scheduler March 2020!");
        }

        Dictionary<string, string> exDict = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            SchedList.SelectedIndex = 0;
            

            listFCFS.Items.Add("Fraction Periods Example");
            listFCFS.Items.Add("Gap Period Example");
            exDict.Add("FCFS Fraction Periods Example", "1 0 -1 4 5.5 0 1.25 3.25 2.25 1.5 3.75 0.75 -1 -1 -1 -1");
            exDict.Add("FCFS Gap Period Example", "1 0 -1 3 7 2 15 3 2 2 -1 -1 -1");
            listSJF.Items.Add("Preemptive Example");
            listSJF.Items.Add("Non-Preemptive Example");
            exDict.Add("SJF Preemptive Example", "2 1 -1 4 0 1 5 6 8 3 7 5 -1 -1 -1 -1");
            exDict.Add("SJF Non-Preemptive Example", "2 0 -1 4 0 1 5 6 8 3 7 5 -1 -1 -1 -1");
            listPriority.Items.Add("Preemptive Example");
            listPriority.Items.Add("Non-Preemptive Example");
            exDict.Add("P Preemptive Example", "3 1 -1 4 0 3 2 5 5 4 3 2 8 3 1 13");
            exDict.Add("P Non-Preemptive Example", "3 0 -1 4 0 3 2 5 5 4 3 2 8 3 1 13");
            listRR.Items.Add("Fraction Quantum Time Example");
            listRR.Items.Add("Gap Period Example");
            exDict.Add("RR Fraction Quantum Time Example", "4 1 1.25 4 0 2 1 6.25 2.5 1.25 3 2.75 -1 -1 -1 -1");
            exDict.Add("RR Gap Period Example", "4 1 2 4 0 5 6 6 1 3 2 1 -1 -1 -1 -1");
            

        }
        

        private void RmvAllBtn_Click(object sender, EventArgs e)
        {
            PList.Items.Clear();
        }

        private void exBtn_Click(object sender, EventArgs e)
        {
            switchExamples();
        }

       
        
        private void loadExFCFS_Click(object sender, EventArgs e)
        {
            cmdToGUI(exDict["FCFS " + listFCFS.SelectedItems[0].Text]);
            
        }

        private void loadExSJF_Click(object sender, EventArgs e)
        {
            cmdToGUI(exDict["SJF " + listSJF.SelectedItems[0].Text]);
        }

        private void loadExPriority_Click(object sender, EventArgs e)
        {
            cmdToGUI(exDict["P " + listPriority.SelectedItems[0].Text]);
        }
        
        private void loadExRR_Click(object sender, EventArgs e)
        {
            cmdToGUI(exDict["RR " + listRR.SelectedItems[0].Text]);
        }
        
    }        
}
