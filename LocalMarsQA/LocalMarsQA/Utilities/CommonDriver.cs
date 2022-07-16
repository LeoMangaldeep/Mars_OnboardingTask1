using LocalMarsQA.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMarsQA.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        //Page object initialization
        LoginPage loginPageobj = new LoginPage();

        public void LoginActions()
        {
            //Open new chrome browser 
            driver = new ChromeDriver();

            //Loginpage object initilization & definition
            loginPageobj.LoginActions(driver);
        }

        public void CloseTestRun()
        {
            driver.Close();
        }
    }
}
