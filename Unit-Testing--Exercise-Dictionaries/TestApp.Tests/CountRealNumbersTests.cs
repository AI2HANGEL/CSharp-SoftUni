using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[0];

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 5 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("5 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 3, 2 , 1, 3, 2 ,1};

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 -> 2\r\n2 -> 2\r\n3 -> 2"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] {-3, -2, -1 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("-3 -> 1\r\n-2 -> 1\r\n-1 -> 1"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        {
            // Arrange
            int[] input = new int[] { 0, 0, 0, 0, 0 };

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("0 -> 5"));
        }
    }
}
