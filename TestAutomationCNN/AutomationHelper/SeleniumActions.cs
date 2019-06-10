using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace AutomationHelper
{
    public static class SeleniumActions
    {
        public static void GoToPage(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlContains(url));
        }
    }
}
