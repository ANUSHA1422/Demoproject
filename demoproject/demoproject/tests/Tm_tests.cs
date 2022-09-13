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
using demoproject.Pages;

namespace demoproject.tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Test, Order(1), Description("Check if user is able to create TM record with valid credentials")]
        public void CreateTMTest()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMpage(driver);

            // TM page object initialization and definition
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit existing TM record")]
        public void EditTMTest()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMpage(driver);

            // Edit TM
            //tmPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete existing TM record")]
        public void DeleteTMTest()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMpage(driver);

            // Delete TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }
    }



}
