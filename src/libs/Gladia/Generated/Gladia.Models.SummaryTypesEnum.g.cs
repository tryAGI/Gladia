
#nullable enable

namespace Gladia
{
    /// <summary>
    /// The type of summarization to apply
    /// </summary>
    public enum SummaryTypesEnum
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        BulletPoints,
        /// <summary>
        /// 
        /// </summary>
        Concise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryTypesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryTypesEnum value)
        {
            return value switch
            {
                SummaryTypesEnum.General => "general",
                SummaryTypesEnum.BulletPoints => "bullet_points",
                SummaryTypesEnum.Concise => "concise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryTypesEnum? ToEnum(string value)
        {
            return value switch
            {
                "general" => SummaryTypesEnum.General,
                "bullet_points" => SummaryTypesEnum.BulletPoints,
                "concise" => SummaryTypesEnum.Concise,
                _ => null,
            };
        }
    }
}