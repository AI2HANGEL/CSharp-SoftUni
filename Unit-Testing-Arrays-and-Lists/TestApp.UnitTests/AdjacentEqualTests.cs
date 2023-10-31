using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { MaxNumber.FindMax(nullList); });
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        //Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> lst = new() { 1, 2, 3, 4, 5 };

        // Act
        var result = AdjacentEqual.Sum(lst);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> lst = new() { 1, 2, 2, 4, 3, 5 };

        // Act
        var result = AdjacentEqual.Sum(lst);

        // Assert
        Assert.That(result, Is.EqualTo("1 8 3 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> lst = new() { 1, 1, 2, 4, 8, 16};

        // Act
        var result = AdjacentEqual.Sum(lst);

        // Assert
        Assert.That(result, Is.EqualTo("32"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> lst = new() { 1, 1, 3, 4 };

        // Act
        var result = AdjacentEqual.Sum(lst);

        // Assert
        Assert.That(result, Is.EqualTo("2 3 4"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> lst = new() { 1, 2, 3, 4, 4 };

        // Act
        var result = AdjacentEqual.Sum(lst);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> lst = new() { 1, 2, 3, 3, 4 };

        // Act
        var result = AdjacentEqual.Sum(lst);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 6 4"));
    }
}
