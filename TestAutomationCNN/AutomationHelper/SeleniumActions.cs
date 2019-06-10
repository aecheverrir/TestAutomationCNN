using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationHelper
{
    public static class SeleniumActions
    {
        public static IWebElement FindElement(IWebDriver driver, By byStatement)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementExists(byStatement));
        }

        public static IWebElement FindElement(IWebDriver driver, IWebElement element, By byStatement)
        {
            try
            {
                return element.FindElement(byStatement);
            }
            catch
            {
                throw new NoSuchElementException(message: "Element not found");
            }
        }
    }
}
