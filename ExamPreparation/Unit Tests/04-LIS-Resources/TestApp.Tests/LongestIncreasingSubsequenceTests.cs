using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] arr = null;

        // Act + Assert
        Assert.That(() => LongestIncreasingSubsequence.GetLis(arr), Throws.TypeOf<ArgumentNullException>());

    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] arr = new int[0];

        // Act
        string result = LongestIncreasingSubsequence.GetLis(arr);


        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] arr = new[] { 1 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(arr);


        // Assert
        Assert.AreEqual("1", result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] arr = new[] { 1, 3, 5, 2, 1 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(arr);


        // Assert
        Assert.AreEqual("1 3 5", result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] arr = new[] { 1, 3, 5};

        // Act
        string result = LongestIncreasingSubsequence.GetLis(arr);


        // Assert
        Assert.AreEqual("1 3 5", result);
    }
}
