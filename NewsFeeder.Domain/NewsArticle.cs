namespace NewsFeeder.Domain;

public record NewsArticle
{
    public NewsArticle(int id, string title, string author, string header, string storyContent, DateTime publishedDate)
    {
        if (string.IsNullOrEmpty(title))
        {
            throw new ArgumentException("Empty Title is not allowed", nameof(title));
        }

        if (publishedDate > DateTime.UtcNow)
        {
            throw new ArgumentException("Publicatiedatum kan niet in de toekomst liggen.", nameof(publishedDate));
        }

        Id = id;
        Title = title;
        Author = author;
        Header = header;
        StoryContent = storyContent;
        PublishedDate = publishedDate;
    }

    public int Id { get; init; }
    public string Title { get; init; }
    public string Author { get; init; }
    public string Header { get; init; }
    public string StoryContent { get; init; }
    public DateTime PublishedDate { get; init; }
}
