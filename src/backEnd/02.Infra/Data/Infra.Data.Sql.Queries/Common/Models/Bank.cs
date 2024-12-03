namespace Infra.Data.Sql.Queries.Common.Models;

public partial class Bank
{
    public int Id { get; set; }
   
    public string Name { get; set; }
    public int Code { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }



}
