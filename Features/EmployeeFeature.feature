Feature: EmployeeFeature

As a TurnUp portal admin user
I would like to create, edit and delete employees
So that I can manage employees successfully

Background:
	Given I logged into Turnup portal successfully
	And I navigate to Employee Page

@regression @employeetests
Scenario: Create new Employee record with valid data
	When I create a new Employee record
	Then the employee record should be created successfully

Scenario: Update new Employee record with valid data
	When I update the Employee record
	Then the employee record should be updated successfully

Scenario: Delete an Employee record
	When I delete the Employee record
	Then the employee record should be deleted successfully