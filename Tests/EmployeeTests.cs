using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalWeek3And4.Pages;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.Tests
{
    [TestFixture]
    public class EmployeeTests : CommonDriver
    {
        //Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        //Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        //Employee page object initialization and definition
        EmployeePage employeePageObj = new EmployeePage();

        [SetUp]
        public void SetUp()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            loginPageObj.LoginActions(driver);
            Console.WriteLine("User logged in successfully - EmployeeTests");
            homePageObj.NavigateToEmployeePage(driver);
        }

        [Test, Order(1), Description("This test create a Employee record with valid details")]
        public void TestCreateEmployeeRecord()
        {
            employeePageObj.CreateEmployeeRecord(driver);
        }

        [Test, Order(2), Description("This test update the Employee record with valid details")]
        public void TestUpdateEmployeeRecord()
        {
            employeePageObj.EditEmployeeRecord(driver);
        }

        [Test, Order(3), Description("This test delete the last Employee record")]
        public void TestDeleteEmployeeRecord()
        {
            employeePageObj.DeleteEmployeeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
