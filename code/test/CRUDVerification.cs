using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.factoryBrowser;
using Module_II_Automation.Todois.code.page;

namespace Module_II_Automation.Todois.code.test
{
    [TestClass]
    public class CRUDVerification : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        ProjectSection projectSection = new ProjectSection();
        
       

        [TestMethod]

        public void VerifyTheCRUDisSucessfuly() 
        {
            

            
            //login
            mainPage.loginButton.Click();
            loginSection.Login("ruizv.marcelo@gmail.com","Mojix2023");
         
            //create
            projectSection.newProjectButton.Click();
            projectSection.projectName.SetText("MarceloTest");
            projectSection.colorProjectMenu.Click();
            projectSection.colorProjectSelector.Click();
            projectSection.projectSaveButton.Click();

            Assert.IsTrue(projectSection.ProjectNameIsDisplayed("MarceloTest"),"Error no se creo el proyecto corrrectamente");

            //edit
            projectSection.editProjectButton.Click();
            projectSection.editProjectMenu.Click();
            projectSection.projectName.SetText("MarceloEdited");
            projectSection.projectSaveButton.Click();

            Assert.IsTrue(projectSection.ProjectNameIsDisplayed("MarceloEdited"), "ERROR el proyecto no fue editado");

            //delete
            projectSection.editProjectButton.Click();
            projectSection.deleteProjectMenu.Click();
            projectSection.deleteProjectButton.Click();

            Assert.IsFalse(projectSection.ProjectNameIsDisplayed("MarceloEdited"), "ERROR el proyecto no fue borrado");
                        
        }
        
    }
}
