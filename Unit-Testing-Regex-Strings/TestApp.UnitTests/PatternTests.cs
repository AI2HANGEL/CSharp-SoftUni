using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("abcd" , 2, "aBcDaBcD")]
    [TestCase("daniel", 4, "dAnIeLdAnIeLdAnIeLdAnIeL")]
    [TestCase("CallOfDutyModern", 3, "cAlLoFdUtYmOdErNcAlLoFdUtYmOdErNcAlLoFdUtYmOdErN")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 2;

        // Act + Assert
        Assert.That(()  => Pattern.GeneratePatternedString(input,repetitionFactor), Throws.ArgumentException);
        

    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcabc";
        int repetitionFactor = -2;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcabc";
        int repetitionFactor = 0;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
