using TechTalk.SpecFlow;

namespace SeleniumWebDriverNET.Driver
{
    [Binding]
    public class TestHooks(WebDriverSetup webDriverSetup)
    {
        private readonly WebDriverSetup _webDriverSetup = webDriverSetup;

        // Este hook se ejecutará antes de cada escenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            _webDriverSetup.StartBrowser("edge");
        }

        // Este hook se ejecutará después de cada escenario
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();
        }
    }
}
