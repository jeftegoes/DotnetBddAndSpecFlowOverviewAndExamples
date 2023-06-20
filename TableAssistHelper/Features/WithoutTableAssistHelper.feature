Feature: WithoutTableAssistHelper

Scenario: Test without table assist helper
	Given the example below
		| Product | Stock | Basket |
		| 1       | 2     | 0      |
		| 2       | 0     | 0      |
		| 3       | 2     | 1      |
		| 4       | 5     | 1      |
	Then valid this scenario without table assist helper