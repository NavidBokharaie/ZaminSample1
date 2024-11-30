namespace Core.Domain.Common.ValueObjects;

public class DateRange : BaseValueObject<DateRange>
{
    private DateRange(DateOnly fromDate, DateOnly endDate)
    {
        if (fromDate > endDate)
            throw new InvalidValueObjectStateException("FromDate can't be higher than EndDate", fromDate.ToString(),
                endDate.ToString());

        FromDate = fromDate;
        EndDate = endDate;
    }

    /// <summary>
    ///     از تاریخ
    /// </summary>
    public DateOnly FromDate { get; }

    /// <summary>
    ///     تا تاریخ
    /// </summary>
    public DateOnly EndDate { get; }

    public static DateRange FromDateOnly(DateOnly fromDate, DateOnly endDate)
    {
        return new DateRange(fromDate, endDate);
    }

    public static (DateOnly, DateOnly) ToDateOnly(DateRange dateRange)
    {
        return (dateRange.FromDate, dateRange.EndDate);
    }

    // Implicit conversion from tuple of DateOnly to DateRange
    public static implicit operator DateRange((DateOnly fromDate, DateOnly endDate) dateTimes)
    {
        return FromDateOnly(dateTimes.fromDate, dateTimes.endDate);
    }

    // Explicit conversion from AssetDate to tuple of DateOnly
    public static explicit operator (DateOnly fromDate, DateOnly endDate)(DateRange dateRange)
    {
        return ToDateOnly(dateRange);
    }


    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FromDate;
        yield return EndDate;
    }
}