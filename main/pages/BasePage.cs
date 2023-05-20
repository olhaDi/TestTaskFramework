using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestTaskFramework.main.pages
{
    public abstract class BasePage
    {
        public IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }
    }
}
