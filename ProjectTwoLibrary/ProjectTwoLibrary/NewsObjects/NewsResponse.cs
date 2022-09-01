using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoLibrary.NewsObjects
{
    public class NewsResponse
    {
        private string _status;
        private bool _statusAsBool;
        private int _totalResults;
        private Article[] _articles;

        public string Status { get => _status; set => _status = value; }
        public bool StatusAsBool { get => _statusAsBool; set => _statusAsBool = value; }
        public int TotalResults { get => _totalResults; set => _totalResults = value; }
        internal Article[] Articles { get => _articles; set => _articles = value; }

        public NewsResponse EmptyResponse()
        {
            NewsResponse newsResponse = new();
            foreach(PropertyInfo propertyInfo in typeof(NewsResponse).GetProperties())
            {
                propertyInfo.SetValue(this, null);
            }
            return newsResponse;
        }
    }
}
