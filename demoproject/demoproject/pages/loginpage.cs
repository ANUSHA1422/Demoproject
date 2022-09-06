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

    }
}
