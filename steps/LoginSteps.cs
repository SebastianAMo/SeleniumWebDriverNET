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

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            _webDriverSetup.Driver.Url.Should().Be("https://www.saucedemo.com/inventory.html");
        }
    }
}
