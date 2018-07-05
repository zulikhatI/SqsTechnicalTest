using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using GR04TechnicalTest.Pages;

namespace GR04TechnicalTest.Pages
{
    public  class SignInPage
    {      
       IWebDriver driver;
       By existingEmail = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input");
       By existingPassword = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input");
       By signInButton = By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button");

       public SignInPage(IWebDriver driver)
       {
           this.driver = driver;
       }
       
       public void WriteToExistingEmailField(string emailField)
       {
           IWebElement email = driver.FindElement(existingEmail);
           email.Clear();
           email.SendKeys(emailField);
           email.SendKeys(Keys.Tab);
       }
       public void WriteToExistingPasswordField(string passwordField)
       {
           IWebElement email = driver.FindElement(existingPassword);
           email.Clear();
           email.SendKeys(passwordField);
           email.SendKeys(Keys.Tab);
       }
       public void ClickSignInButton()
       {
           driver.FindElement(signInButton).Click();
       }      
    }
}
