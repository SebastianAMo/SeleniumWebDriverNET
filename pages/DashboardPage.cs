using OpenQA.Selenium;

namespace SeleniumWebDriverNET.Pages
{
    public class DashboardPage
    {
        private readonly IWebDriver _driver;

        private static By Title => By.CssSelector("div.app_logo");

        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Actions
     
        public string GetTitle()
        {
            return _driver.FindElement(Title).Text;
        }

    }
}
