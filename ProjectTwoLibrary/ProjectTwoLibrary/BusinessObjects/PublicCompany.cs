using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    internal class PublicCompany : Company
    {
        private DateTime _date;
        private string _symbol;
        private decimal? _cik;
        private DateTime? _filingDate;
        private DateTime? _acceptedDate;
        private decimal? _calendarYear;
        private string? _period;
        private decimal? _sharePrice;

        public PublicCompany() { }
        public PublicCompany(string symbol) { _symbol = symbol; }
        public PublicCompany(DateTime date, string symbol, decimal? cik, DateTime? filingDate, DateTime? acceptedDate, decimal? calendarYear, string? period, decimal? sharePrice)
        {
            _date = date;
            _symbol = symbol;
            _cik = cik;
            _filingDate = filingDate;
            _acceptedDate = acceptedDate;
            _calendarYear = calendarYear;
            _period = period;
            _sharePrice = sharePrice;
        }

        public DateTime Date { get => _date; set => _date = value; }
        public string Symbol { get => _symbol; set => _symbol = value; }
        public decimal? Cik { get => _cik; set => _cik = value; }
        public DateTime? FilingDate { get => _filingDate; set => _filingDate = value; }
        public DateTime? AcceptedDate { get => _acceptedDate; set => _acceptedDate = value; }
        public decimal? CalendarYear { get => _calendarYear; set => _calendarYear = value; }
        public string? Period { get => _period; set => _period = value; }
        public decimal? SharePrice { get => _sharePrice; set => _sharePrice = value; }
    }
}
