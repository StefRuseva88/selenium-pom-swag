namespace OnlineStorePomTests.Tests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestInventoryDisplay()
        {
            Assert.That(_inventoryPage.IsInventoryDisplayed(), Is.True, "Inventory page has no items displayed.");
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            _inventoryPage.AddToCartByIndex(1);
            _inventoryPage.ClickCartLink();

            Assert.That(_cartPage.IsCartItemDisplayed(), Is.True, "Cart item is not dispalyed.");
        }

        [Test]
        public void TestAddToCartByName()
        {
            _inventoryPage.AddToCartByName("Sauce Labs Backpack");
            _inventoryPage.ClickCartLink();

            Assert.That(_cartPage.IsCartItemDisplayed(), Is.True, "Cart item is not dispalyed.");
        }

        [Test]
        public void TestPageTitle()
        {
            Assert.That(_inventoryPage.IsPageLoaded(), Is.True, "The page is not loaded after successfull login.");
        }
    }
}
