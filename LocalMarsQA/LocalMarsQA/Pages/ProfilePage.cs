using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalMarsQA.Utilities;

namespace LocalMarsQA.Pages
{
    public class ProfilePage 
    {
        public void AddNewLanguage(IWebDriver driver)
        {
            Console.WriteLine("please");
            IWebElement addNewLanguage = driver.FindElement(By.LinkText("Languages"));
            addNewLanguage.Click();
            //IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            //addNewButton.Click();
        }
        
    }
}
