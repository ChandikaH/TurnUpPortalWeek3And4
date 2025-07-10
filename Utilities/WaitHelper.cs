using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TurnUpPortalWeek3And4.Utilities
{
    public static class WaitHelper
    {
        public static IWebElement WaitForElementVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static IWebElement WaitForElementClickable(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public static bool WaitForElementInvisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public static IWebElement WaitWithFluentWait(IWebDriver driver, By locator, int timeoutInSeconds = 10, int pollingMillis = 500)
        {
            var wait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(timeoutInSeconds),
                PollingInterval = TimeSpan.FromMilliseconds(pollingMillis)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(drv => drv.FindElement(locator));
        }
    }
}