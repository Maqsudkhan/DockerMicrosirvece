using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly ICRUDservice _crudService;

        public BlogPostsController(ICRUDservice crudService)
        {
            _crudService = crudService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(BlogPost post)
        {
            var result = await _crudService.CreatePost(post);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var result = await _crudService.GetAllPosts();
            return Ok(result);
        }
    }
}
 