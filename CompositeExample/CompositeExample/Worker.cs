﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class Worker : IEmployee
    {
        private string name;
        private int happiness;

        public Worker(string name, int happiness)
        {
            this.name = name;
            this.happiness = happiness;
        }

        void IEmployee.ShowHappiness()
        {
            Console.WriteLine(name + " showed happiness level of " + happiness);
        }
    }
}
