﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.control;
using OpenQA.Selenium;

namespace Module_II_Automation.Todois.code.page
{
    public class LoginSection
    {
        public TextBox emailTxtBox = new TextBox(By.XPath("//div/input[@id='element-0']"));
        public TextBox pwdTxtBox = new TextBox(By.XPath("//div/input[@id='element-3']"));
        public Button loginButton = new Button(By.Id("start-email-login"));
    }
}
