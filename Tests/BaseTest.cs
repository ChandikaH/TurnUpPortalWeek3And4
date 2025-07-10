using NUnit.Framework;
using OpenQA.Selenium;
using TurnUpPortalWeek3And4.Utilities;
using TurnUpPortalWeek3And4.WebDriver;

namespace TurnUpPortalWeek3And4.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;
        protected Logger Logger;
        protected ReportManager Reporter;

        [SetUp]
        public void SetUp()
        {
            Logger = Logger.Instance;
            Reporter = ReportManager.Instance;
            Driver = WebDriverManager.Instance.Driver;
            Logger.Info("Test Started");
            Reporter.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDown()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            if (testStatus == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Reporter.Fail(message);
                Logger.Error(message);
            }
            else
            {
                Reporter.Pass("Test Passed");
                Logger.Info("Test Passed");
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverManager.Instance.QuitDriver();
        }
    }
}