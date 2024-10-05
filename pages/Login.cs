using OpenQA.Selenium;
using SeleniumWebDriverNET.Utils;

namespace SeleniumWebDriverNET.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Locators
        private By UsernameField => By.CssSelector("#user-name");
        private By PasswordField => By.CssSelector("#password");
        private By LoginButton => By.CssSelector("#login-button");
        private By ErrorMessage => By.CssSelector(".error-message-container");
        private By Title => By.CssSelector("div.app_logo");

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Actions
        public void EnterUsername(string username)
        {
            _driver.FindElement(UsernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
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

        public string GetTitle()
        {
            return _driver.FindElement(Title).Text;
        }


        // Separate methods for clearing fields
        public void ClearUsernameField()
        {
            FieldUtils.ClearFieldBySelectingAndDeleting(_driver, UsernameField);
        }

        public void ClearPasswordField()
        {
            FieldUtils.ClearFieldBySelectingAndDeleting(_driver, PasswordField);
        }

        public void ClearUsernameFieldKeys()
        {
            FieldUtils.ClearFieldByRepeatedlyDeleting(_driver, UsernameField);
        }

        public void ClearPasswordFieldKeys()
        {
            FieldUtils.ClearFieldByRepeatedlyDeleting(_driver, PasswordField);
        }

    }
}
