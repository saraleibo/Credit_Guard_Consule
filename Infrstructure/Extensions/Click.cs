using System;
using System.Collections.Generic;
using System.Text;
using CreditGuardConsole.Utilities;
using OpenQA.Selenium;

namespace CreditGuardConsole.Infrstructure.Extensions
{
    public class Click:ComOps
    {

        public static void click(IWebElement element)
        {
            try
            {
                element.Click();
              //  ReportStep(LogStatus.Pass, "Element: was clicked successfully");
            }
            catch (Exception e)
            {
              //  ReportFailedStep(LogStatus.Fail, "Element was NOT clicked, See Error: " + e);
            }
        }
    }
}
