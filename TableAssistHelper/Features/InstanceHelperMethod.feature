Feature: InstanceHelperMethod

Scenario: Test with table assist helper
	Given the example below with instance helper
		| Product ID | Reserved Qty | Basket |
		| 1          | 2            | 0      |
		| 2          | 0            | 0      |
		| 3          | 2            | 1      |
		| 4          | 5            | 1      |
	Then valid this scenario with table assist helper