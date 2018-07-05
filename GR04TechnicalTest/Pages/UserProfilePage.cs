using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using GR04TechnicalTest.Pages;
using System.Threading;

namespace GR04TechnicalTest
{
    public class UserProfilePage
    {
        IWebDriver driver;
        By showUsername = By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[4]/a");
        By yourFeed = By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div/ul/li[1]/a");
        By emptyUserFeed = By.XPath("/html/body/div/div/div/div[2]/div/div[1]/article-list/div[2]");
        By newArticleLink = By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[2]/a");
        By articleTitleField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input");
        By articleSummaryField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input");
        By articleBodyField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/textarea");
        By articleTagField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[4]/input");
        By publishButton = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button");

        public UserProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string ShowUserName()
        {
            Thread.Sleep(1000);
            return driver.FindElement(showUsername).Text.Trim();
        }

        public string GetTitle()
        {
            Thread.Sleep(1000);
            return driver.FindElement(yourFeed).Text.Trim();
        }

        public string GetFeedemptyMessage()
        {
            Thread.Sleep(1000);
            return driver.FindElement(emptyUserFeed).Text.Trim();
        }

        public void ClickNewArticleLink()
        {
             driver.FindElement(newArticleLink).Click();
         
        }
        public void WriteToArticleTitleField(string articleText)
        {
            IWebElement articleTitle= driver.FindElement(articleTitleField);
            articleTitle.Clear();
            articleTitle.SendKeys(articleText);
            articleTitle.SendKeys(Keys.Tab);
        }
        public void WriteToArticleSummaryField(string summaryText)
        {
            IWebElement articleSummary = driver.FindElement(articleSummaryField);
            articleSummary.Clear();
            articleSummary.SendKeys(summaryText);
            articleSummary.SendKeys(Keys.Tab);
        }
        public void WriteToArticleBodyField(string articleBodyText)
        {
            IWebElement articleBody = driver.FindElement(articleBodyField);
            articleBody.Clear();
            articleBody.SendKeys(articleBodyText);
            articleBody.SendKeys(Keys.Tab);
        }
        public void WriteToArticleTagField(string articleTagText)
        {
            IWebElement articleTag = driver.FindElement(articleTagField);
            articleTag.Clear();
            articleTag.SendKeys(articleTagText);
            articleTag.SendKeys(Keys.Tab);
        }
        public void ClickPublishButton()
        {
            driver.FindElement(publishButton).Click();           
        }
    }
}
