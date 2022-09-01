using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace ProjectTwo.Models
{
    public class SessionState
    {
        public static Investor currentUser;
        public static decimal DiscountRate = (decimal)currentUser.DiscountRateExpectation;
        public static decimal GrowthRate = (decimal)currentUser.GrowthRateExpectation;
        public static decimal WeightDCF = (decimal)currentUser.WeightDiscountedCashFlow;
        public static decimal WeightComps = (decimal)currentUser.WeightComparable;
        public static decimal WeightFactors = (decimal)currentUser.WeightFactorModel;
    }
}
