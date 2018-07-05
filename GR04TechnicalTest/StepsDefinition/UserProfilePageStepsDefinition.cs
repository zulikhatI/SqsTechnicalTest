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
    class UserProfilePageStepsDefinition : CommonStepsDefinition
    {

        string articleTitleField = "Testing";
        string summaryText = "Manual Testing";
        string articleBodyText = "Test pass when the expected result equal actual result";
        string articleTagText = "12345";
        

        [Then(@"the Your Feeds section should be displayed by default")]
        public void ThenTheYourFeedsSectionShouldBeDisplayedByDefault()
        {
            string expectedResult = "Your Feed";
            string actualResult = setUpObj.userProfilePageObj.GetTitle();
            Assert.IsTrue(actualResult.Equals(expectedResult));
        }

        [Then(@"the Your Feeds section should be empty")]
        public void ThenTheYourFeedsSectionShouldBeEmpty()
        {
            string expectedResult = "No articles are here... yet.";
            string actualResult = setUpObj.userProfilePageObj.GetFeedemptyMessage();
            Assert.IsTrue(actualResult.Equals(expectedResult));
        }

        // an existing user is able to see article information when a new article is created

        [When(@"the user creates a new article")]
        public void WhenTheUserCreatesANewArticle()
        {
            setUpObj.userProfilePageObj.ClickNewArticleLink();
            setUpObj.userProfilePageObj.WriteToArticleTitleField(articleTitleField);
            setUpObj.userProfilePageObj.WriteToArticleSummaryField(summaryText);
            setUpObj.userProfilePageObj.WriteToArticleBodyField(articleBodyText);
            setUpObj.userProfilePageObj.WriteToArticleTagField(articleTagText);
            setUpObj.userProfilePageObj.ClickPublishButton();
        }
    }
}
