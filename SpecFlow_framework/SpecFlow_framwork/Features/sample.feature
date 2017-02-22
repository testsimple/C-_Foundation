Feature: sample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	And I want to see
	| Age | Name | BVC |
	| 12  | DUng | DBN |
	| 12  | Du   | ABV |
	Then the result should be 120 on the screen
