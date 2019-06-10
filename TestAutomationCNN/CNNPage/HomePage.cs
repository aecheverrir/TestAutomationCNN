using System;
using OpenQA.Selenium;

namespace CNNPage
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
