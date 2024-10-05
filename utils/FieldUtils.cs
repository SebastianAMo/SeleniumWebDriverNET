using OpenQA.Selenium;

namespace SeleniumWebDriverNET.Utils
{
    public static class FieldUtils
    {
        // Method to clear field by selecting the text and deleting
        public static void ClearFieldBySelectingAndDeleting(IWebDriver driver, By locator)
        {
            var element = driver.FindElement(locator);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
        }

        // Method to clear field by repeatedly pressing the backspace key
        public static void ClearFieldByRepeatedlyDeleting(IWebDriver driver, By locator)
        {
            var element = driver.FindElement(locator);
            string currentValue = element.GetAttribute("value");
            int length = currentValue.Length;

            for (int i = 0; i < length; i++)
            {
                element.SendKeys(Keys.Backspace);
            }
        }
    }
}
