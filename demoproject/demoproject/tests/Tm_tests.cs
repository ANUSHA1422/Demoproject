using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoproject.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using demoproject.utilities;




namespace demoproject.tests
{
    [TestFixture]
    public class Tm_tests : commondriver
    {
        

        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();


            loginpage loginPageObj = new loginpage();
            loginpage.loginsteps(driver);


            homepage homePageObj = new homepage();
            homePageObj.goToTmPage(driver);

        }
        [Test]
        public void CreateTmTesr()
        {
            tmpage tmPageObj = new tmpage();
            tmpage.createTm(driver);

        }

        [Test]
        public void DeleteTest()
        {
            tmpage tmPageObj = new();
            tmPageObj.deleteTM(driver);


        }
        [Test]
        public void EditTest()
        {
            tmpage tmPageObj = new tmpage();
            tmpage.EditTM(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

       

       //IWebDriver driver = new ChromeDriver();

       //       //page object intialization

       //     loginpage loginPageObj = new loginpage();
       //          loginPageObj.loginsteps(driver);


       //     homepage homePageObj = new homepage();
       //      homePageObj.goToTmPage(driver);

       //     tmpage tmPageObj = new tmpage();
       //      tmPageObj.createTm(driver);


          //   tmPageObj.editTM(driver);


       //        tmPageObj.deleteTM(driver);

    }

    //internal class tmPageObj
    //{
    //    internal static void editTM(IWebDriver driver)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
