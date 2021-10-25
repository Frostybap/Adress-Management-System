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
    public partial class StudentForm : Form
    {
        bool isModify;
        int i = 0;
        public StudentForm(bool isModify)
        {
            InitializeComponent();
            this.isModify = isModify;
            if (isModify)
            {
                textBox_FirstName.Enabled = false;
                textBox_LastName.Enabled = false;
                textBox_Address.Enabled = false;
                textBox_Degree.Enabled = false;
                textBox_Semester.Enabled = false;
                textBox_MatriculationNumber.Enabled = false;
                button_Submit.Visible = false;
                button_Search.Visible = true;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            for (i = 0; i < PersonList.studentsList.Count; i++)
            {
                if (textBox_RollNumber.Text == PersonList.studentsList[i].rollNumber)
                {
                    textBox_RollNumber.Enabled = false;
                    button_Search.Visible = false;
                    textBox_FirstName.Text = PersonList.studentsList[i].firstName;
                    textBox_LastName.Text = PersonList.studentsList[i].lastName;
                    textBox_Address.Text = PersonList.studentsList[i].address;
                    textBox_Degree.Text = PersonList.studentsList[i].degree;
                    textBox_Semester.Text = PersonList.studentsList[i].semester;
                    textBox_MatriculationNumber.Text = (PersonList.studentsList[i].matriculationNumber).ToString();
                    textBox_FirstName.Enabled = true;
                    textBox_LastName.Enabled = true;
                    textBox_Address.Enabled = true;
                    textBox_Degree.Enabled = true;
                    textBox_Semester.Enabled = true;
                    textBox_MatriculationNumber.Enabled = true;
                    button_Submit.Text = "Modify Student";
                    button_Submit.Visible = true;
                    return;
                }
            }
            MessageBox.Show("No student exists against the provided roll number, please ensure the entered roll number is correct & try again.", "Invalid Roll Number!");
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = int.Parse(textBox_MatriculationNumber.Text);
                if (isModify)
                {
                    PersonList.studentsList[i].firstName = textBox_FirstName.Text;
                    PersonList.studentsList[i].lastName = textBox_LastName.Text;
                    PersonList.studentsList[i].address = textBox_Address.Text;
                    PersonList.studentsList[i].degree = textBox_Degree.Text;
                    PersonList.studentsList[i].semester = textBox_Semester.Text;
                    PersonList.studentsList[i].matriculationNumber = int.Parse(textBox_MatriculationNumber.Text);
                }
                else
                {
                    PersonList.AddStudent(textBox_FirstName.Text, textBox_LastName.Text, textBox_Address.Text, DateTime.Now.ToString(), textBox_RollNumber.Text, textBox_Degree.Text, textBox_Semester.Text, int.Parse(textBox_MatriculationNumber.Text));
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer number in the field 'Matriculation Numbers'", "Invalid Matriculation Numbers!");
            }
        }
    }
}
