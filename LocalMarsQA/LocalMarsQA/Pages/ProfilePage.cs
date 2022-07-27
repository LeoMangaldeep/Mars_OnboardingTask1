using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalMarsQA.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LocalMarsQA.Pages
{
    public class ProfilePage 
    {
        public void AddNewLanguage(IWebDriver driver, string language, string level )
        {
            // Find Add New element under Language and click
            Thread.Sleep(4000);           
            IWebElement addNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            IWebElement addLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.Click();                                
            addLanguage.SendKeys(language);

            //Select the drop down list --Level
            var levelLanguage = driver.FindElement(By.Name("level"));

            //Identify from select element dropdown
            var selectElement = new SelectElement(levelLanguage);
            //select by text
            selectElement.SelectByText(level);

            //Add new profile language
            IWebElement addNewLanguageDetails = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addNewLanguageDetails.Click();
        }
        public string GetNewLanguage(IWebDriver driver)
        {
            WaitHelpers.WaitForElementToBeClikable(driver, "XPath", "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement newLanguage = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
        }

        public string GetNewLevel(IWebDriver driver)
        {
            WaitHelpers.WaitForElementToBeClikable(driver, "XPath", "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]", 5);
            IWebElement newLevel = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newLevel.Text;
        }
    }
}
