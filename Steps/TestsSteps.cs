using BDDPOMTEST.Base;
using BDDPOMTEST.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDPOMTEST.Steps
{
    [Binding]
    public class TestsSteps : StepsBase
    {
        [Given(@"user lanuches the valTech website")]
        public void GivenUserLanuchesTheValTechWebsite()
        {
            CurrentPage = (PageBase)PageBase.LoadIndexPage(CurrentDriver, PageBase.BaseUrl);
        }

        [Given(@"user lanches the valTech website")]
        public void GivenUserLanchesTheValTechWebsite()
        {
            CurrentPage = (PageBase)PageBase.LoadIndexPage(CurrentDriver, PageBase.BaseUrl);
        }
       // [When(@"user click on the readmore us")]
       // public void WhenUserClickOnTheReadmoreUs()
       // {
       //  ScenarioContext.Current.Pending();
       //  }

        [When(@"user navigate to the tab menu About")]
       public void WhenUserNavigateToTheTabMenuAbout()
        {
            CurrentPage.As<Menuoption>().Menutabtestclick();
        }
        
        [When(@"user navigate to the Contacts page")]
        public void WhenUserNavigateToTheContactsPage()
        {
            CurrentPage.As<ContactusPage>().contacus();
        }
        
        [Then(@"user should see the latest news displayed on the page")]
        public void ThenUserShouldSeeTheLatestNewsDisplayedOnThePage()
        {
            CurrentPage.As<HomePage>().latestnewsdisplayed();
        }
        
        [Then(@"user should see the page title as About")]
        public void ThenUserShouldSeeThePageTitleAsAbout()
        {
            CurrentPage = (PageBase)PageBase.LoadIndexPage(CurrentDriver, PageBase.BaseUrl);
            CurrentPage.As<Menuoption>().pagetitle();
        }
        
        [Then(@"usershould be able to calculate the number of offices")]
        public void ThenUsershouldBeAbleToCalculateTheNumberOfOffices()
        {
            CurrentPage.As<ContactusPage>().numberofoffices();
        }
    }
}
