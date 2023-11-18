using NUnit.Framework;

using System;
using System.Security;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "I like bananas so much because they are yellow!";
        string[] bannedWords = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "I like bananas so much because they are yellow!";
        string[] bannedWords = { "bananas" };

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo("I like ******* so much because they are yellow!"));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        // Arrange
        string text = "I like bananas so much because they are yellow!";
        string[] bannedWords = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string text = "I like bananas so much because they are yellow!";
        string[] bannedWords = { " bananas " };

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo("I like*********so much because they are yellow!"));
    }
}
