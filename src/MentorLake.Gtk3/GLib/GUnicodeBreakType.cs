namespace MentorLake.GLib;

/// <summary>
/// <para>
/// These are the possible line break classifications.
/// </para>
/// <para>
/// Since new Unicode versions may add new types here, applications should be ready
/// to handle unknown values. They may be regarded as %G_UNICODE_BREAK_UNKNOWN.
/// </para>
/// <para>
/// See [Unicode Line Breaking Algorithm](https://www.unicode.org/reports/tr14/).
/// </para>
/// </summary>

[Flags]
public enum GUnicodeBreakType
{
/// <summary>
/// <para>
/// Mandatory Break (BK)
/// </para>
/// </summary>

	G_UNICODE_BREAK_MANDATORY = 0,
/// <summary>
/// <para>
/// Carriage Return (CR)
/// </para>
/// </summary>

	G_UNICODE_BREAK_CARRIAGE_RETURN = 1,
/// <summary>
/// <para>
/// Line Feed (LF)
/// </para>
/// </summary>

	G_UNICODE_BREAK_LINE_FEED = 2,
/// <summary>
/// <para>
/// Attached Characters and Combining Marks (CM)
/// </para>
/// </summary>

	G_UNICODE_BREAK_COMBINING_MARK = 3,
/// <summary>
/// <para>
/// Surrogates (SG)
/// </para>
/// </summary>

	G_UNICODE_BREAK_SURROGATE = 4,
/// <summary>
/// <para>
/// Zero Width Space (ZW)
/// </para>
/// </summary>

	G_UNICODE_BREAK_ZERO_WIDTH_SPACE = 5,
/// <summary>
/// <para>
/// Inseparable (IN)
/// </para>
/// </summary>

	G_UNICODE_BREAK_INSEPARABLE = 6,
/// <summary>
/// <para>
/// Non-breaking ("Glue") (GL)
/// </para>
/// </summary>

	G_UNICODE_BREAK_NON_BREAKING_GLUE = 7,
/// <summary>
/// <para>
/// Contingent Break Opportunity (CB)
/// </para>
/// </summary>

	G_UNICODE_BREAK_CONTINGENT = 8,
/// <summary>
/// <para>
/// Space (SP)
/// </para>
/// </summary>

	G_UNICODE_BREAK_SPACE = 9,
/// <summary>
/// <para>
/// Break Opportunity After (BA)
/// </para>
/// </summary>

	G_UNICODE_BREAK_AFTER = 10,
/// <summary>
/// <para>
/// Break Opportunity Before (BB)
/// </para>
/// </summary>

	G_UNICODE_BREAK_BEFORE = 11,
/// <summary>
/// <para>
/// Break Opportunity Before and After (B2)
/// </para>
/// </summary>

	G_UNICODE_BREAK_BEFORE_AND_AFTER = 12,
/// <summary>
/// <para>
/// Hyphen (HY)
/// </para>
/// </summary>

	G_UNICODE_BREAK_HYPHEN = 13,
/// <summary>
/// <para>
/// Nonstarter (NS)
/// </para>
/// </summary>

	G_UNICODE_BREAK_NON_STARTER = 14,
/// <summary>
/// <para>
/// Opening Punctuation (OP)
/// </para>
/// </summary>

	G_UNICODE_BREAK_OPEN_PUNCTUATION = 15,
/// <summary>
/// <para>
/// Closing Punctuation (CL)
/// </para>
/// </summary>

	G_UNICODE_BREAK_CLOSE_PUNCTUATION = 16,
/// <summary>
/// <para>
/// Ambiguous Quotation (QU)
/// </para>
/// </summary>

	G_UNICODE_BREAK_QUOTATION = 17,
/// <summary>
/// <para>
/// Exclamation/Interrogation (EX)
/// </para>
/// </summary>

	G_UNICODE_BREAK_EXCLAMATION = 18,
/// <summary>
/// <para>
/// Ideographic (ID)
/// </para>
/// </summary>

	G_UNICODE_BREAK_IDEOGRAPHIC = 19,
/// <summary>
/// <para>
/// Numeric (NU)
/// </para>
/// </summary>

	G_UNICODE_BREAK_NUMERIC = 20,
/// <summary>
/// <para>
/// Infix Separator (Numeric) (IS)
/// </para>
/// </summary>

	G_UNICODE_BREAK_INFIX_SEPARATOR = 21,
/// <summary>
/// <para>
/// Symbols Allowing Break After (SY)
/// </para>
/// </summary>

	G_UNICODE_BREAK_SYMBOL = 22,
/// <summary>
/// <para>
/// Ordinary Alphabetic and Symbol Characters (AL)
/// </para>
/// </summary>

	G_UNICODE_BREAK_ALPHABETIC = 23,
/// <summary>
/// <para>
/// Prefix (Numeric) (PR)
/// </para>
/// </summary>

	G_UNICODE_BREAK_PREFIX = 24,
/// <summary>
/// <para>
/// Postfix (Numeric) (PO)
/// </para>
/// </summary>

	G_UNICODE_BREAK_POSTFIX = 25,
/// <summary>
/// <para>
/// Complex Content Dependent (South East Asian) (SA)
/// </para>
/// </summary>

	G_UNICODE_BREAK_COMPLEX_CONTEXT = 26,
/// <summary>
/// <para>
/// Ambiguous (Alphabetic or Ideographic) (AI)
/// </para>
/// </summary>

	G_UNICODE_BREAK_AMBIGUOUS = 27,
/// <summary>
/// <para>
/// Unknown (XX)
/// </para>
/// </summary>

	G_UNICODE_BREAK_UNKNOWN = 28,
/// <summary>
/// <para>
/// Next Line (NL)
/// </para>
/// </summary>

	G_UNICODE_BREAK_NEXT_LINE = 29,
/// <summary>
/// <para>
/// Word Joiner (WJ)
/// </para>
/// </summary>

	G_UNICODE_BREAK_WORD_JOINER = 30,
/// <summary>
/// <para>
/// Hangul L Jamo (JL)
/// </para>
/// </summary>

	G_UNICODE_BREAK_HANGUL_L_JAMO = 31,
/// <summary>
/// <para>
/// Hangul V Jamo (JV)
/// </para>
/// </summary>

	G_UNICODE_BREAK_HANGUL_V_JAMO = 32,
/// <summary>
/// <para>
/// Hangul T Jamo (JT)
/// </para>
/// </summary>

	G_UNICODE_BREAK_HANGUL_T_JAMO = 33,
/// <summary>
/// <para>
/// Hangul LV Syllable (H2)
/// </para>
/// </summary>

	G_UNICODE_BREAK_HANGUL_LV_SYLLABLE = 34,
/// <summary>
/// <para>
/// Hangul LVT Syllable (H3)
/// </para>
/// </summary>

	G_UNICODE_BREAK_HANGUL_LVT_SYLLABLE = 35,
/// <summary>
/// <para>
/// Closing Parenthesis (CP). Since 2.28. Deprecated: 2.70: Use %G_UNICODE_BREAK_CLOSE_PARENTHESIS instead.
/// </para>
/// </summary>

	G_UNICODE_BREAK_CLOSE_PARANTHESIS = 36,
/// <summary>
/// <para>
/// Closing Parenthesis (CP). Since 2.70
/// </para>
/// </summary>

	G_UNICODE_BREAK_CLOSE_PARENTHESIS = 36,
/// <summary>
/// <para>
/// Conditional Japanese Starter (CJ). Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_BREAK_CONDITIONAL_JAPANESE_STARTER = 37,
/// <summary>
/// <para>
/// Hebrew Letter (HL). Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_BREAK_HEBREW_LETTER = 38,
/// <summary>
/// <para>
/// Regional Indicator (RI). Since: 2.36
/// </para>
/// </summary>

	G_UNICODE_BREAK_REGIONAL_INDICATOR = 39,
/// <summary>
/// <para>
/// Emoji Base (EB). Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_BREAK_EMOJI_BASE = 40,
/// <summary>
/// <para>
/// Emoji Modifier (EM). Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_BREAK_EMOJI_MODIFIER = 41,
/// <summary>
/// <para>
/// Zero Width Joiner (ZWJ). Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_BREAK_ZERO_WIDTH_JOINER = 42,
/// <summary>
/// <para>
/// Aksara (AK). Since: 2.80
/// </para>
/// </summary>

	G_UNICODE_BREAK_AKSARA = 43,
/// <summary>
/// <para>
/// Aksara Pre-Base (AP). Since: 2.80
/// </para>
/// </summary>

	G_UNICODE_BREAK_AKSARA_PRE_BASE = 44,
/// <summary>
/// <para>
/// Aksara Start (AS). Since: 2.80
/// </para>
/// </summary>

	G_UNICODE_BREAK_AKSARA_START = 45,
/// <summary>
/// <para>
/// Virama Final (VF). Since: 2.80
/// </para>
/// </summary>

	G_UNICODE_BREAK_VIRAMA_FINAL = 46,
/// <summary>
/// <para>
/// Virama (VI). Since: 2.80
/// </para>
/// </summary>

	G_UNICODE_BREAK_VIRAMA = 47
}
