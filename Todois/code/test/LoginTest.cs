using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.page;

namespace Module_II_Automation.Todois.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        ProjectSection projectSection = new ProjectSection();

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly() 
        {
            mainPage.loginButton.Click();
            loginSection.emailTxtBox.SetText("ruizv.marcelo@gmail.com");
            loginSection.pwdTxtBox.SetText("Mojix2022");
            loginSection.loginButton.Click();


            Assert.IsTrue(projectSection.leftMenuBotton.IsControlDisplayed(), "ERROR!! no se logueo correctamente");

            
        }
    }
}
