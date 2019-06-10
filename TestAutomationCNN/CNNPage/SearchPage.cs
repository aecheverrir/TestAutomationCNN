using System;
using AutomationHelper;
using OpenQA.Selenium;

namespace CNNPages
{
    public class SearchPage
    {
        private IWebDriver driver;
        private string baseUrl;

        private string searchButtonClassName = "cnn-search__button";
        private IWebElement searchButton
        {
            get
            {
                return SeleniumActions.FindElement(driver, By.ClassName(searchButtonClassName));
            }
            set
            {
                searchButton = value;
            }
        }

        private string searchResultsCountClassName = "cnn-search__results-count";
        private IWebElement searchResultsCount
        {
            get
            {
                return SeleniumActions.FindElement(driver, By.ClassName(searchResultsCountClassName));
            }
            set
            {
                searchResultsCount = value;
            }
        }

        private string searchNoResultsSectionClassName = "cnn-search__no-results";
        private IWebElement searchNoResultsSection
        {
            get
            {
                return SeleniumActions.FindElement(driver, By.ClassName(searchNoResultsSectionClassName));
            }
            set
            {
                searchNoResultsSection = value;
            }
        }

        private string searchNoResultsHeaderMessageTagName = "h3";
        private IWebElement searchNoResultsHeaderMessage
        {
            get
            {
                return SeleniumActions.FindElement(driver, searchNoResultsSection, By.TagName(searchNoResultsHeaderMessageTagName));
            }
            set
            {
                searchNoResultsHeaderMessage = value;
            }
        }

        public SearchPage(IWebDriver driver)
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

        public string GetSearchResultsCountText()
        {
            return searchResultsCount.Text;
        }

        public string GetSearchNoResultsText()
        {
            return searchNoResultsHeaderMessage.Text;
        }
    }
}
