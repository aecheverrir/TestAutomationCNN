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
        IWebDriver driver;
        HomePage homepage;
        SearchPage searchPage;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize browser, obtain driver at: http://chromedriver.chromium.org/downloads
            driver = new ChromeDriver(@"../../../../webdrivers/macOS/version74");
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
