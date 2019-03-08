using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunit
{
    [TestFixture]
    public class TestClass:Hooks
    {
        [Test]
        [Category("One")]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
           

        }

        [Test]
        [Category("Two")]
        public void ExecuteAutomationTest()
        {
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("admin");
            Driver.FindElement(By.Name("Password")).SendKeys("admin");
            Driver.FindElement(By.Name("Login")).Submit();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }
    }
}
