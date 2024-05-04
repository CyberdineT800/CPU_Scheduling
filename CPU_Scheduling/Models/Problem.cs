using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPU_Scheduling.Models
{
    public class Problem
    {
        public int problemId;
        public int priority;
        public int startTime;
        public int ongoingTime;
        public int requiredTime;
        public int lastProcessorId;
        public int lastWaitingTime;

        public Problem (int id, int startTime, int reqTime, int priority)
        {
            this.problemId = id;
            this.startTime = startTime;
            this.priority = priority;
            this.requiredTime = reqTime;

            this.ongoingTime = 0;
            this.lastProcessorId = 0;
            this.lastWaitingTime = 0;
        }

        public bool IsEnd() => requiredTime == 0;

        public override string ToString()
        {
            return "ProblemId: " + problemId + "\n" +
                   ", Start time: " + startTime + "\n" +
                   ", Req. time: " + requiredTime + "\n" +
                   ", Priority: " + priority + "\n" +
                   ", Last Proc: " + lastProcessorId + "\n" +
                   ", Going: " + ongoingTime + "\n" +
                   ", Last wait: " + lastWaitingTime + "\n";
        }
    }
}
