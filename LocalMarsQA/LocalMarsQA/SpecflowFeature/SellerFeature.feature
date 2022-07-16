Feature: SellerFeature

As seller need to add profile to be found.

@Seller
Scenario: Seller profile addition
	Given I login as existing seller
	When I add new language details in profile page
	#Then I verify the details added sucessfully