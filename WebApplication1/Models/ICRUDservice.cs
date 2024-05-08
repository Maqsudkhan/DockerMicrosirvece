namespace WebApplication1.Models
{
    public interface ICRUDservice
    {
        public Task<BlogPost> CreatePost(BlogPost post);
        public Task<List<BlogPost>> GetAllPosts();
    }
}
