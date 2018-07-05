using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using GR04TechnicalTest.Pages;
using System.Threading;

namespace GR04TechnicalTest.Pages
{
    public class ArticlePage
    {
        IWebDriver driver;
        By articleInformation = By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div/p");
        By commentBox = By.XPath("/html/body/div/div/div/div[2]/div[3]/div/div/form/div[1]/textarea");
        By articleTitle = By.TagName("h1");

        public ArticlePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetArticleInformation()
        {
            Thread.Sleep(1000);
            return driver.FindElement(articleInformation).Text.Trim();
        }

        public string GetArticleTitle()
        {
            Thread.Sleep(1000);
            return driver.FindElement(articleTitle).Text.Trim();
        }

        public bool IsCommentBox()
        {
            Thread.Sleep(1000);
            return driver.FindElement(commentBox).Displayed;
        }        
    }
}
