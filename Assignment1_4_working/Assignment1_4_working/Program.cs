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
            Console.WriteLine("Are you looking for the answer to Question 1 or Question 2?");
            var response = Console.ReadLine();
            string responseString = Convert.ToString(response); // This isn't working and I'm annoyed. Probably has to do with the fact I have no error handling and should be using a try-catch but I still have no idea what I'm doing lol. 
            int responseInt = Convert.ToInt32(response);
            if (responseInt == 1 || responseString == "Question 1" || responseString == "Q1")
            {
                Console.WriteLine("Great!");
                QuestionOne();
            }
            else if (responseInt == 2 || responseString == "Question 2" || responseString == "Q2")
            {
                Console.WriteLine("Alrighty then!");
                Console.WriteLine();
                QuestionTwo();
            }
            else
            {
                Console.WriteLine($"I don't recognize '{response}' as a valid answer and I'm too lazy to loop these options. Have a good day!");
            }
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
            }
            else
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
            Console.WriteLine("Welcome to the student data portal.");
            //Console.WriteLine("Would you like to (1) Add data, (2) Lookup data, or Exit?");
            //var answer = Console.ReadLine();
            //int answerInt = Convert.ToInt32(answer);
            //if (answerInt == 1 || answer == "Add")
            //{
            //Console.WriteLine("You'd like to Add data. Good!");
            //Student student = new Student();
            StoreStudentData();
            //DisplayStudentData();
            //}
            //else if (answerInt == 2 || answer == "Lookup")
            //{
            //Console.WriteLine("Okay, cool. You want to lookup information.");
            //Console.WriteLine();
            //}
            //else
            //{
            //Console.WriteLine("Well thanks for checking in, have a good day!");
            //}
        }

        internal class Student
        {
            private int StudentID { get; set; }
            private string? FirstName { get; set; }
            private string? LastName { get; set; }
            private char StudentGrade { get; set; }
        }


        public static void StoreStudentData()
        {
            Console.WriteLine("How many students are you adding?");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            SortedList studentList = new SortedList();
            for (int i = 0; i < (studentCount); i++)
            {
                Student student = new Student();
                Console.WriteLine("What is this student's ID number?");
                student.StudentID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the student's first name?");
#pragma warning disable CS8601 // Possible null reference assignment.
                student.FirstName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                Console.WriteLine("What is the student's last name?");
#pragma warning disable CS8601 // Possible null reference assignment.
                student.LastName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                Console.WriteLine("What is the student's current grade?");
#pragma warning disable CS8604 // Possible null reference argument.
                student.StudentGrade = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
                Console.WriteLine($"We added: {student.FirstName} {student.LastName} is a current student with ID number {student.StudentID} and has the following grade: {student.StudentGrade}.");
                studentList.Add(i, (student.StudentID + student.FirstName + student.LastName + student.StudentGrade));
            }
            //Console.WriteLine($"We added {studentCount} students to our records just now. Their names are: ");
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentList,i}");
            //}
            //Console.WriteLine($"{studentList.Values.ToString()}");
        }

        //public static void DisplayStudentData()
        //{
        //    Console.WriteLine($"We added: {student.FirstName} {student.LastName} is a current student with ID number {student.StudentID} and has the following grade: {student.StudentGrade}.");
        //    Console.WriteLine();
        //}

        #endregion
    }
}