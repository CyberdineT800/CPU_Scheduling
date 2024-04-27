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
        public int processTime;
        public bool isFree;

        public Processor(int id, int procTime, bool isFree) 
        {
            this.id = id;
            this.processTime = procTime;
            this.isFree = isFree;
        }
    }
}
