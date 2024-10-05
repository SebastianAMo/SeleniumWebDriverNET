using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumWebDriverNET.Driver;
using SeleniumWebDriverNET.Pages;

namespace SeleniumWebDriverNET.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly WebDriverSetup _webDriverSetup;
        private LoginPage _loginPage;

        public LoginSteps(WebDriverSetup webDriverSetup)
        {
            _webDriverSetup = webDriverSetup;
        }

        [Given(@"I am on the login page with the url ""(.*)"" using ""(.*)""")]
        public void GivenINavigateToTheLoginPageWithBrowser(string url, string browser)
        {
            _webDriverSetup.StartBrowser(browser);
            _loginPage = new LoginPage(_webDriverSetup.Driver); // Iniciamos la página de login
            _webDriverSetup.Driver.Navigate().GoToUrl(url);
        }

        [When(@"I enter ""(.*)"" and ""(.*)""")]
        public void WhenIEnterCredentials(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [When(@"I clear the username and password fields")]
        public void AndIClearTheUsernameAndPasswordFields()
        {
            _loginPage.ClearUsernameFieldKeys();
            _loginPage.ClearPasswordFieldKeys();
            // _loginPage.ClearUsernameField();
            // _loginPage.ClearPasswordField();
        }

        [When(@"I clear the password field")]
        public void WhenIClearThePasswordField()
        {
            _loginPage.ClearPasswordFieldKeys();
            // _loginPage.ClearPasswordField();
        }

        [Then(@"I should see the title ""(.*)""")]
        public void ThenIShouldBeRedirectedToTheHomePage(string expectedTitle)
        {
            var title = _loginPage.GetTitle();
            title.Should().Be(expectedTitle);
        }

        [Then(@"I should see the error message ""(.*)""")]
        public void ThenIShouldSeeTheErrorMessage(string expectedErrorMessage)
        {
            var errorMessage = _loginPage.GetErrorMessage();
            errorMessage.Should().Be(expectedErrorMessage);
        }
    }
}
