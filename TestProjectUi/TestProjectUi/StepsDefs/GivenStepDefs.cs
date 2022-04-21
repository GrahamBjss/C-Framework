using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectUi.PageObjects;
using TestProjectUi.UtilityHelpers;

namespace TestProjectUi.StepsDefs
{
    [Binding]
    public sealed class GivenStepDefs : BasePage
    {
        public GivenStepDefs(IWebDriver driver)
        {
            Driver = driver;
        }

        [Given(@"I navigate to Bjss site")]
        public void GivenINavigateToBjssSite()
        {
            Driver.Navigate().GoToUrl(ConfigManager.WebSiteUrl);

            WaitUntilElementIsVisible(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));
            if (CurrentPage<BasePage>().AllowAllConsent.Displayed)
            {
                CurrentPage<BasePage>().AllowAllConsent.Click();
            }
        }
    }
}
