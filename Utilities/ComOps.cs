using System;
using System.IO;
using System.Xml;
using AventStack.ExtentReports;
using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CreditGuardConsole.Utilities
{
    public class ComOps : Base
    {

        [OneTimeSetUp]
        public void startSession()
        {
            InitBrowser();
            ManagePages.InitPages();
            InitReport();
        }

        [TearDown]
        //public void AfterTest()
        //{
        //    CloseReportTest();
        //}

        [OneTimeTearDown]
        public void closeSession()
        {
            closeReportAndBrowser();
        }

        public void InitBrowser()
        {
            switch (getData("BrowserType"))
            {
                case "chrome":
                    driver = new ChromeDriver(".");
                    break;
                case "firefox":
                    driver = new FirefoxDriver(".");
                    break;
                case "ie":
                    driver = new InternetExplorerDriver(".");
                    break;
                case "edge":
                    driver = new EdgeDriver(".");
                    break;

                default:
                    throw new Exception("not a valid browser name");
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(getData("URL"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }




        public static string getData(string sNodeName)
        {
            using (XmlReader reader = XmlReader.Create(@"C:\Users\sara\source\repos\CreditGuardConsole\Configuration\DataConfig.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name.ToString().Equals(sNodeName))
                            return reader.ReadString();
                    }
                }
            }
            return "NULL";
        }

        public void InitReport()
        {
            Directory.CreateDirectory(getData("ReportFilePath") + TimeStamp);
            //extent = new ExtentReports(getData("ReportFilePath") + TimeStamp + getData("ReportFileName"));
        }

        public static void  InitReportTest(String TestName, String TestDescription)
        {
            


        }

        //public static void ReportStep(LogStatus Status, String StepDetails)
        //{
        // //   test.Log(Status, StepDetails);
        //}

        //public static void ReportFailedStep(LogStatus Status, String StepDetails)
        //{
        //    test.Log(Status, StepDetails + test.AddScreenCapture(ScreenShot()));
        //}

        //public void CloseReportTest()
        //{
        //    extent.EndTest(test);
        //}

        public void closeReportAndBrowser()
        {
            driver.Quit();
            // extent.Close();
            //extent.Flush();
        }

        public static String ScreenShot()
        {
            String location = getData("ReportFilePath") + TimeStamp + "\\image" + rnd.Next(999999) + ".png";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(location, ScreenshotImageFormat.Png);
            return location;
        }
    }

}

