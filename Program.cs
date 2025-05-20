using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalWeek3And4.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello IndustryConnect!");

        // Open Chrome Browser
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
        IWebDriver driver = new ChromeDriver(options);

        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        // Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

        // TM page object initialization and definition
        TMPage tMPageObj = new TMPage();
        tMPageObj.CreateTimeRecord(driver);

        // Edit Time Record
        tMPageObj.EditTimeRecord(driver);

        // Delete Time Record
        tMPageObj.DeleteTimeRecord(driver);
    }
}