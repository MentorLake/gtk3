namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_unicode_general_category_t
{
	HB_UNICODE_GENERAL_CATEGORY_CONTROL = 0,
	HB_UNICODE_GENERAL_CATEGORY_FORMAT = 1,
	HB_UNICODE_GENERAL_CATEGORY_UNASSIGNED = 2,
	HB_UNICODE_GENERAL_CATEGORY_PRIVATE_USE = 3,
	HB_UNICODE_GENERAL_CATEGORY_SURROGATE = 4,
	HB_UNICODE_GENERAL_CATEGORY_LOWERCASE_LETTER = 5,
	HB_UNICODE_GENERAL_CATEGORY_MODIFIER_LETTER = 6,
	HB_UNICODE_GENERAL_CATEGORY_OTHER_LETTER = 7,
	HB_UNICODE_GENERAL_CATEGORY_TITLECASE_LETTER = 8,
	HB_UNICODE_GENERAL_CATEGORY_UPPERCASE_LETTER = 9,
	HB_UNICODE_GENERAL_CATEGORY_SPACING_MARK = 10,
	HB_UNICODE_GENERAL_CATEGORY_ENCLOSING_MARK = 11,
	HB_UNICODE_GENERAL_CATEGORY_NON_SPACING_MARK = 12,
	HB_UNICODE_GENERAL_CATEGORY_DECIMAL_NUMBER = 13,
	HB_UNICODE_GENERAL_CATEGORY_LETTER_NUMBER = 14,
	HB_UNICODE_GENERAL_CATEGORY_OTHER_NUMBER = 15,
	HB_UNICODE_GENERAL_CATEGORY_CONNECT_PUNCTUATION = 16,
	HB_UNICODE_GENERAL_CATEGORY_DASH_PUNCTUATION = 17,
	HB_UNICODE_GENERAL_CATEGORY_CLOSE_PUNCTUATION = 18,
	HB_UNICODE_GENERAL_CATEGORY_FINAL_PUNCTUATION = 19,
	HB_UNICODE_GENERAL_CATEGORY_INITIAL_PUNCTUATION = 20,
	HB_UNICODE_GENERAL_CATEGORY_OTHER_PUNCTUATION = 21,
	HB_UNICODE_GENERAL_CATEGORY_OPEN_PUNCTUATION = 22,
	HB_UNICODE_GENERAL_CATEGORY_CURRENCY_SYMBOL = 23,
	HB_UNICODE_GENERAL_CATEGORY_MODIFIER_SYMBOL = 24,
	HB_UNICODE_GENERAL_CATEGORY_MATH_SYMBOL = 25,
	HB_UNICODE_GENERAL_CATEGORY_OTHER_SYMBOL = 26,
	HB_UNICODE_GENERAL_CATEGORY_LINE_SEPARATOR = 27,
	HB_UNICODE_GENERAL_CATEGORY_PARAGRAPH_SEPARATOR = 28,
	HB_UNICODE_GENERAL_CATEGORY_SPACE_SEPARATOR = 29
}
