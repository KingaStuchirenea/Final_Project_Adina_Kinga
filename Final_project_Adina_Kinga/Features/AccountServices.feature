﻿Feature: AccountServices
	In order to do actions inside an account
	As a user
	I want to be told the result of my actions

@OpenSavingsAccount
Scenario: Open Savings Account
	Given logged in with valid user
	And navigate to open new account
	When choosing to open savings account
	Then the account is created

@TransferFunds
Scenario: Transfer funds
	Given logged in with valid user
	And navigate to transfer funds
	When transfering the inserted amount
	Then the tranfer is done

@RequestALoan
Scenario: Apply for a Loan
	Given I am logged in with valid user
		And I navigate to request loan page
	When filling in requested details
		And clicking Apply Now button
	Then a confirmation table message is displayed

@UpdateContactInfo
Scenario: Update user's contact info
	Given I am logged in with valid user
		And I navigate to Update Contact Info page
	When filling the updated information fields
		And clicking Update Contact Info button
	Then a confirmation message is shown