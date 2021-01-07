Feature: Product
	In order to view or try products
	As a user
	I want to see all products and to be able to try them

@CheckProducts
Scenario: Check that 9 products are displayed
	Given user navigates to product page
	When opens dropdown
	Then 9 products should be displayed

@TryParasoftJtestForm
Scenario: Try Parasoft Jtest form sent
	Given user navigates to Parasoft Jtest page
	When populates request for trial form
		And sends request
	Then request is registered

Scenario: Try Parasoft Jtest form NOT sent
	Given user navigates to Jtest page
	When populates request for trial form partially
		And sends the request
	Then request is NOT registered