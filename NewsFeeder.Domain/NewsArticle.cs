namespace NewsFeeder.Domain;

public class NewsArticle
{
    private string story;
    private DateOnly publishedDate;

    public NewsArticle(string title, string author, string header, string story, DateOnly publishedDate)
    {
        Title = title;
        Author = author;
        Header = header;
        this.story = story;
        this.publishedDate = publishedDate;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Header { get; set; }
    public string StoryContent { get; set; }
    public DateTime PublishedDate { get; set; }

}
