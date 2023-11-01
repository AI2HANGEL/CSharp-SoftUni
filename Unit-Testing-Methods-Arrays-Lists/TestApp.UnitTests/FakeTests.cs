using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] arr = "Hello123World".ToCharArray();

        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        char[] expected = "HelloWorld".ToCharArray();
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] arr = "HelloWorld".ToCharArray();

        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        Assert.That(result, Is.EqualTo(arr));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] arr = Array.Empty<char>();


        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
