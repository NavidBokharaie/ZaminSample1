using MiniBlog.Core.Contracts.Blogs.Queries;
using MiniBlog.Core.Contracts.Blogs.Queries.GetBlogByBusinessId;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.Blogs.Queries.GetBlogByBusinessId;
public class GetBlogByIdHandler : QueryHandler<GetBlogByIdQuery, BlogQr>
{
    private readonly IBlogQueryRepository _blogQueryRepository;

    public GetBlogByIdHandler(ZaminServices zaminServices,
                                      IBlogQueryRepository blogQueryRepository) : base(zaminServices)
    {
        _blogQueryRepository = blogQueryRepository;
    }

    public override async Task<QueryResult<BlogQr>> Handle(GetBlogByIdQuery query)
    {
        var blog = await _blogQueryRepository.Execute(query);

        return Result(blog);
    }
}
