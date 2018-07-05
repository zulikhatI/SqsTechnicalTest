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
    class SignUpPageStepsDefinition : CommonStepsDefinition
    {
        [Then(@"the user is directed to the Sign up area")]
        public void ThenTheUserIsDirectedToTheSignUpArea()
        {
            string actualResult = "https://angularjs.realworld.io/#/register";
            string expectedResult = setUpObj.signUpPageObj.GetPageURL();
            Assert.IsTrue(actualResult.Equals(expectedResult), "Actual result is not equal to an expected result");
            
        }

        [Then(@"a validation error is displayed")]
        public void ThenAValidationErrorIsDisplayed()
        {
            string expectedResult = "username has already been taken";            
            string actualResult = setUpObj.signUpPageObj.ErrorMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult), "Actual result is not equal to an expected result");
        }
        
        [When(@"the user tries to sign up with a password that is too short")]
        public void WhenTheUserTriesToSignUpWithAPasswordThatIsTooShort()
        {
            setUpObj.signUpPageObj.WriteToShortPasswordField();
        }
    }
}
