using System;
using System.Drawing;  
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        //new class 
        public class Student1
        {
            private string FirstName;
            private string LastName;
            private string MiddleName;
            private string Gender;
            private string Day;
            private string Month;
            private string Year;
            private string Program;

           
            public Student1(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string program)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.MiddleName = middleName;
                this.Gender = gender;
                this.Day = day;
                this.Month = month;
                this.Year = year;
                this.Program = program;
            }

           //overload method
            public void DisplayStudentInfo(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string program)
            {
                MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}\nGender: {gender}\nDate of Birth: {day}/{month}/{year}\nProgram: {program}");
            }

            // Overloaded method without gender and date of birth
            public void DisplayStudentInfo(string firstName, string middleName, string lastName, string program)
            {
                MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}\nProgram: {program}");
            }

            // Overloaded method with just first and last names
            public void DisplayStudentInfo(string firstName, string lastName, string program)
            {
                MessageBox.Show($"Student Name: {firstName} {lastName}\nProgram: {program}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = this.TBFirstName.Text;
            string lastName = this.TBLastName.Text;
            string middleName = this.TBMiddleName.Text;
            string gender = this.RBMale.Checked ? "Male" : this.RBFemale.Checked ? "Female" : "";
            string day = CBDay.SelectedItem?.ToString() ;
            string month = this.CBMonth.SelectedItem?.ToString() ;
            string year = this.CBYear.SelectedItem?.ToString() ;
            string program = this.CBProgram.SelectedItem?.ToString();

            // new student instance 
            Student1 student = new Student1(firstName, middleName, lastName, gender, day, month, year, program);

            // student information 
            if (!string.IsNullOrEmpty(day) && !string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(year))
            {
                // Call method full information
                student.DisplayStudentInfo(firstName, middleName, lastName, gender, day, month, year, program);
            }
            else if (!string.IsNullOrEmpty(middleName))
            {
                // Call method middle name and program
                student.DisplayStudentInfo(firstName, middleName, lastName, program);
            }
            else
            {
                // Call method first name, last name, and program
                student.DisplayStudentInfo(firstName, lastName, program);
            }

            
            
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                this.PBPicture.Image = Image.FromFile(filePath);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
