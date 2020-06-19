namespace ProcessSceduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartBtn = new System.Windows.Forms.Button();
            this.PList = new System.Windows.Forms.ListView();
            this.processColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arvTColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.burstTColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prtColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArvTxt = new System.Windows.Forms.TextBox();
            this.BrstTxt = new System.Windows.Forms.TextBox();
            this.AddPBtn = new System.Windows.Forms.Button();
            this.RmvPBtn = new System.Windows.Forms.Button();
            this.SchedList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrEmpRB = new System.Windows.Forms.RadioButton();
            this.NPrEmpRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.QTTB = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.abtBtn = new System.Windows.Forms.Button();
            this.RmvAllBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.prtTxt = new System.Windows.Forms.TextBox();
            this.exBtn = new System.Windows.Forms.Button();
            this.exTabs = new System.Windows.Forms.TabControl();
            this.fcfsTab = new System.Windows.Forms.TabPage();
            this.listFCFS = new System.Windows.Forms.ListView();
            this.loadExFCFS = new System.Windows.Forms.Button();
            this.sjfTab = new System.Windows.Forms.TabPage();
            this.listSJF = new System.Windows.Forms.ListView();
            this.loadExSJF = new System.Windows.Forms.Button();
            this.priorityTab = new System.Windows.Forms.TabPage();
            this.listPriority = new System.Windows.Forms.ListView();
            this.loadExPriority = new System.Windows.Forms.Button();
            this.rrTab = new System.Windows.Forms.TabPage();
            this.listRR = new System.Windows.Forms.ListView();
            this.loadExRR = new System.Windows.Forms.Button();
            this.exTabs.SuspendLayout();
            this.fcfsTab.SuspendLayout();
            this.sjfTab.SuspendLayout();
            this.priorityTab.SuspendLayout();
            this.rrTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.StartBtn, "StartBtn");
            this.StartBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PList
            // 
            resources.ApplyResources(this.PList, "PList");
            this.PList.BackColor = System.Drawing.Color.AliceBlue;
            this.PList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processColumn,
            this.arvTColumn,
            this.burstTColumn,
            this.prtColumn});
            this.PList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PList.FullRowSelect = true;
            this.PList.GridLines = true;
            this.PList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PList.MultiSelect = false;
            this.PList.Name = "PList";
            this.PList.UseCompatibleStateImageBehavior = false;
            this.PList.View = System.Windows.Forms.View.Details;
            // 
            // processColumn
            // 
            resources.ApplyResources(this.processColumn, "processColumn");
            // 
            // arvTColumn
            // 
            resources.ApplyResources(this.arvTColumn, "arvTColumn");
            // 
            // burstTColumn
            // 
            resources.ApplyResources(this.burstTColumn, "burstTColumn");
            // 
            // prtColumn
            // 
            resources.ApplyResources(this.prtColumn, "prtColumn");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ArvTxt
            // 
            this.ArvTxt.BackColor = System.Drawing.Color.AliceBlue;
            this.ArvTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.ArvTxt, "ArvTxt");
            this.ArvTxt.Name = "ArvTxt";
            // 
            // BrstTxt
            // 
            this.BrstTxt.BackColor = System.Drawing.Color.AliceBlue;
            this.BrstTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.BrstTxt, "BrstTxt");
            this.BrstTxt.Name = "BrstTxt";
            // 
            // AddPBtn
            // 
            this.AddPBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.AddPBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddPBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddPBtn.FlatAppearance.BorderSize = 0;
            this.AddPBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddPBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.AddPBtn, "AddPBtn");
            this.AddPBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddPBtn.Name = "AddPBtn";
            this.AddPBtn.UseVisualStyleBackColor = false;
            this.AddPBtn.Click += new System.EventHandler(this.AddPBtn_Click);
            // 
            // RmvPBtn
            // 
            this.RmvPBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.RmvPBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.RmvPBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RmvPBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RmvPBtn.FlatAppearance.BorderSize = 0;
            this.RmvPBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RmvPBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.RmvPBtn, "RmvPBtn");
            this.RmvPBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.RmvPBtn.Name = "RmvPBtn";
            this.RmvPBtn.UseVisualStyleBackColor = false;
            this.RmvPBtn.Click += new System.EventHandler(this.RmvPBtn_Click);
            // 
            // SchedList
            // 
            this.SchedList.BackColor = System.Drawing.Color.AliceBlue;
            this.SchedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SchedList.Items.AddRange(new object[] {
            resources.GetString("SchedList.Items"),
            resources.GetString("SchedList.Items1"),
            resources.GetString("SchedList.Items2"),
            resources.GetString("SchedList.Items3"),
            resources.GetString("SchedList.Items4")});
            resources.ApplyResources(this.SchedList, "SchedList");
            this.SchedList.Name = "SchedList";
            this.SchedList.SelectedIndexChanged += new System.EventHandler(this.SchedList_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PrEmpRB
            // 
            resources.ApplyResources(this.PrEmpRB, "PrEmpRB");
            this.PrEmpRB.Name = "PrEmpRB";
            this.PrEmpRB.TabStop = true;
            this.PrEmpRB.UseVisualStyleBackColor = true;
            // 
            // NPrEmpRB
            // 
            resources.ApplyResources(this.NPrEmpRB, "NPrEmpRB");
            this.NPrEmpRB.Name = "NPrEmpRB";
            this.NPrEmpRB.TabStop = true;
            this.NPrEmpRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // QTTB
            // 
            this.QTTB.BackColor = System.Drawing.Color.AliceBlue;
            this.QTTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.QTTB, "QTTB");
            this.QTTB.Name = "QTTB";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.CloseBtn, "CloseBtn");
            this.CloseBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            // 
            // abtBtn
            // 
            this.abtBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.abtBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.abtBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.abtBtn.FlatAppearance.BorderSize = 0;
            this.abtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.abtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.abtBtn, "abtBtn");
            this.abtBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.abtBtn.Name = "abtBtn";
            this.abtBtn.UseVisualStyleBackColor = false;
            this.abtBtn.Click += new System.EventHandler(this.abtBtn_Click);
            // 
            // RmvAllBtn
            // 
            this.RmvAllBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.RmvAllBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.RmvAllBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RmvAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RmvAllBtn.FlatAppearance.BorderSize = 0;
            this.RmvAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RmvAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.RmvAllBtn, "RmvAllBtn");
            this.RmvAllBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.RmvAllBtn.Name = "RmvAllBtn";
            this.RmvAllBtn.UseVisualStyleBackColor = false;
            this.RmvAllBtn.Click += new System.EventHandler(this.RmvAllBtn_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // prtTxt
            // 
            this.prtTxt.BackColor = System.Drawing.Color.AliceBlue;
            this.prtTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.prtTxt, "prtTxt");
            this.prtTxt.Name = "prtTxt";
            // 
            // exBtn
            // 
            this.exBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.exBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.exBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exBtn.FlatAppearance.BorderSize = 0;
            this.exBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.exBtn, "exBtn");
            this.exBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.exBtn.Name = "exBtn";
            this.exBtn.UseVisualStyleBackColor = false;
            this.exBtn.Click += new System.EventHandler(this.exBtn_Click);
            // 
            // exTabs
            // 
            this.exTabs.Controls.Add(this.fcfsTab);
            this.exTabs.Controls.Add(this.sjfTab);
            this.exTabs.Controls.Add(this.priorityTab);
            this.exTabs.Controls.Add(this.rrTab);
            resources.ApplyResources(this.exTabs, "exTabs");
            this.exTabs.Multiline = true;
            this.exTabs.Name = "exTabs";
            this.exTabs.SelectedIndex = 0;
            // 
            // fcfsTab
            // 
            this.fcfsTab.BackColor = System.Drawing.Color.AliceBlue;
            this.fcfsTab.Controls.Add(this.listFCFS);
            this.fcfsTab.Controls.Add(this.loadExFCFS);
            resources.ApplyResources(this.fcfsTab, "fcfsTab");
            this.fcfsTab.Name = "fcfsTab";
            // 
            // listFCFS
            // 
            this.listFCFS.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.listFCFS, "listFCFS");
            this.listFCFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listFCFS.GridLines = true;
            this.listFCFS.MultiSelect = false;
            this.listFCFS.Name = "listFCFS";
            this.listFCFS.UseCompatibleStateImageBehavior = false;
            this.listFCFS.View = System.Windows.Forms.View.SmallIcon;
            // 
            // loadExFCFS
            // 
            this.loadExFCFS.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.loadExFCFS, "loadExFCFS");
            this.loadExFCFS.Name = "loadExFCFS";
            this.loadExFCFS.UseVisualStyleBackColor = false;
            this.loadExFCFS.Click += new System.EventHandler(this.loadExFCFS_Click);
            // 
            // sjfTab
            // 
            this.sjfTab.BackColor = System.Drawing.Color.AliceBlue;
            this.sjfTab.Controls.Add(this.listSJF);
            this.sjfTab.Controls.Add(this.loadExSJF);
            resources.ApplyResources(this.sjfTab, "sjfTab");
            this.sjfTab.Name = "sjfTab";
            // 
            // listSJF
            // 
            this.listSJF.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.listSJF, "listSJF");
            this.listSJF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listSJF.GridLines = true;
            this.listSJF.MultiSelect = false;
            this.listSJF.Name = "listSJF";
            this.listSJF.UseCompatibleStateImageBehavior = false;
            this.listSJF.View = System.Windows.Forms.View.SmallIcon;
            // 
            // loadExSJF
            // 
            this.loadExSJF.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.loadExSJF, "loadExSJF");
            this.loadExSJF.Name = "loadExSJF";
            this.loadExSJF.UseVisualStyleBackColor = false;
            this.loadExSJF.Click += new System.EventHandler(this.loadExSJF_Click);
            // 
            // priorityTab
            // 
            this.priorityTab.BackColor = System.Drawing.Color.AliceBlue;
            this.priorityTab.Controls.Add(this.listPriority);
            this.priorityTab.Controls.Add(this.loadExPriority);
            resources.ApplyResources(this.priorityTab, "priorityTab");
            this.priorityTab.Name = "priorityTab";
            // 
            // listPriority
            // 
            this.listPriority.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.listPriority, "listPriority");
            this.listPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listPriority.GridLines = true;
            this.listPriority.MultiSelect = false;
            this.listPriority.Name = "listPriority";
            this.listPriority.UseCompatibleStateImageBehavior = false;
            this.listPriority.View = System.Windows.Forms.View.SmallIcon;
            // 
            // loadExPriority
            // 
            this.loadExPriority.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.loadExPriority, "loadExPriority");
            this.loadExPriority.Name = "loadExPriority";
            this.loadExPriority.UseVisualStyleBackColor = false;
            this.loadExPriority.Click += new System.EventHandler(this.loadExPriority_Click);
            // 
            // rrTab
            // 
            this.rrTab.BackColor = System.Drawing.Color.AliceBlue;
            this.rrTab.Controls.Add(this.listRR);
            this.rrTab.Controls.Add(this.loadExRR);
            resources.ApplyResources(this.rrTab, "rrTab");
            this.rrTab.Name = "rrTab";
            // 
            // listRR
            // 
            this.listRR.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.listRR, "listRR");
            this.listRR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listRR.GridLines = true;
            this.listRR.MultiSelect = false;
            this.listRR.Name = "listRR";
            this.listRR.UseCompatibleStateImageBehavior = false;
            this.listRR.View = System.Windows.Forms.View.SmallIcon;
            // 
            // loadExRR
            // 
            this.loadExRR.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.loadExRR, "loadExRR");
            this.loadExRR.Name = "loadExRR";
            this.loadExRR.UseVisualStyleBackColor = false;
            this.loadExRR.Click += new System.EventHandler(this.loadExRR_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.AddPBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.RmvPBtn;
            this.ControlBox = false;
            this.Controls.Add(this.exTabs);
            this.Controls.Add(this.exBtn);
            this.Controls.Add(this.prtTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RmvAllBtn);
            this.Controls.Add(this.abtBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.QTTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NPrEmpRB);
            this.Controls.Add(this.PrEmpRB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SchedList);
            this.Controls.Add(this.RmvPBtn);
            this.Controls.Add(this.AddPBtn);
            this.Controls.Add(this.BrstTxt);
            this.Controls.Add(this.ArvTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PList);
            this.Controls.Add(this.StartBtn);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.exTabs.ResumeLayout(false);
            this.fcfsTab.ResumeLayout(false);
            this.sjfTab.ResumeLayout(false);
            this.priorityTab.ResumeLayout(false);
            this.rrTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ListView PList;
        private System.Windows.Forms.ColumnHeader processColumn;
        private System.Windows.Forms.ColumnHeader arvTColumn;
        private System.Windows.Forms.ColumnHeader burstTColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArvTxt;
        private System.Windows.Forms.TextBox BrstTxt;
        private System.Windows.Forms.Button AddPBtn;
        private System.Windows.Forms.Button RmvPBtn;
        private System.Windows.Forms.ComboBox SchedList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton PrEmpRB;
        private System.Windows.Forms.RadioButton NPrEmpRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QTTB;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button abtBtn;
        private System.Windows.Forms.ColumnHeader prtColumn;
        private System.Windows.Forms.Button RmvAllBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prtTxt;
        private System.Windows.Forms.Button exBtn;
        private System.Windows.Forms.TabControl exTabs;
        private System.Windows.Forms.TabPage fcfsTab;
        private System.Windows.Forms.TabPage sjfTab;
        private System.Windows.Forms.TabPage priorityTab;
        private System.Windows.Forms.TabPage rrTab;
        private System.Windows.Forms.Button loadExRR;
        private System.Windows.Forms.Button loadExFCFS;
        private System.Windows.Forms.Button loadExSJF;
        private System.Windows.Forms.Button loadExPriority;
        private System.Windows.Forms.ListView listFCFS;
        private System.Windows.Forms.ListView listSJF;
        private System.Windows.Forms.ListView listPriority;
        private System.Windows.Forms.ListView listRR;
    }
}

