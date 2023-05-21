using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.page;

namespace Module_II_Automation.Todois.code.test
{
    [TestClass]
    internal class CrudProject
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        ProjectSection projectSection = new ProjectSection();

        [TestMethod]
        public void VerifyCRUDProject() 
        {
            mainPage.loginButton.Click();
            loginSection.Login("ruizv.marcelo@gmail.com", "Mojix2023");

        }
    }
}
