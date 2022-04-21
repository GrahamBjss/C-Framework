using OpenQA.Selenium;
using System;

namespace TestProjectUi.PageObjects
{
    public class HomePage : BasePage
    {
        public IWebElement CareersLink => Driver.FindElement(By.LinkText("Careers"));
        public IWebElement LearnMoreAboutUs => Driver.FindElement(By.Id("hs-button_widget_1622528203123"));
        public IWebElement SearchEnterBtn => Driver.FindElement(By.CssSelector("[data-tag-name='submit search']"));

        
        public void NavigateToPageName(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "careers":
                    CareersLink.Click();
                    WaitUntilElementIsVisible(By.Id("search-by"));
                    break;

                default:
                    throw new Exception("Incorrect page name");
            }
        }
    }
}
