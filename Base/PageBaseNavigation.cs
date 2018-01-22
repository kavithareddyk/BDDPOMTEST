using BDDPOMTEST.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPOMTEST.Base
{
    public abstract partial class PageBase
    {
        public static string BaseUrl
        {
            get { return ConfigurationManager.AppSettings["seleniumBaseUrl"]; }
        }

        public static HomePage LoadIndexPage(IWebDriver driver, string baseURL)
        {
            //if (driver == null)
            // driver = Browser.Current;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseURL.TrimEnd(new char[] { '/' }) + HomePage.URL);
            driver.Manage().Window.Maximize();

            return GetInstance<HomePage>(driver, baseURL, string.Empty);
        }
    }
}