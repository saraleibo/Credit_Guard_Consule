using System;
using System.Collections.Generic;
using System.Text;
using CreditGuardConsole.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CreditGuardConsole.Infrstructure.Extensions
{
    public class Verify : ComOps
    {

        public static void VerifyTextExistsInElement(IWebElement element, String TextValue)
        {
            try
            {
                NUnit.Framework.Assert.AreEqual(TextValue, element.Text);
                 ReportStep(LogStatus.Pass, "Text: " + TextValue + " Exists in Element");
            }
            catch (AssertionException e)
            {
                 ReportFailedStep(LogStatus.Fail, TextValue + " Does NOT Exist in Element");
            }

        }
        public static void VerifyUrl(string ExpectedUrl, string Pagename)
        {
            try
            {
                NUnit.Framework.Assert.AreEqual(ExpectedUrl, driver.Url);
                 ReportStep(LogStatus.Pass, "The move to the  " + Pagename + " was saccessful");
            }
            catch (AssertionException e)
            {
                 ReportFailedStep(LogStatus.Fail, "The move to the  " + Pagename + " wasn't saccessful");
            }
        }
        public static void Verifytype(string Expectedtype, string type)
        {
            try
            {
                NUnit.Framework.Assert.AreEqual(Expectedtype, type);
                 ReportStep(LogStatus.Pass, "The type password correct");
            }
            catch (AssertionException e)
            {
                 ReportFailedStep(LogStatus.Fail, "The type password not correct");
            }
        }
    }
}

    
