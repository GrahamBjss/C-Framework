using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestProjectUi.UtilityHelpers;

namespace TestProjectUi.PageObjects
{
    public class BasePage : DriverManager
    {
        /// <summary>
        /// Note that this class inherit from DriverManager class
        /// </summary>

        public IWebElement AllowAllConsent => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));


        public T CurrentPage<T>() where T : BasePage, new()
        {
            var page = new T { Driver = Driver };
            return page;
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }

        public void MoveToElement(IWebElement element)
        {
            Actions a = new Actions(Driver);
            a.MoveToElement(element).Perform();
        }

        public void MoveToAndHighlightElementOnPage(IWebElement element)
        {
            //This moves to the element 
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            //This Highlight the element 
            var jsDriver = (IJavaScriptExecutor)Driver;
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: yellow; background : yellow"";";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }
    }
}