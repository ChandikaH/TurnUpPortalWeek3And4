using NUnit.Framework;
using TurnUpPortalWeek3And4.Pages;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.Tests
{
    [TestFixture]
    public class TimeMaterialTests : BaseTest
    {
        private LoginPage loginPage;
        private TimeMaterialPage timeMaterialPage;

        [SetUp]
        public void TestSetup()
        {
            loginPage = new LoginPage();
            timeMaterialPage = new TimeMaterialPage();
            string url = ConfigManager.Get("baseUrl");
            Driver.Navigate().GoToUrl(url);
        }

        [Test, Order(1)]
        public void Test_Login()
        {
            loginPage.Login("hari", "123123");
            Assert.That(Driver.Url.Contains("TimeMaterial"), "Login failed!");
        }

        [Test, Order(2)]
        public void Test_CreateTimeRecord()
        {
            Test_Login();
            string code = TestDataHelper.RandomCode();
            string description = TestDataHelper.RandomDescription();
            string price = TestDataHelper.RandomPrice();

            timeMaterialPage.CreateTimeRecord(code, description, price);
            Assert.Equals(description, timeMaterialPage.GetLastRecordDescription());
        }

        [Test, Order(3)]
        public void Test_EditTimeRecord()
        {
            Test_CreateTimeRecord();
            string newDescription = "Edited" + TestDataHelper.RandomDescription();
            timeMaterialPage.EditLastTimeRecord(newDescription);
            Assert.Equals(newDescription, timeMaterialPage.GetLastRecordDescription());
        }

        [Test, Order(4)]
        public void Test_DeleteTimeRecord()
        {
            Test_EditTimeRecord();
            timeMaterialPage.DeleteLastTimeRecord();
            Assert.Pass("Deleted last time record.");
        }
    }
}