using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);


        // Assert
        Assert.AreEqual(input, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "U";

        // Act
        string actual = StringReverse.Reverse(input);


        // Assert
        Assert.AreEqual(input, actual);
        Assert.AreEqual(input.Length, actual.Length);


    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "kapak";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input.Length, actual.Length);
        Assert.AreEqual("kapak", actual);

    }
}
