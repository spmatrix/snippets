using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlow.Calculator.Specs
{

    [Binding]
    public class CalculatorSeleniumSteps
    {
        private IWebDriver _driver;

        public CalculatorSeleniumSteps()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            _driver = new ChromeDriver(chromeOptions);            
            _driver.Navigate().GoToUrl("http://localhost:54151/Calculator.html");
            ScenarioContext.Current.Add("_driver", _driver);
        }

        [Given(@"I have entered (.*) into number1 textbox")]
        public void GivenIHaveEnteredIntoNumberTextbox(int p0)
        {
            var txtBox1 = _driver.FindElement(By.Name("txtNumber1"));
            txtBox1.SendKeys("10");
            txtBox1.Click();
        }
        
        [Given(@"I have also entered (.*) into number2 textbox")]
        public void GivenIHaveAlsoEnteredIntoNumberTextbox(int p0)
        {
            var txtBox2 = _driver.FindElement(By.Name("txtNumber2"));
            txtBox2.SendKeys("10");
            txtBox2.Click();
        }
        
        [When(@"I press add button")]
        public void WhenIPressAddButton()
        {
            var btnAdd = _driver.FindElement(By.Name("btnAdd"));
            btnAdd.Click();
        }
        
        [Then(@"the result label should display (.*)")]
        public void ThenTheResultLabelShouldDisplay(int p0)
        {
            var lblResult = _driver.FindElement(By.Id("lblResult"));
            Assert.AreEqual(lblResult.Text, "20");
        }
    }
}
