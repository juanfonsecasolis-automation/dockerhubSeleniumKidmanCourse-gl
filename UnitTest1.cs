using System;
using System.Threading;
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
            /*ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);*/
        }

        [Test]
        public void Test1()
        {
            driver.Url = baseUrl;
            IWebElement loginBtn = driver.FindElement(By.CssSelector("#login-button"));
            string current = loginBtn.GetProperty("value");
            TestContext.WriteLine($"Current: '{current}'");
            Assert.True(current.Equals("Login"));
        }
        
        [TearDown]
        public virtual void CleanUp(){
            driver.Close();
        }
    }
}