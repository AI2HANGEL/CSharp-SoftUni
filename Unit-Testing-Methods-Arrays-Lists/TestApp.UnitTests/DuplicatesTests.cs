using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act & Assert
        Assert.IsEmpty(numbers);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4 };
        // Act
        var result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 3, 4, 1 };
        // Act
        var result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.AreNotSame(result, numbers);
        Assert.That(result, Is.EqualTo(new[] { 1, 2, 3, 4 }));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] inputArray = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 5 }));
        Assert.That(result.Length, Is.EqualTo(1));
    }
}
