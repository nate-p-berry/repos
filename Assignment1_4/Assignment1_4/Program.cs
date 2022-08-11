using System;
using System.Collections;
using System.Collections.Generic;
namespace Assignment1_4
{
    internal class Program
    {
        #region SETUP
        static void Main(string[] args)
        {

            Console.WriteLine("Type your first, middle, and last names with a suffix (separated by a carriage return) to test this.");
            Name myName = new Name(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(myName.GetFullName());
            
            //Console.WriteLine("Are you looking for the answer to Question 1 or Question 2?");
            //var response = Console.ReadLine();
            //string responseString = Convert.ToString(response); // This isn't working and I'm annoyed. Probably has to do with the fact I have no error handling and should be using a try-catch but I still have no idea what I'm doing lol. 
            //int responseInt = Convert.ToInt32(response);
            //if (responseInt == 1 || responseString == "Question 1" || responseString == "Q1")
            //{
            //    Console.WriteLine("Great!");
            //    QuestionOne();
            //}
            //else if (responseInt == 2 || responseString == "Question 2" || responseString == "Q2")
            //{
            //    Console.WriteLine("Alrighty then!");
            //    Console.WriteLine();
            //    QuestionTwo();
            //} else
            //{
            //    Console.WriteLine($"I don't recognize '{response}' as a valid answer and I'm too lazy to loop these options. Have a good day!");
            //}
        }
        #endregion

        #region QUESTION 1
        public static void QuestionOne()
        {
            Console.WriteLine("Cool. Well this one said to compare two points and see which one was to the farther right than the other.");
            Point pointOne = new Point();
            Console.WriteLine("We'll start with the first point. What's the X coordinate?");
            pointOne.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the Y coordinate?");
            pointOne.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"For P1, I have ({pointOne.x}, {pointOne.y})");
            Point pointTwo = new Point();
            Console.WriteLine("On to the next one! What's the X coordinate?");
            pointTwo.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the Y coordinate?");
            pointTwo.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"For P2, I have ({pointTwo.x}, {pointTwo.y})");

            Console.WriteLine();
            if (pointOne.x > pointTwo.y)
            {
                Console.WriteLine("Okay. It looks like P1 is to the right of P2 along the X Axis.");
            } else
            {
                Console.WriteLine("Okay. It looks like P1 is to the left of P2 along the X Axis (or on line with it).");
            }
            Console.WriteLine("Thanks for playing! I'll take you to Question Two now.");
            QuestionTwo();
        }

        internal class Point
        {
            public int x;
            public int y;
        }
        #endregion

        #region QUESTION 2
        public static void QuestionTwo()
        {
            Student newStudent = new Student();
            newStudent.StudentID = 12345;
            newStudent.FirstName = "Nate";
            newStudent.LastName = "Berry";
            newStudent.StudentGrade = 'A';
            Console.WriteLine($"Our records have: {newStudent.FirstName} {newStudent.LastName} is a current student with ID number {newStudent.StudentID} and has the following grade: {newStudent.StudentGrade}.");
        }
        
        internal class Student
        {
            private int studentID;
            public int StudentID { get; set; }
            private string? firstName;
            public string FirstName { get; set; }
            private string? lastName; 
            public string LastName { get; set; }
            private char studentGrade; 
            public char StudentGrade { get; set; }
        }
        #endregion

        struct Name
        {
            string firstName;
            string middleName;
            string lastName;
            string suffix;

            public Name(string first,
                        string? middle,
                        string last,
                        string? suff)
            {
                firstName = first;
#pragma warning disable CS8601 // Possible null reference assignment.
                middleName = middle;
#pragma warning restore CS8601 // Possible null reference assignment.
                lastName = last;
#pragma warning disable CS8601 // Possible null reference assignment.
                suffix = suff;
#pragma warning restore CS8601 // Possible null reference assignment.
            }

            public string GetFullName()
            {
                return firstName + " " + middleName + " " + lastName + " " + suffix;
            }
        }
    }
}
