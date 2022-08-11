namespace Assignment4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            int[,] array = new int[,] { { 2, 1 }, { 3, 4 }, { 4, 6 } };
            for (int i = 0; i < array.Length / 2; i++)
            {
                Console.Write("| " + array[i, 0]);
            }
            Console.Write("| ");
            Console.WriteLine();
            for (int i = 0; i < array.Length / 2; i++)
            {
                Console.Write("| " + array[i, 1]);
            }
            Console.Write("| ");
            #endregion

            #region Question 2
            int[,] matrixOne = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] matrixTwo = new int[,] { { 5, 6 }, { 7, 8 } };
            Console.WriteLine("The first matrix is: ");
            PrintMatrix(matrixOne);
            Console.WriteLine("The second matrix is: ");
            PrintMatrix(matrixTwo);
            Console.WriteLine("The result of matrix addition, for these two matrices, is: ");
            int[,] matrixThree = AddMatrix(matrixOne, matrixTwo);
            PrintMatrix(matrixThree);
            #endregion

            #region Question 3
            int userInput;
            do
            {
                Console.WriteLine("What would you like to do?" +
                    "\n    1- Add two numbers together." +
                    "\n    2- Add three numbers together." +
                    "\n    3- Multiply two numbers together." +
                    "\n    4- Multiply three numbers together." +
                    "\n    5- Exit program.");
                userInput = Convert.ToInt32(Console.ReadLine());
                int intOne;
                int intTwo;
                int intThree;
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Enter the first number.");
                        intOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number.");
                        intTwo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Add(intOne, intTwo));
                        break;
                    case 2:
                        Console.WriteLine("Enter the first number.");
                        intOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number.");
                        intTwo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the third number.");
                        intThree = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Add(intOne, intTwo, intThree));
                        break;
                    case 3:
                        Console.WriteLine("Enter the first number.");
                        intOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number.");
                        intTwo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Multiply(intOne, intTwo));
                        break;
                    case 4:
                        Console.WriteLine("Enter the first number.");
                        intOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number.");
                        intTwo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the third number.");
                        intThree = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Multiply(intOne, intTwo, intThree));
                        break;
                    default:
                        break;
                }
            } while (userInput != 5);
            #endregion

            #region Question 4
            Console.WriteLine("This part of the program deals with the area of circles. \nPlease enter the radius of the first circle.");
            Circle circleOne = new();
            Circle circleTwo = new();
            circleOne.Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, what's the radius of the second circle?");
            circleTwo.Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"The result of adding their areas together is: {circleOne + circleTwo}.");
            Console.WriteLine($"The result of subtracting their areas is: {circleOne - circleTwo}"); 
            #endregion
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] AddMatrix(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixResult = new int[matrixA.GetLength(0),matrixB.GetLength(0)];
            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                for (int j = 0; j < matrixA.GetLength(0); j++)
                {
                    matrixResult[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return matrixResult;
        }

        private static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        private static int Add(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
        private static float Multiply(float a, float b)
        {
            float result = a * b;
            return result;
        }

        private static float Multiply(float a, float b, float c)
        {
            float result = a * b * c;
            return result;
        }
    }
}