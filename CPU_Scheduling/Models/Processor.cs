using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduling.Models
{
    public class Processor
    {
        public int id;
        public int processTime, lastProblemId, lastUsedTime;
        public bool isFree;

        public Processor(int id, int procTime, bool isFree) 
        {
            this.id = id;
            this.processTime = procTime;
            this.isFree = isFree;
            this.lastProblemId = -1;
            this.lastUsedTime = -1;
        }

        public override string ToString()
        {
            return "Id: " + id + "\n" +
                   ", Proc. time: " + processTime + "\n" +
                   ", Last prob.: " + lastProblemId + "\n" +
                   ", Last used time: " + lastUsedTime + "\n" +
                   ", Is free: " + isFree + "\n";
        }
    }
}
