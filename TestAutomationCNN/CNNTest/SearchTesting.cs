using Microsoft.VisualStudio.TestTools.UnitTesting;
using CNNPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace CNNTest
{
    [TestClass]
    public class SearchTesting
    {
        private IWebDriver driver;
        private HomePage homepage;
        private SearchPage searchPage;
        private const string chromeDriverPath = @"../../../../webdrivers/windows/version75";

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize browser, obtain drivers at: http://chromedriver.chromium.org/downloads
            driver = new ChromeDriver(chromeDriverPath);
            homepage = new HomePage(driver);
            searchPage = new SearchPage(driver);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Finalize Driver
            driver.Close();
            driver = null;
        }

        [TestMethod]
        public void SearchNFL()
        {
            homepage.GoToPage();
            homepage.ClickSearchButton();
            homepage.TypeSearchInputField("NFL");
            homepage.ClickSubmitButton();
            string result = searchPage.GetSearchResultsCountText();
            Assert.IsTrue(result.Contains("Displaying results"));
        }

        [TestMethod]
        public void SearchNFLFake()
        {
            homepage.GoToPage();
            homepage.ClickSearchButton();
            homepage.TypeSearchInputField("NFLFAKE");
            homepage.ClickSubmitButton();
            string result = searchPage.GetSearchNoResultsText();
            Assert.IsTrue(result.Contains("did not match"));
        }
    }
}
