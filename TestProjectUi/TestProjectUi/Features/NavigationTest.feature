Feature: Navigations

In order to Navigate to site
	As a user
	I want to be able to navigate to different pages

@SmokeTest
Scenario Outline: Verify that user can navigate to Basket page
	Given I navigate to Bjss site
	When I choose navigate to the '<PageName>' page
	Then I should see the '<PageName>' page displayed
Scenarios:
		| PageName |
		| careers   |