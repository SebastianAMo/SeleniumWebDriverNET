using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
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
                case "chrome":
                    Driver = new ChromeDriver();
                    break;
                case "edge":
                    Driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Invalid browser name", browserName);
            }

            Driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}