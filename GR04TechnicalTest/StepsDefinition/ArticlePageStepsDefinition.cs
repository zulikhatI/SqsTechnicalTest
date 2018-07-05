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
    class ArticlePageStepsDefinition : CommonStepsDefinition
    {
        [Then(@"the Article section is displayed with the article information")]
        public void ThenTheArticleSectionIsDisplayedWithTheArticleInformation()
        {
            string expectedArticleTitle = "Testing";
            string expectedArticleInformation = "Test pass when the expected result equals actual result";

            string actualArticleTitle = setUpObj.articlePageObj.GetArticleTitle();
            string actualArticleInformation = setUpObj.articlePageObj.GetArticleInformation();

            Assert.IsTrue(actualArticleInformation.Equals(expectedArticleInformation));
            Assert.IsTrue(actualArticleTitle.Equals(expectedArticleTitle));
        }

        [Then(@"the Comment section is displayed")]
        public void ThenTheCommentSectionIsDisplayed()
        {
            bool actualResult = setUpObj.articlePageObj.IsCommentBox();
            Assert.IsTrue(actualResult);           
        }
    }
}
