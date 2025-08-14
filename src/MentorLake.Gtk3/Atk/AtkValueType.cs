namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Default types for a given value. Those are defined in order to
/// easily get localized strings to describe a given value or a given
/// subrange, using atk_value_type_get_localized_name().
/// </para>
/// </summary>

[Flags]
public enum AtkValueType
{

	ATK_VALUE_VERY_WEAK = 0,

	ATK_VALUE_WEAK = 1,

	ATK_VALUE_ACCEPTABLE = 2,

	ATK_VALUE_STRONG = 3,

	ATK_VALUE_VERY_STRONG = 4,

	ATK_VALUE_VERY_LOW = 5,

	ATK_VALUE_LOW = 6,

	ATK_VALUE_MEDIUM = 7,

	ATK_VALUE_HIGH = 8,

	ATK_VALUE_VERY_HIGH = 9,

	ATK_VALUE_VERY_BAD = 10,

	ATK_VALUE_BAD = 11,

	ATK_VALUE_GOOD = 12,

	ATK_VALUE_VERY_GOOD = 13,

	ATK_VALUE_BEST = 14,

	ATK_VALUE_LAST_DEFINED = 15
}
