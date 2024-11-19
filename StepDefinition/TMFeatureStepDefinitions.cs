using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TurnUpPortalWeek3And4.Pages;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        // Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        // TM page object initialization and definition
        TMPage tMPageObj = new TMPage();

        [BeforeScenario]
        public void SetUpDriver()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();
        }

        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {

            loginPageObj.LoginActions(driver);
            Console.WriteLine("Login - I logged into Turnup portal successfully");
        }

        [When(@"I navigate to Time and Material Page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {

            homePageObj.NavigateToTMPage(driver);
            Console.WriteLine("TM - I navigate to Time and Material Page");
        }

        [When(@"I create a new Time record")]
        public void WhenICreateATimeRecord()
        {

            tMPageObj.CreateTimeRecord(driver);
            Console.WriteLine("Create - I create a new Time record");
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            Assert.That(tMPageObj.GetElementText(driver, "code") == "TA Programme", "Actual Code and expected Code do not match.");
            Assert.That(tMPageObj.GetElementText(driver, "description") == "This is a description", "Actual Description and expected Description do not match.");
            Assert.That(tMPageObj.GetElementText(driver, "price") == "$12.00", "Actual Price and expected Price do not match.");
            Console.WriteLine("Verify - the record should be created successfully");
        }

        [When(@"I update the '([^']*)', '([^']*)' and '([^']*)' on an existing Time record")]
        public void WhenIUpdateTheOnAnExistingTimeRecord(string code, string description, string price)
        {
            tMPageObj.EditTimeRecord(driver, code, description, price);
        }

        [Then(@"the record should have the updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string code, string description, string price)
        {
            Assert.That(tMPageObj.GetElementText(driver, "code") == code, "Expected Edited Code does not match with the Actual Edited Code.");
            Assert.That(tMPageObj.GetElementText(driver, "description") == description, "Expected description does not match with the Actual description.");
            Assert.That(tMPageObj.GetElementText(driver, "price") == price, "Expected price does not match with the Actual price.");
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
