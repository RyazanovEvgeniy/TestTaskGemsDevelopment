using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SiteTests
{
    public class GemsDevSiteTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://gemsdev.ru");
            driver.FindElement(By.LinkText("Продукты")).Click();
        }

        [Test]
        public void FindGeoMeta()
        {
            driver.FindElement(By.CssSelector("section[text*='GeoMeta']"));
        }

        [Test]
        public void FindGosSystem()
        {
            driver.FindElement(By.CssSelector("section[class*=gos-system]"));
        }

        [Test]
        public void FindGosSystemLink()
        {
            var elements = driver.FindElements(By.XPath("//a[text()='GeoMeta']"));

            TestContext.WriteLine("!!!");

            foreach (var element in elements)
                TestContext.WriteLine("tag " + element.TagName +
                    " Text " + element.Text +
                    " href " + element.GetAttribute("href") +
                    " name " + element.GetAttribute("name") +
                    " text " + element.GetAttribute("text"));
            //var elements = driver.FindElements(By.CssSelector("#menu-item-45 > a"));
            //foreach (var element in elements)
            //    TestContext.WriteLine(element.TagName + " " +
            //        element.Text + " " +
            //        element.GetAttribute("href"));
        }

        [Test]
        public void FindUrbanAnalytics()
        {
            driver.FindElement(By.CssSelector("section[class*=urban-analytics]"));
        }

        [Test]
        public void FindOtherProducts()
        {
            driver.FindElement(By.CssSelector("section[class*=other-products]"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}