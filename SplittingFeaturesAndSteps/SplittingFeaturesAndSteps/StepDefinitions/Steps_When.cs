namespace SplittingFeaturesAndSteps.StepDefinitions
{
    public partial class MyStepDefinition
    {
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _calculator.Result = _calculator.Sum();
        }
    }
}
