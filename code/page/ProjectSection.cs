using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.control;
using OpenQA.Selenium;

namespace Module_II_Automation.Todois.code.page
{
    public class ProjectSection
    {
        public Button leftMenuButton = new Button(By.XPath("//button[@class='left_menu_toggle top_bar_btn']"));

        //Create Project
        public Button newProjectButton = new Button(By.XPath("//div/button[@class='_8313bd46 f169a390 _8b7f1a82 _8644eccb _2a3b75a1']"));
        public TextBox projectName = new TextBox(By.XPath("//input [@id='edit_project_modal_field_name']"));
        public Button colorProjectMenu = new Button(By.XPath("//button [@class='color_dropdown_toggle form_field_control']"));
        public Button colorProjectSelector = new Button(By.Id("dropdown-select-0-option-salmon"));
        public Button projectSaveButton = new Button(By.XPath("//button[@type='submit']"));
        public Button createdProjectLabel = new Button(By.XPath("//a/span[text()='MarceloTest']"));

        //Edit Project
        public Button editProjectButton = new Button(By.XPath("//ul[@id=\"projects_list\"]/li[last()]/div/div/div/button"));
        public Button editProjectMenu = new Button(By.XPath("//div[text()='Editar proyecto']"));
        public Button assertProjectName = new Button(By.XPath("//a/span[text()='MarceloEdited']"));


        //Delete Project
        public Button deleteProjectMenu = new Button(By.XPath("//div[text()='Eliminar proyecto']"));
        public Button deleteProjectButton = new Button(By.XPath("//button[@class='_8313bd46 _7a4dbd5f _5e45d59f _2a3b75a1 _56a651f6']"));

        public Boolean ProjectNameIsDisplayed (String nameValue) 
        {
            Label projectName = new Label(By.XPath("//a/span[text()='"+nameValue+"']"));
            return projectName.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label projectName = new Label(By.XPath("//a/span[text()='" + nameValue + "']"));
            projectName.Click();
        }


    }
}
