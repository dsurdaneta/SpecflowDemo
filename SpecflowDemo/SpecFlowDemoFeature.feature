Feature: SpecFlowDemoFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Demo001_Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@mytag
Scenario Outline: Demo002_Add two numbers Outline
	Given I have entered <FirstNumber> into the calculator
	And I have also entered <SecondNumber> into the calculator
	When I press add
	Then the result should be <ResultNumber> on the screen
Examples: 
	| FirstNumber | SecondNumber | ResultNumber |
	| 7			  | 8			 | 15			|
	| 500		  | 1250		 | 1750			|
	| 39		  | 2			 | 41			|
	