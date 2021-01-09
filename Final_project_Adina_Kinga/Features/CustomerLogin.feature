Feature: CustomerLogin
	In order to access all the services Parbank provides
	As a user
	I want to be able to register and login

@RegisterAccount
Scenario: Register New Account
	Given I navigate to Register Page
	When I populate the registration form
	Then a welcome message is displayed

@Login
Scenario: Success Login
	Given I populate the correct login credentials
	When I click the login button
	Then an Account Services menu is displayed in the left hand side

Scenario: Forgot Login Info
	Given I navigate to Forgot Login Info Page
	When I populate the Customer Lookup Form
		And I click the Find My Login Info button
	Then an error message is displayed

@Logout
Scenario: User Logout
	Given I login to Parabank website
	When I click the logout button
	Then the Register button is displayed