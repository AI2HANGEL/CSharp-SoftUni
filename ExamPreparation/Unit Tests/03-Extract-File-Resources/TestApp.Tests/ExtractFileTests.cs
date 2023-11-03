using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string arr = null;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(arr), Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string arr = string.Empty;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(arr), Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\Music\DokoDoko.mp3";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo("File name: DokoDoko\nFile extension: mp3"));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = @"C:\Music\DokoDoko";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo("File name: DokoDoko"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\Music\DokoDoko(2k23 Krisko Mix).mp3";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo("File name: DokoDoko(2k23 Krisko Mix)\nFile extension: mp3"));
    }
}
