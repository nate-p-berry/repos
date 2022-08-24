using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoMSSA.OpenAPIs.FMPHandler
{
    internal class APIAccessorBalanceSheet
    {
        HttpClient balanceSheetHttpClient = new();
        public async Task GetBalanceSheet(string requestBase, string ticker, string apiKey) 
        {
            HttpRequestMessage balanceSheetRequest = new HttpRequestMessage(new HttpMethod("GET"), $"{requestBase}/income-statement/{ticker}?apikey={apiKey}");
            balanceSheetRequest.Headers.TryAddWithoutValidation("Upgrade-Insecure-Requests", "1");

            var response = await balanceSheetHttpClient.SendAsync(balanceSheetRequest);

            if (response.IsSuccessStatusCode)
            {

            }

            return;
        }
    }
}
