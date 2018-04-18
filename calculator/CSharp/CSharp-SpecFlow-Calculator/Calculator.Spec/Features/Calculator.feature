Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I open the calculator
	When I have entered 50 into the calculator
		And I have entered 70 into the calculator
		And I press add
	Then the result should be 120 on the screen

Scenario: Subtract two numbers
	Given I open the calculator
	When I have entered 70 into the calculator
		And I have entered 50 into the calculator
		And I press subtraction
	Then the result should be 20 on the screen