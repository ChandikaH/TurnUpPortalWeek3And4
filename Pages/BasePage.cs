using OpenQA.Selenium;
using TurnUpPortalWeek3And4.WebDriver;
using TurnUpPortalWeek3And4.Utilities;

namespace TurnUpPortalWeek3And4.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver => WebDriverManager.Instance.Driver;

        protected void Click(By locator, int timeout = 10)
        {
            var element = WaitHelper.WaitForElementClickable(Driver, locator, timeout);
            element.Click();
        }

        protected void Type(By locator, string text, int timeout = 10)
        {
            var element = WaitHelper.WaitForElementVisible(Driver, locator, timeout);
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By locator, int timeout = 10)
        {
            var element = WaitHelper.WaitForElementVisible(Driver, locator, timeout);
            return element.Text;
        }

        protected bool IsVisible(By locator, int timeout = 10)
        {
            try
            {
                WaitHelper.WaitForElementVisible(Driver, locator, timeout);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}