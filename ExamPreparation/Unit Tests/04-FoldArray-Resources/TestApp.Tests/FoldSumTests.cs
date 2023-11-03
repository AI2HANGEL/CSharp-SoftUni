using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] {1, 2 , 3, 4}, "3 7")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[] { 1, 2, 3, 4, 4, 5, 1, 4, 5, 7 }, "5 5 11 10")]
    [TestCase(new int[] { 2, 2, 2, 2 }, "4 4")]
    [TestCase(new int[] { 91, 43, 76, 44 }, "134 120")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Arrange


        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
