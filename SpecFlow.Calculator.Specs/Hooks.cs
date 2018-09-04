using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow.Calculator.Specs
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var _driver = ScenarioContext.Current.ContainsKey("_driver")? ScenarioContext.Current["_driver"] :null;
            if (_driver != null)
            {
                var driver = _driver as IWebDriver;
                driver.Close();
                driver.Dispose();
            }
        }
    }
}
