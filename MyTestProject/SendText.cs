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
    class SendText
    {
        string[] login = new string[3] { "+79289094098", "WrongNickName", "" };
        string[] password = new string[3] { "4321uarf", "WrongPassword", "" };
        public SendText()
        {
            PageFactory.InitElements(DriverInit.driver, this);
        }
        [FindsBy(How = How.Id, Using = "quick_email")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.Id, Using = "quick_pass")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "quick_login_button")]
        public IWebElement LogInBtn { get; set; }

        [FindsBy(How = How.Id, Using = "logout_link")]
        public IWebElement LogOutBtn { get; set; }

        [FindsBy(How = How.Id, Using = "message_text")]
        public IWebElement message { get; set; }

        [FindsBy(How = How.Id, Using = "myprofile")]
        public IWebElement MyProfile { get; set; }

        public void LoginProcedure()
        {
            for (int i = 0; i < login.Length; i++)
            {
                for (int j = 0; j < password.Length; j++)
                {
                    DriverInit.driver.Navigate().GoToUrl("http://vk.com/");
                    if (login[i] == "")
                        Console.WriteLine("Your LoginField is Empty");
                    if (password[j] == "")
                        Console.WriteLine("Your PasswordField is Empty");
                    Login.SendKeys(login[i]);
                        Console.WriteLine("Login----" + login[i]);
                    Password.SendKeys(password[j]);
                        Console.WriteLine("Password----" + password[j]);
                    LogInBtn.Click();
                    try
                    {
                        if (message.Enabled)
                            Console.WriteLine("Incorrect data input");
                    }
                    catch (NoSuchElementException)
                    { }
                    try
                    {
                        if (MyProfile.Enabled)
                        {
                            Console.WriteLine("You have entered your page");
                            LogOutBtn.Click();
                        }
                    }
                    catch (NoSuchElementException)
                    { }
                }
            }
        }
    }
}

    

