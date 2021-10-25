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
    public partial class StaffForm : Form
    {
        bool isModify;
        int i = 0;
        public StaffForm(bool isModify)
        {
            InitializeComponent();
            this.isModify = isModify;
            if (isModify)
            {
                textBox_FirstName.Enabled = false;
                textBox_LastName.Enabled = false;
                textBox_Address.Enabled = false;
                textBox_Department.Enabled = false;
                button_Submit.Visible = false;
                button_Search.Visible = true;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            for (i = 0; i < PersonList.staffList.Count; i++)
            {
                if (textBox_StaffID.Text == PersonList.staffList[i].staffID)
                {
                    textBox_StaffID.Enabled = false;
                    button_Search.Visible = false;
                    textBox_FirstName.Text = PersonList.staffList[i].firstName;
                    textBox_LastName.Text = PersonList.staffList[i].lastName;
                    textBox_Address.Text = PersonList.staffList[i].address;
                    textBox_Department.Text = PersonList.staffList[i].department;
                    textBox_FirstName.Enabled = true;
                    textBox_LastName.Enabled = true;
                    textBox_Address.Enabled = true;
                    textBox_Department.Enabled = true;
                    button_Submit.Text = "Modify Staff";
                    button_Submit.Visible = true;
                    return;
                }
            }
            MessageBox.Show("No staff exists against the provided staff id, please ensure the entered staff id is correct & try again.", "Invalid Staff ID!");
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (isModify)
            {
                PersonList.staffList[i].firstName = textBox_FirstName.Text;
                PersonList.staffList[i].lastName = textBox_LastName.Text;
                PersonList.staffList[i].address = textBox_Address.Text;
                PersonList.staffList[i].department = textBox_Department.Text;
            }
            else
            {
                PersonList.AddStaff(textBox_FirstName.Text, textBox_LastName.Text, textBox_Address.Text, DateTime.Now.ToString(), textBox_Department.Text, textBox_StaffID.Text);
            }
            this.Close();
        }
    }
}
