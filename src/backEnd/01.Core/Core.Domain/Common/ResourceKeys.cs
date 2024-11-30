namespace Core.Domain.Common;

public class ResourceKeys
{
    public const string FeatureType = nameof(FeatureType);
    public const string FeatureTypeRangeError = nameof(FeatureTypeRangeError);

    public const string InvalidDuplicateValue = nameof(InvalidDuplicateValue);

    public const string InvalidValue = nameof(InvalidValue);
    public const string InvalidDuplicateValueInCollection = nameof(InvalidDuplicateValueInCollection);
    public const string InvalidOperation = nameof(InvalidOperation);
    public const string InvalidNullOrEmpty = nameof(InvalidNullOrEmpty);
    public const string InvalidMinValue = nameof(InvalidMinValue);
    public const string InvalidMinLenght = nameof(InvalidMinLenght);
    public const string InvalidMaxLenght = nameof(InvalidMaxLenght);
    public const string ObjectNotFound = nameof(ObjectNotFound);
    public const string EntityIsDisable = nameof(EntityIsDisable);
    public const string EntityHasChild = nameof(EntityHasChild);

    public const string IdNotFound = nameof(IdNotFound);
    public const string IdDuplicate = nameof(IdDuplicate);

    public const string BusinessId = nameof(BusinessId);
    public const string BusinessIdNotFound = nameof(BusinessIdNotFound);
    public const string BusinessIdDuplicate = nameof(BusinessIdDuplicate);
    public const string BusinessIdRequiredError = nameof(BusinessIdRequiredError);

    public const string ParentBusinessId = nameof(ParentBusinessId);
    public const string ParentBusinessIdNotFound = nameof(ParentBusinessIdNotFound);
    public const string ParentBusinessIdDuplicate = nameof(ParentBusinessIdDuplicate);

    public const string Name = nameof(Name);
    public const string NameRequiredError = nameof(NameRequiredError);
    public const string NameInValidMinLengthError = nameof(NameInValidMinLengthError);
    public const string NameInValidMaxLengthError = nameof(NameInValidMaxLengthError);

    public const string Text = nameof(Text);
    public const string TextRequiredError = nameof(TextRequiredError);
    public const string TextInValidMinLengthError = nameof(TextInValidMinLengthError);
    public const string TextInValidMaxLengthError = nameof(TextInValidMaxLengthError);

    public const string Title = nameof(Title);
    public const string TitleRequiredError = nameof(TitleRequiredError);
    public const string TitleInValidLengthError = nameof(TitleInValidLengthError);
    public const string TitleInValidMinLengthError = nameof(TitleInValidMinLengthError);
    public const string TitleInValidMaxLengthError = nameof(TitleInValidMaxLengthError);
    public const string TitleExistError = nameof(TitleExistError);

    public const string CodeRequiredError = nameof(CodeRequiredError);

    public const string ParentId = nameof(ParentId);
    public const string ParentIdRequiredError = nameof(ParentIdRequiredError);
    public const string ParentIdNotFound = nameof(ParentIdNotFound);

    public const string ProductTypeBusinessId = nameof(ProductTypeBusinessId);
    public const string ProductTypeFeatureBusinessId = nameof(ProductTypeFeatureBusinessId);
    public const string ProductTypeFeatureBusinessIdRequiredError = nameof(ProductTypeFeatureBusinessIdRequiredError);
    public const string ProductTypeBusinessIdRequiredError = nameof(ProductTypeBusinessIdRequiredError);
    public const string FeatureBusinessId = nameof(FeatureBusinessId);
    public const string FeatureValueBusinessId = nameof(FeatureValueBusinessId);
    public const string FeatureValueBusinessIdRequiredError = nameof(FeatureValueBusinessIdRequiredError);
    public const string FeatureBusinessIdRequiredError = nameof(FeatureBusinessIdRequiredError);
    public const string ProductBusinessIdRequiredError = nameof(ProductBusinessIdRequiredError);
    public const string ProductBusinessId = nameof(ProductBusinessId);
    public const string TagBusinessIdRequiredError = nameof(TagBusinessIdRequiredError);
    public const string TagBusinessId = nameof(TagBusinessId);
    public const string CorrectTagNameRequiredError = nameof(CorrectTagNameRequiredError);
    public const string CorrectTagName = nameof(CorrectTagName);
    public const string TagsIdForMergRequiredError = nameof(TagsIdForMergRequiredError);
    public const string TagsIdForMerg = nameof(TagsIdForMerg);
    public const string DefinitePurchases = nameof(DefinitePurchases);
    public const string IndefinitePurchases = nameof(IndefinitePurchases);
    public const string MoveOldSystem = nameof(MoveOldSystem);

    public const string InvalidSelectedAssetGroupHasChildren = nameof(InvalidSelectedAssetGroupHasChildren);
    public const string InvalidSelectedAssetGroupHasAsset = nameof(InvalidSelectedAssetGroupHasAsset);

    public const string RequeiredFiled = nameof(RequeiredFiled);

    public const string ToDateMustBiggerThanFromDateError = nameof(ToDateMustBiggerThanFromDateError);
    public const string FromDateMustBiggerThanTodayError = nameof(FromDateMustBiggerThanTodayError);
    public const string PriceRequiredError = nameof(PriceRequiredError);
    public const string Price = nameof(Price);
    public const string FromDateRequiredError = nameof(FromDateRequiredError);
    public const string FromDate = nameof(FromDate);
    public const string InValidPriceValueError = nameof(InValidPriceValueError);
    public const string PriceBusinessIdRequiredError = nameof(PriceBusinessIdRequiredError);
    public const string PriceBusinessId = nameof(PriceBusinessId);

    public const string FromDateInvalid = nameof(FromDateInvalid);
    public const string EndDateInvalid = nameof(EndDateInvalid);
    public const string EndDatePeriodOfOneMonth = nameof(EndDatePeriodOfOneMonth);
    public const string EndDateMustGreaterThanOrEqual = nameof(EndDateMustGreaterThanOrEqual);
    public const string FromDateEmpty = nameof(FromDateEmpty);
    public const string EndDateEmpty = nameof(EndDateEmpty);

    public const string ParentMaxLevelCountIsZero = nameof(ParentMaxLevelCountIsZero);

    public const string InvalidProductEqualWithParent = nameof(InvalidProductEqualWithParent);
    public const string InvalidProductEqualWithChild = nameof(InvalidProductEqualWithChild);
    public const string SortOrder = nameof(SortOrder);
    public const string SortOrderRequiredError = nameof(SortOrderRequiredError);
    public const string ChildProductBusinessId = nameof(ChildProductBusinessId);
    public const string ChildProductBusinessIdRequiredError = nameof(ChildProductBusinessIdRequiredError);
    public const string RelationProductBusinessIdRequiredError = nameof(RelationProductBusinessIdRequiredError);
    public const string RelationProductBusinessId = nameof(RelationProductBusinessId);
    public const string ParentProductBusinessIdRequiredError = nameof(ParentProductBusinessIdRequiredError);
    public const string ParentProductBusinessId = nameof(ParentProductBusinessId);
    public const string FileRequiredError = nameof(FileRequiredError);
    public const string File = nameof(File);
    public const string PictureBusinessIdRequiredError = nameof(PictureBusinessIdRequiredError);
    public const string PictureBusinessId = nameof(PictureBusinessId);
    public const string DigitalProductBusinessId = nameof(DigitalProductBusinessId);
    public const string DigitalProductBusinessIdRequiredError = nameof(DigitalProductBusinessIdRequiredError);

    public const string IsFree = nameof(IsFree);
    public const string IsFreeRequiredError = nameof(IsFreeRequiredError);
    public const string DigitalProductFileBusinessId = nameof(DigitalProductFileBusinessId);
    public const string DigitalProductFileBusinessIdRequiredError = nameof(DigitalProductFileBusinessIdRequiredError);


    public const string Description = nameof(Description);
    public const string DescriptionRequiredError = nameof(DescriptionRequiredError);
    public const string DescriptionInValidLengthError = nameof(DescriptionInValidLengthError);
    public const string DescriptionInValidMaxLengthError = nameof(DescriptionInValidMaxLengthError);
    public const string DescriptionInValidMinLengthError = nameof(DescriptionInValidMinLengthError);

    public const string InValidMinOrMaxLengthError = nameof(InValidMinOrMaxLengthError);

    public const string StockRequiredError = nameof(StockRequiredError);
    public const string SaleableRequiredError = nameof(SaleableRequiredError);
    public const string Saleable = nameof(Saleable);
    public const string Stock = nameof(Stock);

    public const string DepreciationTypeRequiredError = nameof(DepreciationTypeRequiredError);

    public const string MovableProperty = nameof(MovableProperty);
    public const string ImmovableProperty = nameof(ImmovableProperty);
    public const string TangibleFixed = nameof(TangibleFixed);
    public const string InTangibleFixed = nameof(InTangibleFixed);


    public const string AssetsStatusTypeError = nameof(AssetsStatusTypeError);


    public const string PriceBookValueGreaterThan0 = nameof(PriceBookValueGreaterThan0);

    public const string ReportTotalLabel = nameof(ReportTotalLabel);

    public static string[] CategoryBusinessIdRequiredError { get; set; }
    public static string CategoryBusinessId { get; set; }
    public static string RuleBusinessId { get; set; }
    public static string[] RuleBusinessIdRequiredError { get; set; }

    #region Enums

    public const string AssetGroup = nameof(AssetGroup);
    public const string AssetGroupChild = nameof(AssetGroupChild);
    public const string AssetGroupProperty = nameof(AssetGroupProperty);
    public const string Asset = nameof(Asset);
    public const string AssetReform = nameof(AssetReform);

    public const string StringMustBeNumber = nameof(StringMustBeNumber);

    //NameTypeForConfigplaque
    public const string Company = nameof(Company);
    public const string Center = nameof(Center);
    public const string CostCenter = nameof(CostCenter);
    public const string Warehouse = nameof(Warehouse);
    public const string WarehouseType = nameof(WarehouseType);
    public const string Department = nameof(Department);
    public const string ProductionArea = nameof(ProductionArea);
    public const string Counter = nameof(Counter);


    //AssetsGroupStatusType
    public const string Direct = nameof(Direct);
    public const string Descending = nameof(Descending);

    //AssetsWarehouseTypeStatus Enums
    public const string InitialRegistration = nameof(InitialRegistration);
    public const string SendForManager = nameof(SendForManager);
    public const string ApprovedByManager = nameof(ApprovedByManager);
    public const string ReturnToRegistrar = nameof(ReturnToRegistrar);
    public const string SendForRepair = nameof(SendForRepair);
    public const string ReturnToManager = nameof(ReturnToManager);
    public const string Done = nameof(Done);

    public const string DarEntezarTaeedModir = nameof(DarEntezarTaeedModir);
    public const string OdatModir = nameof(OdatModir);
    public const string TaeedModirAmval = nameof(TaeedModirAmval);
    public const string OdatModirAmval = nameof(OdatModirAmval);
    public const string TaeedMali = nameof(TaeedMali);
    public const string OdatMali = nameof(OdatMali);
    public const string DarJaryan = nameof(DarJaryan);
    public const string ForoshRafte = nameof(ForoshRafte);
    public const string MadoomShode = nameof(MadoomShode);
    public const string PayanEstehlak = nameof(PayanEstehlak);

    // RepairRequestType
    public const string RepairRequestAutomatic = nameof(RepairRequestAutomatic);
    public const string RepairRequestNonAutomatic = nameof(RepairRequestNonAutomatic);

    //TagTypes Enums
    public const string TextBox = nameof(TextBox);
    public const string ComboBox = nameof(ComboBox);
    public const string DateTime = nameof(DateTime);
    public const string Number = nameof(Number);
    public const string CheckBox = nameof(CheckBox);
    public const string CheckListBox = nameof(CheckListBox);

    //AssetReformType & AssetOperationType
    public const string Increase = nameof(Increase);
    public const string Decrease = nameof(Decrease);
    public const string DisplacementOut = nameof(DisplacementOut);
    public const string DisplacementIn = nameof(DisplacementIn);
    public const string MovingBetweenCenterOut = nameof(MovingBetweenCenterOut);
    public const string MovingBetweenCenterIn = nameof(MovingBetweenCenterIn);
    public const string Depreciation = nameof(Depreciation);
    public const string RemainingBefore = nameof(RemainingBefore);

    public const string DepreciationDisplacementOut = nameof(DepreciationDisplacementOut);
    public const string DepreciationDisplacementIn = nameof(DepreciationDisplacementIn);
    public const string DepreciationMovingBetweenCenterOut = nameof(DepreciationMovingBetweenCenterOut);
    public const string DepreciationMovingBetweenCenterIn = nameof(DepreciationMovingBetweenCenterIn);
    public const string DepreciationReform = nameof(DepreciationReform);


    public const string SystemDepreciationReformAdded = nameof(SystemDepreciationReformAdded);

    #endregion
}