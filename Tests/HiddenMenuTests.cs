namespace OnlineStorePomTests.Tests
{
    public class HiddenMenuTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenHiddenMenu()
        {
            _hiddenMenuPage.ClickMenuButton();

            Assert.That(_hiddenMenuPage.IsMenuOpen(), Is.True, "The hidden menu is not displayed.");
        }

        [Test]
        public void TestLogout()
        {
            _hiddenMenuPage.ClickMenuButton();
            _hiddenMenuPage.ClickLogoutButton();

            Assert.That(_driver.Url.Contains("https://www.saucedemo.com"), Is.True, "The user is not logged out.");
        }
    }
}
