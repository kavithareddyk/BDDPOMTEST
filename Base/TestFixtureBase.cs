using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;

namespace BDDPOMTEST.Base
{

    public class TestFixtureBase
    {
        protected IWebDriver CurrentDriver { get; set; }

        [SetUp]
        public void Test_Setup()
        {
            try {

               // CurrentDriver = Browser.Current;

                CurrentDriver = new ChromeDriver();
            } catch { }
        }

        [TearDown]
        public void Test_Teardown()
        {
            try
            {
                //if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed && CurrentDriver is ITakesScreenshot)
                  //  ((ITakesScreenshot)CurrentDriver).GetScreenshot().SaveAsFile(TestContext.CurrentContext.Test.FullName + ".jpg", ImageFormat.Jpeg);
            }
            catch
            {
                // null ref exception occurs from accessing TestContext.CurrentContext.Result.Status property
            }

            try
            {
                CurrentDriver.Quit();
                CurrentDriver.Dispose();
            }
            catch
            {
            }
        }
    }
}
