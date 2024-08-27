Feature: TimeAndMaterialFeature

A short summary of the feature

@tag1
Scenario: Create Time/Material record with valid data
	Given I logged into Turnup portal successfully
	When I navigate to Time and Material Page
	And I create a new Time record
	Then the record should be created successfully
