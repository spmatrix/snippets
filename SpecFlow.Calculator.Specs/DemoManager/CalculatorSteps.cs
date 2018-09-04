using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecFlow.Calculator.Core;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow.Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        CalculatorManager calculatorManger = new CalculatorManager();
        int result;      

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculatorManger.Number1 = p0;            
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calculatorManger.Number2 = p0;            
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           result = calculatorManger.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {           
            Assert.IsTrue(result == p0);
        }

    }
}
