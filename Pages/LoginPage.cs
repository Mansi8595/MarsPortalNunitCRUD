using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsPortal.Utils;

namespace MarsPortal.Pages
{
    internal class LoginPage
    {
        public void login(IWebDriver driver)
        {         
                
            
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
                driver.FindElement(By.Name("email")).SendKeys("mansisolanki1995@gmail.com");
                driver.FindElement(By.Name("password")).SendKeys("4321@Point");
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
           
        }


        }
    }
