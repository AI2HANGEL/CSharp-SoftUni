using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 } };
        List<List<int>> matrixB = new List<List<int>> { new List<int> { 5, 6 }, new List<int> { 7, 8 } };
        List<List<int>> expected = new List<List<int>> { new List<int> { 6, 8 }, new List<int> { 10, 12 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        // Arrange
        List<List<int>> emptyMatrixA = new List<List<int>>();
        List<List<int>> emptyMatrixB = new List<List<int>>();

        // Act
        List<List<int>> result = Matrix.MatrixAddition(emptyMatrixA, emptyMatrixB);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 } };
        List<List<int>> matrixB = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 } };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Matrix.MatrixAddition(matrixA, matrixB));
    }

    [Test]
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new List<List<int>> { new List<int> { -1, -2 }, new List<int> { -3, -4 } };
        List<List<int>> matrixB = new List<List<int>> { new List<int> { -5, -6 }, new List<int> { -7, -8 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        List<List<int>> expected = new List<List<int>> { new List<int> { -6, -8 }, new List<int> { -10, -12 } };
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        // Arrange
        List<List<int>> zeroMatrix = new List<List<int>> { new List<int> { 0, 0 }, new List<int> { 0, 0 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(zeroMatrix, zeroMatrix);

        // Assert
        List<List<int>> expected = new List<List<int>> { new List<int> { 0, 0 }, new List<int> { 0, 0 } };
        CollectionAssert.AreEqual(expected, result);
    }
}
