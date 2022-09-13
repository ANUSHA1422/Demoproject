using System;
using System.Diagnostics;
using demoproject.pages;
using demoproject.Pages;
using demoproject.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace demoproject.StepDefinitions
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();


        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.loginsteps(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObj.GoToTMpage(driver);
        }

        [When(@"I created new time and material record")]
        public void WhenICreatedNewTimeAndMaterialRecord()
        {
            tmPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "August2022", "Actual code and expected code do not match");
            Assert.That(newDescription == "August2022", "Actual description and expected description do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match");
        }

        [When(@"I upadte '([^']*)','([^']*)' and '([^']*)' on an existing time and materail record")]
        public void WhenIUpadteAndOnAnExistingTimeAndMaterailRecord(string description, string code, string price)
        {
            tmPageObj.EditTM(driver, description, code, price);
        }

        [Then(@"The record should have the updated '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string description, string code, string price)
        {
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);

            // Assertion
            Assert.That(editedDescription == description, "Actual Description and expected description do not match.");
            Assert.That(editedCode == code, "Actual Code and expected code do not match.");
            Assert.That(editedPrice == price, "Actual Price and expected price do not match.");
        }
    }
}
