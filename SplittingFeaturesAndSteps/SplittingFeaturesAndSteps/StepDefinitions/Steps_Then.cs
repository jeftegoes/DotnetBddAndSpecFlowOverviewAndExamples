namespace SplittingFeaturesAndSteps.StepDefinitions
{
    public partial class MyStepDefinition
    {
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.Equal(result, _calculator.Result);
        }
    }
}
