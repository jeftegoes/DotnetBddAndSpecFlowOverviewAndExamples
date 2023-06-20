Feature: HelperCompareToInstance

Scenario: Customer can add product to basket
	Given I have the following data
		| Field     | Value |
		| ProductId | 1     |
		| StockQty  | 2     |
		| Basket    | 0     |
	When I click the Add to Basket button
	Then usgin the first approach, the quantities are
		| StockQty | Basket |
		| 1        | 1      |
	Then usgin the second approach, the quantities are
		| StockQty | Basket |
		| 1        | 1      |
	Then usgin the thirdy approach, the quantities are
		| StockQty | Basket |
		| 1        | 1      |
	Then usgin the FINAL approach, the quantities are
		| StockQty | Basket |
		| 1        | 1      |
	And a message 'Added to basket' is displayed to the customer