namespace OnlineStorePomTests.Tests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
            _inventoryPage.AddToCartByIndex(1);
            _inventoryPage.ClickCartLink();
            _cartPage.ClickCheckout();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.That(_checkoutPage.IsPageLoaded(), Is.True, "The checkout page is not loaded.");
        }

        [Test]
        public void TestContinueToNextStep() 
        {
            _checkoutPage.EnterFirstName("John");
            _checkoutPage.EnterLastName("Doe");
            _checkoutPage.EnterPostalCode("12345");
            _checkoutPage.ClickContinue();

            Assert.That(_driver.Url.Contains("checkout-step-two.html"),Is.True, "The overview page is not loaded.");
        }

        [Test]
        public void TestCompleteOrder() 
        {
            _checkoutPage.EnterFirstName("John");
            _checkoutPage.EnterLastName("Doe");
            _checkoutPage.EnterPostalCode("12345");
            _checkoutPage.ClickContinue();
            _checkoutPage.ClickFinish();

            Assert.That(_driver.Url.Contains("checkout-complete.html"), Is.True, "The order was not completed.");
        }
    }
}
