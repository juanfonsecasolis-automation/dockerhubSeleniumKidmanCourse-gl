using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace kidmanDockerSeleniumCourse
{
    public class Tests
    {
        const string baseUrl = "https://www.saucedemo.com/";
        const string DOCKER_GRID_HUB_URI = "http://localhost:4444/wd/hub";
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new RemoteWebDriver(new Uri(DOCKER_GRID_HUB_URI), new ChromeOptions());
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        
        [TearDown]
        public virtual void CleanUp(){
            driver.Close();
        }
    }
}