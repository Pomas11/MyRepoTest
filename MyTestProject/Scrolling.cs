using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
namespace MyTestProject
{
    class Scrolling
    {
        public static void ScrollPage(string Id, int FriendsCount )
        {
            
            for (int i = 0; i < FriendsCount/4; i++)
            {
                IWebElement element = DriverInit.driver.FindElement(By.Id(Id));
                Actions actions = new Actions(DriverInit.driver);
                actions.MoveToElement(element);
                actions.Perform();
            }
        }
    }
}
