using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    internal class Person : IEnumerable
    {
        private Person[] _people;
        private int _IdentificationNumber;
        private string? _FirstName;
        private string? _LastName;
        private string? _MobileNumber;
        private string? _WorkNumber;
        private string? _Address;

        public Person() { }

        public Person(Person[] people)
        {
            _people = new Person[people.Length];
            for (int i = 0; i < people.Length; i++)
            {
                _people[i] = people[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }

        public Person(int identificationNumber, string firstName, string lastName, string mobileNumber, string workNumber, string address, Person[] people)
        {
            _people = new Person[people.Length];
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            WorkNumber = workNumber;
            Address = address;
        }

        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string MobileNumber { get => _MobileNumber; set => _MobileNumber = value; }
        public string WorkNumber { get => _WorkNumber; set => _WorkNumber = value; }
        public string Address { get => _Address; set => _Address = value; }
        public Person[] People { get; set; }
        
    }
}
