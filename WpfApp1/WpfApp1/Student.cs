using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal struct Student
    {
        public Student(string firstName, string lastName, string address, string grade, int studentID) : this()
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _grade = grade;
            _studentID = studentID;
        }

        private string _firstName;
        private string _lastName;
        private string _address;
        private string _grade;
        private int _studentID;
        public enum _MonthOfAdmission { January, February, March, April, May, June, July, August, September, October, November, December };

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Address { get => _address; set => _address = value; }
        public string Grade { get => _grade; set => _grade = value; }
        public int StudentID { get => _studentID; set => _studentID = value; }
        public _MonthOfAdmission MonthOfAdmission { get; set; }

        public void AddRecord()
        {

        }

        public void DeleteRecord()
        {

        }

        public void DisplayRecordGrid()
        {

        }
    }
}
