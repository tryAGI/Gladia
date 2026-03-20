
#nullable enable

namespace Gladia
{
    /// <summary>
    /// The entity types to redact
    /// </summary>
    public enum PiiRedactionEntityTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Appi,
        /// <summary>
        /// 
        /// </summary>
        AppiSensitive,
        /// <summary>
        /// 
        /// </summary>
        Cci,
        /// <summary>
        /// 
        /// </summary>
        CoreEntities,
        /// <summary>
        /// 
        /// </summary>
        Cpra,
        /// <summary>
        /// 
        /// </summary>
        Gdpr,
        /// <summary>
        /// 
        /// </summary>
        GdprSensitive,
        /// <summary>
        /// 
        /// </summary>
        HealthInformation,
        /// <summary>
        /// 
        /// </summary>
        HipaaSafeHarbor,
        /// <summary>
        /// 
        /// </summary>
        Lidi,
        /// <summary>
        /// 
        /// </summary>
        NumericalExclPci,
        /// <summary>
        /// 
        /// </summary>
        Pci,
        /// <summary>
        /// 
        /// </summary>
        QuebecPrivacyAct,
        /// <summary>
        /// 
        /// </summary>
        AccountNumber,
        /// <summary>
        /// 
        /// </summary>
        Age,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateInterval,
        /// <summary>
        /// 
        /// </summary>
        Dob,
        /// <summary>
        /// 
        /// </summary>
        DriverLicense,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Filename,
        /// <summary>
        /// 
        /// </summary>
        Gender,
        /// <summary>
        /// 
        /// </summary>
        HealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        LocationAddress,
        /// <summary>
        /// 
        /// </summary>
        LocationAddressStreet,
        /// <summary>
        /// 
        /// </summary>
        LocationCity,
        /// <summary>
        /// 
        /// </summary>
        LocationCoordinate,
        /// <summary>
        /// 
        /// </summary>
        LocationCountry,
        /// <summary>
        /// 
        /// </summary>
        LocationState,
        /// <summary>
        /// 
        /// </summary>
        LocationZip,
        /// <summary>
        /// 
        /// </summary>
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        Money,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        NameFamily,
        /// <summary>
        /// 
        /// </summary>
        NameGiven,
        /// <summary>
        /// 
        /// </summary>
        NameMedicalProfessional,
        /// <summary>
        /// 
        /// </summary>
        NumericalPii,
        /// <summary>
        /// 
        /// </summary>
        Occupation,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        OrganizationMedicalFacility,
        /// <summary>
        /// 
        /// </summary>
        Origin,
        /// <summary>
        /// 
        /// </summary>
        PassportNumber,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        PhysicalAttribute,
        /// <summary>
        /// 
        /// </summary>
        PoliticalAffiliation,
        /// <summary>
        /// 
        /// </summary>
        Religion,
        /// <summary>
        /// 
        /// </summary>
        Sexuality,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        Username,
        /// <summary>
        /// 
        /// </summary>
        VehicleId,
        /// <summary>
        /// 
        /// </summary>
        ZodiacSign,
        /// <summary>
        /// 
        /// </summary>
        BloodType,
        /// <summary>
        /// 
        /// </summary>
        Condition,
        /// <summary>
        /// 
        /// </summary>
        Dose,
        /// <summary>
        /// 
        /// </summary>
        Drug,
        /// <summary>
        /// 
        /// </summary>
        Injury,
        /// <summary>
        /// 
        /// </summary>
        MedicalProcess,
        /// <summary>
        /// 
        /// </summary>
        Statistics,
        /// <summary>
        /// 
        /// </summary>
        BankAccount,
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        CreditCardExpiration,
        /// <summary>
        /// 
        /// </summary>
        Cvv,
        /// <summary>
        /// 
        /// </summary>
        RoutingNumber,
        /// <summary>
        /// 
        /// </summary>
        CorporateAction,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Effect,
        /// <summary>
        /// 
        /// </summary>
        FinancialMetric,
        /// <summary>
        /// 
        /// </summary>
        MedicalCode,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        OrganizationId,
        /// <summary>
        /// 
        /// </summary>
        Product,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Trend,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PiiRedactionEntityTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PiiRedactionEntityTypeEnum value)
        {
            return value switch
            {
                PiiRedactionEntityTypeEnum.Appi => "APPI",
                PiiRedactionEntityTypeEnum.AppiSensitive => "APPI_SENSITIVE",
                PiiRedactionEntityTypeEnum.Cci => "CCI",
                PiiRedactionEntityTypeEnum.CoreEntities => "CORE_ENTITIES",
                PiiRedactionEntityTypeEnum.Cpra => "CPRA",
                PiiRedactionEntityTypeEnum.Gdpr => "GDPR",
                PiiRedactionEntityTypeEnum.GdprSensitive => "GDPR_SENSITIVE",
                PiiRedactionEntityTypeEnum.HealthInformation => "HEALTH_INFORMATION",
                PiiRedactionEntityTypeEnum.HipaaSafeHarbor => "HIPAA_SAFE_HARBOR",
                PiiRedactionEntityTypeEnum.Lidi => "LIDI",
                PiiRedactionEntityTypeEnum.NumericalExclPci => "NUMERICAL_EXCL_PCI",
                PiiRedactionEntityTypeEnum.Pci => "PCI",
                PiiRedactionEntityTypeEnum.QuebecPrivacyAct => "QUEBEC_PRIVACY_ACT",
                PiiRedactionEntityTypeEnum.AccountNumber => "ACCOUNT_NUMBER",
                PiiRedactionEntityTypeEnum.Age => "AGE",
                PiiRedactionEntityTypeEnum.Date => "DATE",
                PiiRedactionEntityTypeEnum.DateInterval => "DATE_INTERVAL",
                PiiRedactionEntityTypeEnum.Dob => "DOB",
                PiiRedactionEntityTypeEnum.DriverLicense => "DRIVER_LICENSE",
                PiiRedactionEntityTypeEnum.Duration => "DURATION",
                PiiRedactionEntityTypeEnum.EmailAddress => "EMAIL_ADDRESS",
                PiiRedactionEntityTypeEnum.Event => "EVENT",
                PiiRedactionEntityTypeEnum.Filename => "FILENAME",
                PiiRedactionEntityTypeEnum.Gender => "GENDER",
                PiiRedactionEntityTypeEnum.HealthcareNumber => "HEALTHCARE_NUMBER",
                PiiRedactionEntityTypeEnum.IpAddress => "IP_ADDRESS",
                PiiRedactionEntityTypeEnum.Language => "LANGUAGE",
                PiiRedactionEntityTypeEnum.Location => "LOCATION",
                PiiRedactionEntityTypeEnum.LocationAddress => "LOCATION_ADDRESS",
                PiiRedactionEntityTypeEnum.LocationAddressStreet => "LOCATION_ADDRESS_STREET",
                PiiRedactionEntityTypeEnum.LocationCity => "LOCATION_CITY",
                PiiRedactionEntityTypeEnum.LocationCoordinate => "LOCATION_COORDINATE",
                PiiRedactionEntityTypeEnum.LocationCountry => "LOCATION_COUNTRY",
                PiiRedactionEntityTypeEnum.LocationState => "LOCATION_STATE",
                PiiRedactionEntityTypeEnum.LocationZip => "LOCATION_ZIP",
                PiiRedactionEntityTypeEnum.MaritalStatus => "MARITAL_STATUS",
                PiiRedactionEntityTypeEnum.Money => "MONEY",
                PiiRedactionEntityTypeEnum.Name => "NAME",
                PiiRedactionEntityTypeEnum.NameFamily => "NAME_FAMILY",
                PiiRedactionEntityTypeEnum.NameGiven => "NAME_GIVEN",
                PiiRedactionEntityTypeEnum.NameMedicalProfessional => "NAME_MEDICAL_PROFESSIONAL",
                PiiRedactionEntityTypeEnum.NumericalPii => "NUMERICAL_PII",
                PiiRedactionEntityTypeEnum.Occupation => "OCCUPATION",
                PiiRedactionEntityTypeEnum.Organization => "ORGANIZATION",
                PiiRedactionEntityTypeEnum.OrganizationMedicalFacility => "ORGANIZATION_MEDICAL_FACILITY",
                PiiRedactionEntityTypeEnum.Origin => "ORIGIN",
                PiiRedactionEntityTypeEnum.PassportNumber => "PASSPORT_NUMBER",
                PiiRedactionEntityTypeEnum.Password => "PASSWORD",
                PiiRedactionEntityTypeEnum.PhoneNumber => "PHONE_NUMBER",
                PiiRedactionEntityTypeEnum.PhysicalAttribute => "PHYSICAL_ATTRIBUTE",
                PiiRedactionEntityTypeEnum.PoliticalAffiliation => "POLITICAL_AFFILIATION",
                PiiRedactionEntityTypeEnum.Religion => "RELIGION",
                PiiRedactionEntityTypeEnum.Sexuality => "SEXUALITY",
                PiiRedactionEntityTypeEnum.Ssn => "SSN",
                PiiRedactionEntityTypeEnum.Time => "TIME",
                PiiRedactionEntityTypeEnum.Url => "URL",
                PiiRedactionEntityTypeEnum.Username => "USERNAME",
                PiiRedactionEntityTypeEnum.VehicleId => "VEHICLE_ID",
                PiiRedactionEntityTypeEnum.ZodiacSign => "ZODIAC_SIGN",
                PiiRedactionEntityTypeEnum.BloodType => "BLOOD_TYPE",
                PiiRedactionEntityTypeEnum.Condition => "CONDITION",
                PiiRedactionEntityTypeEnum.Dose => "DOSE",
                PiiRedactionEntityTypeEnum.Drug => "DRUG",
                PiiRedactionEntityTypeEnum.Injury => "INJURY",
                PiiRedactionEntityTypeEnum.MedicalProcess => "MEDICAL_PROCESS",
                PiiRedactionEntityTypeEnum.Statistics => "STATISTICS",
                PiiRedactionEntityTypeEnum.BankAccount => "BANK_ACCOUNT",
                PiiRedactionEntityTypeEnum.CreditCard => "CREDIT_CARD",
                PiiRedactionEntityTypeEnum.CreditCardExpiration => "CREDIT_CARD_EXPIRATION",
                PiiRedactionEntityTypeEnum.Cvv => "CVV",
                PiiRedactionEntityTypeEnum.RoutingNumber => "ROUTING_NUMBER",
                PiiRedactionEntityTypeEnum.CorporateAction => "CORPORATE_ACTION",
                PiiRedactionEntityTypeEnum.Day => "DAY",
                PiiRedactionEntityTypeEnum.Effect => "EFFECT",
                PiiRedactionEntityTypeEnum.FinancialMetric => "FINANCIAL_METRIC",
                PiiRedactionEntityTypeEnum.MedicalCode => "MEDICAL_CODE",
                PiiRedactionEntityTypeEnum.Month => "MONTH",
                PiiRedactionEntityTypeEnum.OrganizationId => "ORGANIZATION_ID",
                PiiRedactionEntityTypeEnum.Product => "PRODUCT",
                PiiRedactionEntityTypeEnum.Project => "PROJECT",
                PiiRedactionEntityTypeEnum.Trend => "TREND",
                PiiRedactionEntityTypeEnum.Year => "YEAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PiiRedactionEntityTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "APPI" => PiiRedactionEntityTypeEnum.Appi,
                "APPI_SENSITIVE" => PiiRedactionEntityTypeEnum.AppiSensitive,
                "CCI" => PiiRedactionEntityTypeEnum.Cci,
                "CORE_ENTITIES" => PiiRedactionEntityTypeEnum.CoreEntities,
                "CPRA" => PiiRedactionEntityTypeEnum.Cpra,
                "GDPR" => PiiRedactionEntityTypeEnum.Gdpr,
                "GDPR_SENSITIVE" => PiiRedactionEntityTypeEnum.GdprSensitive,
                "HEALTH_INFORMATION" => PiiRedactionEntityTypeEnum.HealthInformation,
                "HIPAA_SAFE_HARBOR" => PiiRedactionEntityTypeEnum.HipaaSafeHarbor,
                "LIDI" => PiiRedactionEntityTypeEnum.Lidi,
                "NUMERICAL_EXCL_PCI" => PiiRedactionEntityTypeEnum.NumericalExclPci,
                "PCI" => PiiRedactionEntityTypeEnum.Pci,
                "QUEBEC_PRIVACY_ACT" => PiiRedactionEntityTypeEnum.QuebecPrivacyAct,
                "ACCOUNT_NUMBER" => PiiRedactionEntityTypeEnum.AccountNumber,
                "AGE" => PiiRedactionEntityTypeEnum.Age,
                "DATE" => PiiRedactionEntityTypeEnum.Date,
                "DATE_INTERVAL" => PiiRedactionEntityTypeEnum.DateInterval,
                "DOB" => PiiRedactionEntityTypeEnum.Dob,
                "DRIVER_LICENSE" => PiiRedactionEntityTypeEnum.DriverLicense,
                "DURATION" => PiiRedactionEntityTypeEnum.Duration,
                "EMAIL_ADDRESS" => PiiRedactionEntityTypeEnum.EmailAddress,
                "EVENT" => PiiRedactionEntityTypeEnum.Event,
                "FILENAME" => PiiRedactionEntityTypeEnum.Filename,
                "GENDER" => PiiRedactionEntityTypeEnum.Gender,
                "HEALTHCARE_NUMBER" => PiiRedactionEntityTypeEnum.HealthcareNumber,
                "IP_ADDRESS" => PiiRedactionEntityTypeEnum.IpAddress,
                "LANGUAGE" => PiiRedactionEntityTypeEnum.Language,
                "LOCATION" => PiiRedactionEntityTypeEnum.Location,
                "LOCATION_ADDRESS" => PiiRedactionEntityTypeEnum.LocationAddress,
                "LOCATION_ADDRESS_STREET" => PiiRedactionEntityTypeEnum.LocationAddressStreet,
                "LOCATION_CITY" => PiiRedactionEntityTypeEnum.LocationCity,
                "LOCATION_COORDINATE" => PiiRedactionEntityTypeEnum.LocationCoordinate,
                "LOCATION_COUNTRY" => PiiRedactionEntityTypeEnum.LocationCountry,
                "LOCATION_STATE" => PiiRedactionEntityTypeEnum.LocationState,
                "LOCATION_ZIP" => PiiRedactionEntityTypeEnum.LocationZip,
                "MARITAL_STATUS" => PiiRedactionEntityTypeEnum.MaritalStatus,
                "MONEY" => PiiRedactionEntityTypeEnum.Money,
                "NAME" => PiiRedactionEntityTypeEnum.Name,
                "NAME_FAMILY" => PiiRedactionEntityTypeEnum.NameFamily,
                "NAME_GIVEN" => PiiRedactionEntityTypeEnum.NameGiven,
                "NAME_MEDICAL_PROFESSIONAL" => PiiRedactionEntityTypeEnum.NameMedicalProfessional,
                "NUMERICAL_PII" => PiiRedactionEntityTypeEnum.NumericalPii,
                "OCCUPATION" => PiiRedactionEntityTypeEnum.Occupation,
                "ORGANIZATION" => PiiRedactionEntityTypeEnum.Organization,
                "ORGANIZATION_MEDICAL_FACILITY" => PiiRedactionEntityTypeEnum.OrganizationMedicalFacility,
                "ORIGIN" => PiiRedactionEntityTypeEnum.Origin,
                "PASSPORT_NUMBER" => PiiRedactionEntityTypeEnum.PassportNumber,
                "PASSWORD" => PiiRedactionEntityTypeEnum.Password,
                "PHONE_NUMBER" => PiiRedactionEntityTypeEnum.PhoneNumber,
                "PHYSICAL_ATTRIBUTE" => PiiRedactionEntityTypeEnum.PhysicalAttribute,
                "POLITICAL_AFFILIATION" => PiiRedactionEntityTypeEnum.PoliticalAffiliation,
                "RELIGION" => PiiRedactionEntityTypeEnum.Religion,
                "SEXUALITY" => PiiRedactionEntityTypeEnum.Sexuality,
                "SSN" => PiiRedactionEntityTypeEnum.Ssn,
                "TIME" => PiiRedactionEntityTypeEnum.Time,
                "URL" => PiiRedactionEntityTypeEnum.Url,
                "USERNAME" => PiiRedactionEntityTypeEnum.Username,
                "VEHICLE_ID" => PiiRedactionEntityTypeEnum.VehicleId,
                "ZODIAC_SIGN" => PiiRedactionEntityTypeEnum.ZodiacSign,
                "BLOOD_TYPE" => PiiRedactionEntityTypeEnum.BloodType,
                "CONDITION" => PiiRedactionEntityTypeEnum.Condition,
                "DOSE" => PiiRedactionEntityTypeEnum.Dose,
                "DRUG" => PiiRedactionEntityTypeEnum.Drug,
                "INJURY" => PiiRedactionEntityTypeEnum.Injury,
                "MEDICAL_PROCESS" => PiiRedactionEntityTypeEnum.MedicalProcess,
                "STATISTICS" => PiiRedactionEntityTypeEnum.Statistics,
                "BANK_ACCOUNT" => PiiRedactionEntityTypeEnum.BankAccount,
                "CREDIT_CARD" => PiiRedactionEntityTypeEnum.CreditCard,
                "CREDIT_CARD_EXPIRATION" => PiiRedactionEntityTypeEnum.CreditCardExpiration,
                "CVV" => PiiRedactionEntityTypeEnum.Cvv,
                "ROUTING_NUMBER" => PiiRedactionEntityTypeEnum.RoutingNumber,
                "CORPORATE_ACTION" => PiiRedactionEntityTypeEnum.CorporateAction,
                "DAY" => PiiRedactionEntityTypeEnum.Day,
                "EFFECT" => PiiRedactionEntityTypeEnum.Effect,
                "FINANCIAL_METRIC" => PiiRedactionEntityTypeEnum.FinancialMetric,
                "MEDICAL_CODE" => PiiRedactionEntityTypeEnum.MedicalCode,
                "MONTH" => PiiRedactionEntityTypeEnum.Month,
                "ORGANIZATION_ID" => PiiRedactionEntityTypeEnum.OrganizationId,
                "PRODUCT" => PiiRedactionEntityTypeEnum.Product,
                "PROJECT" => PiiRedactionEntityTypeEnum.Project,
                "TREND" => PiiRedactionEntityTypeEnum.Trend,
                "YEAR" => PiiRedactionEntityTypeEnum.Year,
                _ => null,
            };
        }
    }
}