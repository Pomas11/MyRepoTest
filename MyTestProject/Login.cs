using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace MyTestProject
{
    class LoginToProfile
    {
        public LoginToProfile()
        {
            PageFactory.Equals(DriverInit.driver, this);
        }
        [FindsBy(How = How.Id, Using = "quick_email")]
        public IWebElement login { get; set; }
        [FindsBy(How = How.Id, Using = "quick_pass")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "quick_login_button")]
        public IWebElement LoginBtn { get; set; }

            public void Login (string LoginId, string PassId)
            {
            login.SendKeys(LoginId);
            Password.SendKeys(PassId);
            LoginBtn.Click();

            }
    }
}
