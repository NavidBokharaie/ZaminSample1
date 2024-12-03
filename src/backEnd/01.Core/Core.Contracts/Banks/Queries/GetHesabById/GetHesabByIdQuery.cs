namespace Core.Contracts.Banks.Queries.GetHesabById;

public class GetHesabByIdQuery : IQuery<HesabByIdDto>
{
    public int Id { get; set; }
}
