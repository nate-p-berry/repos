using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Investor
    {
        public Investor() { }

        private string _countryPreference;
        private string _categoryPreference;

        public int Id { get; set; } = default(int);
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Smith";
        public string Description { get; set; } = "";
        public decimal? DiscountRateExpectation { get; set; } = 6 / 100;
        public decimal? GrowthRateExpectation { get; set; } = 2 / 100;
        public decimal? WeightDiscountedCashFlow { get; set; } = 3333 / 10000;
        public decimal? WeightComparable { get; set; } = 3333 / 10000;
        public decimal? WeightFactorModel { get; set; } = 3333 / 10000;
        public string? CountryPreference
        {
            get
            {
                return _countryPreference;
            }
            set
            {
                if (!AllowedCountryPreferences.Any(x => x == value))
                    throw new ArgumentException("Not a valid country.");
                _countryPreference = value ?? "us";

            }
        }
        internal static string[] AllowedCountryPreferences = new string[] 
        {  
            "ae", "ar", "at", "au", "be", 
            "bg", "br", "ca", "ch", "cn", 
            "co", "cu", "cz", "de", "eg",
            "fr", "gb", "gr", "hk", "hu",
            "id", "ie", "il", "in", "it",
            "jp", "kr", "lt", "lv", "ma",
            "mx", "my", "ng", "nl", "no",
            "nz", "ph", "pl", "pt", "ro",
            "rs", "ru", "sa", "se", "sg",
            "si", "sk", "th", "tr", "tw",
            "ua", "us", "ve", "za" 
        };
        public string? CategoryPreference
        {
            get
            {
                return _categoryPreference;
            }
            set
            {
                if (!AllowedCategoryPreferences.Any(x => x == value))
                    throw new ArgumentException("Not a valid category.");
                _categoryPreference = value ?? "business";
            }
        }
        internal static string[] AllowedCategoryPreferences = new string[] 
        { 
            "business", 
            "entertainment", 
            "general", 
            "health", 
            "science", 
            "sports", 
            "technology" 
        };
    }
}
