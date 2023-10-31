using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException> (() => { MaxNumber.FindMax(nullList); });
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { MaxNumber.FindMax(emptyList); });
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> lst = new() { 42 };

        // Act
        int result = MaxNumber.FindMax(lst);

        // Assert
        Assert.That(result, Is.EqualTo(42));


    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> lst = new() { 42, 4, 15, 33 };

        // Act
        int result = MaxNumber.FindMax(lst);

        // Assert
        Assert.That(result, Is.EqualTo(42));




    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> lst = new() { -42, -3, -18, -22 };

        // Act
        int result = MaxNumber.FindMax(lst);

        // Assert
        Assert.That(result, Is.EqualTo(-3));




    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> lst = new() { -42, -3, 69, -18, -22, 5, 22 };

        // Act
        int result = MaxNumber.FindMax(lst);

        // Assert
        Assert.That(result, Is.EqualTo(69));


    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> lst = new() { -42, -3, 69, -18, -22, 5, 69,  22 };

        // Act
        int result = MaxNumber.FindMax(lst);

        // Assert
        Assert.That(result, Is.EqualTo(69));



    }
}
