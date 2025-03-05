using OpenQA.Selenium;
using TAProgramme.Utilities;

namespace TurnUpPortalWeek3And4.Pages
{
    public class LoginPage
    {
        // Functions that allow users to login to TurnUp portal
        public void LoginActions(IWebDriver driver)
        {
            // Launch TurnUp portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            // Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // Identify login buton and click on it
            IWebElement loginButton = WaitUtils.FluentWait(driver, By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"), 10, 500);
            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
