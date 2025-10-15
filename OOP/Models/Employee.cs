using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public  class Employee
    {
        public const double TAX = 0.03;

        public int Id; 
        public string Fname;
        public string Lname;
        public decimal Wage; //Rate per hour/day
        public double loggedHours; //


        //public override string ToString()
        //{
        //    return $"Employee name is {this.Fname} {this.Lname}";
        //}
    }

}
