using Core.Contracts.Banks.Queries;
using Core.Contracts.Banks.Queries.GetHesabById;

namespace Core.ApplicationServices.Banks.Queries.GetHesabById;

public class GetHesabByIdQueryHandler : QueryHandler<GetHesabByIdQuery, HesabByIdDto>
{
    public IBankQueryRepository _bankQueryRepository;

    public GetHesabByIdQueryHandler(ZaminServices zaminServices,
        IBankQueryRepository bankQueryRepository) : base(zaminServices)
    {
        _bankQueryRepository = bankQueryRepository;
    }

    public override async Task<QueryResult<HesabByIdDto>> Handle(GetHesabByIdQuery query)
    {
        var hesab = await _bankQueryRepository.SelectAsync(query);
        return await ResultAsync(hesab);
    }
}
