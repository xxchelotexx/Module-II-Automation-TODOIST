using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.factoryBrowser;
using Module_II_Automation.Todois.code.page;

namespace Module_II_Automation.Todois.code.test
{
    [TestClass]
    public class LoginTest
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        ProjectSection projectSection = new ProjectSection();
        TestBase testBase = new TestBase();

        [TestMethod]

        public void VerifyTheLoginIsSuccessfuly() 
        {
            testBase.OpenBrowser();
            //session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com");
            mainPage.loginButton.Click();
            loginSection.Login("ruizv.marcelo@gmail.com","Mojix2023");
         
            //create
            projectSection.newProjectButton.Click();
            projectSection.projectName.SetText("MarceloTest");
            projectSection.colorProjectMenu.Click();
            projectSection.colorProjectSelector.Click();
            projectSection.projectSaveButton.Click();

            Assert.IsTrue(projectSection.createdProjectLabel.IsControlDisplayed(),"Error no se creo el proyecto corrrectamente");

            //edit
            projectSection.editProjectButton.Click();
            projectSection.editProjectMenu.Click();
            projectSection.projectName.SetText("MarceloEdited");
            projectSection.projectSaveButton.Click();

            Assert.IsTrue(projectSection.assertProjectName.IsControlDisplayed(), "ERROR el proyecto no fue editado");

            //delete
            projectSection.editProjectButton.Click();
            projectSection.deleteProjectMenu.Click();
            projectSection.deleteProjectButton.Click();
            Assert.IsFalse(projectSection.assertProjectName.IsControlDisplayed(), "ERRO el proyecto no fue borrado");

            testBase.CloseBrowser();
        }
        
    }
}
