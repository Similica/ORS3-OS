﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ORS3_OS.Processes
{
    class Process
    {
        public int Pid { get; set; }
        public String Status { get; set; }
        public int Memory { get; set; }
        public int CPU_usage { get; set; }
        public String Name { get; set; }
        public Thread Work { get; set; }

        public Process (String Name)
        {
            Random rnd = new Random();
            Pid = rnd.Next(0, 1000);
            //this.Memory = Memory;
            this.Name = Name;
            CPU_usage = 0;
            Status = "Ready";
            //Console.WriteLine("Process created.");
        }

        public void Utilization()
        {
            if (this.Status == "Running")
            {
                CPU_usage++;
            }
            Console.WriteLine("Process"+Name+"have:"+CPU_usage+" CPU usage.");
        }
        public void BlockSignal()
        {
            
        }
        public void Blocked()
        {
            this.Status = "Blocked";
            Console.WriteLine("Process" + this.Name + "is blocked.");
        }
        public void Ready()
        {
            this.Status = "Ready";
            Console.WriteLine("Process" + this.Name + "is ready.");
        }
        
        public void Finish()
        {
            if(this.CPU_usage == 100)
            {
                Console.WriteLine("Process" + this.Name + "is finished.");
            }
        }
        public void Running()
        {
            if (Status == "Running")
            {
                Console.WriteLine("Process" + this.Name + "is running.");
            }
        }
        public void MemoryAllocation(int m)
        {
            Memory = m;
        }



    }
}
