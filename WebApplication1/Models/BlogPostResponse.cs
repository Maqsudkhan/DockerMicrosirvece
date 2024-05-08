namespace WebApplication1.Models
{
    public class BlogPostResponse
    {
        // public IEnumerable<BlogPost> MongoBlogPost { get; set; }
        public BlogPost RedisBlogPost { get; set; }
        public List<BlogPost> PostgressBlogPost { get; set; }
    }
}
