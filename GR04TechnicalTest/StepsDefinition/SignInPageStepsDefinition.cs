using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GR04TechnicalTest.StepsDefinition
{
    [Binding]
    class SignInPageStepsDefinition : CommonStepsDefinition
    {
        string emailField = "tester2.ve@gmail.com";
        string passwordField = "testing12345";

        [Then(@"the user is automatically logged in")]
        [Then(@"the user is logged in")]
        [Then(@"the users name is displayed")]
        public void ThenTheUserIsAutomaticallyLoggedIn()
        {
            string expectedResult = "Testing2";
            string actualResult = setUpObj.userProfilePageObj.ShowUserName();
            Assert.IsTrue(actualResult.Equals(expectedResult));
        }


        [When(@"the user signs in")]
        [Given(@"a user is logged in")]
        public void WhenTheUserSignsIn()
        {
            setUpObj.homePageObj.ClickSignIn();
            setUpObj.signInPageObj.WriteToExistingEmailField(emailField);
            setUpObj.signInPageObj.WriteToExistingPasswordField(passwordField);
            setUpObj.signInPageObj.ClickSignInButton();
        }
    }
}
