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
        public void launchurl(String url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

        }
    }
}
