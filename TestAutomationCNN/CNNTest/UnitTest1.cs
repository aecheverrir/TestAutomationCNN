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


        [ClassInitialize]
        public void ClassInitialize()
        {
        }
        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize browser
            driver = new ChromeDriver();
            homepage = new HomePage(driver);
        }

        [TestMethod]
        public void SearchNFL()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SearchNFLFake()
        {
            Assert.IsTrue(true);
        }
    }
}
