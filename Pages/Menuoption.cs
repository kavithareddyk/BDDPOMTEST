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
    class Menuoption: PageBase
    {

        //public static string URL = "/";

        [FindsBy(How = How.CssSelector, Using = "li.navigation__menu__item > a > span")]
        public IWebElement About;



        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div[1]/h1")]
        public IWebElement ABOUTTILE;


        [FindsBy(How = How.XPath, Using = "//*[@id='navigationMenuWrapper']/div/ul/li[2]/a")]
        public IWebElement Services;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/header/h1")]
        public IWebElement SERVICESTITLE;

        [FindsBy(How = How.XPath, Using = "//*[@id='navigationMenuWrapper']/div/ul/li[3]/a")]
        public IWebElement Work;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/section/header/h1")]
        public IWebElement WORKTITLE;

        public void Menutabtestclick()
        {

            this.About.Click();
          // Assert.AreEqual("About", ABOUTTILE.Text);

            this.Work.Click();
           // Assert.AreEqual("Services", WORKTITLE.Text);


            this.Services.Click();
            //Assert.AreEqual("Work", SERVICESTITLE.Text);


        }

        public void pagetitle()
        {

            Assert.AreEqual("About", ABOUTTILE.Text);

            Assert.AreEqual("Services", WORKTITLE.Text);
            Assert.AreEqual("Work", SERVICESTITLE.Text);

        }


    }















}

