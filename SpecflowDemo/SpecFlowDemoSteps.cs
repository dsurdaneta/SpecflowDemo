using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecflowDemo
{
    [Binding]
    public sealed class SpecFlowDemoSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int firstNumber)
        {
            ScenarioContext.Current.Add("firstNumber", firstNumber);
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int secondNumber)
        {
            ScenarioContext.Current.Add("secondNumber", secondNumber);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            int firstNumber = ScenarioContext.Current.Get<int>("firstNumber");
            int secondNumber = ScenarioContext.Current.Get<int>("secondNumber");

            ScenarioContext.Current.Add("expectedResultNumber", firstNumber + secondNumber);
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            int expectedResultNumber = ScenarioContext.Current.Get<int>("expectedResultNumber");
            Assert.AreEqual(expectedResultNumber, result);
        }
    }
}
