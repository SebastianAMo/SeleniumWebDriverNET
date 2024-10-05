using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using System.IO;
using System.Collections.Specialized;
using OpenQA.Selenium;

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

        // This hook is executed before each scenario
        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverSetup.CloseBrowser();
        }


        // This hook is executed after each step, and takes a screenshot
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
