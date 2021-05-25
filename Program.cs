using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace SeleniumTests
{
    
    public class Centric
    {
       
       // private string baseURL;
    
    
        
         static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://centricconsultingllc.sharepoint.com/sites/TheLounge");
            driver.FindElement(By.XPath("//*[@id=\"O365_AppName\"]/span")).Click();
            driver.FindElement(By.XPath("//a[contains(.,'Celebrating Mental Health Awareness: Shedding the Stigma')]")).Click();
        }
       
    }
}
