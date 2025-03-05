using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TAProgramme.Utilities
{
    public class WaitUtils
    {
        // Helper method to get the By object based on locator type and value
        private static By GetBy(string locatorType, string locatorValue)
        {
            return locatorType switch
            {
                "XPath" => By.XPath(locatorValue),
                "Id" => By.Id(locatorValue),
                _ => throw new ArgumentException("Invalid locator type", nameof(locatorType)),
            };
        }

        // Generic function to wait for an element to be clickable
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            var by = GetBy(locatorType, locatorValue);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }

        // Generic function to wait for an element to be visible
        public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            var by = GetBy(locatorType, locatorValue);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        public static IWebElement FluentWait(IWebDriver driver, By by, int timeoutInSeconds, int pollingIntervalInMilliseconds)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(timeoutInSeconds),
                PollingInterval = TimeSpan.FromMilliseconds(pollingIntervalInMilliseconds)
            };

            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return fluentWait.Until(drv => drv.FindElement(by));
        }
    }
}