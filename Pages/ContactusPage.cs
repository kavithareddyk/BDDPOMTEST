using BDDPOMTEST.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPOMTEST.Pages
{
    class ContactusPage: PageBase
    {


        //public override string DefaultTitle
        //{
        //   get { return "Register - My ASP.NET Application"; }
       // }



        [FindsBy(How = How.XPath, Using = "//*[@id='navigationMenuWrapper']/div/ul/li[1]/a")]
        public IWebElement ABOUT;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div[9]/div[2]/a")]
        public IWebElement contactus;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/header/h1")]
        public IWebElement contactustitle;


        [FindsBy(How = How.ClassName, Using = "office__heading")]
        public ReadOnlyCollection<IWebElement> officelinks;

        internal void contacus()
        {
            this.ABOUT.Click();
            this.contactus.Click();
            AssertEqual("contactus", contactustitle.Text);
        }

        private void AssertEqual(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void numberofoffices()
        {

            //this.ABOUT.Click();
            //this.contactus.Click();

           // ReadOnlyCollection<IWebElement> links1 = officelinks;    //Identify the number of Link on webpage and assign into Webelement List 

            int Noffices = officelinks.Count;
           // return Noffices;

            Console.WriteLine("The number of Valtech contact us office location includes" + Noffices);





        }
















    }
}
