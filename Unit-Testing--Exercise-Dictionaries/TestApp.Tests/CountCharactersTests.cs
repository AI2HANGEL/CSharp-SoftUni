using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa", "bb", "c" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 3");
        sb.AppendLine("b -> 2");
        sb.AppendLine("c -> 1");

        string expcted = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expcted));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!ab!", "b!baaa", "!cccb!" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 6");
        sb.AppendLine("! -> 5");
        sb.AppendLine("b -> 4");
        sb.AppendLine("c -> 3");

        string expcted = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expcted));
    }
    [Test]
    public void Test_Count_WithAdditionalCharac_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!ab!", "b!baaa", "!cccb!", "ABC123", "CBA231", "BCA321" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 6");
        sb.AppendLine("! -> 5");
        sb.AppendLine("b -> 4");
        sb.AppendLine("c -> 3");
        sb.AppendLine("A -> 3");
        sb.AppendLine("B -> 3");
        sb.AppendLine("C -> 3");
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 3");


        string expcted = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expcted));
    }
}