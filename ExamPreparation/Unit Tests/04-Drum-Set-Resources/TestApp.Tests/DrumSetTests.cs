using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "20", "30" };  

        // Act + Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "invalid", "30" };

        // Act + Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "20", "30", "Hit it again, Gabsy!" };

        // Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(result, Is.EqualTo("10\nGabsy has 10.00lv."));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 90;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "20", "30", "10", "20", "30", "Hit it again, Gabsy!" };

        // Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(result, Is.EqualTo("\nGabsy has 30.00lv."));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 10;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "20", "30", "Hit it again, Gabsy!" };

        // Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(result, Is.EqualTo("\nGabsy has 10.00lv."));
    }
}
