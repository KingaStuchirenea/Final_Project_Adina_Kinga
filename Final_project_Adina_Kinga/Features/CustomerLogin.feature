Feature: CustomerLogin
	In order to access all the services Parbank provides
	As a user
	I want to be able to register and login

@RegisterAccount
Scenario: Register New Account
	Given I navigate to Register Page
	When I populate the registration form
		And populate account login details
	Then a welcome message is displayed

@Login
Scenario: Success Login

Scenario: Fail Login

Scenario: Forgot Login Info

@Logout
Scenario: User Logout