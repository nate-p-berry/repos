using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    // In retrospect, I could and maybe should try to tie these together with the other classes such that -for example- the revenue of one statement
    // can't be different from the same data in another and vice versa. Feels like that could be needlessly complex though and I intend to just use similar
    // database references/sources to set the values.
    public class IncomeStatement : FinancialStatement
    {
        #region Fields
        private decimal? _revenue;
        private decimal? _costOfRevenue;
        private decimal? _grossProfit;
        private decimal? _grossProfitRatio;
        private decimal? _researchAndDevelopmentExpense;
        private decimal? _sellingAndMarketingExpense;
        private decimal? _sellingGeneralAndAdministrativeExpense;
        private decimal? _otherExpense;
        private decimal? _operatingExpense;
        private decimal? _costAndExpense;
        private decimal? _interestIncome;
        private decimal? _interestExpense;
        private decimal? _depreciationAndAmortization;
        private decimal? _ebitda;
        private decimal? _ebitdaRatio;
        private decimal? _operatingIncome;
        private decimal? _operatingIncomeRatio;
        private decimal? _totalOtherIncomeandExpenseNet;
        private decimal? _incomeBeforeTax;
        private decimal? _incomeBeforeTaxRatio;
        private decimal? _incomeTaxExpense;
        private decimal? _netIncome;
        private decimal? _netIncomeRatio;
        private decimal? _eps;
        private decimal? _epsDiluted;
        private decimal? _weightedAverageSharesOutstanding;
        private decimal? _weightedAverageSharesOutstandingDiluted;
        #endregion

        #region Constructor
        public IncomeStatement() { }
        public IncomeStatement(decimal? revenue,
                                  decimal? costOfRevenue,
                                  decimal? grossProfit,
                                  decimal? grossProfitRatio,
                                  decimal? researchAndDevelopmentExpense,
                                  decimal? sellingAndMarketingExpense,
                                  decimal? sellingGeneralAndAdministrativeExpense,
                                  decimal? otherExpense,
                                  decimal? operatingExpense,
                                  decimal? costAndExpense,
                                  decimal? interestIncome,
                                  decimal? interestExpense,
                                  decimal? depreciationAndAmortization,
                                  decimal? ebitda,
                                  decimal? ebitdaRatio,
                                  decimal? operatingIncome,
                                  decimal? operatingIncomeRatio,
                                  decimal? totalOtherIncomeandExpenseNet,
                                  decimal? incomeBeforeTax,
                                  decimal? incomeBeforeTaxRatio,
                                  decimal? incomeTaxExpense,
                                  decimal? netIncome,
                                  decimal? netIncomeRatio,
                                  decimal? eps,
                                  decimal? epsDiluted,
                                  decimal? weightedAverageSharesOutstanding,
                                  decimal? weightedAverageSharesOutstandingDiluted)
        {
            _revenue = revenue;
            _costOfRevenue = costOfRevenue;
            _grossProfit = grossProfit;
            _grossProfitRatio = grossProfitRatio;
            _researchAndDevelopmentExpense = researchAndDevelopmentExpense;
            _sellingAndMarketingExpense = sellingAndMarketingExpense;
            _sellingGeneralAndAdministrativeExpense = sellingGeneralAndAdministrativeExpense;
            _otherExpense = otherExpense;
            _operatingExpense = operatingExpense;
            _costAndExpense = costAndExpense;
            _interestIncome = interestIncome;
            _interestExpense = interestExpense;
            _depreciationAndAmortization = depreciationAndAmortization;
            _ebitda = ebitda;
            _ebitdaRatio = ebitdaRatio;
            _operatingIncome = operatingIncome;
            _operatingIncomeRatio = operatingIncomeRatio;
            _totalOtherIncomeandExpenseNet = totalOtherIncomeandExpenseNet;
            _incomeBeforeTax = incomeBeforeTax;
            _incomeBeforeTaxRatio = incomeBeforeTaxRatio;
            _incomeTaxExpense = incomeTaxExpense;
            _netIncome = netIncome;
            _netIncomeRatio = netIncomeRatio;
            _eps = eps;
            _epsDiluted = epsDiluted;
            _weightedAverageSharesOutstanding = weightedAverageSharesOutstanding;
            _weightedAverageSharesOutstandingDiluted = weightedAverageSharesOutstandingDiluted;
        }
        #endregion

        #region Properties
        public decimal? Revenue { get => _revenue; set => _revenue = value; }
        public decimal? CostOfRevenue { get => _costOfRevenue; set => _costOfRevenue = value; }
        public decimal? GrossProfit { get => _grossProfit; set => _grossProfit = value; }
        public decimal? GrossProfitRatio { get => _grossProfitRatio; set => _grossProfitRatio = value; }
        public decimal? ResearchAndDevelopmentExpense { get => _researchAndDevelopmentExpense; set => _researchAndDevelopmentExpense = value; }
        public decimal? SellingAndMarketingExpense { get => _sellingAndMarketingExpense; set => _sellingAndMarketingExpense = value; }
        public decimal? SellingGeneralAndAdministrativeExpense { get => _sellingGeneralAndAdministrativeExpense; set => _sellingGeneralAndAdministrativeExpense = value; }
        public decimal? OtherExpense { get => _otherExpense; set => _otherExpense = value; }
        public decimal? OperatingExpense { get => _operatingExpense; set => _operatingExpense = value; }
        public decimal? CostAndExpense { get => _costAndExpense; set => _costAndExpense = value; }
        public decimal? InterestIncome { get => _interestIncome; set => _interestIncome = value; }
        public decimal? InterestExpense { get => _interestExpense; set => _interestExpense = value; }
        public decimal? DepreciationAndAmortization { get => _depreciationAndAmortization; set => _depreciationAndAmortization = value; }
        public decimal? Ebitda { get => _ebitda; set => _ebitda = value; }
        public decimal? EbitdaRatio { get => _ebitdaRatio; set => _ebitdaRatio = value; }
        public decimal? OperatingIncome { get => _operatingIncome; set => _operatingIncome = value; }
        public decimal? OperatingIncomeRatio { get => _operatingIncomeRatio; set => _operatingIncomeRatio = value; }
        public decimal? TotalOtherIncomeandExpenseNet { get => _totalOtherIncomeandExpenseNet; set => _totalOtherIncomeandExpenseNet = value; }
        public decimal? IncomeBeforeTax { get => _incomeBeforeTax; set => _incomeBeforeTax = value; }
        public decimal? IncomeBeforeTaxRatio { get => _incomeBeforeTaxRatio; set => _incomeBeforeTaxRatio = value; }
        public decimal? IncomeTaxExpense { get => _incomeTaxExpense; set => _incomeTaxExpense = value; }
        public decimal? NetIncome { get => _netIncome; set => _netIncome = value; }
        public decimal? NetIncomeRatio { get => _netIncomeRatio; set => _netIncomeRatio = value; }
        public decimal? Eps { get => _eps; set => _eps = value; }
        public decimal? EpsDiluted { get => _epsDiluted; set => _epsDiluted = value; }
        public decimal? WeightedAverageSharesOutstanding { get => _weightedAverageSharesOutstanding; set => _weightedAverageSharesOutstanding = value; }
        public decimal? WeightedAverageSharesOutstandingDiluted { get => _weightedAverageSharesOutstandingDiluted; set => _weightedAverageSharesOutstandingDiluted = value; }
        #endregion

        #region Methods
        public override IncomeStatement EmptyStatement()
        {
            IncomeStatement emptyIncomeStatement = new();
            foreach(PropertyInfo propertyInfo in typeof(IncomeStatement).GetProperties())
            {
                propertyInfo.SetValue(this, 0);
            }
            return emptyIncomeStatement;
        }
        #endregion
    }
}
