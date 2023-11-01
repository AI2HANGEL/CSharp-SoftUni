using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isValid = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(isValid);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string validEmail = "test_example.com";

        // Act
        bool isValid = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsFalse(isValid);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string validEmail = null;

        // Act
        bool isValid = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsFalse(isValid);
    }
}
