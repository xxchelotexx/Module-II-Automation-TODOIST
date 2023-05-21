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
        public Button leftMenuBotton = new Button(By.XPath("//button[@class='left_menu_toggle top_bar_btn']"));
    }
}
