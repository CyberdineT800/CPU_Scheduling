using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using CPU_Scheduling.Algorithms;
using System.Collections.Generic;
using CPU_Scheduling.Models;

namespace CPU_Scheduling
{
    public partial class Form1 : Form
    {
        public int numProc = 1, numProb = 1;
        bool started = false;

        public Problem[] problems;
        public Processor[] processors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // processorsGrid.Enabled = false;
            // problemsGrid.Enabled = false;

            processorsGrid.RowCount = (int)numProcessors.Value;
            problemsGrid.RowCount = (int)numProblems.Value;

            processorsGrid[0, 0].Value = 1;
            processorsGrid[1, 0].Value = 1;
            processorsGrid[2, 0].Value = "Free";

            problemsGrid[0, 0].Value = 1;
            problemsGrid[1, 0].Value = 0;
            problemsGrid[2, 0].Value = 0;
            problemsGrid[3, 0].Value = 0;

            InitializeValues();
        }

        private void numProcessors_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numProcessors.Value;
            processorsGrid.RowCount = n;

            for (int i = 1; i <= n; i++)
            {
                processorsGrid[0, i - 1].Value = i;
                processorsGrid[1, i - 1].Value = 1;
                processorsGrid[2, i - 1].Value = "Free";
            }

            numProc = n;
            started = true;
        }

        private void numProblems_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numProblems.Value;
            problemsGrid.RowCount = n;

            for (int i = 1; i <= n; i++)
            {
                problemsGrid[0, i - 1].Value = i;
                problemsGrid[1, i - 1].Value = 0;
                problemsGrid[2, i - 1].Value = 0;
                problemsGrid[3, i - 1].Value = 0;
            }

            numProb = n;
            started = true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            InitializeValues();
            started = true;

            switch (algorithmCombo.Text)
            {
                //case "FCFS": problemsGrid.Columns.AddRange(FCFS.Start(this));  break;
                case "FCFS": FCFS.Start(this);  break;
                case "SJF": break;
                case "RR": break;
                default: MessageBox.Show("Scheduling algorithm is not selected !"); break;
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            if (started)
            {
                DialogResult res = MessageBox.Show("Clear all fields and cell !", "CPU SCHEDULER", MessageBoxButtons.OKCancel);

                if (res == DialogResult.OK)
                {
                    Clear();
                    started = false;
                }
            }
        }

        public void InitializeValues ()
        {
            problems = new Problem[numProb];
            processors = new Processor[numProc];

            for (int i = 0; i < numProc; i++)
            {
                processors[i] = new Processor(i + 1, Convert.ToInt32(processorsGrid[1, i].Value), true);
            }

            for (int i = 0; i < numProb; i++)
            {
                problems[i] = new Problem(Convert.ToInt32(problemsGrid[0, i].Value) - 1,
                                          Convert.ToInt32(problemsGrid[1, i].Value),
                                          Convert.ToInt32(problemsGrid[2, i].Value),
                                          Convert.ToInt32(problemsGrid[3, i].Value));
            }
        }

        public void Clear ()
        {
            numProblems.Value = 1;
            numProcessors.Value = 1;

            InitializeValues();

            started = false;
        }
    }
}
