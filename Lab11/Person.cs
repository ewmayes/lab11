using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        //private string name;
        //private string address;

        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person()
        {
           
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + Address;
        }
    }
}
