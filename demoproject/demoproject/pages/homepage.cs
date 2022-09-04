
using demoproject.utilities;
using OpenQA.Selenium;

namespace demoproject.pages
{
    public class homepage
    {
        public static void goTOTMpage(IWebDriver driver)
        {
            IWebElement goToAdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            goToAdministrationTab.Click();

            waithelpers.WaitToBeClickable(driver,"XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",3);


            IWebElement goToTMTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            goToTMTab.Click();

        }

        internal void goToTmPage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

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
