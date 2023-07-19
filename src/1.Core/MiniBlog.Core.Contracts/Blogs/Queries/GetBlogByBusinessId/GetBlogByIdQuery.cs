using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniBlog.Core.Contracts.Blogs.Queries.GetBlogByBusinessId;

public class GetBlogByIdQuery : IQuery<BlogQr>
{
    public Guid BlogBusinessId { get; set; }
}