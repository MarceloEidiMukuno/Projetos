namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; } //Navigation Properties
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public List<Tag> Tags { get; set; }
    }
}