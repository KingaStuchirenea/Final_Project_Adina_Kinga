Feature: AccountServices
	In order to do actions inside an account
	As a user
	I want to be told the result of my actions

@OpenSavingsAccount
Scenario: Open Savings Account
	Given logged in with valid user
	And navigate to open new account
	When choosing to open savings account
	Then the account is created

@RequestALoan
Scenario: Apply for a Loan
	Given I am logged in with valid user
		And I navigate to request loan page
	When filling in requested details
		And clicking Apply Now button
	Then a confirmation table message is displayed
