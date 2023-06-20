namespace TableAssistHelper.StepDefinitions
{
    [Binding]
    public class WithoutTableAssistHelperStepDefinitions
    {
        private class ProductQuantities
        {
            public string ProductID { get; set; }
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        private List<ProductQuantities> productQuantities = new List<ProductQuantities>();

        [Given(@"the example below")]
        public void GivenTheExampleBelow(Table table)
        {
            for (var row = 0; row < table.Rows.Count; row++)
            {
                var product = table.Rows[row];
                productQuantities.Add(new ProductQuantities()
                {
                    ProductID = product["Product"],
                    StockQty = int.Parse(product["Stock"]),
                    Basket = int.Parse(product["Basket"])
                });
            }
        }

        [Then(@"valid this scenario without table assist helper")]
        public void ThenValidThisScenarioWithoutTableAssistantHelper()
        {
            Assert.Equal(4, productQuantities.Count);
        }
    }
}
