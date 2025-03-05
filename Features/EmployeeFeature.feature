Feature: EmployeeFeature

As a TurnUp portal admin user
I would like to create, edit and delete employees
So that I can manage employees successfully

Background: 
	Given I logged into Turnup portal successfully
	When I navigate to Employee Page

@regression @employeetests
Scenario: Create new Employee record with valid data
	And I create a new Employee record
	Then the employee record should be created successfully