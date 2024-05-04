using CPU_Scheduling.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CPU_Scheduling.Algorithms
{
    internal class FCFS
    {
        static Form1 mainForm;

        
        public static async void StartAsync(Form1 form) 
        {
            mainForm = form;

            await OnProgressAsync();
        }


        public static async Task OnProgressAsync ()
        {
            int time = 0, notEnd = mainForm.numProb;
            int columnsCount = mainForm.problemsGrid.Columns.Count; 
            bool notEnded;

            do
            {
                mainForm.Invoke((MethodInvoker)delegate
                {
                    mainForm.problemsGrid.Columns.Add("time" + time.ToString(), time.ToString());
                    mainForm.problemsGrid.Columns[columnsCount].MinimumWidth = 25;
                });

                // kutish vaqti bo'yicha kamayish tartibida tartiblash 
                mainForm.problems = mainForm.problems.OrderBy(p => p.problemId).ToArray();
                mainForm.problems = mainForm.problems.OrderByDescending(p => p.lastWaitingTime).ToArray();
                // mainForm.problems = mainForm.problems.OrderBy(p => p.lastWaitingTime).ToArray();

                /*for (int i = 0; i < mainForm.numProb; i++)
                {

                    for (int j = i + 1; j < mainForm.numProb; j++)
                    {
                        if (mainForm.problems[i].lastWaitingTime < mainForm.problems[j].lastWaitingTime)
                        {
                            Problem tmp = mainForm.problems[i];
                            mainForm.problems[i] = mainForm.problems[j];
                            mainForm.problems[j] = tmp;
                        }
                    }
                }*/

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
                                    if (mainForm.processors[j].isFree && 
                                        mainForm.processors[j].lastProblemId != mainForm.problems[i].problemId &&
                                        mainForm.processors[j].lastUsedTime != time)
                                    {
                                        mainForm.Invoke((MethodInvoker)delegate
                                        {
                                            mainForm.processorsGrid[2, j].Value = "Busy";
                                            mainForm.processorsGrid[2, j].Style.BackColor = Color.Yellow;

                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = 
                                                                                                        "P" + (j + 1).ToString();
                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Style.BackColor = Color.LightGreen;
                                        });

                                        mainForm.problems[i].requiredTime--;
                                        mainForm.problems[i].ongoingTime++;
                                        mainForm.problems[i].lastProcessorId = j + 1;
                                        mainForm.problems[i].lastWaitingTime = 0;

                                        if (mainForm.problems[i].requiredTime != 0)
                                        {
                                            mainForm.processorsGrid[2, j].Style.BackColor = Color.Yellow;

                                            mainForm.processors[j].isFree = false;
                                            mainForm.processors[j].lastUsedTime = time;
                                            mainForm.processors[j].lastProblemId = mainForm.problems[i].problemId;
                                        }
                                        else
                                        {
                                            mainForm.processorsGrid[2, 0].Style.BackColor = Color.LightGreen;
                                            mainForm.processorsGrid[2, j].Value = "Free";

                                            mainForm.processors[j].isFree = true;
                                            mainForm.processors[j].lastUsedTime = time;
                                            mainForm.processors[j].lastProblemId = mainForm.problems[i].problemId;
                                        }

                                        started = true;

                                        break;
                                    }
                                }

                                // birorta ham bo'sh protsessor topilmasa
                                if (!started)
                                {
                                    if (notEnd == 1)
                                    {
                                        mainForm.Invoke((MethodInvoker)delegate
                                        {
                                            if (mainForm.problems[i].lastProcessorId != 0)
                                            {
                                                mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P" + mainForm.problems[i].lastProcessorId.ToString();

                                                mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId].Value = "Busy";
                                                mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId].Style.BackColor = Color.Yellow;
                                            }
                                            else
                                            {
                                                mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P";

                                                mainForm.processorsGrid[2, 0].Value = "Busy";
                                                mainForm.processorsGrid[2, 0].Style.BackColor = Color.Yellow;
                                            }

                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Style.BackColor = Color.LightGreen;
                                        });

                                        mainForm.problems[i].requiredTime--;
                                        mainForm.problems[i].lastWaitingTime = 0;
                                        mainForm.problems[i].lastProcessorId = 0;
                                        mainForm.problems[i].ongoingTime++;
                                    }
                                    else
                                    {
                                        mainForm.Invoke((MethodInvoker)delegate
                                        {
                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "W";
                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Style.BackColor = Color.LightBlue;
                                        });

                                        mainForm.problems[i].lastWaitingTime++;
                                        mainForm.problems[i].lastProcessorId = 0;
                                        mainForm.problems[i].ongoingTime = 0;
                                    }
                                }
                            }
                            // agar bajarilayotgan bo'lsa
                            else
                            {
                                // protsessorning ishlash vaqtiga tenglashsa
                                if (mainForm.problems[i].ongoingTime + 1 == mainForm.processors[mainForm.problems[i].lastProcessorId - 1].processTime)
                                {
                                    // faqat 1 ta vazifa qolgan bo'lsa
                                    if (notEnd == 1)
                                    {
                                        mainForm.Invoke((MethodInvoker)delegate
                                        {
                                            if (mainForm.problems[i].lastProcessorId != 0)
                                            {
                                                mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P" + mainForm.problems[i].lastProcessorId.ToString();

                                                mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId].Value = "Busy";
                                                mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId].Style.BackColor = Color.Yellow;
                                            }
                                            else
                                            {
                                                mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P";

                                                mainForm.processorsGrid[2, 0].Value = "Busy";
                                                mainForm.processorsGrid[2, 0].Style.BackColor = Color.Yellow;
                                            }

                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Style.BackColor = Color.LightGreen;
                                        });

                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].isFree = true;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastUsedTime = time;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastProblemId = -1;

                                        mainForm.problems[i].requiredTime--;
                                        mainForm.problems[i].ongoingTime++;
                                        mainForm.problems[i].lastProcessorId = 0;
                                        mainForm.problems[i].lastWaitingTime = 0;
                                    }
                                    else
                                    {
                                        mainForm.Invoke((MethodInvoker)delegate
                                        {
                                            mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Value = "Free";
                                            mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Style.BackColor = Color.LightGreen;

                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P" + mainForm.problems[i].lastProcessorId.ToString();
                                            mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Style.BackColor = Color.LightGreen;
                                        });

                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].isFree = true;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastUsedTime = time;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastProblemId = mainForm.problems[i].problemId;

                                        mainForm.problems[i].requiredTime--;
                                        mainForm.problems[i].ongoingTime = 0;
                                        mainForm.problems[i].lastProcessorId = 0;
                                        mainForm.problems[i].lastWaitingTime = 0;
                                    }
                                }
                                // oxirgi protsessori bilan ishlashni davom ettirish
                                else
                                {
                                    mainForm.Invoke((MethodInvoker)delegate
                                    {
                                        mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Value = "Busy";
                                        mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Style.BackColor = Color.Yellow;

                                        mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Value = "P" + mainForm.problems[i].lastProcessorId.ToString();
                                        mainForm.problemsGrid[columnsCount, mainForm.problems[i].problemId].Style.BackColor = Color.LightGreen;
                                    });

                                    if (mainForm.problems[i].requiredTime - 1 != 0)
                                    {
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].isFree = false;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastUsedTime = time;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastProblemId = mainForm.problems[i].problemId;
                                    }
                                    else
                                    {
                                        mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Value = "Free";
                                        mainForm.processorsGrid[2, mainForm.problems[i].lastProcessorId - 1].Style.BackColor = Color.LightGreen;

                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].isFree = true;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastUsedTime = time;
                                        mainForm.processors[mainForm.problems[i].lastProcessorId - 1].lastProblemId = mainForm.problems[i].problemId;
                                    }
                                    

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

                await Task.Delay(100);
            }
            while (notEnded && !mainForm.stopped);

            mainForm.Invoke((MethodInvoker)delegate {
                for (int i = 0; i < mainForm.numProc; i++)
                {
                    mainForm.processorsGrid[2, i].Value = "Free";
                    mainForm.processorsGrid[2, i].Style.BackColor = Color.LightGreen;
                    mainForm.processors[i].isFree = true;
                }
            });
        }
    }
}
