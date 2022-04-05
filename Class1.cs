using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_with_selenium
{
    class Class1
    {
        IWebDriver driver;
        public void launchurl(String url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

        }
        
        public void clickalert(By locator)
        {

            driver.FindElement(By.XPath("//*[@class='btn btn-primary']")).Click();
        }

        internal void clickalert()
        {
            throw new NotImplementedException();
        }
    } 
}
