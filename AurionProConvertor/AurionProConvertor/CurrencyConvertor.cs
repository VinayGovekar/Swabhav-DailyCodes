using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace AurionProConvertor
{
    public static class CurrencyConvertor
    {
        public static Dictionary<string, string> GetApiResponse(string from)
        {
            string path = "https://freecurrencyapi.net/api/v2/latest?apikey=c82228a0-38d2-11ec-967e-03a05098f525&base_currency="+from;
            var client = new HttpClient();
            var result = client.GetAsync(path);
            string jsonString = result.Result.Content.ReadAsStringAsync().Result;
            dynamic json = JObject.Parse(jsonString);
            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(System.Convert.ToString(json.data));
            //Console.WriteLine(json.data);
            return values;
        }

        public static double Convert(double amount, string from, string currency)
        {
            Dictionary<string, string> values = GetApiResponse(from);
            double result = System.Convert.ToDouble(values[currency]) * amount;
            return result;
        }
    }
}
