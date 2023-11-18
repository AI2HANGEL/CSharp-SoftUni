using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new();


        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.Empty);
    }   

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        string text = "Test a given method which takes in a string array of phone numbers ";
        List<string> expected = new();


        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        string text = "Test a given method which takes in https://softuni.bg";
        List<string> expected = new() { "https://softuni.bg" };


        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        string text = "list of urls https://softuni.bg https://abv.bg https://google.com";
        List<string> expected = new() { "https://softuni.bg" , "https://abv.bg" , "https://google.com" };


        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        string text = "list of urls 'https://softuni.bg' 'https://abv.bg' 'https://google.com' ";
        List<string> expected = new() { "https://softuni.bg", "https://abv.bg", "https://google.com" };


        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
