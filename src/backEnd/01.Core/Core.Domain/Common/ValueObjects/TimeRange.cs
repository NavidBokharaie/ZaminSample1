namespace Core.Domain.Common.ValueObjects;

public class TimeRange : BaseValueObject<TimeRange>
{
    private TimeRange(TimeOnly fromTime, TimeOnly endTime)
    {
        FromTime = fromTime;
        EndTime = endTime;
    }

    /// <summary>
    ///     از ساعت
    /// </summary>
    public TimeOnly FromTime { get; }

    /// <summary>
    ///     تا ساعت
    /// </summary>
    public TimeOnly EndTime { get; }

    public static TimeRange FromTimeOnly(TimeOnly fromTime, TimeOnly endTime)
    {
        return new TimeRange(fromTime, endTime);
    }

    public static (TimeOnly, TimeOnly) ToTimeOnly(TimeRange timeRange)
    {
        return (timeRange.FromTime, timeRange.EndTime);
    }

    // Implicit conversion from tuple of DateOnly to DateRange
    public static implicit operator TimeRange((TimeOnly fromTime, TimeOnly endTime) timeRange)
    {
        return FromTimeOnly(timeRange.fromTime, timeRange.endTime);
    }

    // Explicit conversion from AssetDate to tuple of DateOnly
    public static explicit operator (TimeOnly fromTime, TimeOnly endTime)(TimeRange timeRange)
    {
        return ToTimeOnly(timeRange);
    }


    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FromTime;
        yield return EndTime;
    }
}