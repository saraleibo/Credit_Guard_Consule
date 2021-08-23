using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CreditGuardConsole.Infrstructure.PageObjects
{
    public class MainPage
    {
        [FindsBy(How = How.Id, Using = "additionalIdentifier")]
        public IWebElement additionalIdentifier;
        [FindsBy(How = How.Id, Using = "additionalIdentifier-error-label")]
        public IWebElement additionalIdentifiererror;
        //יש להזין מזהה
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;
        [FindsBy(How = How.Id, Using = "password-error-label")]
        public IWebElement passworderror;
        //יש להזין סיסמא
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement username;
        [FindsBy(How = How.Id, Using = "username-error-label")]
        public IWebElement usernameerror;
        //יש להזין דואר אלקטרוני

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement submit;
        [FindsBy(How = How.ClassName, Using = "blue-link")]
        public IWebElement linkpassword;
        [FindsBy(How = How.ClassName, Using = "error-description")]
        public IWebElement error_description;

        





    }
}
