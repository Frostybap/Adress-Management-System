using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Address_Management_System
{
    static class PersonList
    {
        public static List<Staff> staffList = new List<Staff>();
        public static List<Student> studentsList = new List<Student>();

        public static void AddStaff(string firstName, string lastName, string address, string creationDate, string department, string staffID)
        {
            Staff staff = new Staff();
            staff.firstName = firstName;
            staff.lastName = lastName;
            staff.address = address;
            staff.creationDate = creationDate;
            staff.department = department;
            staff.staffID = staffID;
            staffList.Add(staff);
        }

        public static void AddStudent(string firstName, string lastName, string address, string creationDate, string rollNumber, string degree, string semester, int matriculationNumber)
        {
            Student student = new Student();
            student.firstName = firstName;
            student.lastName = lastName;
            student.address = address;
            student.creationDate = creationDate;
            student.rollNumber = rollNumber;
            student.degree = degree;
            student.semester = semester;
            student.matriculationNumber = matriculationNumber;
            studentsList.Add(student);
        }
    }
}
