using System;
using System.Collections;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Text.RegularExpressions;

namespace MyTestProject
{
    [TestFixture]
    public class Main
    {
        [Test]
        public void LoginFormTest()
        {

            SendText PAGE = new SendText();
            PAGE.LoginProcedure();
        }
        [SetUp]
        public void SetUp()
        {
            DriverInit.driver = new ChromeDriver();
            DriverInit.driver.Navigate().GoToUrl("http://vk.com/");
        }
        [TearDown]
        public void TearDown()
        {
            
        }
        [Test]
        public void WriteMessage()
        {
            LoginToProfile Log = new LoginToProfile();
            Log.Login("+79289094098", "4321uarf");
            DriverInit.driver.FindElement(By.XPath(".//*[@id='l_fr']/a/span/span[2]")).Click();
            Scrolling.ScrollPage("footer", 50);
            VKsendMessage Search = new VKsendMessage();
            Search.SearchFrisendsLinks("message");
        }
    }
}







