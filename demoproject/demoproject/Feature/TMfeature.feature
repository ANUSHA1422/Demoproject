Feature: TMfeature

A short summary of the feature

@tag1
Scenario: create time and material record with valid credentials
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And I created new time and material record
	Then The record should be created successfully
