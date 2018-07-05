using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using GR04TechnicalTest.Pages;


namespace GR04TechnicalTest
{ 
    [Binding]
    class CommonStepsDefinition 
    {        
        public static SetUp setUpObj = new SetUp();
        
        [Given(@"a user is not logged in")]
        [When(@"the home page is shown")]
        public static void GivenAUserIsNotLoggedIn()
        {
            setUpObj.StartUp();
        }           

        [When(@"user signs up")]
        [When(@"the user tries to sign up with an email address that already exists")]
        [When(@"a user tries to sign up with a username that already exists")]
        public void TheUserSignsUp()
        {
            setUpObj.homePageObj.ClickSignUp();
            setUpObj.signUpPageObj.WriteToUserNameField();
            setUpObj.signUpPageObj.WriteToEmailField();
            setUpObj.signUpPageObj.WriteToPasswordField();
            setUpObj.signUpPageObj.ClickSignUpButton();
        }       

        [AfterScenario]
        public static void ShutDown()
        {
            setUpObj.ShutDown();
        }
    }
}
