using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestTaskFramework.main.pages;

namespace TestTaskFramework.test
{
    public class SearchDataTest : BaseTest
    {
        [Test]
        public void Test()
        {
            String searchText = "Selenium IDE export to C#";
            int resultNumber = 4;
            String expectedText = "Selenium IDE";

            GoogleMainPage googleMainPage = new GoogleMainPage(driver);
            GoogleResultPage googleResultPage = new GoogleResultPage(driver);

            googleMainPage.enterTextToSearchBox(searchText);
            googleMainPage.clickSearchButton();
            String resultText = googleResultPage.getSearchResultTextByNumber(resultNumber);
            String errorMessage = String.Format("Search result text: {0} doesn't contain phrase:{1}", resultText, expectedText);
            Assert.IsTrue(resultText.ToLower().Contains(expectedText.ToLower()), errorMessage);
        }
    }
}
