using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoproject.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace demoproject.utilities
{
    public class commondriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();


            LoginPage loginPageObj = new LoginPage();
            LoginPage.loginsteps(driver);


        }
    }
}
