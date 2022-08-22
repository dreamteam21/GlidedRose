Feature: UpdateItem
	Update item SellIn property

@mytag
Scenario: Decrease SellIn property for an item
	Given the item SellIn is 10
	When the day is passed
	Then the item SellIn should be 9