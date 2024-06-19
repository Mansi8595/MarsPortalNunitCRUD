using MarsPortal.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsPortal.Pages
{
    internal class languageTab
    {
        public void CreateLanguage(IWebDriver driver)
        {

            //Actions
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target' and @data-tab='first']//div[contains(@class, 'ui teal button') and text()='Add New']")));
            driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target' and @data-tab='first']//div[contains(@class, 'ui teal button') and text()='Add New']")).Click();
            driver.FindElement(By.Name("name")).SendKeys("English");
            driver.FindElement(By.XPath("//select[@name='level']")).Click();
            driver.FindElement(By.XPath("//div[@class='five wide field']/select[@name='level']/option[@value='Fluent']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();

            //Assertion
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")));
            string Language = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            string Level = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
            Assert.That(Language, Is.EqualTo("English"), "Language value does not match");
            Assert.That(Level, Is.EqualTo("Fluent"), "Level value does not match");
        }

        public void EditLanguage(IWebDriver driver)
        {
            //Actions
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")));
            
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")).Click();
            driver.FindElement(By.Name("name")).SendKeys("Hindi");
            driver.FindElement(By.XPath("//select[@name='level']")).Click();
            driver.FindElement(By.XPath("//div[@class='five wide field']/select[@name='level']/option[@value='Fluent']")).Click();
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();

            //Assertion
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")));
            string Language = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            string Level = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
            Assert.That(Language, Is.EqualTo("EnglishHindi"), "Language value does not match");
            Assert.That(Level, Is.EqualTo("Fluent"), "Level value does not match");

        }
        public void DeleteLanguage(IWebDriver driver)
        {
            //Action
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")));
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();

            //Assertion
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")));
            string Language = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            string Level = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
            Assert.That(Language, Is.Not.EqualTo("EnglishHindi"), "Language value does not match");
            Assert.That(Level, Is.Not.EqualTo("Fluent"), "Level value does not match");
        }
    }
}

