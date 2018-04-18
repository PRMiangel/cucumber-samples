using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Spec.Steps
{
    using TechTalk.SpecFlow;
    using AUT;

    [Binding]
    public sealed class StepDefinitions
    {
        private Calculator calculator;
        private int result;

        [Given("I open the calculator")]
        public void GivenIOpenTheCalculator()
        {
            calculator = new Calculator();
        }

        [When("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            calculator.AddNumber(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [When("I press subtraction")]
        public void WhenIPressSubtraction()
        {
            result = calculator.Subtraction();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result, "The result isn't correct.");
        }
    }
}
