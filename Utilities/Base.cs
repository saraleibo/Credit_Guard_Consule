using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using CreditGuardConsole.Infrstructure.PageObjects;
using OpenQA.Selenium;

namespace CreditGuardConsole.Utilities
{
    public class Base
    {
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test;
       
        public static MainPage main = new MainPage();
        public static ResultsPage result = new ResultsPage();
        public static DateTime CurrentTime = Convert.ToDateTime(DateTime.Now);
        public static String TimeStamp = CurrentTime.ToString("yyyy-MM-dd_HH-mm-ss");
        public static Random rnd = new Random();
    }
}
