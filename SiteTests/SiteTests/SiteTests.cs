using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SiteTests
{
    public class GemsDevSiteTests
    {
        private IWebDriver driver;

        // Метод начальной настройки теста
        [SetUp]
        public void Setup()
        {
            // Создаем ChromeDriver, с помощью которого будем тестировать в дальнейшем
            driver = new ChromeDriver();
            // Увеличим окно для удобства
            driver.Manage().Window.Maximize();
            // Переходим на тестируемый сайт "https://gemsdev.ru"
            driver.Navigate().GoToUrl("https://gemsdev.ru");
            // Находим ссылку с текстом "Продукты" и переходим по ней
            driver.FindElement(By.LinkText("Продукты")).Click();
        }

        // Метод поиска раздела "GeoMeta"
        [Test]
        public void FindGeoMeta()
        {
            // Ищем заголовок, находящийся в каком либо разделе, содержащий текст "GeoMeta"
            driver.FindElement(By.CssSelector("section h1, h2")).Text.Contains("GeoMeta");
        }

        // Метод поиска раздела "Государственная система обеспечения градостроительной деятельности"
        [Test]
        public void FindGosSystem()
        {
            // Ищем раздел реализующий класс gos-system
            driver.FindElement(By.CssSelector("section[class*=gos-system]"));
        }

        // Метод поиска ссылки https://исогдрегион.рф в разделе "Государственная система обеспечения градостроительной деятельности"
        [Test]
        public void FindGosSystemLink()
        {
            driver.FindElement(By.CssSelector($"section[class*=gos-system] a[href*='https://исогдрегион.рф']"));
        }

        // Метод поиска раздела “Городская аналитика”
        [Test]
        public void FindUrbanAnalytics()
        {
            // Ищем раздел реализующий класс urban-analytics
            driver.FindElement(By.CssSelector("section[class*=urban-analytics]"));
        }

        // Метод поиска раздела “Другие наши продукты”
        [Test]
        public void FindOtherProducts()
        {
            // Ищем раздел реализующий класс other-products
            driver.FindElement(By.CssSelector("section[class*=other-products]"));
        }

        // Метод завершение теста
        [TearDown]
        public void TearDown()
        {
            // Закрываем ChromeDriver
            driver.Close();
        }
    }
}