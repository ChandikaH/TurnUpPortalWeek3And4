Feature: TMFeature

As a Turnup portal admin user
I would like to create, edit and delete time and material records
So that I can manage the employee time and materials successfully

@regression @bvt @timeandmaterial
Scenario: Create new time and material record with valid data
	Given I logged into TurnUp portal successfully
	And I navigate to the Time and Material page
	When I create a new time and material record
	Then the record should be created successfully
