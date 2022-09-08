using System;
using demoproject.pages;
using demoproject.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace demoproject.StepDefinitions
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginsteps(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);
        }

        [When(@"I created new time and material record")]
        public void WhenICreatedNewTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTm(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj. GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);
            Assert.That(newCode == "ABC", "actual code and expected code do not match");
            Assert.That(newDescription == "ABC", "actual description and expected description do not match");
            Assert.That(newPrice == "$22.00", "actual price and expected price do not match");

        }

        [When(@"I upadte '([^']*)' on an existing time and materail record")]
        public void WhenIUpadteOnAnExistingTimeAndMaterailRecord(string description)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, description);
        }

        [Then(@"The record should have updated 'Time")]
        public void ThenTheRecordShouldHaveUpdatedTime(string description)
        {

        }

     
    }


    
}
