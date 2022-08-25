using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    internal class BalanceSheet
    {
        #region Fields
        private decimal? _cashAndCashEquivalents;
        private decimal? _shortTermInvestments;
        private decimal? _cashAndShortTermInvestments;
        private decimal? _netReceivables;
        private decimal? _inventory;
        private decimal? _otherCurrentAssets;
        private decimal? _totalCurrentAssets;
        private decimal? _propertyPlantAndEquipment;
        private decimal? _goodwill;
        private decimal? _goodwillAndIntangibleAssets;
        private decimal? _longTermInvestments;
        private decimal? _taxAssets;
        private decimal? _totalAssets;
        private decimal? _accountsPayable;
        private decimal? _shortTermDebt;
        private decimal? _taxPayable;
        private decimal? _deferredRevenue;
        private decimal? _otherCurrentLiabilities;
        private decimal? _totalCurrentLiabilities;
        private decimal? _longTermDebt;
        private decimal? _deferredRevenueNonCurrent;
        private decimal? _deferredTaxLiabilitiesNonCurrent;
        private decimal? _otherNonCurrentLiabilities;
        private decimal? _totalNonCurrentLiabilities;
        private decimal? _otherLiabilities;
        private decimal? _capitalLeaseObligations;
        private decimal? _totalLiabilities;
        private decimal? _preferredStock;
        private decimal? _commonStock;
        private decimal? _retainedEarnings;
        private decimal? _accumulatedOtherComprehensiveIncomeLoss;
        private decimal? _otherTotalStockholdersEquity;
        private decimal? _totalStockholdersEquity;
        private decimal? _totalLiabilitiesAndStockholdersEquity;
        private decimal? _minorityInterest;
        private decimal? _totalEquity;
        private decimal? _totalLiabilitiesAndEquity;
        private decimal? _totalInvestments;
        private decimal? _totalDebt;
        private decimal? _netDebt; 
        #endregion

        #region Constructors
        public BalanceSheet(decimal? cashAndCashEquivalents,
                               decimal? shortTermInvestments,
                               decimal? cashAndShortTermInvestments,
                               decimal? netReceivables,
                               decimal? inventory,
                               decimal? otherCurrentAssets,
                               decimal? totalCurrentAssets,
                               decimal? propertyPlantAndEquipment,
                               decimal? goodwill,
                               decimal? goodwillAndIntangibleAssets,
                               decimal? longTermInvestments,
                               decimal? taxAssets,
                               decimal? totalAssets,
                               decimal? accountsPayable,
                               decimal? shortTermDebt,
                               decimal? taxPayable,
                               decimal? deferredRevenue,
                               decimal? otherCurrentLiabilities,
                               decimal? totalCurrentLiabilities,
                               decimal? longTermDebt,
                               decimal? deferredRevenueNonCurrent,
                               decimal? deferredTaxLiabilitiesNonCurrent,
                               decimal? otherNonCurrentLiabilities,
                               decimal? totalNonCurrentLiabilities,
                               decimal? otherLiabilities,
                               decimal? capitalLeaseObligations,
                               decimal? totalLiabilities,
                               decimal? preferredStock,
                               decimal? commonStock,
                               decimal? retainedEarnings,
                               decimal? accumulatedOtherComprehensiveIncomeLoss,
                               decimal? otherTotalStockholdersEquity,
                               decimal? totalStockholdersEquity,
                               decimal? totalLiabilitiesAndStockholdersEquity,
                               decimal? minorityInterest,
                               decimal? totalEquity,
                               decimal? totalLiabilitiesAndEquity,
                               decimal? totalInvestments,
                               decimal? totalDebt,
                               decimal? netDebt)
        {
            _cashAndCashEquivalents = cashAndCashEquivalents;
            _shortTermInvestments = shortTermInvestments;
            _cashAndShortTermInvestments = cashAndShortTermInvestments;
            _netReceivables = netReceivables;
            _inventory = inventory;
            _otherCurrentAssets = otherCurrentAssets;
            _totalCurrentAssets = totalCurrentAssets;
            _propertyPlantAndEquipment = propertyPlantAndEquipment;
            _goodwill = goodwill;
            _goodwillAndIntangibleAssets = goodwillAndIntangibleAssets;
            _longTermInvestments = longTermInvestments;
            _taxAssets = taxAssets;
            _totalAssets = totalAssets;
            _accountsPayable = accountsPayable;
            _shortTermDebt = shortTermDebt;
            _taxPayable = taxPayable;
            _deferredRevenue = deferredRevenue;
            _otherCurrentLiabilities = otherCurrentLiabilities;
            _totalCurrentLiabilities = totalCurrentLiabilities;
            _longTermDebt = longTermDebt;
            _deferredRevenueNonCurrent = deferredRevenueNonCurrent;
            _deferredTaxLiabilitiesNonCurrent = deferredTaxLiabilitiesNonCurrent;
            _otherNonCurrentLiabilities = otherNonCurrentLiabilities;
            _totalNonCurrentLiabilities = totalNonCurrentLiabilities;
            _otherLiabilities = otherLiabilities;
            _capitalLeaseObligations = capitalLeaseObligations;
            _totalLiabilities = totalLiabilities;
            _preferredStock = preferredStock;
            _commonStock = commonStock;
            _retainedEarnings = retainedEarnings;
            _accumulatedOtherComprehensiveIncomeLoss = accumulatedOtherComprehensiveIncomeLoss;
            _otherTotalStockholdersEquity = otherTotalStockholdersEquity;
            _totalStockholdersEquity = totalStockholdersEquity;
            _totalLiabilitiesAndStockholdersEquity = totalLiabilitiesAndStockholdersEquity;
            _minorityInterest = minorityInterest;
            _totalEquity = totalEquity;
            _totalLiabilitiesAndEquity = totalLiabilitiesAndEquity;
            _totalInvestments = totalInvestments;
            _totalDebt = totalDebt;
            _netDebt = netDebt;
        } 
        #endregion

        #region Properties
        public decimal? CashAndCashEquivalents { get => _cashAndCashEquivalents; set => _cashAndCashEquivalents = value; }
        public decimal? ShortTermInvestments { get => _shortTermInvestments; set => _shortTermInvestments = value; }
        public decimal? CashAndShortTermInvestments { get => _cashAndShortTermInvestments; set => _cashAndShortTermInvestments = value; }
        public decimal? NetReceivables { get => _netReceivables; set => _netReceivables = value; }
        public decimal? Inventory { get => _inventory; set => _inventory = value; }
        public decimal? OtherCurrentAssets { get => _otherCurrentAssets; set => _otherCurrentAssets = value; }
        public decimal? TotalCurrentAssets { get => _totalCurrentAssets; set => _totalCurrentAssets = value; }
        public decimal? PropertyPlantAndEquipment { get => _propertyPlantAndEquipment; set => _propertyPlantAndEquipment = value; }
        public decimal? Goodwill { get => _goodwill; set => _goodwill = value; }
        public decimal? GoodwillAndIntangibleAssets { get => _goodwillAndIntangibleAssets; set => _goodwillAndIntangibleAssets = value; }
        public decimal? LongTermInvestments { get => _longTermInvestments; set => _longTermInvestments = value; }
        public decimal? TaxAssets { get => _taxAssets; set => _taxAssets = value; }
        public decimal? TotalAssets { get => _totalAssets; set => _totalAssets = value; }
        public decimal? AccountsPayable { get => _accountsPayable; set => _accountsPayable = value; }
        public decimal? ShortTermDebt { get => _shortTermDebt; set => _shortTermDebt = value; }
        public decimal? TaxPayable { get => _taxPayable; set => _taxPayable = value; }
        public decimal? DeferredRevenue { get => _deferredRevenue; set => _deferredRevenue = value; }
        public decimal? OtherCurrentLiabilities { get => _otherCurrentLiabilities; set => _otherCurrentLiabilities = value; }
        public decimal? TotalCurrentLiabilities { get => _totalCurrentLiabilities; set => _totalCurrentLiabilities = value; }
        public decimal? LongTermDebt { get => _longTermDebt; set => _longTermDebt = value; }
        public decimal? DeferredRevenueNonCurrent { get => _deferredRevenueNonCurrent; set => _deferredRevenueNonCurrent = value; }
        public decimal? DeferredTaxLiabilitiesNonCurrent { get => _deferredTaxLiabilitiesNonCurrent; set => _deferredTaxLiabilitiesNonCurrent = value; }
        public decimal? OtherNonCurrentLiabilities { get => _otherNonCurrentLiabilities; set => _otherNonCurrentLiabilities = value; }
        public decimal? TotalNonCurrentLiabilities { get => _totalNonCurrentLiabilities; set => _totalNonCurrentLiabilities = value; }
        public decimal? OtherLiabilities { get => _otherLiabilities; set => _otherLiabilities = value; }
        public decimal? CapitalLeaseObligations { get => _capitalLeaseObligations; set => _capitalLeaseObligations = value; }
        public decimal? TotalLiabilities { get => _totalLiabilities; set => _totalLiabilities = value; }
        public decimal? PreferredStock { get => _preferredStock; set => _preferredStock = value; }
        public decimal? CommonStock { get => _commonStock; set => _commonStock = value; }
        public decimal? RetainedEarnings { get => _retainedEarnings; set => _retainedEarnings = value; }
        public decimal? AccumulatedOtherComprehensiveIncomeLoss { get => _accumulatedOtherComprehensiveIncomeLoss; set => _accumulatedOtherComprehensiveIncomeLoss = value; }
        public decimal? OtherTotalStockholdersEquity { get => _otherTotalStockholdersEquity; set => _otherTotalStockholdersEquity = value; }
        public decimal? TotalStockholdersEquity { get => _totalStockholdersEquity; set => _totalStockholdersEquity = value; }
        public decimal? TotalLiabilitiesAndStockholdersEquity { get => _totalLiabilitiesAndStockholdersEquity; set => _totalLiabilitiesAndStockholdersEquity = value; }
        public decimal? MinorityInterest { get => _minorityInterest; set => _minorityInterest = value; }
        public decimal? TotalEquity { get => _totalEquity; set => _totalEquity = value; }
        public decimal? TotalLiabilitiesAndEquity { get => _totalLiabilitiesAndEquity; set => _totalLiabilitiesAndEquity = value; }
        public decimal? TotalInvestments { get => _totalInvestments; set => _totalInvestments = value; }
        public decimal? TotalDebt { get => _totalDebt; set => _totalDebt = value; }
        public decimal? NetDebt { get => _netDebt; set => _netDebt = value; }
        #endregion
        
        #region Methods

        #endregion
    }
}
