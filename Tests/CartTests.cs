namespace OnlineStorePomTests.Tests
{
    public class CartTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
            _inventoryPage.AddToCartByIndex(1);
            _inventoryPage.ClickCartLink();
        }

        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.That(_cartPage.IsCartItemDisplayed(), Is.True, "Cart item is not displayed.");
        }

        [Test]
        public void TestClickCheckout() 
        {
            _cartPage.ClickCheckout();

            Assert.That(_checkoutPage.IsPageLoaded(), Is.True, "The checkout page is not loaded.");
        }
    }
}
