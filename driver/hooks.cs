using TechTalk.SpecFlow;

namespace SeleniumWebDriverNET
{
    [Binding]
    public class TestHooks(WebDriverSetup webDriverSetup)
    {
        private readonly WebDriverSetup _webDriverSetup = webDriverSetup;

        // Este hook se ejecutar� antes de cada escenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            _webDriverSetup.StartBrowser("firefox");
        }

        // Este hook se ejecutar� despu�s de cada escenario
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();
        }
    }
}
