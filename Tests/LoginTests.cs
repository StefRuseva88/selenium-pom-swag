namespace OnlineStorePomTests.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void LoginWithValidCredentialsTest()
        {
            Login("standard_user", "secret_sauce");

            Assert.That(_inventoryPage.IsPageLoaded(), Is.True, "The page is not loaded after successfull login.");
        }

        [Test]
        public void LoginWithInvalidCredentialsTest()
        {
            Login("invalid_user", "secret_sauce");

            string errorMessage = _loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "Error message is not correct.");
        }

        [Test]
        public void LoginWithLockedOutUserTest()
        {
            Login("locked_out_user", "secret_sauce");

            string errorMessage = _loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."), "Error message is not correct.");
        }
    }
}
