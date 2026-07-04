using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM_Automation.Pages
{
    internal class BasePage
    {
        protected IWebDriver driver { get; set; }

        public BasePage(WebDriver myDriver)
        {
            this.driver = myDriver;
        }
    }
}
