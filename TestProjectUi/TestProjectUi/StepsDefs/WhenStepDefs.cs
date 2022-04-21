using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectUi.PageObjects;

namespace TestProjectUi.StepsDefs
{
    [Binding]
    public class WhenStepDefs : BasePage
    {
        public WhenStepDefs(IWebDriver driver)
        {
            Driver = driver;
        }

        [When(@"I choose navigate to the '(.*)' page")]
        public void WhenIChooseNavigateToThePage(string pageName)
        {
            CurrentPage<HomePage>().NavigateToPageName(pageName);
        }
    }
}
