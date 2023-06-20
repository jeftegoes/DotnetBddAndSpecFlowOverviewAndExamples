using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace TableAssistHelper.StepDefinitions
{
    [Binding]
    public class HelperCompareToSetStepDefinitions
    {
        private class ProductQuantities
        {
            [TableAliases("Product ID")]
            public string ProductID { get; set; }
            [TableAliases("Stock Qty")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        private IEnumerable<ProductQuantities> _productWithQuantities;
        private ProductQuantities _product;

        [Given(@"I have the following data using CompareToSet")]
        public void GivenIHaveTheFollowingDataUsingCompareToSet(Table table)
        {
            _productWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            _product = _productWithQuantities.FirstOrDefault(c => c.ProductID == productId);
        }

        [When(@"I click the Add to Basket button using CompareToSet")]
        public void WhenIClickTheAddToBasketButtonUsingCompareToSet()
        {
            if (_product.StockQty > 0 && _product.Basket == 0)
            {
                _product.Basket++;
                _product.StockQty--;
            }
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = _productWithQuantities.Where(t => t.ProductID == _product.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }

        [Then(@"a message '([^']*)' is displayed to the customer using CompareToSet")]
        public void ThenAMessageIsDisplayedToTheCustomerUsingCompareToSet(string p0)
        {

        }
    }
}
