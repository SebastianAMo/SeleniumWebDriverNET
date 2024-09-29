using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace SeleniumWebDriverNET
{
    public class WebDriverSetup
    {
        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    throw new InvalidOperationException("WebDriver is not initialized.");
                }
                return _driver;
            }
            private set
            {
                _driver = value;
            }
        }

        private IWebDriver? _driver;
        public void StartBrowser(string browserName)
        {
            switch (browserName)
            {
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentException("Invalid browser name", browserName);
            }
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}