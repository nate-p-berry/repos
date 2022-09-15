using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace ProjectTwo.Models
{
    public struct SessionState
    {
        internal static Investor currentUser = new();
        // TODO: Add more session state here, DiscountRate below keeps throwing an error when I try to use it
        internal static decimal DiscountRate = (decimal)currentUser.DiscountRateExpectation;
        internal static decimal GrowthRate = (decimal)currentUser.GrowthRateExpectation;
        internal static decimal WeightDCF = (decimal)currentUser.WeightDiscountedCashFlow;
        internal static decimal WeightComps = (decimal)currentUser.WeightComparable;
        internal static decimal WeightFactors = (decimal)currentUser.WeightFactorModel;
    }
}
