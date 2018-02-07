﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff:Person
    {
        //private string school;
        //private double pay;

        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string name, string address, string school, double pay):
            base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public Staff()
        {

        }

        public override string ToString()
        {
            return "Staff: " + School + " " + Pay;
        }
    }
}
