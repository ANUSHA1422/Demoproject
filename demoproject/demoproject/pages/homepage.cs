
using demoproject.utilities;
using OpenQA.Selenium;

namespace demoproject.pages
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            IWebElement goToAdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            goToAdministrationTab.Click();

            waithelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 9);


            IWebElement goToTMTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            goToTMTab.Click();
            Thread.Sleep(2000);

        }


        public void GoToEmployeePage(IWebDriver driver)
        {        //    IWebElement goToAdministartionTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        //    goToAdministartionTab.Click();

        //    waithelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 9);

        //    IWebElement goToEmployeePage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
        //    goToEmployeePage.Click();
        }

        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        //    internal void goToTMTab(IWebDriver driver)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void goToTMTab(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

        ////internal void goToTmPage(IWebDriver driver)
        ////{
        ////    throw new NotImplementedException();
        ////}

        //internal void goToTmPage(IWebDriver driver)
        //{
        //    throw new NotImplementedException();//
        //}

        //internal void goToTmPage(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}

    }
}

