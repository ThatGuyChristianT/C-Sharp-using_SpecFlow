Feature: tcGoogleSearch
		Simple google search

@Browser:Chrome
Scenario: Add two numbers
	Given I navigate to website "https://www.google.com"
	Then I see Google page is loaded
	When I enter "" on searchbox
	And click on Search
	#Add step here 