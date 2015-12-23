using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

    class Program
    {
        static void Main(string[] args)
        {
        IWebDriver driver = new ChromeDriver();
            bool b = true;
            string[] login = new string[3] { "+79289094098", "WrongNickName", "" };
            string[] password = new string[3] { "4321uarf", "WrongPassword", "" };
            for (int i = 0; i <= login.Length; i++)
            {
                for (int j = 0; j <= password.Length; j++)
                {
                    driver.Navigate().GoToUrl("http://vk.com/");

                    driver.FindElement(By.Id("quick_email")).SendKeys(login[i]);

                    Console.WriteLine("Login----" + login[i]);

                    driver.FindElement(By.Id("quick_pass")).SendKeys(password[j]);

                    Console.WriteLine("Password----" + password[j]);

                    driver.FindElement(By.Id("quick_login_button")).Click();
                try
                {
                    if (driver.FindElement(By.Id("message_text")).Enabled)

                        Console.WriteLine("Incorrect data input");
                }
                catch
                { }
                try
                {
                    if (driver.FindElement(By.Id("myprofile")).Enabled)
                    {
                        Console.WriteLine("You have entered your page");
                        driver.FindElement(By.Id("logout_link")).Click();
                    }
                }
                catch
                { }
                }
            }
        }
    }

