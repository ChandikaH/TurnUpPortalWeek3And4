using OpenQA.Selenium;

namespace TurnUpPortalWeek3And4.Pages
{
    public class LoginPage : BasePage
    {
        private By UsernameField => By.Id("UserName");
        private By PasswordField => By.Id("Password");
        private By LoginButton => By.XPath("//input[@value='Log in']");

        public void Login(string username, string password)
        {
            Type(UsernameField, username);
            Type(PasswordField, password);
            Click(LoginButton);
        }
    }
}