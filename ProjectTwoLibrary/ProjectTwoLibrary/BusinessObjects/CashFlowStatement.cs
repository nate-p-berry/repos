using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class CashFlowStatement : FinancialStatement
    {
        #region Fields
        private decimal? _netIncome;
        private decimal? _depreciationAndAmortization;
        private decimal? _deferredIncomeTax;
        private decimal? _stockBasedCompensation;
        private decimal? _changeInWorkingCapital;
        private decimal? _accountsReceivable;
        private decimal? _inventory;
        private decimal? _accountsPayable;
        private decimal? _otherWorkingCapital;
        private decimal? _otherNonCashItems;
        private decimal? _netCashFromOperations;
        private decimal? _investmentsInPropertyPlantAndEquipment;
        private decimal? _acquisitionsNet;
        private decimal? _purchasesOfInvestments;
        private decimal? _salesMaturitiesOfInvestments;
        private decimal? _otherInvestingActivities;
        private decimal? _netCashFromInvestments;
        private decimal? _debtRepayment;
        private decimal? _commonStockIssued;
        private decimal? _commonStockRepurchased;
        private decimal? _dividendsPaid;
        private decimal? _otherFinancingActivities;
        private decimal? _netCashFromFinancing;
        private decimal? _effectOfForExOnCash;
        private decimal? _netChangeInCash;
        private decimal? _cashBeginning;
        private decimal? _cashEnding;
        private decimal? _operatingCashFlow;
        private decimal? _capitalExpenditure;
        private decimal? _freeCashFlow;
        #endregion

        #region Constructor
        public CashFlowStatement() { }
        public CashFlowStatement(decimal? netIncome,
                                    decimal? depreciationAndAmortization,
                                    decimal? deferredIncomeTax,
                                    decimal? stockBasedCompensation,
                                    decimal? changeInWorkingCapital,
                                    decimal? accountsReceivable,
                                    decimal? inventory,
                                    decimal? accountsPayable,
                                    decimal? otherWorkingCapital,
                                    decimal? otherNonCashItems,
                                    decimal? netCashFromOperations,
                                    decimal? investmentsInPropertyPlantAndEquipment,
                                    decimal? acquisitionsNet,
                                    decimal? purchasesOfInvestments,
                                    decimal? salesMaturitiesOfInvestments,
                                    decimal? otherInvestingActivities,
                                    decimal? netCashFromInvestments,
                                    decimal? debtRepayment,
                                    decimal? commonStockIssued,
                                    decimal? commonStockRepurchased,
                                    decimal? dividendsPaid,
                                    decimal? otherFinancingActivities,
                                    decimal? netCashFromFinancing,
                                    decimal? effectOfForExOnCash,
                                    decimal? netChangeInCash,
                                    decimal? cashBeginning,
                                    decimal? cashEnding,
                                    decimal? operatingCashFlow,
                                    decimal? capitalExpenditure,
                                    decimal? freeCashFlow)
        {
            _netIncome = netIncome;
            _depreciationAndAmortization = depreciationAndAmortization;
            _deferredIncomeTax = deferredIncomeTax;
            _stockBasedCompensation = stockBasedCompensation;
            _changeInWorkingCapital = changeInWorkingCapital;
            _accountsReceivable = accountsReceivable;
            _inventory = inventory;
            _accountsPayable = accountsPayable;
            _otherWorkingCapital = otherWorkingCapital;
            _otherNonCashItems = otherNonCashItems;
            _netCashFromOperations = netCashFromOperations;
            _investmentsInPropertyPlantAndEquipment = investmentsInPropertyPlantAndEquipment;
            _acquisitionsNet = acquisitionsNet;
            _purchasesOfInvestments = purchasesOfInvestments;
            _salesMaturitiesOfInvestments = salesMaturitiesOfInvestments;
            _otherInvestingActivities = otherInvestingActivities;
            _netCashFromInvestments = netCashFromInvestments;
            _debtRepayment = debtRepayment;
            _commonStockIssued = commonStockIssued;
            _commonStockRepurchased = commonStockRepurchased;
            _dividendsPaid = dividendsPaid;
            _otherFinancingActivities = otherFinancingActivities;
            _netCashFromFinancing = netCashFromFinancing;
            _effectOfForExOnCash = effectOfForExOnCash;
            _netChangeInCash = netChangeInCash;
            _cashBeginning = cashBeginning;
            _cashEnding = cashEnding;
            _operatingCashFlow = operatingCashFlow;
            _capitalExpenditure = capitalExpenditure;
            _freeCashFlow = freeCashFlow;
        }
        #endregion

        #region Properties
        public decimal? NetIncome { get => _netIncome; set => _netIncome = value; }
        public decimal? DepreciationAndAmortization { get => _depreciationAndAmortization; set => _depreciationAndAmortization = value; }
        public decimal? DeferredIncomeTax { get => _deferredIncomeTax; set => _deferredIncomeTax = value; }
        public decimal? StockBasedCompensation { get => _stockBasedCompensation; set => _stockBasedCompensation = value; }
        public decimal? ChangeInWorkingCapital { get => _changeInWorkingCapital; set => _changeInWorkingCapital = value; }
        public decimal? AccountsReceivable { get => _accountsReceivable; set => _accountsReceivable = value; }
        public decimal? Inventory { get => _inventory; set => _inventory = value; }
        public decimal? AccountsPayable { get => _accountsPayable; set => _accountsPayable = value; }
        public decimal? OtherWorkingCapital { get => _otherWorkingCapital; set => _otherWorkingCapital = value; }
        public decimal? OtherNonCashItems { get => _otherNonCashItems; set => _otherNonCashItems = value; }
        public decimal? NetCashFromOperations { get => _netCashFromOperations; set => _netCashFromOperations = value; }
        public decimal? InvestmentsInPropertyPlantAndEquipment { get => _investmentsInPropertyPlantAndEquipment; set => _investmentsInPropertyPlantAndEquipment = value; }
        public decimal? AcquisitionsNet { get => _acquisitionsNet; set => _acquisitionsNet = value; }
        public decimal? PurchasesOfInvestments { get => _purchasesOfInvestments; set => _purchasesOfInvestments = value; }
        public decimal? SalesMaturitiesOfInvestments { get => _salesMaturitiesOfInvestments; set => _salesMaturitiesOfInvestments = value; }
        public decimal? OtherInvestingActivities { get => _otherInvestingActivities; set => _otherInvestingActivities = value; }
        public decimal? NetCashFromInvestments { get => _netCashFromInvestments; set => _netCashFromInvestments = value; }
        public decimal? DebtRepayment { get => _debtRepayment; set => _debtRepayment = value; }
        public decimal? CommonStockIssued { get => _commonStockIssued; set => _commonStockIssued = value; }
        public decimal? CommonStockRepurchased { get => _commonStockRepurchased; set => _commonStockRepurchased = value; }
        public decimal? DividendsPaid { get => _dividendsPaid; set => _dividendsPaid = value; }
        public decimal? OtherFinancingActivities { get => _otherFinancingActivities; set => _otherFinancingActivities = value; }
        public decimal? NetCashFromFinancing { get => _netCashFromFinancing; set => _netCashFromFinancing = value; }
        public decimal? EffectOfForExOnCash { get => _effectOfForExOnCash; set => _effectOfForExOnCash = value; }
        public decimal? NetChangeInCash { get => _netChangeInCash; set => _netChangeInCash = value; }
        public decimal? CashBeginning { get => _cashBeginning; set => _cashBeginning = value; }
        public decimal? CashEnding { get => _cashEnding; set => _cashEnding = value; }
        public decimal? OperatingCashFlow { get => _operatingCashFlow; set => _operatingCashFlow = value; }
        public decimal? CapitalExpenditure { get => _capitalExpenditure; set => _capitalExpenditure = value; }
        public decimal? FreeCashFlow { get => _freeCashFlow; set => _freeCashFlow = value; }
        #endregion

        #region Methods
        public override CashFlowStatement EmptyStatement()
        {
            CashFlowStatement emptyStatement = new(/*
                NetIncome = 0,
                DepreciationAndAmortization = 0,
                DeferredIncomeTax = 0,
                StockBasedCompensation = 0,
                ChangeInWorkingCapital = 0,
                AccountsReceivable = 0,
                Inventory = 0,
                AccountsPayable = 0,
                OtherWorkingCapital = 0,
                OtherNonCashItems = 0,
                NetCashFromOperations = 0, 
                InvestmentsInPropertyPlantAndEquipment = 0,
                AcquisitionsNet = 0, 
                PurchasesOfInvestments = 0,
                SalesMaturitiesOfInvestments = 0,
                OtherInvestingActivities = 0,
                NetCashFromInvestments = 0,
                DebtRepayment = 0,
                CommonStockIssued = 0,
                CommonStockRepurchased = 0,
                DividendsPaid = 0,
                OtherFinancingActivities = 0,
                NetCashFromFinancing = 0,
                EffectOfForExOnCash = 0,
                NetChangeInCash = 0,
                CashBeginning = 0,
                CashEnding = 0,
                OperatingCashFlow = 0,
                CapitalExpenditure = 0,
                FreeCashFlow = 0 */);
            foreach(PropertyInfo propertyInfo in typeof(CashFlowStatement).GetProperties())
            {
                propertyInfo.SetValue(this, 0);
            }
            return emptyStatement;
        }
        #endregion
        
    }
}
