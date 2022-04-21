using OpenQA.Selenium;

namespace TestProjectUi.PageObjects
{
    public class CareersPage : BasePage
    {
        public IWebElement Header => Driver.FindElement(By.CssSelector("[class='test']"));


    }
}
