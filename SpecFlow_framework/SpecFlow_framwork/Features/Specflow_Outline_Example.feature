Feature: Specflow_Outline_Example
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario Outline: Create new Specflow outline sample
	Given I have new page
	And I add <Name>, <Age>, <BVC> into new feature
	Then New feature created
Examples: 
| Name | Age | BVC |
| Dung | 20  | GHN |
| Du   | 20  | BVV |