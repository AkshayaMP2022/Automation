using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Seleniumcoredemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver(@"C:\Users\USER\Desktop\driver 105\chromedriver_win32");
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //Login
            var linklogin = webDriver.FindElement(By.Id("loginLink"));
            linklogin.Click();
            var Username = webDriver.FindElement(By.Id("UserName"));
            Username.SendKeys("admin");
            var pswd = webDriver.FindElement(By.Id("Password"));
            pswd.SendKeys("password");
            var login = webDriver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/section/form/div[4]/div/input"));
            login.Submit();
            
            //Employee List
            var Employee = webDriver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[3]/a"));
            Employee.Click();
            var createnew = webDriver.FindElement(By.XPath("/html/body/div[2]/form/a"));
            createnew.Click();
            webDriver.FindElement(By.Id("Name")).SendKeys("Achu");
            webDriver.FindElement(By.Id("Salary")).SendKeys("10000");
            webDriver.FindElement(By.Id("DurationWorked")).SendKeys("5");
            webDriver.FindElement(By.Id("Grade")).SendKeys("2");
            webDriver.FindElement(By.Id("Email")).SendKeys("Achu@gmail.com");
            webDriver.FindElement(By.XPath("/ html / body / div[2] / form / div / div[6] / div / input")).Click();
            //Search from List
            webDriver.FindElement(By.Name("searchTerm")).SendKeys("Achu");
            webDriver.FindElement(By.XPath("/html/body/div[2]/form/input[2]")).Click();
            Thread.Sleep(1000);

            //Logoff
            var logout = webDriver.FindElement(By.Id("logoutForm"));
            logout.Submit();

            //Register
            var register = webDriver.FindElement(By.Id("registerLink"));
            register.Click();
            var Usernew = webDriver.FindElement(By.Name("UserName"));
            Usernew.SendKeys("Akshaya");
            var pswdnew = webDriver.FindElement(By.Name("Password"));
            pswdnew.SendKeys("Aksh@123");
            var Confirmpswdnew = webDriver.FindElement(By.Name("ConfirmPassword"));
            Confirmpswdnew.SendKeys("Aksh@123");
            var email = webDriver.FindElement(By.Name("Email"));
            email.SendKeys("test123@gmail.com");
            var reg = webDriver.FindElement(By.XPath("/html/body/div[2]/form/div[6]/div/input"));
            reg.Submit();

           
        }

        private void Sleep(int v, object s)
        {
            throw new NotImplementedException();
        }
    }


}