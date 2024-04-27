using CPU_Scheduling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling.Algorithms
{
    internal class FCFS
    {
        static Form1 mainForm;
        // static Problem[] problems;
        // static Processor[] processors;

        
        public static void Start(Form1 form) 
        {
            mainForm = form;
            
            /*mainForm.problemsGrid.Columns.Add("1", "10");
            mainForm.problemsGrid.Columns.Add("2", "11");
            mainForm.problemsGrid.Columns.Add("3", "12");
            mainForm.problemsGrid.Columns.Add("4", "13");*/

            OnProgress();

            // problems = mainForm.problems;
            // processors = mainForm.processors;
        }


        public static void OnProgress ()
        {
            int time = 0, notEnd = mainForm.numProb;
            int columnsCount = mainForm.problemsGrid.Columns.Count;
            bool notEnded;

            do
            {
                mainForm.problemsGrid.Columns.Add("time" + time.ToString(), time.ToString());
                mainForm.problemsGrid.Columns[columnsCount].MinimumWidth = 25;

                // kutish vaqti bo'yicha kamayish tartibida tartiblash
                for (int i = 0; i < mainForm.numProb; i++)
                {
                    // MessageBox.Show(mainForm.problems[i].ToString());

                    for (int j = i + 1; j < mainForm.numProb; j++)
                    {
                        if (mainForm.problems[i].lastWaitingTime < mainForm.problems[j].lastWaitingTime)
                        {
                            Problem tmp = mainForm.problems[i];
                            mainForm.problems[i] = mainForm.problems[j];
                            mainForm.problems[j] = tmp;
                        }
                    }
                }


                notEnded = false;


                for (int i = 0; i < mainForm.numProb; i++)
                {
                    notEnd--;

                    if (!mainForm.problems[i].IsEnd())
                    {
                        notEnded = true;
                        notEnd++;

                        // agar vazifani boshlanish vaqtidan o'tilsa
                        if (mainForm.problems[i].startTime <= time)
                        {
                            // agar vazifa bajarilmayotgan bo'lsa
                            if (mainForm.problems[i].lastProcessorId == 0)
                            {
                                bool started = false;

                                for (int j = 0; j < mainForm.numProc; j++)
                                {
                                    // bo'sh protsessor topilsa
                                    if (mainForm.processors[j].isFree)
                                    {
                                        mainForm.processorsGrid[2, j].Value = "Busy";
                                        mainForm.processors[j].isFree = false;

                                        mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P" + (j + 1).ToString();

                                        mainForm.problems[i].requiredTime--;
                                        mainForm.problems[i].ongoingTime++;
                                        mainForm.problems[i].lastProcessorId = j + 1;
                                        mainForm.problems[i].lastWaitingTime = 0;

                                        started = true;

                                        break;
                                    }
                                }

                                // birorta ham bo'sh protsessor topilmasa
                                if (!started)
                                {
                                    mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "W";

                                    mainForm.problems[i].lastWaitingTime++;
                                    mainForm.problems[i].lastProcessorId = 0;
                                }
                            }
                            // agar bajarilayotgan bo'lsa
                            else
                            {
                                // protsessorning ishlash vaqtiga tenglashsa
                                if (mainForm.problems[i].ongoingTime == mainForm.processors[mainForm.problems[i].lastProcessorId - 1].processTime)
                                {
                                    // faqat 1 ta vazifa qolgan bo'lsa
                                    if (notEnd == 1)
                                    {
                                        mainForm.processorsGrid[2, 0].Value = "Busy";
                                        mainForm.processors[0].isFree = false;

                                        mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P";

                                        mainForm.problems[i].requiredTime--;
                                        mainForm.problems[i].ongoingTime++;
                                        mainForm.problems[i].lastProcessorId = 1;
                                        mainForm.problems[i].lastWaitingTime = 0;
                                    }
                                    else
                                    {
                                        mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Value = "Free";
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].isFree = true;

                                        mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "W";

                                        mainForm.problems[i].ongoingTime = 0;
                                        mainForm.problems[i].lastProcessorId = 0;
                                        mainForm.problems[i].lastWaitingTime++;
                                    }
                                }
                                // oxirgi protsessori bilan ishlashni davom ettirish
                                else
                                {
                                    mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Value = "Busy";
                                    mainForm.processors[mainForm.problems[i].lastProcessorId - 1].isFree = false;

                                    mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P" + mainForm.problems[i].lastProcessorId.ToString();

                                    mainForm.problems[i].requiredTime--;
                                    mainForm.problems[i].ongoingTime++;
                                    mainForm.problems[i].lastProcessorId = mainForm.problems[i].lastProcessorId;
                                    mainForm.problems[i].lastWaitingTime = 0;
                                }
                            }
                        }
                    }
                }

                columnsCount++;
                time++;
            }
            while (notEnded);
        }
    }
}
