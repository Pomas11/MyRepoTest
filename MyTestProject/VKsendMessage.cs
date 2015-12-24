using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace MyTestProject
{
    class VKsendMessage
    {
        public void SearchFrisendsLinks(string Somekeys)
        { 
        System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> links = DriverInit.driver.FindElements(By.PartialLinkText("Написать сообщение"));
            foreach (IWebElement link in links)
                {
                    System.Console.WriteLine(link.GetAttribute("href"));
                }
            int count = links.Count;
            for (int i = 0; i < count; i++)
            {
                DriverInit.driver.FindElements(By.PartialLinkText("Написать сообщение"))[i].Click();
                DriverInit.driver.FindElement(By.Id("mail_box_editable")).SendKeys(Somekeys);
            }
        }
    }
}
