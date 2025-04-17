using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalWeek3And4.Utilities;
using NUnit.Framework;

namespace TurnUpPortalWeek3And4.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Alert not present within the specified time.");
            }

            // Navigate to Time and Material Page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);

            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
        }

        public void NavigateToEmployeePage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time and Material module (Click Administration button -> Select Employee Option)
                IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
                administrationTab.Click();
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[normalize-space()='Employees']")));

                IWebElement employeeOption = driver.FindElement(By.XPath("//a[normalize-space()='Employees']"));
                employeeOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp portal page did not displayed" + ex.Message);
            }
        }
    }
}
