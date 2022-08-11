namespace Assignment2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answerOne = new AnswerOne();
            var answerTwo = new AnswerTwo();
            Console.WriteLine("Would you like to check question 1 or question 2?");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {
                answerOne.StoreInformation();
                answerOne.ReadInformation();
            } else if (response == 2)
            {
                answerTwo.CalculateTip();
            } else
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(1);
            }
        }
    }
}