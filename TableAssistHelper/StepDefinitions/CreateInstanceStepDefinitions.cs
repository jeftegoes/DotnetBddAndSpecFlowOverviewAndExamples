using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace TableAssistHelper.StepDefinitions
{
    [Binding]
    public class CreateInstanceStepDefinitions
    {
        private class ProductQuantities
        {
            public string ProductID { get; set; }
            [TableAliases("Reserved Qty", "Internal Qty")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        private ProductQuantities _product { get; set; }

        [Given(@"the example below to create an instance")]
        public void GivenTheExampleBelowToCreateAnInstance(Table table)
        {
            _product = table.CreateInstance<ProductQuantities>();
        }

        [Then(@"valid values this scenario")]
        public void ThenValidValuesThisScenario()
        {
            Assert.Equal("1", _product.ProductID);
            Assert.Equal(2, _product.StockQty);
            Assert.Equal(0, _product.Basket);
        }
    }
}
