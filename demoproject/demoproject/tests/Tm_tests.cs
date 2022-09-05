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
    [Parallelizable]
   
    public class Tm_tests : commondriver
    {
        homepage homePageObj = new homepage();

        TMpage tmPageObj = new TMpage();

        //[SetUp]
        //public void LoginActions()
        //{
        //    driver = new ChromeDriver();


        //    loginpage loginPageObj = new loginpage();
        //    loginpage.loginsteps(driver);


        //homepage homePageObj = new homepage();
        //homePageObj.goToTMTab(driver);



        [Test,Order (1),Description("check if user is able to create Tm record")]
        public void CreateTmTesr(IWebDriver driver)
        {
        /*homepage homePageObj = new homepage()*/;
        homePageObj.goToTMTab(driver);

            //TMpage tmPageObj = new TMpage();
            TMpage.createTm(driver);

        }

        [Test,Order(2),Description("check if user is able to edit Tm record")]
        public void EditTest()
        {
           /* homepage homePageObj = new homepage()*/;
            homePageObj.goToTMTab(driver);

            //TMpage tmPageObj = new TMpage();
            TMpage.EditTM(driver);

        }
        [Test,Order(3),Description("check if user is able to delete Tm record ")]
        public void DeleteTest()
        {
            /*homepage homePageObj = new homepage()*/;
            homePageObj.goToTMTab(driver);

            //TMpage tmPageObj = new();
            tmPageObj.deleteTM(driver);
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
