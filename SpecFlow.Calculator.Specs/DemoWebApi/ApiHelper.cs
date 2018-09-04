using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Calculator.Specs.DemoWebApi
{
    public class ApiHelper
    {

        public static async Task<int> GetCalculatedValue(int number1, int number2)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                   { "Number1", number1.ToString() },
                   { "Number2", number2.ToString() }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await httpClient.PostAsync("http://localhost:57334/api/Calculator", content);
                var responseString = await response.Content.ReadAsStringAsync();
                return Convert.ToInt32(responseString);
            }
        }
    }
}
