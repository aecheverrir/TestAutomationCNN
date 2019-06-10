using System;
using AutomationHelper;
using OpenQA.Selenium;

namespace CNNPage
{
    public class HomePage
    {
        private IWebDriver driver;
        private string baseUrl;

        private string searchButtonID = "search-button";
        private IWebElement searchButton
        {
            get
            {
                return SeleniumActions.FindElement;
            }
            set
            {
                this.name = value;
            }
        }

        private string searchInputFieldID = "search-input-field";
        private IWebElement searchInputField
        {
            get
            {
                return SeleniumActions.FindElement;
            }
            set
            {
                this.name = value;
            }
        }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            baseUrl = "https://edition.cnn.com/";
        }

        public void GoToPage()
        {
            SeleniumActions.GoToPage(driver, baseUrl);
        }

        public void ClickSearchButton()
        {
            JSActions.Click(driver, searchButton);
        }

        public void TypeSearchInputField(string text)
        {
            JSActions.Type(driver, searchInputField, text);
        }

    }
}
