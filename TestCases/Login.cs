using System;
using System.Collections.Generic;
using System.Text;
using CreditGuardConsole.Flows;
using CreditGuardConsole.Infrstructure.Extensions;
using CreditGuardConsole.Utilities;
using NUnit.Framework;

namespace CreditGuardConsole.TestCases
{
    public class Login : ComOps
    {

        [Test]
        public void login_Test01()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name, "This is a Test Dscription");
            Flows_login.login();
           
        }

        [Test]
        public void login_Test02()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name, "This is a Test Dscription");
            Flows_login.forgetpassword();
        }
        [Test]
        public void login_Test03()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name, "This is a Test Dscription");
            Flows_login.notvalid_login();

        }

        [Test]
        public void login_Test04()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name, "This is a Test Dscription");
            Flows_login.requiredfields();

        }

        [Test]
        public void login_Test05()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name, "This is a Test Dscription");
            Flows_login.MaxInputLenght();
        }

        [Test]
        public void login_Test06()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name, "This is a Test Dscription");
            Flows_login.passwordformat();
        }



    }
}
