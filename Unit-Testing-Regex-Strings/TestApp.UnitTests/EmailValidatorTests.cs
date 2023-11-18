using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("ivan.ivanov@abv.bg")]
    [TestCase("dimitar_dimitrov@googel.bg")]
    [TestCase("stivan.jobs@apple.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("ivan.ivanov@abv_bg")]
    [TestCase("dimitar_dimi@trov@googel.bg")]
    [TestCase("google.com@ivan_dimitrov")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
