Feature: Product
	In order to view or try products
	As a user
	I want to see all products and to be able to open them

@CheckAllProductsAreDisplayed
Scenario: Check that 9 products are displayed
	Given user navigates to product page
	When opens dropdown
	Then 9 products should be displayed