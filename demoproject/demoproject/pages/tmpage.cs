
using NuGet.ContentModel;
using NuGet.Frameworks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace demoproject.pages
{
    public class TMPage
    {
       

        public  void CreateTm(IWebDriver driver)
        {
            IWebElement goToCreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            goToCreateNewButton.Click();
            IWebElement goToTypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            goToTypeCodeDropDown.Click();
            IWebElement goToCodeButton = driver.FindElement(By.Id("Code"));
            goToCodeButton.SendKeys("ABC");
            IWebElement goToDescriptionButton = driver.FindElement(By.Id("Description"));
            goToDescriptionButton.SendKeys("ABC");
            IWebElement PriceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTag.Click();
            IWebElement goToPricePerUnit = driver.FindElement(By.Id("Price"));
            goToPricePerUnit.SendKeys("22");
            IWebElement goToSaveButton = driver.FindElement(By.Id("SaveButton"));
            goToSaveButton.Click();
            Thread.Sleep(1000);
            

            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            //IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
           // IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
           // IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assert.That(newCode.Text == "ABC", "actual code and expected code do not match");
            //Assert.That(newDescription.Text == "ABC", "actual description and expected description do not match");
            //Assert.That(newPrice.Text == "$22.00", "actual price and expected price do not match");

            //if (newCode.Text == "ABC")
            //{
            //    Assert.Pass("new record created");
            //}
            //else
            //{
            //   Assert.Fail("new record unsuccessfull");
            //}

        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;

        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;

        }


        public void EditTM(IWebDriver driver, string description)
        {
            IWebElement goToEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            goToEditButton.Click();
            IWebElement editTypeCodeButton = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            editTypeCodeButton.Click();
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.SendKeys("dx");
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.SendKeys("dx");
            IWebElement editPriceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceTag.Click();
            IWebElement editPricePerUnit = driver.FindElement(By.Id("Price"));
            editPricePerUnit.SendKeys("14");
            IWebElement gotoSaveButton = driver.FindElement(By.Id("SaveButton"));
            gotoSaveButton.Click();
            Thread.Sleep(1000);

            IWebElement goToLPButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLPButton.Click();
            IWebElement newEditCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(newEditCode.Text == "ABCdx", "actual code and expected code do not match");
            if (newEditCode.Text == "ABCdx")
            {
                Console.WriteLine("edit successfull");
            }
            else
            {
                //Console.WriteLine("edit unsuccessfull");
                Assert.Fail("RECORD NOT EDITED");
            }
           
        }

        
        
           

        public void DeleteTM(IWebDriver driver )
        {
            IWebElement goTolastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            goTolastPage.Click();
            IWebElement GOTODeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            GOTODeleteButton.Click();
            driver.SwitchTo().Alert().Accept();

            //Assert.That(LastCode.Text != "ABCdx", "actual code deleted");

            //if (newCode.Text != "ABCdx")
            //{
            //    Console.WriteLine("delete successfull");

            //}
            //else
            //{
            //    Console.WriteLine("delete unsuccessfull");
            //}

        }

        //internal static void CreateTM(IWebDriver driver)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
