using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TurnUpPortalWeek3And4.Utilities;
using System;

namespace TurnUpPortalWeek3And4.WebDriver
{
    public sealed class WebDriverManager
    {
        private static readonly Lazy<WebDriverManager> lazy = new Lazy<WebDriverManager>(() => new WebDriverManager());
        private IWebDriver driver;

        private WebDriverManager() { }

        public static WebDriverManager Instance => lazy.Value;

        public IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    string browser = ConfigManager.Get("browser")?.ToLower() ?? "chrome";
                    if (browser == "chrome")
                    {
                        driver = new ChromeDriver();
                    }
                    else if (browser == "firefox")
                    {
                        driver = new FirefoxDriver();
                    }
                    else
                    {
                        throw new Exception("Unsupported browser in config.");
                    }
                    driver.Manage().Window.Maximize();
                }
                return driver;
            }
        }

        public void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}