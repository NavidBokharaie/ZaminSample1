using Microsoft.EntityFrameworkCore;
using Core.Contracts.Banks.Queries;
using Core.Contracts.Banks.Queries.GetBanks;
using Core.Contracts.Banks.Queries.GetBankById;
using Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;
using Zamin.Utilities.Extensions;

using Core.Contracts.Banks.Queries.GetHesabById;
using Core.Contracts.Banks.Queries.GetHesabs;
//EntityQueryRepositoryUsingReplacementText

namespace Infra.Data.Sql.Queries.Banks;

public class BankQueryRepository : BaseQueryRepository<ZaminSample1QueryDbContext>,
    IBankQueryRepository
{
    public BankQueryRepository(ZaminSample1QueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<BankByIdDto> SelectAsync(GetBankByIdQuery request)
    {
        return await _dbContext.Banks.Select(c => new BankByIdDto()
        {
            Id = c.Id,
            Name = c.Name,
            Code = c.Code,
            UserId = c.UserId,
            CreatedDate = c.CreatedDate
        }).SingleOrDefaultAsync(c => c.Id.Equals(request.Id));
    }
    public async Task<PagedData<BankDto>> SelectAsync(GetBankQuery request)
    {
        #region Query
        var query = _dbContext.Banks.AsQueryable();
        #endregion

        #region Filters
        query = query.WhereIf(request.Name != null, p => p.Name.Contains(request.Name));
        query = query.WhereIf(request.Code != null, m => m.Code == request.Code);
        query = query.WhereIf(request.UserId != null, m => m.UserId == request.UserId);
        query = query.WhereIf(request.CreatedDate != null, m => m.CreatedDate == request.CreatedDate);




        #endregion

        #region Result
        PagedData<BankDto> result = await query.ToPagedData(request, c => new BankDto
        {
            Id = c.Id,
            Name = c.Name,
            Code = c.Code,
            UserId = c.UserId,
            CreatedDate = c.CreatedDate ,


        });

        return result;
        #endregion
    }


public async Task<HesabByIdDto> SelectAsync(GetHesabByIdQuery request)
{
    return await _dbContext.Hesabs.Select(c => new HesabByIdDto()
    {
        Id = c.Id,
            HesabNumber = c.HesabNumber,
            CodeCenter = c.CodeCenter,
            TelNumber = c.TelNumber,
            Address = c.Address,
            BankId = c.BankId
    }).SingleOrDefaultAsync(c => c.Id.Equals(request.Id));
}
public async Task<PagedData<HesabDto>> SelectAsync(GetHesabQuery request)
{
    #region Query
    var query = _dbContext.Hesabs.AsQueryable();
    #endregion

    #region Filters
        query = query.WhereIf(request.HesabNumber != null, m => m.HesabNumber == request.HesabNumber);
        query = query.WhereIf(request.CodeCenter != null, p => p.CodeCenter.Contains(request.CodeCenter));
        query = query.WhereIf(request.TelNumber != null, p => p.TelNumber.Contains(request.TelNumber));
        query = query.WhereIf(request.Address != null, p => p.Address.Contains(request.Address));
        query = query.WhereIf(request.BankId != null, m => m.BankId == request.BankId);

    #endregion

    #region Result
    PagedData<HesabDto> result = await query.ToPagedData(request, c => new HesabDto
    {
        Id = c.Id,
            HesabNumber = c.HesabNumber,
            CodeCenter = c.CodeCenter,
            TelNumber = c.TelNumber,
            Address = c.Address,
            BankId = c.BankId
    });

    return result;
    #endregion
}
//EntityQueryRepositoryReplacementText
}
