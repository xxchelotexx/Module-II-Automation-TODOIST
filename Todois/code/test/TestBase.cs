﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.session;

namespace Module_II_Automation.Todois.code.test
{
    [TestClass]
    public class TestBase
    {
        [TestMethod]

        public void OpenBrowser() 
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com");
            
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
    
}
