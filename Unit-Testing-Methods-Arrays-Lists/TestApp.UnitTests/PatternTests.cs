using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? arr = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(arr), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] arr = new int[] { 7, 3, 5, 2, 8, 6, 1, 4 };

        // Act
        int[] result = Pattern.SortInPattern(arr);

        // Assert
        int[] expected = new int[] { 1, 8, 2, 7, 3, 6, 4, 5 };
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] arr = new int[] {};

        // Act
        int[] result = Pattern.SortInPattern(arr);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] arr = new int[] { 1 };

        // Act
        int[] result = Pattern.SortInPattern(arr);

        // Assert
        Assert.That(result, Is.EqualTo(arr));
    }
}
