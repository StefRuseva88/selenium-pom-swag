using OnlineStorePomTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineStorePomTests.Tests
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected LoginPage _loginPage;
        protected InventoryPage _inventoryPage;
        protected CartPage _cartPage;
        protected CheckoutPage _checkoutPage;
        protected HiddenMenuPage _hiddenMenuPage;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArguments("--disable-search-engine-choice-screen");

            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _loginPage = new LoginPage(_driver);
            _inventoryPage = new InventoryPage(_driver);
            _cartPage = new CartPage(_driver);
            _checkoutPage = new CheckoutPage(_driver);
            _hiddenMenuPage = new HiddenMenuPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            if(_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }

        protected void Login(string username, string password)
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
            var loginPage = new LoginPage(_driver);
            loginPage.Login(username, password);
        }
    }
}
