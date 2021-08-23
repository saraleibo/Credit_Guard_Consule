using System;
using System.Collections.Generic;
using System.Text;
using CreditGuardConsole.Infrstructure.Extensions;
using CreditGuardConsole.Utilities;

namespace CreditGuardConsole.Flows
{
    public class Flows_login:ComOps
    {
        public static void login()
        {
            Sendkeys.sendkeys(main.username, "qatest@mailinator.com");
            Sendkeys.sendkeys(main.password, "Admin123.");
            Sendkeys.sendkeys(main.additionalIdentifier, "123456");
            Click.click(main.submit);
            Verify.VerifyUrl("https://cg-uat.stage-rc.com/merchant-configuration/details?merchantId=7454", "Home_Page");

        }

        public static void forgetpassword()
        {
            Click.click(main.linkpassword);
            Verify.VerifyUrl("https://cg-uat.stage-rc.com/login/forgot-password", "password_Page");
        }
        public static void requiredfields()
        {
            Click.click(main.submit);
            Verify.VerifyTextExistsInElement(main.usernameerror, "יש להזין דואר אלקטרוני");
            Verify.VerifyTextExistsInElement(main.passworderror, "יש להזין סיסמא");
            Verify.VerifyTextExistsInElement(main.additionalIdentifiererror, "יש להזין מזהה");
        }


        public static void notvalid_login()
        {
            Sendkeys.sendkeys(main.username, "leibo.sara@gmail.com");
            Sendkeys.sendkeys(main.password, "Admin123!");
            Sendkeys.sendkeys(main.additionalIdentifier, "1234567");
            Click.click(main.submit);
            Verify.VerifyTextExistsInElement(main.error_description, "אחד או יותר מפרטי ההזדהות אינם תקנים ");

        }

        public static void MaxInputLenght()
        {

            string maxLength=main.additionalIdentifier.GetAttribute("maxlength");

            Sendkeys.sendkeys(main.additionalIdentifier, "12345678901234567890");
            if(main.additionalIdentifier.Text.Length > int.Parse(maxLength))
            {
                Verify.VerifyTextExistsInElement(main.additionalIdentifiererror, "יש להזין בין 6 ל 16 ספרות ");
            }



        }

        public static void passwordformat()
        {

            string type = main.password.GetAttribute("type");
            Verify.Verifytype("password", type);
        }

    }
}
