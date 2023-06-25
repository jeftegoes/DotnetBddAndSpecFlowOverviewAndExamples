namespace SplittingFeaturesAndSteps.StepDefinitions
{
    [Binding]
    public partial class MyStepDefinition
    {
        private readonly Calculator _calculator;

        public MyStepDefinition(Calculator calculator)
        {
            _calculator = calculator;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }
    }
}
