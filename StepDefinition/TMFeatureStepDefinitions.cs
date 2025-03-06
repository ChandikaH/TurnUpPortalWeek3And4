using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using TurnUpPortalWeek3And4.Pages;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given("I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Given("I navigate to the Time and Material page")]
        public void GivenINavigateToTheTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);
        }

        [When("I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTimeRecord(driver);
        }

        [Then("the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tMPageObj = new TMPage();

            string newCode = tMPageObj.GetCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.That(newCode == "TA Programme", "Actual Code and expected Code do not match.");
            Assert.That(newDescription == "This is a description", "Actual Description and expected Description do not match.");
            Assert.That(newPrice == "$12.00", "Actual Price and expected Price do not match.");
        }

        //[When("I update the {string} on an existing Time record")]
        //public void WhenIUpdateTheOnAnExistingTimeRecord(string code)
        //{
        //    TMPage tMPageObj = new TMPage();
        //    tMPageObj.EditTimeRecord(driver, code);
        //}

        //[Then("the record should have the updated {string}")]
        //public void ThenTheRecordShouldHaveTheUpdated(string code)
        //{
        //    TMPage tMPageObj = new TMPage();

        //    string editedCode = tMPageObj.GetEditedCode(driver);

        //    Assert.That(editedCode == code, "Expected Edited Code does not match with the Actual Edited Code.");
        //}

        [When("I update the {string} and {string} on an existing Time record")]
        public void WhenIUpdateTheAndOnAnExistingTimeRecord(string code, string description)
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTimeRecord(driver, code, description);
        }

        [Then("the record should have the updated {string} and {string}")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string code, string description)
        {
            TMPage tMPageObj = new TMPage();

            string editedCode = tMPageObj.GetEditedCode(driver);
            string editedDescription = tMPageObj.GetEditedDescription(driver);
            Assert.That(editedCode == code, "Expected Edited Code and actual edited code do not match.");
            Assert.That(editedDescription == description, "Expected Edited Description and actual edited description do not match.");
        }


    }
}
