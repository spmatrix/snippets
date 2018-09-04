Feature: CalculatorSelenium
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers using calculator web
	Given I have entered 50 into number1 textbox
	And I have also entered 70 into number2 textbox
	When I press add button
	Then the result label should display 120 
