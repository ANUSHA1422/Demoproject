using System;
using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;

namespace demoproject.pages
{
    public class LoginPage
    {
        public void loginsteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

        }
        //public void LoginSteps(IWebDriver driver)
        //{
        //    driver.Manage().Window.Maximize();

        //    // lanch turnup portal
        //    driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        //    Thread.Sleep(1000);

        //    try
        //    {
        //        // identify username textbox and enter valid username
        //        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        //        usernameTextbox.SendKeys("hari");
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Fail("TurnUp portal page did not launch", ex.Message);
        //    }


        //    // indetify password textbox and enter valid password
        //    IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        //    passwordTextbox.SendKeys("123123");

        //    // identify login button and click on it
        //    IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
        //    loginButton.Click();
        //}

    }
}
