namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for the &quot;General_Category&quot; (gc) property from
/// the Unicode Character Database.
/// </para>
/// </summary>

[Flags]
public enum hb_unicode_general_category_t
{
/// <summary>
/// <para>
/// [Cc]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_CONTROL = 0,
/// <summary>
/// <para>
/// [Cf]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_FORMAT = 1,
/// <summary>
/// <para>
/// [Cn]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_UNASSIGNED = 2,
/// <summary>
/// <para>
/// [Co]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_PRIVATE_USE = 3,
/// <summary>
/// <para>
/// [Cs]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_SURROGATE = 4,
/// <summary>
/// <para>
/// [Ll]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_LOWERCASE_LETTER = 5,
/// <summary>
/// <para>
/// [Lm]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_MODIFIER_LETTER = 6,
/// <summary>
/// <para>
/// [Lo]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_OTHER_LETTER = 7,
/// <summary>
/// <para>
/// [Lt]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_TITLECASE_LETTER = 8,
/// <summary>
/// <para>
/// [Lu]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_UPPERCASE_LETTER = 9,
/// <summary>
/// <para>
/// [Mc]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_SPACING_MARK = 10,
/// <summary>
/// <para>
/// [Me]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_ENCLOSING_MARK = 11,
/// <summary>
/// <para>
/// [Mn]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_NON_SPACING_MARK = 12,
/// <summary>
/// <para>
/// [Nd]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_DECIMAL_NUMBER = 13,
/// <summary>
/// <para>
/// [Nl]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_LETTER_NUMBER = 14,
/// <summary>
/// <para>
/// [No]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_OTHER_NUMBER = 15,
/// <summary>
/// <para>
/// [Pc]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_CONNECT_PUNCTUATION = 16,
/// <summary>
/// <para>
/// [Pd]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_DASH_PUNCTUATION = 17,
/// <summary>
/// <para>
/// [Pe]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_CLOSE_PUNCTUATION = 18,
/// <summary>
/// <para>
/// [Pf]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_FINAL_PUNCTUATION = 19,
/// <summary>
/// <para>
/// [Pi]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_INITIAL_PUNCTUATION = 20,
/// <summary>
/// <para>
/// [Po]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_OTHER_PUNCTUATION = 21,
/// <summary>
/// <para>
/// [Ps]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_OPEN_PUNCTUATION = 22,
/// <summary>
/// <para>
/// [Sc]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_CURRENCY_SYMBOL = 23,
/// <summary>
/// <para>
/// [Sk]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_MODIFIER_SYMBOL = 24,
/// <summary>
/// <para>
/// [Sm]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_MATH_SYMBOL = 25,
/// <summary>
/// <para>
/// [So]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_OTHER_SYMBOL = 26,
/// <summary>
/// <para>
/// [Zl]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_LINE_SEPARATOR = 27,
/// <summary>
/// <para>
/// [Zp]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_PARAGRAPH_SEPARATOR = 28,
/// <summary>
/// <para>
/// [Zs]
/// </para>
/// </summary>

	HB_UNICODE_GENERAL_CATEGORY_SPACE_SEPARATOR = 29
}
