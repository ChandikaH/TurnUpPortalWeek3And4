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
                IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
                administrationDropdown.Click();
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")));

                IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                employeeOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp portal page did not displayed" + ex.Message);
            }
        }
    }
}
