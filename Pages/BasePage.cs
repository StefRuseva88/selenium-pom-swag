using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlineStorePomTests.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;

        protected WebDriverWait _wait;
        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
            _wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));
        }
        protected IWebElement FindElement(By by)
        {
            return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
        protected IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        protected void Click(By by)
        {
            FindElement(by).Click();
        }

        protected void Type(By by, string text)
        {
            var element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By by)
        {
            return FindElement(by).Text;
        }
    }
}
