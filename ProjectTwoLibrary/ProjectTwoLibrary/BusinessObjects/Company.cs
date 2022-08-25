using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoMSSA.BusinessData
{
    internal abstract class Company
    {
        private string _name;
        private BalanceSheet _balanceSheet;
        private IncomeStatement _incomeStatement;
        private CashFlowStatement _cashFlowStatement;
        private Enum _currencyDenomination;
        private string? _link;
        private string? _finalLink;

        public string Name { get => _name; set => _name = value; }
        public string Link { get => _link; set => _link = value; }
        public string FinalLink { get => _finalLink; set => _finalLink = value; }
        internal BalanceSheet BalanceSheet { get => _balanceSheet; set => _balanceSheet = value; }
        internal IncomeStatement IncomeStatement { get => _incomeStatement; set => _incomeStatement = value; }
        internal CashFlowStatement CashFlowStatement { get => _cashFlowStatement; set => _cashFlowStatement = value; }
    }
}
