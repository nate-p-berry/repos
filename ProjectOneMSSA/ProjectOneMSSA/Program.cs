using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProjectOneMSSA
{
    internal class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Company Valuation Calculator";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("This program calculates company valuations based off of user input and certain stored values.");
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            string filePath;
            int userInput;
            Record record = new();
            do
            {
                InitializeProgram(out userInput);
                switch (Convert.ToInt32(userInput))
                {
                    case 1:
                        CaseOne();
                        break;
                    case 2:
                        CaseTwo();
                        break;
                    case 3:
                        #region CaseThree
                        UserValuationArrayAssembler(out float discountRate, out float growthRate, out decimal weightIntrinsic, out decimal weightComparable, out float timeHorizon);
                        filePath = null;
                        Console.Clear();
                        decimal value;
                        bool result = record.YesNoQuestion("Are you valuing a public company?");
                        if (result == true)
                        {
                            bool isPublic = true;
                            filePath = @"Record.txt";
                            PublicCompany publicCompany = new();
                            Console.WriteLine();
                            Console.WriteLine("What is the ticker symbol of this company?");
                            string tickerSymbol = Console.ReadLine();
                            publicCompany.Value = ValuationTechniqueSwitch(tickerSymbol, filePath, discountRate, growthRate, weightIntrinsic, weightComparable, timeHorizon, out value, isPublic);
                            Console.WriteLine();
                            Console.WriteLine($"Based on your inputs, the value of {tickerSymbol.ToUpper()} is {value:C}.");
                            if (!YesNoQuestion("Would you like to continue?"))
                            {
                                KillProgram();
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            bool isPublic = false;
                            filePath = @"PrivateRecord.txt";
                            PrivateCompany privateCompany = new();
                            Console.WriteLine();
                            Console.WriteLine("What is the name of this company?");
                            string tickerSymbol = Console.ReadLine();
                            privateCompany.Value = ValuationTechniqueSwitch(tickerSymbol, filePath, discountRate, growthRate, weightIntrinsic, weightComparable, timeHorizon, out value, isPublic);
                            Console.WriteLine();
                            Console.WriteLine($"Based on your inputs, the value of {tickerSymbol.ToUpper()} is {value:C}.");
                            if (!YesNoQuestion("Would you like to continue?"))
                            {
                                KillProgram();
                            }
                            else
                            {
                                break;
                            }
                        } 
                        #endregion
                        break;
                    case 4:
                        KillProgram();
                        break;
                    default:
                        break;
                }
            } while (userInput != 4);
        }
        public static void InitializeProgram(out int initializerInputInt) // Decided to make these into their own standalone methods for readability and cleanliness. 
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("What would you like to do? " +
                "\n   1 - Add a new company to the list " +
                "\n   2 - Lookup an existing company " +
                "\n   3 - Value a company " +
                "\n   4 - Exit program");
            try // Very rudimentary event handling!
            {
                initializerInputInt = Convert.ToInt32(Console.ReadLine());
                if (initializerInputInt > 4 || initializerInputInt < 0) // Effectively a catch clause in the event that user input is numeric but outside the range of options.
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't looke like a valid input. Please choose option 1, 2, 3, or 4.");
                    InitializeProgram(out initializerInputInt);
                }
            }
            catch (Exception) // Catch clause in the event that user input is non-numeric.
            {
                Console.Clear();
                Console.WriteLine("That doesn't look like a valid input. Please choose option 1, 2, 3, or 4.");
                InitializeProgram(out initializerInputInt);
            }
        }
        private static void CaseOne()
        {
            string userInputCaseOne;
            int userInputCaseOneAsInt;
            Console.Clear();
            Console.WriteLine("What kind of company would you like to add? " +
                "\n   1 - A publicly traded company " +
                "\n   2 - A private company ");
            try
            {
                userInputCaseOne = Console.ReadLine();
                userInputCaseOneAsInt = Convert.ToInt32(userInputCaseOne);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, that doesn't look lik a valid input. Press any key to continue or ESC to exit.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    KillProgram();
                }
                userInputCaseOneAsInt = 0;
                CaseOne();
            }
            if (userInputCaseOneAsInt == 1)
            {
                Console.Clear();
                Console.WriteLine("Great! you want to add a new public company to the list.");
                PublicCompany newPublicCompany = new() { IsPublic = true };
                string[] companyRecordBase = newPublicCompany.AddCompany();
                string[] companyRecordPublic = newPublicCompany.AddPublicData();
                newPublicCompany.Name = companyRecordBase[0];
                newPublicCompany.Sector = companyRecordBase[1];
                newPublicCompany.Revenue = Convert.ToInt64(companyRecordBase[2]);
                newPublicCompany.EBITDA = Convert.ToInt64(companyRecordBase[3]);
                newPublicCompany.FreeCashFlow = Convert.ToInt64(companyRecordBase[4]);
                newPublicCompany.SharesOutstanding = Convert.ToInt32(companyRecordPublic[2]);
                newPublicCompany.Exchange = companyRecordPublic[0];
                newPublicCompany.TickerSymbol = companyRecordPublic[3];
                string[] companyRecord = {
                            newPublicCompany.TickerSymbol,
                            newPublicCompany.Name,
                            newPublicCompany.Sector,
                            Convert.ToString(newPublicCompany.Revenue),
                            Convert.ToString(newPublicCompany.EBITDA),
                            Convert.ToString(newPublicCompany.FreeCashFlow),
                            Convert.ToString(newPublicCompany.SharesOutstanding),
                            Convert.ToString(newPublicCompany.IsPublic),
                            newPublicCompany.Exchange };
                string addToFile = string.Join(',', companyRecord);
                Console.WriteLine();
                newPublicCompany.AddToFile(addToFile, "Record.txt");
                userInputCaseOne = null;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Great! You want to add a new private company to the list.");
                PrivateCompany newPrivateCompany = new() { IsPublic = false };
                string companyRecord = string.Join(',', newPrivateCompany.AddCompany()) + ',' + string.Join(',', newPrivateCompany.AddPrivateData());
                Console.WriteLine(companyRecord);
                Console.WriteLine();
                newPrivateCompany.AddToFile(companyRecord, "PrivateRecord.txt");
                userInputCaseOne = null;
            }
            Console.WriteLine();
            Console.WriteLine("Continue or exit program?\n    1- Continue\n    2- Exit");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                return;
            }
            else
            {
                KillProgram();
            }
        }
        private static void CaseTwo()
        {
            string filePath;
            string searchTerm;
            string[] sector = new string[] { "Technology/ Telecom", "Finance/ Professional Services", "Industrial", "Real Estate", "Healthcare", "Consumer Staples", "Agriculture/ Materials", "Consumer Discretionary", "Energy/ Utilities", "Government" };
            Console.Clear();
            Console.WriteLine("Are you searching for a public company or a private company?\n    1- Public Company\n    2- Private Company\n    3- Exit Program");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    filePath = @"Record.txt";
                    Console.WriteLine();
                    Console.WriteLine("What is the ticker symbol of the company you'd like to find?");
                    Console.WriteLine();
                    searchTerm = Console.ReadLine().ToUpper();
                    Record.SearchRecord(searchTerm, filePath, 0, out string searchResultPublic);
                    string[] searchResultPublicArray = searchResultPublic.Split(',');
                    string sectorPublicLocal = "professional services";
                    try
                    {
                        sectorPublicLocal = sector[(Convert.ToInt32(searchResultPublicArray[2])) - 1];
                    }
                    catch (Exception)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Record not found.");
                        Console.WriteLine("Continue or exit program?\n    1- Continue\n    2- Exit");
                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                        {
                            return;
                        }
                        else
                        {
                            KillProgram();
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{searchResultPublicArray[1]} (${searchResultPublicArray[0]}) is a company listed on the {searchResultPublicArray[8]} with {searchResultPublicArray[6]} common shares outstanding and operates in the {sectorPublicLocal} segment." +
                        $"\nTheir revenue, EBITDA, and free cash flow last year were {Convert.ToDecimal(searchResultPublicArray[3]):C}, {Convert.ToDecimal(searchResultPublicArray[4]):C}, and {Convert.ToDecimal(searchResultPublicArray[5]):C} respectively.");
                    Console.WriteLine();
                    Console.WriteLine("Continue or exit program?\n    1- Continue\n    2- Exit");
                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                    {
                        return;
                    } else
                    {
                        KillProgram();
                    }
                    break;
                case 2:
                    filePath = @"PrivateRecord.txt";
                    Console.WriteLine();
                    Console.WriteLine("What is the name of the company you'd like to find?");
                    Console.WriteLine();
                    searchTerm = Console.ReadLine().ToUpper();
                    Record.SearchRecord(searchTerm, filePath, 0, out string searchResultPrivate);
                    string[] searchResultPrivateArray = searchResultPrivate.Split(',');
                    string sectorPrivateLocal = sector[(Convert.ToInt32(searchResultPrivateArray[1]))];
                    Console.WriteLine();
                    Console.WriteLine($"{searchResultPrivateArray[0]} is a private company that operates in the {sectorPrivateLocal} segment." +
                        $"\nTheir revenue, EBITDA, and free cash flow last year were {Convert.ToDecimal(searchResultPrivateArray[2]):C}, {Convert.ToDecimal(searchResultPrivateArray[3]):C}, and {Convert.ToDecimal(searchResultPrivateArray[4]):C} respectively." +
                        $"\nOur records indicate that the seller's valuation, last audit price, and most recent sale price were {Convert.ToDecimal(searchResultPrivateArray[5]):C}, {Convert.ToDecimal(searchResultPrivateArray[6]):C}, and {Convert.ToDecimal(searchResultPrivateArray[7]):C} respectively.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Continue or exit program?\n    1- Continue\n    2- Exit");
                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                    {
                        return;
                    }
                    else
                    {
                        KillProgram();
                    }
                    break;
                case 3:
                    KillProgram();
                    break;
                default:
                    KillProgram();
                    break;
            }

        }
        public static void KillProgram() // Having a method for this works way better than iterating and carrying values through everything. 
        {
            Console.Clear();
            Console.WriteLine("Well shucks, thanks for playing!" +
                "\n" +
                "\nY'all come back now, you hear?");
            Environment.Exit(100);
        }
        private static void UserValuationArrayAssembler(out float discountRate, out float growthRate, out decimal weightIntrinsic, out decimal weightComparable, out float timeHorizon)
        {
            bool isValid;
            do
            {
                #region discountRate
                Console.WriteLine();
                Console.WriteLine("What is the discount rate you would like to apply?\n(Enter your answer in whole percentage points - e.g. 5% not 0.05)");
                try
                {
                    discountRate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The discount rate you entered is {discountRate}.");
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't look like a valid numerical input. Let's try again.");

                    UserValuationArrayAssembler(out discountRate, out growthRate, out weightIntrinsic, out weightComparable, out timeHorizon);
                }
                #endregion
                #region growthRate
                Console.WriteLine();
                Console.WriteLine("What is the growth rate that you are assuming?\n(Enter your answer in whole percentage points - e.g. 5% not 0.05)");
                try
                {
                    growthRate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The growth rate you entered is {growthRate}.");

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't look like a valid numerical input. Let's try again.");
                    UserValuationArrayAssembler(out discountRate, out growthRate, out weightIntrinsic, out weightComparable, out timeHorizon);
                }
                #endregion
                #region weightIntrinsic
                Console.WriteLine();
                Console.WriteLine("What weight would you like give to intrinsic (i.e. Discounted Cash Flow) value calculations?\n(Enter your answer in whole percentage points - e.g. 5% not 0.05)");
                try
                {
                    weightIntrinsic = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The weight you entered is {weightIntrinsic}.");

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't look like a valid numerical input. Let's try again.");
                    UserValuationArrayAssembler(out discountRate, out growthRate, out weightIntrinsic, out weightComparable, out timeHorizon);
                }
                #endregion
                #region weightComparable
                Console.WriteLine();
                Console.WriteLine("What weight would you like give to comparable value calculations?\n(Enter your answer in whole percentage points - e.g. 5% not 0.05)");
                try
                {
                    weightComparable = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The weight you entered is {weightComparable}.");

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't look like a valid numerical input. Let's try again.");
                    UserValuationArrayAssembler(out discountRate, out growthRate, out weightIntrinsic, out weightComparable, out timeHorizon);
                }
                #endregion
                #region weightByGeography
                Console.WriteLine();
                Console.WriteLine("What weight would you like give to valuations adjusted by geography?\n(Enter your answer in whole percentage points - e.g. 5% not 0.05)");
                try
                {
                    int fake = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The weight you entered is {fake}.");

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't look like a valid numerical input. Let's try again.");
                    UserValuationArrayAssembler(out discountRate, out growthRate, out weightIntrinsic, out weightComparable, out timeHorizon);
                }
                #endregion
                #region timeHorizon
                Console.WriteLine();
                Console.WriteLine("What is your time horizon for this particular investment?\n(Enter your answer in whole years)");
                try
                {
                    timeHorizon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"You entered {timeHorizon} year(s).");

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("That doesn't look like a valid numerical input. Let's try again.");
                    UserValuationArrayAssembler(out discountRate, out growthRate, out weightIntrinsic, out weightComparable, out timeHorizon);
                }
                #endregion
                isValid = true;
            } while (isValid == false);
            return;
        }
        private static decimal ValuationTechniqueSwitch(string tickerSymbol, string filePath, float discountRate, float growthRate, decimal weightIntrinsic, decimal weightComparable, float timeHorizon, out decimal companyValue, bool? isPublic)
        {
            if (isPublic == true)
            {
                Console.WriteLine();
                Company company = new();
                Console.WriteLine("Which valuation technique would you like to use?" +
                    "\n    1- Intrinsic Value (i.e. Discounted Cash Flow)" +
                    "\n    2- Comparable Firm Value" +
                    "\n    3- Value adjusted by geography" +
                    "\n    4- Combination of all three");
                int response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        company.GetValueIntrinsic(tickerSymbol, filePath, out decimal intrinsicValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, intrinsicValue, out decimal adjustedIntrinsicValue);
                        companyValue = adjustedIntrinsicValue;
                        break;
                    case 2:
                        company.GetValueComparable(tickerSymbol, filePath, out decimal comparableValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, comparableValue, out decimal adjustedComparableValue);
                        companyValue = adjustedComparableValue;
                        break;
                    case 3:
                        company.GetValueByGeography(tickerSymbol, filePath, out decimal geographyValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, geographyValue, out decimal adjustedGeographyValue);
                        companyValue = adjustedGeographyValue;
                        break;
                    case 4:
                        company.GetValueAverage(tickerSymbol, filePath, weightIntrinsic, weightComparable, out decimal averageValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, averageValue, out decimal adjustedAverageValue);
                        companyValue = adjustedAverageValue;
                        break;
                    default:
                        companyValue = 0;
                        break;
                }
                return companyValue; 
            } else
            {
                Console.WriteLine();
                PrivateCompany company = new();
                Console.WriteLine("Which valuation technique would you like to use?" +
                    "\n    1- Intrinsic Value (i.e. Discounted Cash Flow)" +
                    "\n    2- Comparable Firm Value" +
                    "\n    3- Value adjusted by geography" +
                    "\n    4- Combination of all three");
                int response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        company.GetValueIntrinsic(tickerSymbol, filePath, out decimal intrinsicValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, intrinsicValue, out decimal adjustedIntrinsicValue);
                        companyValue = adjustedIntrinsicValue;
                        break;
                    case 2:
                        company.GetValueComparable(tickerSymbol, filePath, out decimal comparableValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, comparableValue, out decimal adjustedComparableValue);
                        companyValue = adjustedComparableValue;
                        break;
                    case 3:
                        company.GetValueByGeography(tickerSymbol, filePath, out decimal geographyValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, geographyValue, out decimal adjustedGeographyValue);
                        companyValue = adjustedGeographyValue;
                        break;
                    case 4:
                        company.GetValueAverage(tickerSymbol, filePath, weightIntrinsic, weightComparable, out decimal averageValue);
                        PresentValueCalculator(discountRate, growthRate, timeHorizon, averageValue, out decimal adjustedAverageValue);
                        companyValue = adjustedAverageValue;
                        break;
                    default:
                        companyValue = 0;
                        break;
                }
                return companyValue;
            }
        }
        public static bool YesNoQuestion(string question)
        {
            Console.WriteLine();
            Console.WriteLine($"{question} \n     Y - Yes\n     N - No ");
            string input = Console.ReadLine();
            string[] yes = new string[] { "y", "yes", "yup", "yep", "yeah", "yah" }; 
            string[] no = new string[] { "n", "no", "nope", "nah", "negative", "no" } ;
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
                if (Console.ReadKey().Key==ConsoleKey.Escape)
                {
                    KillProgram();
                } else
                {
                    YesNoQuestion(question);
                }
            }
            Console.WriteLine("For the sake of my sanity, we're going to try this again until you give me a real answer.");
            YesNoQuestion(question);
            return true;
        }
        private static decimal PresentValueCalculator(float discountRate, float growthRate, float timeHorizon, decimal unadjustedValue, out decimal adjustedValue)
        {
            // Not gonna lie, this is all "hand waved" math here and, if I'm gonna make this for real, it will need to be much better in the future. 
            List <decimal> cashFlowsUnadjusted = new();
            List<decimal> cashFlowsAdjusted = new();
            int timeHorizonAsInt = Convert.ToInt32(timeHorizon);
            decimal projectedCashFlow = unadjustedValue / timeHorizonAsInt;
            for (int i = 0; i < timeHorizonAsInt; i++)
            {
                cashFlowsUnadjusted.Add(projectedCashFlow);
            }
            growthRate = 1 + (growthRate / 100);
            discountRate = 1 + (discountRate / 100);
            for (double i = 0; i < cashFlowsUnadjusted.Count; i++)
            {
                decimal factor = Convert.ToDecimal((Math.Pow(Convert.ToDouble(growthRate), i)) / (Math.Pow(Convert.ToDouble(discountRate), i))) * 1000;
                decimal cashflowAdjusted = cashFlowsUnadjusted[Convert.ToInt32(i)] * factor / 1000;
                cashFlowsAdjusted.Add(cashflowAdjusted);
            }
            adjustedValue = cashFlowsAdjusted.Sum();
            return adjustedValue;
        }
    }
}