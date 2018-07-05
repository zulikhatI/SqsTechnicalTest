using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using System.Threading;

namespace GR04TechnicalTest.Pages
{
  public class SetUp
    {
        IWebDriver driver;
        string baseUrl = ConfigurationManager.AppSettings["URL"];
        string browser = ConfigurationManager.AppSettings["browser"];
        public ArticlePage articlePageObj { get; set; }
        public HomePage homePageObj { get; set; }
        public SignInPage signInPageObj { get; set; }
        public SignUpPage signUpPageObj { get; set; }
        public UserProfilePage userProfilePageObj { get; set; }             

        public void StartUp()
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    driver = new InternetExplorerDriver();
                    break;
            }
           
            driver.Manage().Window.Maximize();            
            driver.Navigate().GoToUrl(baseUrl);
            Thread.Sleep(3000);
            articlePageObj = new ArticlePage(driver);
            homePageObj = new HomePage(driver);
            signInPageObj = new SignInPage(driver);
            signUpPageObj = new SignUpPage(driver);
            userProfilePageObj = new UserProfilePage(driver);            
        }
        
        public void ShutDown()
        {
            driver.Close();
        }
    }
        
}
