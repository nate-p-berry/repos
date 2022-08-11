using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectOneMSSA
{
    #region baseClass - Company
    public class Company
    {
        #region Constructors
        public Company()
        {
        }
        public Company(string name, string sector)
        {
            _Name = name;
            _Sector = sector;
        }
        public Company(
            string name,
            string sector,
            decimal revenue = 0,
            decimal EBITDA = 0,
            decimal freeCashFlow = 0, 
            bool isPublic = true)
        {
            _Name = name;
            _Sector = sector;
            _Revenue = revenue;
            _EBITDA = EBITDA;
            _FreeCashFlow = freeCashFlow;
            _IsPublic = isPublic;
        }
        #endregion

        #region Fields
        private string _Name;
        private string _Sector;
        private decimal _Revenue;
        private decimal _EBITDA;
        private decimal _FreeCashFlow;
        private bool _IsPublic;
        private decimal _Value;
        #endregion

        #region Properties
        public string Name { get => _Name; set => _Name = value; }
        public string Sector { get => _Sector; set => _Sector = value; }
        public decimal Revenue { get => _Revenue; set => _Revenue = value; }
        public decimal EBITDA { get => _EBITDA; set => _EBITDA = value; }
        public decimal FreeCashFlow { get => _FreeCashFlow; set => _FreeCashFlow = value; }
        public bool IsPublic { get => _IsPublic; set => _IsPublic = value; }
        public decimal Value { get => _Value; set => _Value = value; }
        #endregion

        #region Methods
        public virtual decimal GetValueIntrinsic(string tickerSymbol, string filePath, out decimal intrinsicValue) // Result is a rudimentary Discounted Cash Flow valuation of the business.
        {
            Record.SearchRecord(tickerSymbol, filePath, 0, out string searchResult);
            string[] resultArray = searchResult.Split(',');
            decimal freeCashFlow = Convert.ToInt64(resultArray[5]);
            intrinsicValue = freeCashFlow * 15;
            return intrinsicValue;
        }
        public virtual decimal GetValueComparable(string tickerSymbol, string filePath, out decimal comparableValue) // Result is a rudimentary Comparable Analysis valuation of the business.
        {
            int[] sectorMultiples = new int[10] { 20, 17, 7, 14, 19, 12, 6, 15, 9, 10 };
            Record.SearchRecord(tickerSymbol, filePath, 0, out string searchResult);
            string[] resultArray = searchResult.Split(',');
            int companySectorCode = Convert.ToInt32(resultArray[2]);
            decimal EBITDA = Convert.ToInt64(resultArray[4]);
            comparableValue = EBITDA * sectorMultiples[companySectorCode - 1];
            return comparableValue;
        }
        public virtual decimal GetValueByGeography(string tickerSymbol, string filePath, out decimal multipleEBITDAvalue) // Result is a product of previous transaction multiples applied to current metrics. 
        {
            Record.SearchRecord(tickerSymbol, filePath, 0, out string searchResult);
            string[] resultArray = searchResult.Split(',');
            decimal baseRevenue = Convert.ToInt64(resultArray[3]);
            int[] sectorMultiples = new int[10] { 10, 8, 4, 7, 9, 6, 3, 7, 5, 5 };
            int companySectorCode = Convert.ToInt32(resultArray[2]);
            string[] exchangeList = new string[10] {
                "  New York Stock Exchange" ,
                "  Nasdaq",
                "  Shanghai Stock Exchange",
                "  Euronext",
                "  Japan Stock Exchange",
                "  Hong Kong Stock Exchange",
                "  Shenzen Stock Exchange",
                "  Bombay Stock Exchange",
                "  London Stock Exchange",
                " Toronto Stock Exchange" };
            float[] taxRates = new float[10] { 0.20f, 0.20f, 0.33f, 0.40f, 0.25f, 0.33f, 0.33f, 0.40f, 0.25f, 0.33f };
            string exchange = resultArray[8];
            float taxRate = taxRates[Array.IndexOf(exchangeList, exchange)];
            multipleEBITDAvalue = baseRevenue * sectorMultiples[companySectorCode - 1] * (1 - (Convert.ToInt32(taxRate)));
            return multipleEBITDAvalue;
        }
        public virtual decimal GetValueAverage(string tickerSymbol, string filePath, decimal weightIntrinsic, decimal weightComparable, out decimal valueAverage) // Result is a weighted average of the other valuation techniques. 
        {
            decimal valueByGeography = GetValueByGeography(tickerSymbol, filePath, out valueByGeography);
            decimal valueComparable = GetValueComparable(tickerSymbol, filePath, out valueComparable);
            decimal valueIntrinsic = GetValueIntrinsic(tickerSymbol, filePath, out valueIntrinsic);
            valueAverage = Convert.ToDecimal((valueIntrinsic * (weightIntrinsic/100)) + (valueComparable * (weightComparable/100)) + (valueByGeography * ((1- (weightComparable + weightIntrinsic)/100))));
            return valueAverage;
        }
        public virtual string[] AddCompany() // Adds company information to a .txt file (should make this a database later once I learn how).
        {
            Company newCompany = new() { IsPublic = true };

            #region Input Company Name
            Console.WriteLine();
            Console.WriteLine("What is the name of this company?");
            bool isValid = false;
            while (isValid != true) // Loop through user input until receiving a valid entry. 
            {
                try
                {
                    newCompany.Name = Console.ReadLine();
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("That doesn't look right, please try again.");
                }
            }
            #endregion

            #region Input Company Sector
            Console.WriteLine();
            Console.WriteLine($"What sector does {newCompany.Name} operate in?");
            string[,] sector = new string[,] { 
                { "1", "Technology/ Telecom" }, 
                { "2", "Finance/ Professional Services" }, 
                { "3", "Industrial" }, 
                { "4", "Real Estate" }, 
                { "5", "Healthcare" }, 
                { "6", "Consumer Staples" }, 
                { "7", "Agriculture/ Materials" }, 
                { "8", "Consumer Discretionary" }, 
                { "9", "Energy/ Utilities" }, 
                { "10", "Government" } };
            for (int i = 0; i < sector.GetLength(0); i++)
            {
                for (int j = 0; j < sector.GetLength(1); j++)
                {
                    Console.Write("   {0}", sector[i, j]);
                }
                Console.WriteLine();
            }
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    newCompany.Sector = sector[0, 0];
                    break;
                case 2:
                    newCompany.Sector = sector[1, 0];
                    break;
                case 3:
                    newCompany.Sector = sector[2, 0];
                    break;
                case 4:
                    newCompany.Sector = sector[3, 0];
                    break;
                case 5:
                    newCompany.Sector = sector[4, 0];
                    break;
                case 6:
                    newCompany.Sector = sector[5, 0];
                    break;
                case 7:
                    newCompany.Sector = sector[6, 0];
                    break;
                case 8:
                    newCompany.Sector = sector[7, 0];
                    break;
                case 9:
                    newCompany.Sector = sector[8, 0];
                    break;
                case 10:
                    newCompany.Sector = sector[9, 0];
                    break;
                default:
                    Console.WriteLine("I've run into a problem. Goodbye!");
                    Environment.Exit(1);
                    break;
            }
            #endregion

            #region Input Company Revenue
            Console.WriteLine();
            try
            {
                Console.WriteLine($"What was their revenue last year?");
                newCompany.Revenue = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't look like a valid input, let's continue for now.");
                newCompany.Revenue = 0;
            }
            #endregion

            #region Input Company EBITDA
            Console.WriteLine();
            try
            {
                Console.WriteLine($"What was their EBITDA last year?");
                newCompany.EBITDA = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't look like a valid input, let's continue for now.");
                newCompany.EBITDA = 0;
            }
            #endregion

            #region Input Free Cash Flow // In future, this would be calculated (and all the financials will get pulled from an API through Nasdaq/ Bloomberg etc.
            Console.WriteLine();
            try
            {
                Console.WriteLine($"What is the Free Cash Flow of {newCompany.Name}?");
                newCompany.FreeCashFlow = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't look like a valid input, let's continue for now.");
                newCompany.FreeCashFlow = 0;
            }
            #endregion

            #region Input Check
            Console.WriteLine();
            Console.WriteLine($"For clarity's sake, we copy the following information:");
            Console.WriteLine($"{newCompany.Name} is a firm operating in the {newCompany.Sector} sector with {newCompany.Revenue:C2} in revenue and {newCompany.FreeCashFlow:C2} of FCF.");
            string[] companyData = new string[] { 
                newCompany.Name,
                newCompany.Sector, 
                Convert.ToString(newCompany.Revenue), 
                Convert.ToString(newCompany.EBITDA),
                Convert.ToString(newCompany.FreeCashFlow) };
            return companyData;
            #endregion
        }
        public virtual void AddToFile(string companyString, string filePath)
        {
            using StreamWriter writer = new(filePath, true);
            {
                writer.WriteLine();
                writer.Write(companyString);
            }
            Console.WriteLine($"We recorded information to {filePath}.");
        }
        #endregion
    }
    #endregion

    public class PublicCompany : Company
    {
        #region Constructors
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public PublicCompany()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }
        #endregion

        #region Fields
        private string _exchange;
        private string _tickerSymbol;
        private decimal _sharePrice;
        private int _sharesOutstanding;
        #endregion

        #region Properties
        public string Exchange { get => _exchange; set => _exchange = value; }
        public string TickerSymbol { get => _tickerSymbol; set => _tickerSymbol = value; }
        public decimal SharePrice { get => _sharePrice; set => _sharePrice = value; }
        public int SharesOutstanding { get => _sharesOutstanding; set => _sharesOutstanding = value; }
        #endregion

        #region Methods
        public string[] AddPublicData()
        {
            string[] companyData = new string[5];
            string newCompanyExchange = "unlisted";
            string newCompanyTickerSymbol;
            decimal newCompanySharePrice;
            int newCompanySharesOutstanding;

            #region Input exchange
            Console.WriteLine();
            Console.WriteLine("What Exchange ise this company listed on?");
            string[,] exchangeList = new string[,] { 
                { "1", " New York Stock Exchange" }, 
                { "2", " Nasdaq" }, 
                { "3", " Shanghai Stock Exchange" }, 
                { "4", " Euronext" }, 
                { "5", " Japan Stock Exchange" }, 
                { "6", " Hong Kong Stock Exchange" }, 
                { "7", " Shenzen Stock Exchange" }, 
                { "8", " Bombay Stock Exchange" }, 
                { "9", " London Stock Exchange" }, 
                { "10", "Toronto Stock Exchange" } };
            for (int i = 0; i < exchangeList.GetLength(0); i++)
            {
                for (int j = 0; j < exchangeList.GetLength(1); j++)
                {
                    Console.Write("   {0}", exchangeList[i, j]);
                }
                Console.WriteLine();
            }
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    newCompanyExchange = exchangeList[0, 0];
                    break;
                case 2:
                    newCompanyExchange = exchangeList[1, 0];
                    break;
                case 3:
                    newCompanyExchange = exchangeList[2, 0];
                    break;
                case 4:
                    newCompanyExchange = exchangeList[3, 0];
                    break;
                case 5:
                    newCompanyExchange = exchangeList[4, 0];
                    break;
                case 6:
                    newCompanyExchange = exchangeList[5, 0];
                    break;
                case 7:
                    newCompanyExchange = exchangeList[6, 0];
                    break;
                case 8:
                    newCompanyExchange = exchangeList[7, 0];
                    break;
                case 9:
                    newCompanyExchange = exchangeList[8, 0];
                    break;
                case 10:
                    newCompanyExchange = exchangeList[9, 0];
                    break;
                default:
                    Console.WriteLine("I've run into a problem. Goodbye!");
                    Environment.Exit(1);
                    break;
            }
            #endregion

            #region Input ticker symbol
            Console.WriteLine();
            Console.WriteLine("What is their ticker symbol?");
            newCompanyTickerSymbol = Console.ReadLine();
            newCompanyTickerSymbol = newCompanyTickerSymbol.ToUpperInvariant();
            #endregion

            #region Input share price
            Console.WriteLine();
            try
            {
                Console.WriteLine("What is their current share price?");
                newCompanySharePrice = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't look right, for now let's continue.");
                newCompanySharePrice = 0;
            }
            #endregion

            #region Input shares outstanding
            Console.WriteLine();
            try
            {
                Console.WriteLine("How many shares of common stock do they have outstanding?");
                newCompanySharesOutstanding = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't look right, for now let's continue.");
                newCompanySharesOutstanding = 1;
            }
            #endregion

            #region Output entered data
            companyData[0] = newCompanyExchange;
            companyData[1] = Convert.ToString(newCompanySharePrice);
            companyData[2] = Convert.ToString(newCompanySharesOutstanding);
            companyData[3] = newCompanyTickerSymbol;
            return companyData;
            #endregion
            
        }
        #endregion
    }

    public class PrivateCompany : Company
    {
        #region Constructors
        public PrivateCompany()
        {
        }
        #endregion

        #region Fields
        private decimal _askPrice;
        private decimal? _auditPrice;
        private decimal? _lastPrice;
        #endregion

        #region Properties
        public decimal AskPrice { get => _askPrice; set => _askPrice = value; }
        public decimal? AuditPrice { get => _auditPrice; set => _auditPrice = value; }
        public decimal? LastPrice { get => _lastPrice; set => _lastPrice = value; }
        #endregion

        #region Methods
        public virtual string AddPrivateData()
        {
            decimal newAskPrice;
            decimal newAuditPrice;
            decimal newLastPrice;

            Console.WriteLine();
            bool solicitResult = Program.YesNoQuestion("Is this a solicited bid or not?");
            if (solicitResult == true)
            {
                Console.WriteLine();
                Console.WriteLine("What is the seller asking price?");
                newAskPrice = Convert.ToDecimal(Console.ReadLine());
            } else if (solicitResult == false)
            {
                newAskPrice = 0;
            } else
            {
                Console.WriteLine("I seem to be having an issue, let's continue for now.");
                newAskPrice = 0;
            }
            Console.WriteLine();
            bool auditResult = Program.YesNoQuestion("Have you conducted an audit of their financials?");
            if (auditResult == true)
            {
                Console.WriteLine();
                Console.WriteLine("Excellent! What is their audited valuation recommendation?");
                newAuditPrice = Convert.ToDecimal(Console.ReadLine());
            } else if (auditResult == false)
            {
                newAuditPrice = 0;
            } 
            else
            {
                Console.WriteLine("I seem to be having an issue, let's continue for now.");
                newAuditPrice = 0;
            }
            Console.WriteLine();
            bool precedentResult = Program.YesNoQuestion("Has this business been sold previously?");
            if (precedentResult == true)
            {
                Console.WriteLine();
                Console.WriteLine("For what price?");
                newLastPrice = Convert.ToDecimal(Console.ReadLine());
            }
            else if (precedentResult == false)
            {
                newLastPrice = 0;
            }
            else
            {
                Console.WriteLine("I seem to be having an issue, let's continue for now.");
                newLastPrice = 0;
            }
            string[] privateData = new string[] {
                Convert.ToString(newAskPrice),
                Convert.ToString(newAuditPrice), 
                Convert.ToString(newLastPrice) };
            string privateCompanyInformation = string.Join(',', privateData);
            return privateCompanyInformation;
        }
        public override decimal GetValueIntrinsic(string tickerSymbol, string filePath, out decimal intrinsicValue) // Result is a rudimentary Discounted Cash Flow valuation of the business.
        {
            Record.SearchRecord(tickerSymbol, filePath, 0, out string searchResult);
            string[] resultArray = searchResult.Split(',');
            decimal freeCashFlow = Convert.ToInt64(resultArray[4]);
            intrinsicValue = freeCashFlow * 15;
            return intrinsicValue;
        }
        public override decimal GetValueComparable(string tickerSymbol, string filePath, out decimal comparableValue) // Result is a rudimentary Comparable Analysis valuation of the business.
        {
            int[] sectorMultiples = new int[10] { 20, 17, 7, 14, 19, 12, 6, 15, 9, 10 };
            Record.SearchRecord(tickerSymbol, filePath, 0, out string searchResult);
            string[] resultArray = searchResult.Split(',');
            int companySectorCode = Convert.ToInt32(resultArray[1]);
            decimal EBITDA = Convert.ToInt64(resultArray[3]);
            comparableValue = EBITDA * sectorMultiples[companySectorCode - 1];
            return comparableValue;
        }
        public override decimal GetValueByGeography(string tickerSymbol, string filePath, out decimal multipleEBITDAvalue) // Result is a product of previous transaction multiples applied to current metrics. 
        {
            Record.SearchRecord(tickerSymbol, filePath, 0, out string searchResult);
            string[] resultArray = searchResult.Split(',');
            decimal baseRevenue = Convert.ToInt64(resultArray[2]);
            int[] sectorMultiples = new int[10] { 10, 8, 4, 7, 9, 6, 3, 7, 5, 5 };
            int companySectorCode = Convert.ToInt32(resultArray[1]);
            string[] exchangeList = new string[10] {
                " New York Stock Exchange" ,
                " Nasdaq",
                " Shanghai Stock Exchange",
                " Euronext",
                " Japan Stock Exchange",
                " Hong Kong Stock Exchange",
                " Shenzen Stock Exchange",
                " Bombay Stock Exchange",
                " London Stock Exchange",
                "Toronto Stock Exchange" };
            float[] taxRates = new float[10] { 0.20f, 0.20f, 0.33f, 0.40f, 0.25f, 0.33f, 0.33f, 0.40f, 0.25f, 0.33f };
            //string exchange = resultArray.Last();
            float taxRate = taxRates[0];
            multipleEBITDAvalue = baseRevenue * sectorMultiples[companySectorCode - 1] * (1 - (Convert.ToInt32(taxRate)));
            return multipleEBITDAvalue;
        }
        public override decimal GetValueAverage(string tickerSymbol, string filePath, decimal weightIntrinsic, decimal weightComparable, out decimal valueAverage) // Result is a weighted average of the other valuation techniques. 
        {
            decimal valueByGeography = GetValueByGeography(tickerSymbol, filePath, out valueByGeography);
            decimal valueComparable = GetValueComparable(tickerSymbol, filePath, out valueComparable);
            decimal valueIntrinsic = GetValueIntrinsic(tickerSymbol, filePath, out valueIntrinsic);
            valueAverage = Convert.ToDecimal((valueIntrinsic * (weightIntrinsic / 100)) + (valueComparable * (weightComparable / 100)) + (valueByGeography * ((1 - (weightComparable + weightIntrinsic) / 100))));
            return valueAverage;
        }
        #endregion
    }

    public class Record
    {
        #region Constructors
        public Record()
        {
        }
        #endregion
        #region Fields
        #endregion
        #region Properties
        #endregion
        #region Methods
        public virtual string TestSearchRecord(string searchTerm, string filePath, int positionOfSearchTerm, out string result) // I need to push this over into a Transact SQL call.
        {
            IDictionary dictionary = new Hashtable();
            string[] record = File.ReadAllLines(filePath);
            foreach (string line in record)
            {
                string[] lines = line.Split(',');
                string ticker = lines[0];
                dictionary[ticker] = lines[1];
            }

            if (dictionary.Contains(searchTerm))
            {
                result = (string)dictionary[searchTerm];
            }
            else
            {
                result = "Record not found!";
            }
            return result;
        }
        public static string SearchRecord(string searchTerm, string filePath, int positionOfSearchTerm, out string result)
        {
            string recordNotFound = "Record not found!";
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (RecordMatches(searchTerm, fields, positionOfSearchTerm))
                {
                    result = string.Join(", ", fields);
                    return result;
                }
            }
            result = recordNotFound;
            return result;
        }
        public static bool RecordMatches(string searchTerm, string[] record, int indexOfSearchTerm)
        {
            if (record[indexOfSearchTerm].ToUpper().Equals(searchTerm.ToUpper()))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public bool YesNoQuestion(string question)
        {
            Console.WriteLine();
            Console.WriteLine($"{question} \n     Y - Yes\n     N - No ");
            string input = Console.ReadLine();
            string[] yes = new string[] { "y", "yes", "yup", "yep", "yeah", "yah" };
            string[] no = new string[] { "n", "no", "nope", "nah", "negative", "no" };
            try
            {
                foreach (string response in yes)
                {
                    if (input.ToLower() == response) { return true; }
                }
                foreach (string response in no)
                {
                    if (input.ToLower() == response) { return false; }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't look like a valid input. Press enter to try again or escape to exit");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Program.KillProgram();
                }
                else
                {
                    YesNoQuestion(question);
                }
            }
            Console.WriteLine("For the sake of my sanity, we're going to try this again until you give me a real answer.");
            YesNoQuestion(question);
            return true;
        }

        #endregion
    }
    
    #region temp
    /*    abstract class User
{
    #region Constructors
    #endregion
    #region Fields
    #endregion
    #region Properties
    #endregion
    #region Methods
    #endregion
}
abstract class Template
{
    #region Constructors
    #endregion
    #region Fields
    #endregion
    #region Properties
    #endregion
    #region Methods
    #endregion
}*/ 
    #endregion
}