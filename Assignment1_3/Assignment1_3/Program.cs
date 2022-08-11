// See https://aka.ms/new-console-template for more information

static void AreaOfRectangle(int length, int width)
{
    Console.Out.WriteLine($"The area of a rectangle with dimensions {length} units by {width} units is {length * width} units^2.");
}

static void AreaOfTriangle(int length, int width)
{
    Console.Out.WriteLine($"The area of a triangle with dimensions {length} units by {width} units is { (length * width) / 2 } units^2." );
}

static void AreaOfSquare(int length)
{
    Console.Out.WriteLine($"The area of a square with side length {length} units is {length * length} units^2.");
}

Console.Out.WriteLine("Hello. This program finds the area of three different shapes depending on your choices.");
Console.Out.WriteLine("Which shape would you like to calculate?");
Console.Out.WriteLine("1 - Square, 2 - Rectangle, 3 Triangle");
int input = Convert.ToInt32(Console.ReadLine());
switch (input) {
    case (1):
        Console.Out.WriteLine("What is the side length of this square?");
        int lengthSquare = Convert.ToInt32(Console.ReadLine());
        AreaOfSquare(lengthSquare);
        break;
    case (2):
        Console.Out.WriteLine("What is the length of this rectangle?");
        int lengthRectangle = Convert.ToInt32(Console.ReadLine());
        Console.Out.WriteLine("What is the width of this rectangle?");
        int widthRectangle = Convert.ToInt32(Console.ReadLine());
        AreaOfRectangle(lengthRectangle, widthRectangle);
        break;
    case (3):
        Console.Out.WriteLine("What is the height of this triangle?");
        int lengthTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Out.WriteLine("What is the width of the base this triangle?");
        int widthTriangle = Convert.ToInt32(Console.ReadLine());
        AreaOfTriangle(lengthTriangle, widthTriangle);
        break;
    default:
        Console.WriteLine("Sorry, that doesn't look like one of the options (and I'm not great at exception handling just yet). Thanks for playing anyway!");
        break;
}

int[] numArray = new int[10];

Console.WriteLine("For my next trick, I'll reverse the numbers you give me after storing them in an array.");
Console.WriteLine("What's the first number that you'd like me to store?");
numArray[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Okay cool, what's the second number?");
numArray[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Awesome, what's the third number?");
numArray[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"I copy these values: ");
Console.WriteLine($"{numArray[0]}, {numArray[1]}, {numArray[2]}");
Console.WriteLine("Presto change-o, here's those same numbers (but the order's not the same-o!)");
Array.Reverse(numArray);
Console.WriteLine(String.Join(", ", numArray));
Array.Reverse(numArray);
numArray[3] = 2 * numArray[2];
numArray[4] = 7 + numArray[0];
numArray[5] = numArray[4] / 2;
numArray[6] = 10000 / numArray[3]; 
numArray[7] = 94 + numArray[6];
numArray[8] = numArray[7]++;
numArray[9] = numArray[6]+50;

Console.WriteLine("Here's my final (bonus) trick, I've generated more numbers based off your input and now I'll sort them too!");
void BubbleSort()
{
    int temp;
    for (int j = 0; j <= numArray.Length - 2 ; j++)
    {
        for (int i = 0; i <= numArray.Length - 2 ; i++)
        {
            if (numArray[i] > numArray[i + 1])
            {
                temp = numArray[i + 1];
                numArray[i + 1] = numArray[i];
                numArray[i] = temp;
            }
        }
    }
    Console.WriteLine("Okay I think they're sorted now.");
    foreach (int i in numArray)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("That's all folx.");
}

Console.WriteLine("Presto change-o, here's those same numbers (but the order's not the same-o!)");
BubbleSort();