using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumWebDriverNET.Driver
{
    [Binding]
    public class TestHooks
    {
        private readonly WebDriverSetup _webDriverSetup;
        private readonly TestContext _testContext;

        public TestHooks(WebDriverSetup webDriverSetup, TestContext testContext)
        {
            _webDriverSetup = webDriverSetup;
            _testContext = testContext;
        }

        // Este hook se ejecutará antes de cada escenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Acceder al parámetro de prueba desde el archivo .runsettings
            string browser = (string)_testContext.Properties["Browser"] ?? "firefox";  // Valor predeterminado: firefox
            _webDriverSetup.StartBrowser(browser);
        }

        // Este hook se ejecutará después de cada escenario
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();
        }
    }
}
