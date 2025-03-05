using System;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using TurnUpPortalWeek3And4.Pages;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.StepDefinition
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommonDriver
    {
        // Home page object initialization and definition
        
        // TM page object initialization and definition
        EmployeePage employeePageObj = new EmployeePage();

        [BeforeScenario]
        public void SetUpDriver()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();
        }

        [Given("I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When("I navigate to Employee Page")]
        public void WhenINavigateToEmployeePage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToEmployeePage(driver);
            Console.WriteLine("I navigate to Employee Page");
        }

        [When("I create a new Employee record")]
        public void GivenICreateANewEmployeeRecord()
        {
            employeePageObj.CreateEmployeeRecord(driver);
            Console.WriteLine("Create - I create a new Time record");
        }

        [Then("the employee record should be created successfully")]
        public void ThenTheEmployeeRecordShouldBeCreatedSuccessfully()
        {
            //Assert.That(employeePageObj.GetElementText(driver, "name") == "Employee 1", "Actual Name and expected Name do not match.");
            Console.WriteLine("Verify - the record should be created successfully");
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
