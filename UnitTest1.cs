using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SeleniumWebDriverNET
{
    [Binding]
    public class ExampleSiteSteps
    {
        private readonly WebDriverSetup _webDriverSetup;

        public ExampleSiteSteps(WebDriverSetup webDriverSetup) => _webDriverSetup = webDriverSetup;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _webDriverSetup.StartBrowser("firefox");
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {  // Iniciar el navegador
            _webDriverSetup.Driver.Navigate().GoToUrl(url);
        }

        [Then(@"the title should contain ""(.*)""")]
        public void ThenTheTitleShouldContain(string titleText)
        {
            var title = _webDriverSetup.Driver.Title;
            title.Should().Contain(titleText);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();
        }
    }


}