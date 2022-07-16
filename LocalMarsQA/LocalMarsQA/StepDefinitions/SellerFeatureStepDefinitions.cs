using LocalMarsQA.Pages;
using System;
using TechTalk.SpecFlow;
using LocalMarsQA.Utilities;

namespace LocalMarsQA.StepDefinitions 
{
    [Binding]
    public class SellerFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I login as existing seller")]
        public void GivenILoginAsExistingSeller()
        {
            //Loginpage object initilization & definitions
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I add new language details in profile page")]
        public void WhenIAddNewLanguageDetailsInProfilePage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddNewLanguage(driver);
        }

        [Then(@"I verify the details added sucessfully")]
        public void ThenIVerifyTheDetailsAddedSucessfully()
        {
            throw new PendingStepException();
        }
    }
}
