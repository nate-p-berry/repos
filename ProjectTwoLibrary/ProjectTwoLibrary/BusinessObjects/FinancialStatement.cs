using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public abstract class FinancialStatement
    {
        public abstract FinancialStatement EmptyStatement();

        public string emptyStatementMessage = "Statement not found.";
    }
}
