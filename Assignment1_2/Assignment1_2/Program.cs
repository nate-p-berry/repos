// See https://aka.ms/new-console-template for more information
static bool AreEqual(int intOne, int intTwo)
{
    if (intOne == intTwo)
    {
        return true;
    }
    return false;
}

static void RunCalculator()
{
    Console.Out.WriteLine("Great. What is the first number you are testing?");
    int intOne = Convert.ToInt32(Console.ReadLine());
    Console.Out.WriteLine("Excellent. What is the second number you are testing?");
    int intTwo = Convert.ToInt32(Console.ReadLine());

    Console.Out.WriteLine("Great. What operation would you like to perform? 1 = Addition, 2 = Subtraction, 3 = Multiplication, 4 = Division, 5 = Equivalence");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice) //This part answers both Assignment 1.2.1 and Assignment 1.2.2
    {
        case (1):
            Console.Out.WriteLine($"Result of {intOne} plus {intTwo} is {intOne + intTwo}");
            break;
        case (2):
            Console.Out.WriteLine($"Result of {intOne} minus {intTwo} is {intOne - intTwo}");
            break;
        case (3):
            Console.Out.WriteLine($"Result of {intOne} multiplied by {intTwo} is {intOne * intTwo}");
            break;
        case (4):
            Console.Out.WriteLine($"Result of {intOne} divided by {intTwo} is {intOne / intTwo}");
            break;
        case (5):
            Console.Out.WriteLine($"It is {AreEqual(intOne, intTwo)} that {intOne} and {intTwo} are equal.");
            break;
        default:
            Console.Out.WriteLine("That doesn't make sense here and I don't know how to handle exceptions that well yet. Bye!");
            break;
    }

}

static void SumNaturalNumbers()
{
    int[] arrayFirstTenNaturals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.Out.WriteLine($"The first ten natural numbers are: ");
        for (int numCount = 0; numCount < arrayFirstTenNaturals.Length; numCount = numCount + 1)
    {
        Console.Out.WriteLine(arrayFirstTenNaturals[numCount]);
    }
    int sumNaturalNums = arrayFirstTenNaturals.Sum();
    Console.Out.WriteLine($"Their sum is {sumNaturalNums}");
}

RunCalculator();
SumNaturalNumbers();
