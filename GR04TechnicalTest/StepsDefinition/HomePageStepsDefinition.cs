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
    class HomePageStepsDefinition : CommonStepsDefinition
    {
        [When(@"a user tries to like an article")]
        public void WhenAUserTriesToLikeAnArticle()
        {
            setUpObj.homePageObj.ClickArticleLike();
        }

        [Then(@"the global feeds and popular tags are displayed")]
        public void ThenTheGlobalFeedsAndPopularTagsAreDisplayed()
        {
            string expectedGlobalText = "Global Feed";
            string expectedPopularTagsText = "Popular Tags";

            string actualGlobalText = setUpObj.homePageObj.GetGlobalFeed();
            string actualPopularTagsText = setUpObj.homePageObj.GetPopularTags();

            Assert.AreEqual(actualGlobalText, expectedGlobalText);
            Assert.AreEqual(actualPopularTagsText, expectedPopularTagsText);
        } 
    }
}
