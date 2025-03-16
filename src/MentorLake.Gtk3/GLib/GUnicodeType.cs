namespace MentorLake.GLib;

[Flags]
public enum GUnicodeType
{
	G_UNICODE_CONTROL = 0,
	G_UNICODE_FORMAT = 1,
	G_UNICODE_UNASSIGNED = 2,
	G_UNICODE_PRIVATE_USE = 3,
	G_UNICODE_SURROGATE = 4,
	G_UNICODE_LOWERCASE_LETTER = 5,
	G_UNICODE_MODIFIER_LETTER = 6,
	G_UNICODE_OTHER_LETTER = 7,
	G_UNICODE_TITLECASE_LETTER = 8,
	G_UNICODE_UPPERCASE_LETTER = 9,
	G_UNICODE_SPACING_MARK = 10,
	G_UNICODE_ENCLOSING_MARK = 11,
	G_UNICODE_NON_SPACING_MARK = 12,
	G_UNICODE_DECIMAL_NUMBER = 13,
	G_UNICODE_LETTER_NUMBER = 14,
	G_UNICODE_OTHER_NUMBER = 15,
	G_UNICODE_CONNECT_PUNCTUATION = 16,
	G_UNICODE_DASH_PUNCTUATION = 17,
	G_UNICODE_CLOSE_PUNCTUATION = 18,
	G_UNICODE_FINAL_PUNCTUATION = 19,
	G_UNICODE_INITIAL_PUNCTUATION = 20,
	G_UNICODE_OTHER_PUNCTUATION = 21,
	G_UNICODE_OPEN_PUNCTUATION = 22,
	G_UNICODE_CURRENCY_SYMBOL = 23,
	G_UNICODE_MODIFIER_SYMBOL = 24,
	G_UNICODE_MATH_SYMBOL = 25,
	G_UNICODE_OTHER_SYMBOL = 26,
	G_UNICODE_LINE_SEPARATOR = 27,
	G_UNICODE_PARAGRAPH_SEPARATOR = 28,
	G_UNICODE_SPACE_SEPARATOR = 29
}
