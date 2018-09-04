Feature: CalculatorApi
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers using Calculator Web Api
	Given I have entered 50 into the calculator api
	And I have also entered 70 into the calculator api
	When I submit the  request
	Then the api result should be 120
