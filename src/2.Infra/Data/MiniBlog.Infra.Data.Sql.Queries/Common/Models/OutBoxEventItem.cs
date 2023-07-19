namespace MiniBlog.Infra.Data.Sql.Queries.Common.Models;

public partial class OutBoxEventItem
{
	public long OutBoxEventItemId { get; set; }

	public Guid EventId { get; set; }

	public string AccuredByUserId { get; set; } = null!;

	public DateTime AccuredOn { get; set; }

	public string AggregateName { get; set; } = null!;

	public string AggregateTypeName { get; set; } = null!;

	public string AggregateId { get; set; } = null!;

	public string EventName { get; set; } = null!;

	public string EventTypeName { get; set; } = null!;

	public string EventPayload { get; set; } = null!;

	public string? TraceId { get; set; }

	public string? SpanId { get; set; }

	public bool IsProcessed { get; set; }
}
