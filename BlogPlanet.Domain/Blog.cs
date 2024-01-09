namespace BlogPlanet.Domain;
public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
