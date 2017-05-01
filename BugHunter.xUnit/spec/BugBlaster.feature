Feature: BugBlaster
	In order to avoid being overrun by bus
	As a space marine
	I want to be able to blast bugs

@mytag
Scenario: Blast a bug
	Given I have a raygun
	And I have at least 1 charge
	And I have a stationary target bug
	When I fire at the bug
	Then the result should be a dead bug
