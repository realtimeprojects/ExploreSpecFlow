Feature: 001-my-first-feature
	Das ist mein erster Testcase,
	um einmal auszuprobieren, wie gut
	SpecFlow eigentlich funktioniert.

@mytag
Scenario: Add two numbers
	Given this is my first step

Scenario: Second scenario
	Given I store 50 in my test
	Then the stored value shall be 50

Scenario: Third scenario
	Given I store 50 in my test
	Then the stored value shall be 51

Scenario: CalculatorTest1
	Given I have entered 50 into the calculator
	And I have entered 20 into the calculator
	When I press Add
	Then I want to see 70

Scenario: CalculatorTest2
	Given I have entered 22 into the calculator
	And I have entered 47 into the calculator
	When I press Add
	Then I want to see 69
	Then I have entered 3 into the calculator
	Then I press Divide
	Then I want to see 23

Scenario: NegativTest
	Given I have entered 22 into the calculator
	And I have entered 0 into the calculator
	When I press Divide
	
	

