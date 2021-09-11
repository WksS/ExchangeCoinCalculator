using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExchangeCalculator.Handler
{
    class ExchangeHandler
    {
        public static async Task<string> GetExchangeRate(string from)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://economia.awesomeapi.com.br");
                    var response = await client.GetAsync($"/last/{from}-BRL");
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    JObject jsonJObject = JObject.Parse(jsonResult);
                    string bid = (string)jsonJObject.SelectToken($"{from}BRL.bid");
                    if (bid == null)
                    {
                        return "Could not return API values!";
                    }

                    if (bid.Contains("."))
                    {
                        return bid.Replace(".", ",");
                    }

                    return bid;
                }
                catch (HttpRequestException exception)
                {
                    return $"Error calling API. Please do manual lookup! Error: {exception.Message}";
                }
                catch (Exception exception)
                {
                    return $"Some error occurred while call values from API. Error: {exception.Message}";
                }
            }
        }
    }
}
