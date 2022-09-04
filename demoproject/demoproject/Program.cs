using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (hellohari.Text == "Hello hari!") 
{
    Console.WriteLine("LOGIN SUCCESSFULL");
}

else
{
    Console.WriteLine("LOGIN FAILED");
}



//create new record
IWebElement goToAdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
goToAdministrationTab.Click();
IWebElement goToTMTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
goToTMTab.Click();
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
IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage.Click();
IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if(newCode.Text == "ABC")
{
    Console.WriteLine("new record created");
}
else
{
    Console.WriteLine("new record unsuccessfull");
}

