using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace TableAssistHelper.StepDefinitions
{
    [Binding]
    public class InstanceHelperMethodStepDefinitions
    {
        private class ProductQuantities
        {
            public string ProductID { get; set; }
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        private IEnumerable<ProductQuantities> _productQuantities = new List<ProductQuantities>();

        [Given(@"the example below with instance helper")]
        public void GivenTheExampleBelowWithInstanceHelper(Table table)
        {
            _productQuantities = table.CreateSet<ProductQuantities>();
        }

        [Then(@"valid this scenario with table assist helper")]
        public void ThenValidThisScenarioWithTableAssistHelper()
        {
            Assert.Equal(4, _productQuantities.Count());
        }
    }
}
