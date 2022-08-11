using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2_2
{
    internal class AnswerOne
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AnswerOne()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AnswerOne(string first, string last, int age, string address)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            FirstName = first;
            LastName = last;
            Age = age;
            Address = address;
        }
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _address;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public string Address { get => _address; set => _address = value; }

        public void StoreInformation()
        {
            Console.WriteLine("First name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("Last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("Age?");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Address?");
            Address = Console.ReadLine();
            string storeInformation = $"Information to be stored is {FirstName} {LastName} is {Age} years old and lives at {Address}.";
            Console.WriteLine(storeInformation);
            string filePath = @"C:\Users\berry\source\repos\newContainer.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                if (!File.Exists(filePath))
                {
                    try
                    {
                        File.WriteAllText(filePath, storeInformation);
                        
                        //writer.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Operation will not be completed. {e.Message}");
                        Environment.Exit(1);
                    }
                }
                else
                {
                    try
                    {
                        //File.AppendAllText(filePath, storeInformation);
                        writer.WriteLine(storeInformation);
                        writer.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Operation could not be completed. {e.Message}");
                        Environment.Exit(1);
                    }
                }
            }
        }
        public void ReadInformation()
        {
            string filePath = @"C:\Users\berry\source\repos\newContainer.txt";
            StreamReader stringReader = new(filePath);
            string contents = stringReader.ReadToEnd();
            stringReader.Close();
            Console.WriteLine(contents);
        }
    }
    internal class AnswerTwo
    {
        public void CalculateTip()
        {
            Console.WriteLine("Okay, what is the current price of the bill?");
            int mealPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What percent tip would you like to apply?");
            decimal tipPercent = Convert.ToDecimal(Console.ReadLine());
            decimal mealWithTip = mealPrice * (1 + (tipPercent/100));
            Console.WriteLine($"With tip, that comes out to ${mealWithTip}");
            Environment.ExitCode = 0;
        }
    }
}
