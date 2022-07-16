using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalMarsQA.Utilities;
using OpenQA.Selenium.Chrome;

namespace LocalMarsQA.Pages
{
    public class ProfilePage 
    {
        public void AddNewLanguage(IWebDriver driver)
        {
            Thread.Sleep(4000);
                        
            IWebElement addNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();                                   //div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div    
        }

    }
}
