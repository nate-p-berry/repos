namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int intput;
            string record = @"Record.txt";
            string[] recordArray = File.ReadAllLines(record).ToArray();
            string[] companyArray = new string[9];

            do
            {
                Console.WriteLine("Let's test this stupid POS.");
                Console.WriteLine();
                Console.WriteLine("Enter Search Term.");
                input = Console.ReadLine();
                Console.WriteLine("Enter Position Index.");
                intput = Convert.ToInt32(Console.ReadLine());
                SearchRecord(input, record, intput); 
            } while (!RecordMatches(input, , intput));
        }

        public static string SearchRecord(string searchTerm, string filePath, int positionOfSearchTerm)
        {
            string recordNotFound = "Record not found!";
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (RecordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Record found!");
                        Console.WriteLine(string.Join(", ", fields));
                        return string.Join(',', fields);
                    }
                    else if (!RecordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{recordNotFound}\nPress 1 to return to search again or press 2 to quit.");
                        var response = Convert.ToInt32(Console.ReadLine());
                        if (response == 2)
                        {
                            Console.WriteLine("Program.KillProgram()");
                        }
                        else if (response == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter another search term.");
                            string newSearchTerm = Console.ReadLine();
                            SearchRecord(newSearchTerm, filePath, positionOfSearchTerm);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("That doesn't look quite right, let's start over.");
                            Console.WriteLine("Program.InitializeProgram(out int placeholder)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That doesn't look quite right, let's start over.");
                        Console.WriteLine("Program.InitializeProgram(out int fake)");
                        return "";
                    }
                }
                Console.WriteLine("That doesn't look quite right, let's start over.");
                SearchRecord(searchTerm, filePath, positionOfSearchTerm);
                return "";
            }
            catch (Exception ex)
            {

                return $"Program error, our bad. {ex}";
            }
        }
        public static bool RecordMatches(string searchTerm, string[] record, int indexOfSearchTerm)
        {
            if (record[indexOfSearchTerm].Equals(searchTerm.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}