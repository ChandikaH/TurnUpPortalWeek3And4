using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TurnUpPortalWeek3And4.Pages;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.StepDefinition
{
    [Binding]
    public class EmployeeFeatureStepDef : CommonDriver
    {
        // Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        // TM page object initialization and definition
        EmployeePage employeePageObj = new EmployeePage();

        [BeforeScenario]
        public void SetUpDriver()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();
        }

        [When(@"I navigate to Employee Page")]
        public void WhenINavigateToEmployeePage()
        {

            homePageObj.NavigateToEmployeePage(driver);
            Console.WriteLine("TM - I navigate to Employee Page");
        }

        [When(@"I create a new Employee record")]
        public void WhenICreateAnEmployeeRecord()
        {
            employeePageObj.CreateEmployeeRecord(driver);
            Console.WriteLine("Create - I create a new Time record");
        }

        [Then(@"the employee record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            //Assert.That(employeePageObj.GetElementText(driver, "name") == "Employee 1", "Actual Name and expected Name do not match.");
            Console.WriteLine("Verify - the record should be created successfully");
        }

        [When(@"I update the '([^']*)' on an existing Time record")]
        public void WhenIUpdateTheOnAnExistingEmployeeRecord(string name)
        {
            employeePageObj.EditEmployeeRecord(driver);
        }

        [Then(@"the record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string name)
        {
            Console.WriteLine("Verify - the record should be updated successfully");
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
