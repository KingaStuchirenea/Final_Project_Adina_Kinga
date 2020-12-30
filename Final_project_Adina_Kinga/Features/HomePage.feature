Feature: HomePage
	In order to send request to customer care
	As a user
	I want to be told if the message is registered or not

@CustomerCareRequestSent
Scenario: Sent request to customer care
	Given User populates Customer Care Form
	When clicking on Send to customer care button
	Then message is registered

@CustomerCareRequestNotSent
Scenario: Request to customer care NOT sent
	Given User populates partially Customer Care Form
	When click on Send to customer care button
	Then warning message appears

