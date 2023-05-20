using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestTaskFramework.test
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://google.com");
        }

        [TearDown]
        public void TearDown() {
            driver.Quit();
        }
    }
}