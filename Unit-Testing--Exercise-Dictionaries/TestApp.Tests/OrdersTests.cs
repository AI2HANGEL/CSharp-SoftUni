using System;
using NUnit.Framework;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[] 
        { 
            "apple 5.97 1",
            "banana 3.75 1",
            "orange 1.98 1",
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[]
        {
            "apple 1.9900000000000000001 3",
            "banana 2.9900000000000002 2",
            "orange 3.9900000000001 2",
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 5.98{Environment.NewLine}orange -> 7.98"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[]
        {
            "apple 2 3.5",
            "banana 3 2.5",
            "orange 1 2.5",
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 7.00{Environment.NewLine}banana -> 7.50{Environment.NewLine}orange -> 2.50"));
    }
}
