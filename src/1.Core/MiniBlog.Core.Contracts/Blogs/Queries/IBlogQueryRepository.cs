using MiniBlog.Core.Contracts.Blogs.Queries.GetBlogById;

namespace MiniBlog.Core.Contracts.Blogs.Queries;

public interface IBlogQueryRepository
{
    public Task<BlogQr> Execute(GetBlogByIdQuery query);
}