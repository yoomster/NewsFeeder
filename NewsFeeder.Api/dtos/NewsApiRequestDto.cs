using System.ComponentModel.DataAnnotations;

namespace NewsFeeder.Api.dtos
{
    public record NewsApiRequestDto(
        [MaxLength(2)]
        string Country,
        string Category,
        string Sources,
        string q,
        [MaxLength(100)]
        int? PageSize,
        int? Page
    );
    public record NewsApiResponseDto(
        string Status,
        int TotalResults,
        List<ArticleDto> Articles
    );
    public record ArticleDto
    (
        Source Source,
        [Required(ErrorMessage = "Title is manditory.")]
        [StringLength(100, ErrorMessage = "Title may be at most 100 characters long.")]
        string Title,
        string Author,
        string Description,
        string Url,
        string UrlToImage,
        string PublishedAt,
        string Content
    );
    public record Source
    (
        int Id,
        string Name
    );
}
