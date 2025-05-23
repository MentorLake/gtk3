namespace MentorLake.GLib;

[Flags]
public enum GUnicodeBreakType
{
	G_UNICODE_BREAK_MANDATORY = 0,
	G_UNICODE_BREAK_CARRIAGE_RETURN = 1,
	G_UNICODE_BREAK_LINE_FEED = 2,
	G_UNICODE_BREAK_COMBINING_MARK = 3,
	G_UNICODE_BREAK_SURROGATE = 4,
	G_UNICODE_BREAK_ZERO_WIDTH_SPACE = 5,
	G_UNICODE_BREAK_INSEPARABLE = 6,
	G_UNICODE_BREAK_NON_BREAKING_GLUE = 7,
	G_UNICODE_BREAK_CONTINGENT = 8,
	G_UNICODE_BREAK_SPACE = 9,
	G_UNICODE_BREAK_AFTER = 10,
	G_UNICODE_BREAK_BEFORE = 11,
	G_UNICODE_BREAK_BEFORE_AND_AFTER = 12,
	G_UNICODE_BREAK_HYPHEN = 13,
	G_UNICODE_BREAK_NON_STARTER = 14,
	G_UNICODE_BREAK_OPEN_PUNCTUATION = 15,
	G_UNICODE_BREAK_CLOSE_PUNCTUATION = 16,
	G_UNICODE_BREAK_QUOTATION = 17,
	G_UNICODE_BREAK_EXCLAMATION = 18,
	G_UNICODE_BREAK_IDEOGRAPHIC = 19,
	G_UNICODE_BREAK_NUMERIC = 20,
	G_UNICODE_BREAK_INFIX_SEPARATOR = 21,
	G_UNICODE_BREAK_SYMBOL = 22,
	G_UNICODE_BREAK_ALPHABETIC = 23,
	G_UNICODE_BREAK_PREFIX = 24,
	G_UNICODE_BREAK_POSTFIX = 25,
	G_UNICODE_BREAK_COMPLEX_CONTEXT = 26,
	G_UNICODE_BREAK_AMBIGUOUS = 27,
	G_UNICODE_BREAK_UNKNOWN = 28,
	G_UNICODE_BREAK_NEXT_LINE = 29,
	G_UNICODE_BREAK_WORD_JOINER = 30,
	G_UNICODE_BREAK_HANGUL_L_JAMO = 31,
	G_UNICODE_BREAK_HANGUL_V_JAMO = 32,
	G_UNICODE_BREAK_HANGUL_T_JAMO = 33,
	G_UNICODE_BREAK_HANGUL_LV_SYLLABLE = 34,
	G_UNICODE_BREAK_HANGUL_LVT_SYLLABLE = 35,
	G_UNICODE_BREAK_CLOSE_PARANTHESIS = 36,
	G_UNICODE_BREAK_CLOSE_PARENTHESIS = 36,
	G_UNICODE_BREAK_CONDITIONAL_JAPANESE_STARTER = 37,
	G_UNICODE_BREAK_HEBREW_LETTER = 38,
	G_UNICODE_BREAK_REGIONAL_INDICATOR = 39,
	G_UNICODE_BREAK_EMOJI_BASE = 40,
	G_UNICODE_BREAK_EMOJI_MODIFIER = 41,
	G_UNICODE_BREAK_ZERO_WIDTH_JOINER = 42,
	G_UNICODE_BREAK_AKSARA = 43,
	G_UNICODE_BREAK_AKSARA_PRE_BASE = 44,
	G_UNICODE_BREAK_AKSARA_START = 45,
	G_UNICODE_BREAK_VIRAMA_FINAL = 46,
	G_UNICODE_BREAK_VIRAMA = 47
}
