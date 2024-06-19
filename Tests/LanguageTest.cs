using MarsPortal.Pages;
using MarsPortal.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsPortal.Tests
{
    internal class LanguageTest : CommonDriver
    {
       
        
        LoginPage LoginPageObj = new LoginPage();
        languageTab LanguageTabObj = new languageTab();

        [SetUp]
        public void SetUp() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            LoginPageObj.login(driver);
            
        }
        
        [TearDown]
        public void teardown()
        {
            driver.Quit();
        }
        
        [Test, Order(1)]
        public void CreateLanguage()

        {
          LanguageTabObj.CreateLanguage(driver);

        }

        [Test, Order(2)]
        public void EditLanguage()
        { 
            LanguageTabObj.EditLanguage(driver);
        }
        [Test, Order(3)]
        public void DeleteLanguage()
        {
            LanguageTabObj.DeleteLanguage(driver);
        }
    }
}
