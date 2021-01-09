Feature: HomePage
	In order to send customer care request / Initialize, clean DB
	As a user / as an admin
	I want to be notified if the action is done or not

@CustomerCareRequests
Scenario: Request to customer care sent
	Given User populates Customer Care Form
	When clicking on Send to customer care button
	Then message is registered

Scenario: Request to customer care NOT sent
	Given User populates partially Customer Care Form
	When click on Send to customer care button
	Then warning message appears

@InitializeCleanDatabaseAsAdmin
Scenario: As admin initialize the database
Given User navigates to Admin page
When clicks on initialize button
Then database is initialized

Scenario: As admin clean the database
Given User navigates to Admin page
When clicks on clean button
Then database is cleaned

@CheckPages
Scenario: Check Pages load properly
	Given I click on all the welcome to Parabank Icons
	Then all the pages load properly