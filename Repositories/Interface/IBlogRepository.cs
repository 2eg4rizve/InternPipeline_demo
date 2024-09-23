using InternPipeline.Models;

namespace InternPipeline.Repositories.Interface
{
    public interface IBlogRepository
    {
        Task<BlogModel> CreateBlog(BlogModel blogModel);
    }
}
