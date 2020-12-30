Feature: HomePage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@CustomerCareRequest
Scenario: Sent request to customer care
	Given User populates Customer Care Form
	When clicking on Send to customer care button
	Then message is registered