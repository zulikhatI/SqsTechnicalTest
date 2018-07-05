using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using GR04TechnicalTest.Pages;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GR04TechnicalTest
{
    public class HomePage 
    {
        IWebDriver driver;

        By signup = By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a");
        By signIn = By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[2]/a");
        By articlelike = By.XPath("/html/body/div/div/div/div[2]/div/div[1]/article-list/article-preview[1]/div/article-meta/div/ng-transclude/favorite-btn/button/i");
        By globalFeed = By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div/ul/li[2]/a");
        By popularTags = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/p");
        By popularTagslist = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/div[1]");               

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickSignUp()
        {
            driver.FindElement(signup).Click();
        }

        public void ClickSignIn()
        {
            driver.FindElement(signIn).Click();
        }
        public void ClickArticleLike()
        {
            driver.FindElement(articlelike).Click();
        }
        public string GetGlobalFeed()
        {
            Thread.Sleep(1000);
            return driver.FindElement(globalFeed).Text.Trim();
        }
        public string GetPopularTags()
        {
            Thread.Sleep(1000);
            return driver.FindElement(popularTags).Text.Trim();
        }       
    }
}
