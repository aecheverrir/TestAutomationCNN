using System;
using AutomationHelper;
using OpenQA.Selenium;

namespace CNNPages
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
                return SeleniumActions.FindElement(driver, By.Id(searchButtonID));
            }
            set
            {
                searchButton = value;
            }
        }

        private string searchInputFieldID = "search-input-field";
        private IWebElement searchInputField
        {
            get
            {
                return SeleniumActions.FindElement(driver, By.Id(searchInputFieldID));
            }
            set
            {
                searchInputField = value;
            }
        }

        private string submitButtonID = "submit-button";
        private IWebElement submitButton
        {
            get
            {
                return SeleniumActions.FindElement(driver, By.Id(submitButtonID));
            }
            set
            {
                submitButton = value;
            }
        }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            baseUrl = "https://edition.cnn.com/";
        }

        public void GoToPage()
        {
            JSActions.GoToPage(driver, baseUrl);
        }

        public void ClickSearchButton()
        {
            JSActions.Click(driver, searchButton);
        }

        public void ClickSubmitButton()
        {
            JSActions.Click(driver, submitButton);
        }

        public void TypeSearchInputField(string text)
        {
            JSActions.Type(driver, searchInputField, text);
        }

    }
}
