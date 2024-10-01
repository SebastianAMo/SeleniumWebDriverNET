using OpenQA.Selenium;

namespace SeleniumWebDriverNET.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Locators
        private By UsernameField => By.Id("user-name");
        private By PasswordField => By.Id("password");
        private By LoginButton => By.Id("login-button");
        private By ErrorMessage => By.CssSelector(".error-message-container");

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Actions
        public void EnterUsername(string username)
        {
            _driver.FindElement(UsernameField).Clear();
            _driver.FindElement(UsernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(PasswordField).Clear();
            _driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(LoginButton).Click();
        }

        public string GetErrorMessage()
        {
            return _driver.FindElement(ErrorMessage).Text;
        }

        // Login method to combine actions
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
