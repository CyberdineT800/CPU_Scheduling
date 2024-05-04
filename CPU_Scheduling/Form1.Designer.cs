namespace CPU_Scheduling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.managementGroup = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.algorithmCombo = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.isAnimation = new System.Windows.Forms.CheckBox();
            this.problemGroup = new System.Windows.Forms.GroupBox();
            this.numProblems = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.procGroup = new System.Windows.Forms.GroupBox();
            this.numProcessors = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.processorsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workinTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemsGrid = new System.Windows.Forms.DataGridView();
            this.problemIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.managementGroup.SuspendLayout();
            this.problemGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProblems)).BeginInit();
            this.procGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProcessors)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(328, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU SCHEDULER";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 392);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(924, 93);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.94534F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.05466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.managementGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.problemGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.procGroup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // managementGroup
            // 
            this.managementGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managementGroup.Controls.Add(this.stopBtn);
            this.managementGroup.Controls.Add(this.clrBtn);
            this.managementGroup.Controls.Add(this.algorithmCombo);
            this.managementGroup.Controls.Add(this.startBtn);
            this.managementGroup.Controls.Add(this.isAnimation);
            this.managementGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.managementGroup.Location = new System.Drawing.Point(625, 3);
            this.managementGroup.Name = "managementGroup";
            this.managementGroup.Size = new System.Drawing.Size(294, 85);
            this.managementGroup.TabIndex = 5;
            this.managementGroup.TabStop = false;
            this.managementGroup.Text = "Management";
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Location = new System.Drawing.Point(116, 56);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clrBtn.Location = new System.Drawing.Point(15, 56);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 3;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // algorithmCombo
            // 
            this.algorithmCombo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.algorithmCombo.FormattingEnabled = true;
            this.algorithmCombo.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "RR"});
            this.algorithmCombo.Location = new System.Drawing.Point(167, 19);
            this.algorithmCombo.Name = "algorithmCombo";
            this.algorithmCombo.Size = new System.Drawing.Size(121, 21);
            this.algorithmCombo.TabIndex = 2;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(213, 56);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // isAnimation
            // 
            this.isAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.isAnimation.AutoSize = true;
            this.isAnimation.Location = new System.Drawing.Point(15, 19);
            this.isAnimation.Name = "isAnimation";
            this.isAnimation.Size = new System.Drawing.Size(96, 17);
            this.isAnimation.TabIndex = 0;
            this.isAnimation.Text = "With animation";
            this.isAnimation.UseVisualStyleBackColor = true;
            // 
            // problemGroup
            // 
            this.problemGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.problemGroup.Controls.Add(this.numProblems);
            this.problemGroup.Controls.Add(this.label3);
            this.problemGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.problemGroup.Location = new System.Drawing.Point(295, 3);
            this.problemGroup.Name = "problemGroup";
            this.problemGroup.Size = new System.Drawing.Size(324, 85);
            this.problemGroup.TabIndex = 4;
            this.problemGroup.TabStop = false;
            this.problemGroup.Text = "Problems";
            // 
            // numProblems
            // 
            this.numProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numProblems.BackColor = System.Drawing.SystemColors.MenuBar;
            this.numProblems.Location = new System.Drawing.Point(198, 36);
            this.numProblems.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numProblems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProblems.Name = "numProblems";
            this.numProblems.Size = new System.Drawing.Size(120, 20);
            this.numProblems.TabIndex = 3;
            this.numProblems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProblems.ValueChanged += new System.EventHandler(this.numProblems_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of problems:";
            // 
            // procGroup
            // 
            this.procGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procGroup.Controls.Add(this.numProcessors);
            this.procGroup.Controls.Add(this.label2);
            this.procGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.procGroup.Location = new System.Drawing.Point(3, 3);
            this.procGroup.Name = "procGroup";
            this.procGroup.Size = new System.Drawing.Size(286, 85);
            this.procGroup.TabIndex = 3;
            this.procGroup.TabStop = false;
            this.procGroup.Text = "Processors";
            // 
            // numProcessors
            // 
            this.numProcessors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numProcessors.BackColor = System.Drawing.SystemColors.MenuBar;
            this.numProcessors.Location = new System.Drawing.Point(160, 36);
            this.numProcessors.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numProcessors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProcessors.Name = "numProcessors";
            this.numProcessors.Size = new System.Drawing.Size(120, 20);
            this.numProcessors.TabIndex = 2;
            this.numProcessors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProcessors.ValueChanged += new System.EventHandler(this.numProcessors_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of processors:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.processorsGrid);
            this.panel3.Controls.Add(this.problemsGrid);
            this.panel3.Location = new System.Drawing.Point(3, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 285);
            this.panel3.TabIndex = 0;
            // 
            // processorsGrid
            // 
            this.processorsGrid.AllowUserToAddRows = false;
            this.processorsGrid.AllowUserToDeleteRows = false;
            this.processorsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processorsGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.processorsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.workinTime,
            this.status});
            this.processorsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processorsGrid.Location = new System.Drawing.Point(3, 3);
            this.processorsGrid.Name = "processorsGrid";
            this.processorsGrid.Size = new System.Drawing.Size(196, 277);
            this.processorsGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // workinTime
            // 
            this.workinTime.HeaderText = "WT";
            this.workinTime.Name = "workinTime";
            // 
            // status
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.status.DefaultCellStyle = dataGridViewCellStyle1;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // problemsGrid
            // 
            this.problemsGrid.AllowUserToAddRows = false;
            this.problemsGrid.AllowUserToDeleteRows = false;
            this.problemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.problemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.problemsGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.problemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.problemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.problemIndex,
            this.startTime,
            this.demandTime,
            this.priority});
            this.problemsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.problemsGrid.Location = new System.Drawing.Point(205, 3);
            this.problemsGrid.Name = "problemsGrid";
            this.problemsGrid.Size = new System.Drawing.Size(714, 277);
            this.problemsGrid.TabIndex = 0;
            // 
            // problemIndex
            // 
            this.problemIndex.HeaderText = "№";
            this.problemIndex.MinimumWidth = 20;
            this.problemIndex.Name = "problemIndex";
            this.problemIndex.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "ST";
            this.startTime.MinimumWidth = 25;
            this.startTime.Name = "startTime";
            // 
            // demandTime
            // 
            this.demandTime.HeaderText = "DT";
            this.demandTime.MinimumWidth = 25;
            this.demandTime.Name = "demandTime";
            // 
            // priority
            // 
            this.priority.HeaderText = "P";
            this.priority.MinimumWidth = 25;
            this.priority.Name = "priority";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(910, 510);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.managementGroup.ResumeLayout(false);
            this.managementGroup.PerformLayout();
            this.problemGroup.ResumeLayout(false);
            this.problemGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProblems)).EndInit();
            this.procGroup.ResumeLayout(false);
            this.procGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProcessors)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processorsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView problemsGrid;   /////////////////////
        public System.Windows.Forms.DataGridView processorsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox managementGroup;
        private System.Windows.Forms.GroupBox problemGroup;
        private System.Windows.Forms.GroupBox procGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numProcessors;
        private System.Windows.Forms.NumericUpDown numProblems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isAnimation;
        private System.Windows.Forms.ComboBox algorithmCombo;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workinTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.Button stopBtn;
    }
}

