using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using demoproject.utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace demoproject.pages
{
    public class Employeepage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            IWebElement goToCreateButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            goToCreateButton.Click();
            IWebElement goToNameTextBox = driver.FindElement(By.Id("Name"));
            goToNameTextBox.SendKeys("ANUSHA");
            IWebElement goToUserNameTextBox = driver.FindElement(By.Id("Username"));
            goToUserNameTextBox.SendKeys("ANUSHA");
            IWebElement goToContactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            goToContactTextBox.SendKeys("1422");
            IWebElement goToPasswordTextBox = driver.FindElement(By.Id("Password"));
            goToPasswordTextBox.SendKeys("Abcdefg22$");
            IWebElement goToRetypePassword = driver.FindElement(By.Id("RetypePassword"));
            goToRetypePassword.SendKeys("Abcdefg22$");
            IWebElement goToIsAdminBox = driver.FindElement(By.Id("IsAdmin"));
            goToIsAdminBox.Click();
            IWebElement goToVehicleButton = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            goToVehicleButton.SendKeys("CAR");
            IWebElement goToGroupButton = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            goToGroupButton.SendKeys("ABC");
            IWebElement goToSaveButton = driver.FindElement(By.Id("SaveButton"));
            goToSaveButton.Click();
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            

            IWebElement Name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement UserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(Name.Text == "ANUSHA", "ACTUAL NAME AND EXPECTED NAME DO NOT MATCH");
            Assert.That(UserName.Text == "ANUSHA", "ACTUAL USERNAME AND EXPECTED USERNAME DO NOT MATCH");

        }


        public void EditEmployee(IWebDriver driver)   
        {
        //    IWebElement goToLastPageButton = driver.FindElement(By.XPath(""));
        //    goToLastPageButton.Click();
            IWebElement goToEditButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            goToEditButton.Click();
            IWebElement EditName = driver.FindElement(By.Id("Name"));
            EditName.Clear();
            EditName.SendKeys("DX");
            IWebElement EditUserName = driver.FindElement(By.Id("Username"));
            EditUserName.Clear();
            EditUserName.SendKeys("DX");
            IWebElement EditContact = driver.FindElement(By.Id("EditContactButton"));
            EditContact.Clear();
            EditContact.SendKeys("2214");
            IWebElement EditPassword = driver.FindElement(By.Id("Password"));
            EditPassword.Clear();
            EditPassword.SendKeys("1422Anud$");
            IWebElement EditRetypePassword = driver.FindElement(By.Id("RetypePassword"));
            EditRetypePassword.Clear();
            EditRetypePassword.SendKeys("1422Anud$");
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();

            IWebElement EditedName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement EditedUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(EditedName.Text == "DX", "actual name and expected name do not match");
            Assert.That(EditedUserName.Text == "DX", "actual username and expected username do not match");



        }



        public void DeleteEmployee(IWebDriver driver)
        {
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            driver.SwitchTo().Alert().Accept();

            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));
            IWebElement newUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[2]"));

            Assert.That(newName.Text != "DX", "EMPLOYEE DELETED");
            Assert.That(newUserName.Text != "DX", "USERNAME DELETED");

        }


    }
}
