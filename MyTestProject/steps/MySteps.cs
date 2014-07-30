using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace MyTestProject.steps
{
    [Binding]
    public class MySteps
    {
        [AfterFeature]
        public static void Feierabend()
        {
            Debug.WriteLine("Feierabend!");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Debug.WriteLine("Hallo Welt");
        }

        [StepDefinition(@"this is my first step")]
        public void GivenThisIsMyFirstStep()
        {
            Assert.Fail("Dieser Test schlägt immer fehl");
        }

        [Given(@"I store (.*) in my test")]
        public void GivenIStoreInMyTest(int p0)
        {
            value = p0;
        }

        [Then(@"the stored value shall be (.*)")]
        public void ThenTheStoredValueShallBe(int p0)
        {
            Assert.AreEqual(p0, value, "Erwartungswert nicht getroffen:" + p0);
        }


        [BeforeScenario]
        public static void InitCalculator()
        {
            testCalculator = new SimpleCalculator();
        }

        [StepDefinition(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0)
        {
            testCalculator.Enter(p0);
        }

        [StepDefinition(@"I press (.*)")]
        public void WhenIPressAdd(string op)
        {
            switch (op)
            {
                case "Add": testCalculator.Enter("+"); break;
                case "Divide": testCalculator.Enter("/"); break;
                default: Assert.Fail("Unknown operator: " + op); break;
            }
        }

        [StepDefinition(@"I want to see (.*)")]
        public void ThenIWantToSee(Int16 p0)
        {
            Assert.AreEqual(p0, testCalculator.Result);
        }

        static SimpleCalculator testCalculator;
        int value;
    }
}
