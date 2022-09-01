using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using System.Net.Http;
using ProjectTwoLibrary;
using BusinessObjects;

namespace ProjectTwo.ViewModels
{
    [ApiController] 
    internal class FinModPrepAPIController : ApiController
    {
        public static HttpClient fmpClient = new() { Timeout = TimeSpan.FromSeconds(45) };
        
        public static Uri baseAddress = new("https://financialmodelingprep.com/api/v3/");

        public static string apiKey = "65e4f4db8384062431460136af38c05f";

        public static async Task<BalanceSheet> GetBalanceSheet(string tickerSymbol)
        {
            BalanceSheet balanceSheet = new();
            Uri balanceSheetUri = new($"{baseAddress}balance-sheet-statement/{tickerSymbol.ToUpperInvariant()}?limit=120&apikey={apiKey}");
            try
            {
                await fmpClient.GetAsync(balanceSheetUri).ContinueWith((responseTask) =>
                {
                    var response = responseTask.Result;
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var balanceSheet = Newtonsoft.Json.JsonConvert.DeserializeObject<BalanceSheet>(jsonString.Result);
                    return balanceSheet;
                });
            }
            catch (System.Exception)
            {
                balanceSheet = balanceSheet.EmptyStatement();
            }
            return balanceSheet;
        }
        public static async Task<BalanceSheet> GetBalanceSheetAsync(string tickerSymbol)
        {
            return await GetBalanceSheet(tickerSymbol);
        }

        public static async Task<CashFlowStatement> GetCashFlowStatement(string tickerSymbol)
        {
            CashFlowStatement cashFlowStatement = new();
            Uri cashFlowStatementUri = new($"{baseAddress}cash-flow-statement/{tickerSymbol.ToUpperInvariant()}?limit=120&apikey={apiKey}");
            try
            {
                await fmpClient.GetAsync(cashFlowStatementUri).ContinueWith((responseTask) =>
        {
            var response = responseTask.Result;
            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            var cashFlowStatement = Newtonsoft.Json.JsonConvert.DeserializeObject<CashFlowStatement>(jsonString.Result);
            return cashFlowStatement;
        });
            }
            catch (System.Exception)
            {
                cashFlowStatement = cashFlowStatement.EmptyStatement();
            }
            return cashFlowStatement;
        }
        public static async Task<CashFlowStatement> GetFlowStatementAsync(string tickerSymbol)
        {
            return await GetFlowStatementAsync(tickerSymbol);
        }
        
        public static async Task<IncomeStatement> GetIncomeStatement(string tickerSymbol)
        {
            IncomeStatement incomeStatement = new();
            Uri incomeStatementUri = new($"{baseAddress}income-statement/{tickerSymbol.ToUpperInvariant()}?limit=120&apikey={apiKey}");
            try
            {
                await fmpClient.GetAsync(incomeStatementUri).ContinueWith((responseTask) =>
                {
                    var response = responseTask.Result;
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    incomeStatement = Newtonsoft.Json.JsonConvert.DeserializeObject<IncomeStatement>(jsonString.Result);
                });
            }
            catch (System.Exception)
            {
                incomeStatement = incomeStatement.EmptyStatement();
                throw;
            }
            return incomeStatement;
        }
        public static async Task<IncomeStatement> GetIncomeStatementAsync(string tickerSymbol)
        {
            return await GetIncomeStatement(tickerSymbol);
        }
    }
}
