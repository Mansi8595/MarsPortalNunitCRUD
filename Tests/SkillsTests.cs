using MarsPortal.Pages;
using MarsPortal.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsPortal.Tests
{
    internal class SkillsTests : CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage();
        SkillTab SkillTabObj = new SkillTab();

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
        public void CreateSkill()

        {
          SkillTabObj.CreateSkill(driver);

        }

        [Test, Order(2)]
        public void EditSkill()
        { 
            SkillTabObj.EditSkill(driver);
        }
        [Test, Order(3)]
        public void DeleteSkill()
        {
            SkillTabObj.DeleteSkill(driver);
        }
    }
}
