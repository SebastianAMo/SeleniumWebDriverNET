using TechTalk.SpecFlow;
using System.Collections.Specialized; // Necesario para IOrderedDictionary

namespace SeleniumWebDriverNET.Driver
{
    [Binding]
    public class TestHooks
    {
        private readonly WebDriverSetup _webDriverSetup;

        public TestHooks(WebDriverSetup webDriverSetup)
        {
            _webDriverSetup = webDriverSetup;
        }

        // Este hook se ejecutar� despu�s de cada escenario
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();  // Cerrar el navegador despu�s de cada escenario
        }
    }
}
