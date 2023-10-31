using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;
        int expectedResult = 1;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreNotEqual(input, result);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 5;
        int expectedResult = 120;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.Positive(result);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int input = -5;

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
