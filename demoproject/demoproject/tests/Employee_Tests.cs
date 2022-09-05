using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoproject.pages;
using demoproject.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace demoproject.tests
{
    [TestFixture]
    [Parallelizable]
   
    public class Employee_Tests : commondriver
    {
        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();


            loginpage loginPageObj = new loginpage();
            loginpage.loginsteps(driver);


                homepage homePageObj = new homepage();
            homePageObj.goToEmployeePage(driver);

        }
            

           


        [Test]
        public void CreateEmployee()
        {
            Employeepage employeePageObj = new Employeepage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee()
        {
            Employeepage employeePageObj = new Employeepage();
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee()
        {
            Employeepage employeePageObj = new Employeepage();
            employeePageObj.DeleteEmployee(driver);
        }


        [TearDown]
        public void CloseRunTest()
        {
            driver.Quit();
        }

    }

}
