Feature: CreateInstance

Scenario: Test with table assist helper
	# This is the vertical table style
	Given the example below to create an instance
		| Field     | Value |
		| ProductId | 1     |
		| StockQty  | 2     |
		| Basket    | 0     |
	Then valid values this scenario