using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestProjectUi.PageObjects;

namespace TestProjectUi.StepsDefs
{
    [Binding]
    public class ThenStepDefs : BasePage
    {
        public ThenStepDefs(IWebDriver driver)
        {
            Driver = driver;
        }

        [Then(@"I should see the '(.*)' page displayed")]
        public void ThenIShouldSeeThePageDisplayed(string pageTitle)
        {
            string actualText;
            string expectedTitle;

            switch (pageTitle.ToLower())
            {
                case "careers":
                    actualText = CurrentPage<CareersPage>().GetPageTitle();
                    expectedTitle = "Careers | Overview";
                    Assert.AreEqual(expectedTitle, actualText);
                    break;

                default:
                    throw new Exception("Incorrect page title name");
            }
        }
    }
}
