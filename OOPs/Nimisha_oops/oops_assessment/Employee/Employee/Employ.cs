﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public abstract class Employ
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public abstract double CalculateSalary();


    }
}
