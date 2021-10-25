using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace _3.Address_Management_System
{
    public partial class MainWindow : Window
    {
        static int size;
        GeneralPerson[] persons;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_AddStaff_Click(object sender, RoutedEventArgs e)
        {
            StaffForm staffForm = new StaffForm(false);
            staffForm.ShowDialog();
        }

        private void button_ModifyStaff_Click(object sender, RoutedEventArgs e)
        {
            StaffForm staffForm = new StaffForm(true);
            staffForm.ShowDialog();
        }

        private void button_AddStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentForm studentForm = new StudentForm(false);
            studentForm.ShowDialog();
        }

        private void button_ModifyStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentForm studentForm = new StudentForm(true);
            studentForm.ShowDialog();
        }

        private void button_ViewPersons_Click(object sender, RoutedEventArgs e)
        {
            DisplayPersons displayPersons = new DisplayPersons();
            displayPersons.ShowDialog();
        }

        private void button_Export_Click(object sender, RoutedEventArgs e)
        {
            FetchPersons();
            var mem = new MemoryStream();
            var writer = new StreamWriter(mem);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);
            csvWriter.WriteField("First Name");
            csvWriter.WriteField("Last Name");
            csvWriter.WriteField("Address");
            csvWriter.WriteField("Creation Date");
            csvWriter.WriteField("Department");
            csvWriter.WriteField("Staff ID");
            csvWriter.WriteField("Roll #");
            csvWriter.WriteField("Degree");
            csvWriter.WriteField("Semester");
            csvWriter.WriteField("Matriculation Numbers");
            csvWriter.NextRecord();
            foreach (GeneralPerson person in persons)
            {
                csvWriter.WriteField(person.firstName);
                csvWriter.WriteField(person.lastName);
                csvWriter.WriteField(person.address);
                csvWriter.WriteField(person.creationDate);
                csvWriter.WriteField(person.department);
                csvWriter.WriteField(person.staffID);
                csvWriter.WriteField(person.rollNumber);
                csvWriter.WriteField(person.degree);
                csvWriter.WriteField(person.semester);
                csvWriter.WriteField(person.matriculationNumber);
                csvWriter.NextRecord();
            }
            writer.Flush();
            var result = Encoding.UTF8.GetString(mem.ToArray());
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "AddressesExport.csv"));
            outputFile.WriteLine(result);
            MessageBox.Show("Successfully exported the file \"AddressesExport.csv\" to \"Documents\" directory in your pc.", "Export Successful!");
            outputFile.Close();
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
                persons[i] = new GeneralPerson();
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
    }
}
