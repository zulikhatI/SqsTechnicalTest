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
    public  class SignUpPage
    {
          
        IWebDriver driver;
        By userNameField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input");
        By emailField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input");
        By passwordField = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input");
        By signUpButton = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button");
        By signInLink = By.XPath("/html/body/div/div/div/div/div/div/p/a[1]");
        By errorMessage = By.XPath("/html/body/div/div/div/div/div/div/list-errors/ul/div/li");

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void WriteToUserNameField()
        {
           IWebElement username =  driver.FindElement(userNameField);
           username.Clear();
           username.SendKeys("Test2");
           username.SendKeys(Keys.Tab);
        }
        public void WriteToEmailField()
        {
            IWebElement email = driver.FindElement(emailField);
            email.Clear();
            email.SendKeys("tester2.ve@gmail.com");
            email.SendKeys(Keys.Tab);
        }
        public void WriteToPasswordField()
        {
            IWebElement password = driver.FindElement(passwordField);
            password.Clear();
            password.SendKeys("testing12345");
            password.SendKeys(Keys.Tab);
        }
        public void ClickSignUpButton()
        {
            driver.FindElement(signUpButton).Click();          
        }
        public void WriteToShortPasswordField()
        {
            IWebElement password = driver.FindElement(passwordField);
            password.Clear();
            password.SendKeys("tes");
            password.SendKeys(Keys.Tab);
        }
        public string ErrorMessage()
        {
            Thread.Sleep(1000);
           return  driver.FindElement(errorMessage).Text;
        }
        public string GetPageURL()
        {
            return driver.Url;
        }
    }
}
