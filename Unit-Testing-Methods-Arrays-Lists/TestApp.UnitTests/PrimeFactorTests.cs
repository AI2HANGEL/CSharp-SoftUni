using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        int n = 1;


        // Act & Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        int n = 7;

        // Act
        var result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.That(result, Is.EqualTo(n));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        int n = 1254;

        // Act
        var result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.That(result, Is.EqualTo(19));
    }
}
