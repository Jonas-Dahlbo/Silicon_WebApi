namespace Infrastructure.Entities;

public class CoursesEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Price { get; set; } = null!;
    public string DiscountedPrice { get; set; } = null!;
    public string Hours { get; set; } = null!;
    public string LikesRating { get; set; } = null!;
    public string Likes { get; set; } = null!;

    public bool IsBestseller {  get; set; } = false;
}
