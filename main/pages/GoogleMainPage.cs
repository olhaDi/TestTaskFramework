using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestTaskFramework.main.pages
{
    public class GoogleMainPage : BasePage
    {
        public GoogleMainPage(IWebDriver webDriver) : base(webDriver) { }


        [FindsBy(How = How.XPath, Using = "//textarea[@id = 'APjFqb']")]
        private IWebElement searchTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@class=\"gNO89b\"]")]
        private IWebElement searchButton;


        public GoogleMainPage enterTextToSearchBox(String textToSearch) {
            searchTextBox.SendKeys(textToSearch);
            return this;
        }

        public GoogleResultPage clickSearchButton() {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", searchButton);
            return new GoogleResultPage(this.driver);
        }
    }
}
