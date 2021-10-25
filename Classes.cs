using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Address_Management_System
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string creationDate { get; set; }
    }

    class Staff : Person
    {
        public string department { get; set; }
        public string staffID { get; set; }
    }

    class Student : Person
    {
        public string rollNumber { get; set; }
        public string degree { get; set; }
        public string semester { get; set; }
        public int matriculationNumber { get; set; }
    }

    class GeneralPerson
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string creationDate { get; set; }
        public string department { get; set; }
        public string staffID { get; set; }
        public string rollNumber { get; set; }
        public string degree { get; set; }
        public string semester { get; set; }
        public string matriculationNumber { get; set; }
    }
}
