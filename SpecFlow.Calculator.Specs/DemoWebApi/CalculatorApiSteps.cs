using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace SpecFlow.Calculator.Specs.DemoWebApi
{
    [Binding]
    public class CalculatorApiSteps
    {
        private readonly HttpClient client;
        int number1;
        int number2;
        int result;

        public CalculatorApiSteps()
        {
            client = new HttpClient();
        }

        [Given(@"I have entered (.*) into the calculator api")]
        public void GivenIHaveEnteredIntoTheCalculatorApi(int p0)
        {
            number1 = p0;
        }

        [Given(@"I have also entered (.*) into the calculator api")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorApi(int p0)
        {
            number2 = p0;
        }

        [When(@"I submit the  request")]
        public void WhenISubmitTheRequest()
        {
            result = ApiHelper.GetCalculatedValue(number1, number2).Result;
        }
        
        [Then(@"the api result should be (.*)")]
        public void ThenTheApiResultShouldBe(int p0)
        {
            Assert.IsTrue(result == p0);
        }
    }
}
