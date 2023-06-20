using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace TableAssistHelper.StepDefinitions
{
    [Binding]
    public class HelperCompareToInstanceStepDefinitions
    {
        private class ProductQuantities
        {
            public string ProductID { get; set; }
            [TableAliases("Stock")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        private ProductQuantities _product;

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            _product = table.CreateInstance<ProductQuantities>();
        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            _product.Basket++;
            _product.StockQty--;
        }

        [Then(@"usgin the first approach, the quantities are")]
        public void ThenUsginTheFirstApproachTheQuantitiesAre(Table table)
        {
            Assert.Equal(int.Parse(table.Rows[0]["StockQty"]), _product.StockQty);
            Assert.Equal(int.Parse(table.Rows[0]["Basket"]), _product.Basket);
        }

        [Then(@"usgin the second approach, the quantities are")]
        public void ThenUsginTheSecondApproachTheQuantitiesAre(Table table)
        {
            var comparison = table.CreateInstance<ProductQuantities>();
            Assert.Equal(comparison.StockQty, _product.StockQty);
            Assert.Equal(comparison.Basket, _product.Basket);
        }

        [Then(@"usgin the thirdy approach, the quantities are")]
        public void ThenUsginTheThirdyApproachTheQuantitiesAre(Table table)
        {
            var comparison = new ProductQuantities();
            comparison.ProductID = _product.ProductID;
            table.FillInstance(comparison);
            Assert.Equal(comparison.StockQty, _product.StockQty);
            Assert.Equal(comparison.Basket, _product.Basket);
        }

        [Then(@"usgin the FINAL approach, the quantities are")]
        public void ThenUsginTheFourthApproachTheQuantitiesAre(Table table)
        {
            table.CompareToInstance(_product);
        }


        [Then(@"a message '([^']*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {
            //throw new PendingStepException();
        }
    }
}
