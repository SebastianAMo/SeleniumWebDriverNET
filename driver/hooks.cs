using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using System.IO;
using System.Collections.Specialized;
using OpenQA.Selenium; // Necesario para IOrderedDictionary

namespace SeleniumWebDriverNET.Driver
{
    [Binding]
    public class TestHooks
    {
        private readonly WebDriverSetup _webDriverSetup;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

        public TestHooks(WebDriverSetup webDriverSetup, ISpecFlowOutputHelper specFlowOutputHelper)
        {
            _webDriverSetup = webDriverSetup;
            _specFlowOutputHelper = specFlowOutputHelper;
        }

        // Este hook se ejecutará después de cada escenario
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();  // Cerrar el navegador después de cada escenario
        }

        [AfterStep()]
        public void TakeScreenshotAfterEachStep()
        {

            if (_webDriverSetup.Driver is ITakesScreenshot screenshotTaker)
            {
                var filename = Path.ChangeExtension(Path.GetRandomFileName(), "png");

                screenshotTaker.GetScreenshot().SaveAsFile(filename);

                _specFlowOutputHelper.AddAttachment(filename);
            }
        }
    }
}
