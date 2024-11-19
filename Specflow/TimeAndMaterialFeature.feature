Feature: TimeAndMaterialFeature

As a TurnUp portal admin user
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

Background:
	Given I logged into Turnup portal successfully
	When I navigate to Time and Material Page

@regression @bvt
Scenario: Create Time/Material record with valid data
	And I create a new Time record
	Then the record should be created successfully

Scenario Outline: edit existing time record with valid data
	When I update the '<Code>', '<Description>' and '<Price>' on an existing Time record
	Then the record should have the updated '<Code>', '<Description>' and '<Price>'

Examples:
	| Code             | Description | Price |
	| Industry Connect | test 1      | 13    |
	| TA Job Ready     | test 2      | 5     |
	| EditedRecord     | test 3      | 7     |

@regression @bvt
Scenario: Delete Time/Material record
	And I delete an existing Time/Material record
	Then the record should be deleted successfully