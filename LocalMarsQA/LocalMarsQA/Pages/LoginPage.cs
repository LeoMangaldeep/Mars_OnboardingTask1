using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using NUnit.Framework;
using LocalMarsQA.Utilities;

namespace LocalMarsQA.Pages

    {
        public class LoginPage
        {
            public void LoginActions(IWebDriver driver)
            {
                
                //maximise window
                driver.Manage().Window.Maximize();

                //launch url "MarsQA"
                driver.Navigate().GoToUrl("http://localhost:5000/Home");
                IWebElement signInTextbox = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));

                //WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 5);
                signInTextbox.Click();
                Thread.Sleep(1500);

                Console.WriteLine("signInTextbox clicked");

                try
                {
                    // Select email address & enter valid username credentials.

                    IWebElement emailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                    WaitHelpers.WaitForElementToBeClikable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
                    emailAddress.SendKeys("mangalins@gmail.com");

                    // Select password textbox and enter valid credentials.
                    IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                    WaitHelpers.WaitForElementToBeClikable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[2]/input", 5);
                    passwordTextbox.SendKeys("industryconnect");

                    //identify the login textbox and click.
                    IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                    WaitHelpers.WaitForElementToBeClikable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 5);
                    loginButton.Click();

                Thread.Sleep(2500);

                }
                catch (Exception ex)
                {
                    Assert.Fail("Mars webpage did not launch", ex.Message);
                }

            }

        }
    }


