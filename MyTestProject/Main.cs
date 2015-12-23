using System;
using System.Collections;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
        }
        [TearDown]
        public void TearDown()
        {
        }
    }
}







