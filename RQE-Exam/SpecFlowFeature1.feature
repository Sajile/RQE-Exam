Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of a trigonometric function

@mytag
Scenario: The Sinus Function
	Given the first number is PI
	And the chosen function is sinus
	When this combinatin is choosen
	Then the result should be 0

Scenario: The Cosinus Function
	Given the first number is PI
	And the chosen function is cosinus
	When this combinatin is choosen
	Then the result should be -1

Scenario: The Tangens Function
	Given the first number is PI
	And the chosen function is tangens
	When this combinatin is choosen
	Then the result should be 0