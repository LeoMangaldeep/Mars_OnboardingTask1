Feature: SellerFeature

As seller need to add profile to be found.

@Seller
Scenario: Seller profile addition
	Given I login as existing seller
	When I add new '<language>','<level>' details in profile page
	Then the record should have updated '<language>','<level>'

	Examples: 
	| language | level            |
	| Arabic   | Basic            |
	| Sou      | Conversational   |
	| Tamil    | Fluent           |
	| Roja     | Native/Bilingual |