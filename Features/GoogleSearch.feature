Feature: GoogleSearch
	Feature to test Google page search functionality
	Here we will test auto-search as well as navigating to search result

@SmokeTest
@Browser:Chrome
Scenario: Google Search for Execute Automation
	Given I have navigated to Google page
	And I see the Google page fully loaded
	When I type search keyword as
	| Keyword            |
	| execute automation |
	Then I should see the result for keyword
	| Keyword            |
	| Execute Automation |
