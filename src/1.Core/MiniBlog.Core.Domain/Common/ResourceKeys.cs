namespace MiniBlog.Core.Domain.Common;

public class ResourceKeys
{
    public const string IdNotFound = nameof(IdNotFound);
    public const string IdDuplicate = nameof(IdDuplicate);

    public const string BusinessId = nameof(BusinessId);
    public const string BusinessIdNotFound = nameof(BusinessIdNotFound);
    public const string BusinessIdDuplicate = nameof(BusinessIdDuplicate);
    public const string BusinessIdRequiredError = nameof(BusinessIdRequiredError);

    public const string MustNotNullError = nameof(MustNotNullError);
    public const string InValidMinLengthError = nameof(InValidMinLengthError);
    public const string InValidMaxLengthError = nameof(InValidMaxLengthError);

}