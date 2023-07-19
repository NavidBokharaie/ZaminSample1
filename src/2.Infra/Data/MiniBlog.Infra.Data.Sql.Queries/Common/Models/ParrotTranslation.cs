﻿namespace MiniBlog.Infra.Data.Sql.Queries.Common.Models;

public partial class ParrotTranslation
{
    public long Id { get; set; }

    public Guid BusinessId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Culture { get; set; }
}
