namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The possible feature types defined for AAT shaping, from Apple [Font Feature Registry](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html).
/// </para>
/// </summary>

[Flags]
public enum hb_aat_layout_feature_type_t
{
/// <summary>
/// <para>
/// Initial, unset feature type
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_INVALID = 65535,
/// <summary>
/// <para>
/// [All Typographic Features](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type0)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_ALL_TYPOGRAPHIC = 0,
/// <summary>
/// <para>
/// [Ligatures](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type1)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_LIGATURES = 1,
/// <summary>
/// <para>
/// [Cursive Connection](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type2)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CURSIVE_CONNECTION = 2,
/// <summary>
/// <para>
/// [Letter Case](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type3)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_LETTER_CASE = 3,
/// <summary>
/// <para>
/// [Vertical Substitution](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type4)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_VERTICAL_SUBSTITUTION = 4,
/// <summary>
/// <para>
/// [Linguistic Rearrangement](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type5)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_LINGUISTIC_REARRANGEMENT = 5,
/// <summary>
/// <para>
/// [Number Spacing](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type6)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_NUMBER_SPACING = 6,
/// <summary>
/// <para>
/// [Smart Swash](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type8)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_SMART_SWASH_TYPE = 8,
/// <summary>
/// <para>
/// [Diacritics](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type9)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_DIACRITICS_TYPE = 9,
/// <summary>
/// <para>
/// [Vertical Position](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type10)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_VERTICAL_POSITION = 10,
/// <summary>
/// <para>
/// [Fractions](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type11)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_FRACTIONS = 11,
/// <summary>
/// <para>
/// [Overlapping Characters](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type13)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_OVERLAPPING_CHARACTERS_TYPE = 13,
/// <summary>
/// <para>
/// [Typographic Extras](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type14)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_TYPOGRAPHIC_EXTRAS = 14,
/// <summary>
/// <para>
/// [Mathematical Extras](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type15)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_MATHEMATICAL_EXTRAS = 15,
/// <summary>
/// <para>
/// [Ornament Sets](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type16)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_ORNAMENT_SETS_TYPE = 16,
/// <summary>
/// <para>
/// [Character Alternatives](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type17)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CHARACTER_ALTERNATIVES = 17,
/// <summary>
/// <para>
/// [Design Complexity](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type18)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_DESIGN_COMPLEXITY_TYPE = 18,
/// <summary>
/// <para>
/// [Style Options](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type19)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_STYLE_OPTIONS = 19,
/// <summary>
/// <para>
/// [Character Shape](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type20)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CHARACTER_SHAPE = 20,
/// <summary>
/// <para>
/// [Number Case](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type21)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_NUMBER_CASE = 21,
/// <summary>
/// <para>
/// [Text Spacing](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type22)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_TEXT_SPACING = 22,
/// <summary>
/// <para>
/// [Transliteration](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type23)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_TRANSLITERATION = 23,
/// <summary>
/// <para>
/// [Annotation](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type24)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_ANNOTATION_TYPE = 24,
/// <summary>
/// <para>
/// [Kana Spacing](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type25)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_KANA_SPACING_TYPE = 25,
/// <summary>
/// <para>
/// [Ideographic Spacing](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type26)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_IDEOGRAPHIC_SPACING_TYPE = 26,
/// <summary>
/// <para>
/// [Unicode Decomposition](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type27)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_UNICODE_DECOMPOSITION_TYPE = 27,
/// <summary>
/// <para>
/// [Ruby Kana](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type28)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_RUBY_KANA = 28,
/// <summary>
/// <para>
/// [CJK Symbol Alternatives](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type29)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CJK_SYMBOL_ALTERNATIVES_TYPE = 29,
/// <summary>
/// <para>
/// [Ideographic Alternatives](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type30)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_IDEOGRAPHIC_ALTERNATIVES_TYPE = 30,
/// <summary>
/// <para>
/// [CJK Vertical Roman Placement](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type31)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CJK_VERTICAL_ROMAN_PLACEMENT_TYPE = 31,
/// <summary>
/// <para>
/// [Italic CJK Roman](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type32)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_ITALIC_CJK_ROMAN = 32,
/// <summary>
/// <para>
/// [Case Sensitive Layout](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type33)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CASE_SENSITIVE_LAYOUT = 33,
/// <summary>
/// <para>
/// [Alternate Kana](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type34)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_ALTERNATE_KANA = 34,
/// <summary>
/// <para>
/// [Stylistic Alternatives](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type35)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_STYLISTIC_ALTERNATIVES = 35,
/// <summary>
/// <para>
/// [Contextual Alternatives](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type36)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CONTEXTUAL_ALTERNATIVES = 36,
/// <summary>
/// <para>
/// [Lower Case](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type37)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_LOWER_CASE = 37,
/// <summary>
/// <para>
/// [Upper Case](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type38)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_UPPER_CASE = 38,
/// <summary>
/// <para>
/// [Language Tag](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type39)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_LANGUAGE_TAG_TYPE = 39,
/// <summary>
/// <para>
/// [CJK Roman Spacing](https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html#Type103)
/// </para>
/// </summary>

	HB_AAT_LAYOUT_FEATURE_TYPE_CJK_ROMAN_SPACING_TYPE = 103
}
