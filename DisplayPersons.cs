using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Address_Management_System
{
    public partial class DisplayPersons : Form
    {
        static int size;
        GeneralPerson[] persons;

        public DisplayPersons()
        {
            InitializeComponent();
            FetchPersons();
            listBox_Filter.SelectedIndex = 0;
        }

        private void FetchPersons()
        {
            size = PersonList.staffList.Count + PersonList.studentsList.Count;
            persons = new GeneralPerson[size];
            int i = 0;
            for (; i < PersonList.staffList.Count; i++)
            {
                persons[i] = new GeneralPerson();
                persons[i].firstName = PersonList.staffList[i].firstName;
                persons[i].lastName = PersonList.staffList[i].lastName;
                persons[i].address = PersonList.staffList[i].address;
                persons[i].creationDate = PersonList.staffList[i].creationDate;
                persons[i].department = PersonList.staffList[i].department;
                persons[i].staffID = PersonList.staffList[i].staffID;
                persons[i].rollNumber = "N/A";
                persons[i].degree = "N/A";
                persons[i].semester = "N/A";
                persons[i].matriculationNumber = "N/A";
            }
            for (int f = 0; f < PersonList.studentsList.Count; f++)
            {
                persons[i + f] = new GeneralPerson();
                persons[i + f].firstName = PersonList.studentsList[f].firstName;
                persons[i + f].lastName = PersonList.studentsList[f].lastName;
                persons[i + f].address = PersonList.studentsList[f].address;
                persons[i + f].creationDate = PersonList.studentsList[f].creationDate;
                persons[i + f].department = "N/A";
                persons[i + f].staffID = "N/A";
                persons[i + f].rollNumber = PersonList.studentsList[f].rollNumber;
                persons[i + f].degree = PersonList.studentsList[f].degree;
                persons[i + f].semester = PersonList.studentsList[f].semester;
                persons[i + f].matriculationNumber = PersonList.studentsList[f].matriculationNumber.ToString();
            }
        }

        private void FillTextBox()
        {
            string text = "First Name\tLast Name\tAddress\tCreation Date\t\tDepartment\tStaff ID\tRoll #\tDegree\tSemester\tMatric. Numbers" + Environment.NewLine + Environment.NewLine;
            for (int i = 0; i < size; i++)
            {
                text += Environment.NewLine;
                text += persons[i].firstName + "\t\t";
                text += persons[i].lastName + "\t\t";
                text += persons[i].address + "\t";
                text += persons[i].creationDate + "\t\t";
                text += persons[i].department + "\t\t";
                text += persons[i].staffID + "\t";
                text += persons[i].rollNumber + "\t";
                text += persons[i].degree + "\t";
                text += persons[i].semester + "\t";
                text += persons[i].matriculationNumber;
            }
            textBox_Persons.Text = text;
        }

        private void SortPersons(string filter) // "Type", "Name" or "Date" are the acceptable values.
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int f = 0; f < size - (i + 1); f++)
                {
                    if (filter == "Type" || filter == "type")
                    {
                        int personOneType = 0, personTwoType = 0;
                        if (persons[i].staffID != "N/A")
                        {
                            personOneType = 1;
                        }
                        if (persons[i + 1].staffID != "N/A")
                        {
                            personTwoType = 1;
                        }
                        if (personOneType > personTwoType)
                        {
                            (persons[i], persons[i + 1]) = (persons[i + 1], persons[i]);
                        }
                    }
                    else if (filter == "Name" || filter == "name")
                    {
                        if (String.Compare(persons[i].firstName + persons[i].lastName, persons[i + 1].firstName + persons[i + 1].lastName) > 0)
                        {
                            (persons[i], persons[i + 1]) = (persons[i + 1], persons[i]);
                        }
                    }
                    else if (filter == "Date" || filter == "date")
                    {
                        if (String.Compare(persons[i].creationDate, persons[i + 1].creationDate) > 0)
                        {
                            (persons[i], persons[i + 1]) = (persons[i + 1], persons[i]);
                        }
                    }    
                }
            }
        }

        private void listBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Filter.SelectedIndex == 0)
            {
                SortPersons("Type");
            }
            else if (listBox_Filter.SelectedIndex == 1)
            {
                SortPersons("Name");
            }
            else
            {
                SortPersons("Date");
            }
            FillTextBox();
        }
    }
}
