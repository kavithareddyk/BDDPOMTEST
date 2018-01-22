using BDDPOMTEST.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPOMTEST.Pages

    {
        public class HomePage : PageBase
        {
            public static string URL = "/";
           // public override string DefaultTitle
            //{
              //  get { return "Home Page - My ASP.NET Application"; }
          //  }


        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div[1]/div[2]/p[2]/a")]
        public IWebElement readmore;

        [FindsBy(How = How.XPath, Using = "////*[@id='container']/div[10]/div/div[1]/header/h2*")]
        public IWebElement latestnews;







        internal void latestnewsdisplayed()
        {
            this.readmore.Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Assert.AreEqual("Latest News", latestnews.Text);


        }






    }
    }
