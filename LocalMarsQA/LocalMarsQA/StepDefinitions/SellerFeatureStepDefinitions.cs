using LocalMarsQA.Pages;
using System;
using TechTalk.SpecFlow;
using LocalMarsQA.Utilities;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace LocalMarsQA.StepDefinitions 
{
    [Binding]
    public class SellerFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I login as existing seller")]
        public void GivenILoginAsExistingSeller()
        {
            //Loginpage object initilization & definitions
            driver = new ChromeDriver();
             
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I add new '([^']*)','([^']*)' details in profile page")]
        public void WhenIAddNewDetailsInProfilePage(string p0, string p1)
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddNewLanguage(driver, p0, p1);
        }

        [Then(@"the record should have updated '([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string p0, string p1)
        {
            //Page object initialization
            ProfilePage profilePageObj = new ProfilePage();

            string newLanguage = profilePageObj.GetNewLanguage(driver);
            string newLevel = profilePageObj.GetNewLevel(driver);

            //Assertion to validate if new profile has been added
            Assert.That(newLanguage == p0, "Actual language and expected language do not match.");
            Assert.That(newLevel == p1, "Actual level and expected level do not match.");

        }
    }
}
