using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace AutomationHelper
{
    public static class JSActions
    {
        private static void waitPageReadyState(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(
            d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void GoToPage(IWebDriver driver, string url)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("window.location = arguments[0];", url);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.UrlContains(url));
        }

        public static void Click(IWebDriver driver, IWebElement element)
        {
            waitPageReadyState(driver);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public static void Type(IWebDriver driver, IWebElement element, string text)
        {
            waitPageReadyState(driver);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].value = arguments[1]", element, text);
        }
    }
}
