using NewsFeeder.Domain;

namespace NewsFeeder.Tests.Unit;

public class NewsArticleTests
{
    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void CreateNewsArticle_WithInvalidTitle_ThrowsArgumentException(string title)
    {
        // Arrange
        var author = "NewsFeeder";
        var header = "Technology";
        var story = "An example story.";
        var publishedDate = new DateOnly(2026, 10, 17);

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            new NewsArticle(
                title,
                author,
                header,
                story,
                publishedDate));
    }
}
