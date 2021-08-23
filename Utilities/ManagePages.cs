using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace CreditGuardConsole.Utilities
{
    public class ManagePages:Base
    {
        public static void InitPages()
        {
            PageFactory.InitElements(driver, main);
            PageFactory.InitElements(driver, result);
        }
    }
}
