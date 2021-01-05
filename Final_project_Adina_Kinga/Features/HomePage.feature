Feature: HomePage
	In order to send request to customer care
	As a user
	I want to be told if the message is registered or not

@CustomerCareRequests
Scenario: Request to customer care sent
	Given User populates Customer Care Form
	When clicking on Send to customer care button
	Then message is registered

Scenario: Request to customer care NOT sent
	Given User populates partially Customer Care Form
	When click on Send to customer care button
	Then warning message appears

