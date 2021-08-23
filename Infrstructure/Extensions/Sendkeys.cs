using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CreditGuardConsole.Infrstructure.Extensions
{
    public class Sendkeys
    {
        public static void sendkeys(IWebElement element, String TextValue)
        {
            try
            {
                element.SendKeys(TextValue);
                ReportStep(LogStatus.Pass, "Element:  was Updated successfully");
            }
            catch (Exception e)
            {
                ReportFailedStep(LogStatus.Fail, "Element was NOT Update, See Error: " + e);
            }
        }
    }
}
