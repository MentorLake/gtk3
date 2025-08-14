namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for the Canonical_Combining_Class (ccc) property
/// from the Unicode Character Database.
/// </para>
/// <para>
/// <note>Note: newer versions of Unicode may add new values.
/// Client programs should be ready to handle any value in the 0..254 range
/// being returned from hb_unicode_combining_class().</note>
/// </para>
/// </summary>

[Flags]
public enum hb_unicode_combining_class_t
{
/// <summary>
/// <para>
/// Spacing and enclosing marks; also many vowel and consonant signs, even if nonspacing
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_NOT_REORDERED = 0,
/// <summary>
/// <para>
/// Marks which overlay a base letter or symbol
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_OVERLAY = 1,
/// <summary>
/// <para>
/// Diacritic nukta marks in Brahmi-derived scripts
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_NUKTA = 7,
/// <summary>
/// <para>
/// Hiragana/Katakana voicing marks
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_KANA_VOICING = 8,
/// <summary>
/// <para>
/// Viramas
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_VIRAMA = 9,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC10 = 10,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC11 = 11,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC12 = 12,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC13 = 13,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC14 = 14,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC15 = 15,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC16 = 16,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC17 = 17,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC18 = 18,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC19 = 19,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC20 = 20,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC21 = 21,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC22 = 22,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC23 = 23,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC24 = 24,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC25 = 25,
/// <summary>
/// <para>
/// [Hebrew]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC26 = 26,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC27 = 27,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC28 = 28,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC29 = 29,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC30 = 30,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC31 = 31,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC32 = 32,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC33 = 33,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC34 = 34,
/// <summary>
/// <para>
/// [Arabic]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC35 = 35,
/// <summary>
/// <para>
/// [Syriac]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC36 = 36,
/// <summary>
/// <para>
/// [Telugu]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC84 = 84,
/// <summary>
/// <para>
/// [Telugu]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC91 = 91,
/// <summary>
/// <para>
/// [Thai]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC103 = 103,
/// <summary>
/// <para>
/// [Thai]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC107 = 107,
/// <summary>
/// <para>
/// [Lao]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC118 = 118,
/// <summary>
/// <para>
/// [Lao]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC122 = 122,
/// <summary>
/// <para>
/// [Tibetan]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC129 = 129,
/// <summary>
/// <para>
/// [Tibetan]
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC130 = 130,
/// <summary>
/// <para>
/// [Tibetan] Since: 7.2.0
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_CCC132 = 132,
/// <summary>
/// <para>
/// Marks attached at the bottom left
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ATTACHED_BELOW_LEFT = 200,
/// <summary>
/// <para>
/// Marks attached directly below
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ATTACHED_BELOW = 202,
/// <summary>
/// <para>
/// Marks attached directly above
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ATTACHED_ABOVE = 214,
/// <summary>
/// <para>
/// Marks attached at the top right
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ATTACHED_ABOVE_RIGHT = 216,
/// <summary>
/// <para>
/// Distinct marks at the bottom left
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_BELOW_LEFT = 218,
/// <summary>
/// <para>
/// Distinct marks directly below
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_BELOW = 220,
/// <summary>
/// <para>
/// Distinct marks at the bottom right
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_BELOW_RIGHT = 222,
/// <summary>
/// <para>
/// Distinct marks to the left
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_LEFT = 224,
/// <summary>
/// <para>
/// Distinct marks to the right
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_RIGHT = 226,
/// <summary>
/// <para>
/// Distinct marks at the top left
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ABOVE_LEFT = 228,
/// <summary>
/// <para>
/// Distinct marks directly above
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ABOVE = 230,
/// <summary>
/// <para>
/// Distinct marks at the top right
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_ABOVE_RIGHT = 232,
/// <summary>
/// <para>
/// Distinct marks subtending two bases
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_DOUBLE_BELOW = 233,
/// <summary>
/// <para>
/// Distinct marks extending above two bases
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_DOUBLE_ABOVE = 234,
/// <summary>
/// <para>
/// Greek iota subscript only
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_IOTA_SUBSCRIPT = 240,
/// <summary>
/// <para>
/// Invalid combining class
/// </para>
/// </summary>

	HB_UNICODE_COMBINING_CLASS_INVALID = 255
}
