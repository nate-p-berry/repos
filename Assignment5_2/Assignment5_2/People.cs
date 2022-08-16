using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    internal class People
    {
        private int _IdentificationNumber;
        private string? _FirstName;
        private string? _LastName;
        private string? _MobileNumber;
        private string? _WorkNumber;
        private string? _Address;

        public People()
        {

        }

        public People(int identificationNumber, string firstName, string lastName, string mobileNumber, string workNumber, string address)
        {
            IdentificationNumber = identificationNumber;
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            WorkNumber = workNumber;
            Address = address;
        }

        public int IdentificationNumber { get => _IdentificationNumber; set => _IdentificationNumber = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string MobileNumber { get => _MobileNumber; set => _MobileNumber = value; }
        public string WorkNumber { get => _WorkNumber; set => _WorkNumber = value; }
        public string Address { get => _Address; set => _Address = value; }

        public static Dictionary<string, People> peopleDictionary = new();
    }
}
