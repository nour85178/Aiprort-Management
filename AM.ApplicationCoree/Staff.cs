﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree
{
    public  class Staff: Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $" {EmploymentDate} , {Function} , {Salary}  ";
        }
        public override void PassengerType()
        {
            Console.WriteLine("I am a passenger I am a Staff Member");
        }


    }

}
