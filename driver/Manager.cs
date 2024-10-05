using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace SeleniumWebDriverNET.Driver
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
            if (string.IsNullOrEmpty(browserName))
            {
                throw new ArgumentNullException(nameof(browserName));
            }

            Driver = browserName.ToLower() switch
            {
                "firefox" => new FirefoxDriver(),
                "chrome" => new ChromeDriver(),
                "edge" => new EdgeDriver(),
                _ => throw new ArgumentException($"Invalid browser name: {browserName}", nameof(browserName))
            };

            Driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            _driver?.Quit();
        }
    }
}
