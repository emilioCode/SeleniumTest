using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumTest
{
    class Sample1
    {
        //create the reference for the browser  
        IWebDriver driver = new ChromeDriver("D:\\Archivos del Escritorio\\SERIES\\Test\\release\\v91");//the path where the webdriver is
        [SetUp]
        public void Setup()
        {
            //open the browser
            //navigate to URL
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            //Maximize the browser window (Optional)
            //driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void ExecuteTest()
        {
            //perform browser operations  
            //identify the username text box  
            IWebElement ele = driver.FindElement(By.Id("email"));
            //enter the username value  
            ele.SendKeys("example@email.com");
            Thread.Sleep(2000);
            Console.Write("username value is entered\n");

            //identify the password text box  
            IWebElement ele1 = driver.FindElement(By.Name("pass"));
            //enter the password value  
            ele1.SendKeys("#####");
            Console.Write("password is entered\n");

            //click on the Log in button  
            IWebElement ele2 = driver.FindElement(By.Name("login"));
            ele2.Click();
            Thread.Sleep(3000);
            Console.Write("login button is clicked\n");
            //Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        { 
            //close the browser  
            driver.Close();
        }
    }
}
