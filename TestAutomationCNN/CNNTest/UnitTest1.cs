using Microsoft.VisualStudio.TestTools.UnitTesting;
using CNNPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CNNTest
{
    [TestClass]
    public class HomePageTesting
    {
        IWebDriver driver;
        HomePage homepage;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize browser, obtain driver at: http://chromedriver.chromium.org/downloads
            driver = new ChromeDriver(@"../../../webdrivers");
            homepage = new HomePage(driver);
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
        }

        [TestMethod]
        public void SearchNFLFake()
        {

        }
    }
}
