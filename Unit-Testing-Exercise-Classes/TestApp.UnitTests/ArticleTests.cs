using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ArticleTests
{

    private Article _article;

    [SetUp]

    public void SetUp()
    {
        this._article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articlesData = 
            { 
            "Title1 Content1 Author1", 
            "Title2 Content2 Author2", 
            "Title3 Content3 Author3" 
            };

        // Act
        Article result = this._article.AddArticles(articlesData);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Title1"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Daniel",
                    Content = "Content",
                    Title = "C#"
                },
                new Article()
                {
                    Author = "Fani",
                    Content = "NoContent",
                    Title = "Python"
                }

            }
        };
        string expected = $"C# - Content: Daniel{Environment.NewLine}Python - NoContent: Fani";
        // Act
        string result = this._article.GetArticleList(inputArticle, "title");

        // Assert
        Assert.AreEqual(expected, result);  
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Daniel",
                    Content = "Content",
                    Title = "C#"
                },
                new Article()
                {
                    Author = "Fani",
                    Content = "NoContent",
                    Title = "Python"
                }

            }
        };
        string expected = string.Empty;
        // Act
        string result = this._article.GetArticleList(inputArticle, "Pop");

        // Assert
        Assert.AreEqual(expected, result);
    }
}
