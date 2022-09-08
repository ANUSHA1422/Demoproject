Feature: TMfeature

A short summary of the feature

@tag1
Scenario: Create time and material record with valid credentials
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And I created new time and material record
	Then The record should be created successfully

Scenario Outline: Edit time and material record with valid credentials
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And  I upadte '<Description>' on an existing time and materail record
	Then The record should have the updated '<Description>'

Examples: 
| Description |
|  Time       |
|  Material   |
|  abc        |