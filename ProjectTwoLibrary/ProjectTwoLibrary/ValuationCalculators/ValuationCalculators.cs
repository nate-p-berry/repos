using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoLibrary.Calculators
{
    internal class ValuationCalculators
    {
        public static double CalculateNetPresentValue(double cashFlow, double discountRate, int numberOfPeriods)
        {
            double netPresentValue = 0;
            for (int i = 0; i < numberOfPeriods; i++)
            {
                netPresentValue += cashFlow / Math.Pow(1 + discountRate, i);
            }
            return netPresentValue;
        }

        public static double CalculateInternalRateOfReturn(double cashFlow, double discountRate, int numberOfPeriods)
        {
            double internalRateOfReturn = 0;
            for (int i = 0; i < numberOfPeriods; i++)
            {
                internalRateOfReturn += cashFlow / Math.Pow(1 + discountRate, i);
            }
            return internalRateOfReturn;
        }

        public static double CalculatePaybackPeriod(double cashFlow, double discountRate, int numberOfPeriods)
        {
            double paybackPeriod = 0;
            for (int i = 0; i < numberOfPeriods; i++)
            {
                paybackPeriod += cashFlow / Math.Pow(1 + discountRate, i);
            }
            return paybackPeriod;
        }
        
        // TODO: Fill in the logic here, this was just to get LINQ statement practice but it's also useful. 
        // Realistically, I wouldn't run one query per company, I'd take the whole set or some subset, store that as a local list, then run calcs on that.
        // Of course, in a live application, the selling point may be the "real time" nature of it all so maybe each one should be a unique query. Idk. 
        /*public static double GetFundamentals()
        {
            var companyFundamentalsQuery =
                from c in companies
                select new { Symbol = , Name = , ... etc.};

            foreach (var company in companyFundamentalsQuery)
            {
                //DoMath()
            }
            return companyFundamentalsQuery;
        }*/
    }
}
