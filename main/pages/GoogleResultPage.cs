using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestTaskFramework.main.pages
{
    public class GoogleResultPage : BasePage
    {
        public GoogleResultPage(IWebDriver webDriver) : base(webDriver) { }

        public String getSearchResultTextByNumber(int n)
        {
            String xpathToResults = "//div[@class='Z26q7c UK95Uc jGGQ5e']";
            String xpathModified = String.Format("({0})[{1}]", xpathToResults, n);
            return driver.FindElement(By.XPath(xpathModified)).Text;
        }
    }
}
