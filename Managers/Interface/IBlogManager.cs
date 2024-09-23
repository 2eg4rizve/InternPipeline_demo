
using InternPipeline.Entities.RequestEntity;
using InternPipeline.Entities.ResponseEntity;

namespace InternPipeline.Managers.Interface
{
    public interface IBlogManager
    {
        Task<CommonResponse> CreateBlog(CreateBlogRequestEntity createBlogRequestEntity);
    }
}
