namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoScript` enumeration identifies different writing
/// systems.
/// </para>
/// <para>
/// The values correspond to the names as defined in the Unicode standard. See
/// [Unicode Standard Annex 24: Script names](http://www.unicode.org/reports/tr24/)
/// </para>
/// <para>
/// Note that this enumeration is deprecated and will not be updated to include values
/// in newer versions of the Unicode standard. Applications should use the
/// [enum@GLib.UnicodeScript] enumeration instead,
/// whose values are interchangeable with `PangoScript`.
/// </para>
/// </summary>

[Flags]
public enum PangoScript
{
/// <summary>
/// <para>
/// a value never returned from pango_script_for_unichar()
/// </para>
/// </summary>

	PANGO_SCRIPT_INVALID_CODE = -1,
/// <summary>
/// <para>
/// a character used by multiple different scripts
/// </para>
/// </summary>

	PANGO_SCRIPT_COMMON = 0,
/// <summary>
/// <para>
/// a mark glyph that takes its script from the
/// base glyph to which it is attached
/// </para>
/// </summary>

	PANGO_SCRIPT_INHERITED = 1,
/// <summary>
/// <para>
/// Arabic
/// </para>
/// </summary>

	PANGO_SCRIPT_ARABIC = 2,
/// <summary>
/// <para>
/// Armenian
/// </para>
/// </summary>

	PANGO_SCRIPT_ARMENIAN = 3,
/// <summary>
/// <para>
/// Bengali
/// </para>
/// </summary>

	PANGO_SCRIPT_BENGALI = 4,
/// <summary>
/// <para>
/// Bopomofo
/// </para>
/// </summary>

	PANGO_SCRIPT_BOPOMOFO = 5,
/// <summary>
/// <para>
/// Cherokee
/// </para>
/// </summary>

	PANGO_SCRIPT_CHEROKEE = 6,
/// <summary>
/// <para>
/// Coptic
/// </para>
/// </summary>

	PANGO_SCRIPT_COPTIC = 7,
/// <summary>
/// <para>
/// Cyrillic
/// </para>
/// </summary>

	PANGO_SCRIPT_CYRILLIC = 8,
/// <summary>
/// <para>
/// Deseret
/// </para>
/// </summary>

	PANGO_SCRIPT_DESERET = 9,
/// <summary>
/// <para>
/// Devanagari
/// </para>
/// </summary>

	PANGO_SCRIPT_DEVANAGARI = 10,
/// <summary>
/// <para>
/// Ethiopic
/// </para>
/// </summary>

	PANGO_SCRIPT_ETHIOPIC = 11,
/// <summary>
/// <para>
/// Georgian
/// </para>
/// </summary>

	PANGO_SCRIPT_GEORGIAN = 12,
/// <summary>
/// <para>
/// Gothic
/// </para>
/// </summary>

	PANGO_SCRIPT_GOTHIC = 13,
/// <summary>
/// <para>
/// Greek
/// </para>
/// </summary>

	PANGO_SCRIPT_GREEK = 14,
/// <summary>
/// <para>
/// Gujarati
/// </para>
/// </summary>

	PANGO_SCRIPT_GUJARATI = 15,
/// <summary>
/// <para>
/// Gurmukhi
/// </para>
/// </summary>

	PANGO_SCRIPT_GURMUKHI = 16,
/// <summary>
/// <para>
/// Han
/// </para>
/// </summary>

	PANGO_SCRIPT_HAN = 17,
/// <summary>
/// <para>
/// Hangul
/// </para>
/// </summary>

	PANGO_SCRIPT_HANGUL = 18,
/// <summary>
/// <para>
/// Hebrew
/// </para>
/// </summary>

	PANGO_SCRIPT_HEBREW = 19,
/// <summary>
/// <para>
/// Hiragana
/// </para>
/// </summary>

	PANGO_SCRIPT_HIRAGANA = 20,
/// <summary>
/// <para>
/// Kannada
/// </para>
/// </summary>

	PANGO_SCRIPT_KANNADA = 21,
/// <summary>
/// <para>
/// Katakana
/// </para>
/// </summary>

	PANGO_SCRIPT_KATAKANA = 22,
/// <summary>
/// <para>
/// Khmer
/// </para>
/// </summary>

	PANGO_SCRIPT_KHMER = 23,
/// <summary>
/// <para>
/// Lao
/// </para>
/// </summary>

	PANGO_SCRIPT_LAO = 24,
/// <summary>
/// <para>
/// Latin
/// </para>
/// </summary>

	PANGO_SCRIPT_LATIN = 25,
/// <summary>
/// <para>
/// Malayalam
/// </para>
/// </summary>

	PANGO_SCRIPT_MALAYALAM = 26,
/// <summary>
/// <para>
/// Mongolian
/// </para>
/// </summary>

	PANGO_SCRIPT_MONGOLIAN = 27,
/// <summary>
/// <para>
/// Myanmar
/// </para>
/// </summary>

	PANGO_SCRIPT_MYANMAR = 28,
/// <summary>
/// <para>
/// Ogham
/// </para>
/// </summary>

	PANGO_SCRIPT_OGHAM = 29,
/// <summary>
/// <para>
/// Old Italic
/// </para>
/// </summary>

	PANGO_SCRIPT_OLD_ITALIC = 30,
/// <summary>
/// <para>
/// Oriya
/// </para>
/// </summary>

	PANGO_SCRIPT_ORIYA = 31,
/// <summary>
/// <para>
/// Runic
/// </para>
/// </summary>

	PANGO_SCRIPT_RUNIC = 32,
/// <summary>
/// <para>
/// Sinhala
/// </para>
/// </summary>

	PANGO_SCRIPT_SINHALA = 33,
/// <summary>
/// <para>
/// Syriac
/// </para>
/// </summary>

	PANGO_SCRIPT_SYRIAC = 34,
/// <summary>
/// <para>
/// Tamil
/// </para>
/// </summary>

	PANGO_SCRIPT_TAMIL = 35,
/// <summary>
/// <para>
/// Telugu
/// </para>
/// </summary>

	PANGO_SCRIPT_TELUGU = 36,
/// <summary>
/// <para>
/// Thaana
/// </para>
/// </summary>

	PANGO_SCRIPT_THAANA = 37,
/// <summary>
/// <para>
/// Thai
/// </para>
/// </summary>

	PANGO_SCRIPT_THAI = 38,
/// <summary>
/// <para>
/// Tibetan
/// </para>
/// </summary>

	PANGO_SCRIPT_TIBETAN = 39,
/// <summary>
/// <para>
/// Canadian Aboriginal
/// </para>
/// </summary>

	PANGO_SCRIPT_CANADIAN_ABORIGINAL = 40,
/// <summary>
/// <para>
/// Yi
/// </para>
/// </summary>

	PANGO_SCRIPT_YI = 41,
/// <summary>
/// <para>
/// Tagalog
/// </para>
/// </summary>

	PANGO_SCRIPT_TAGALOG = 42,
/// <summary>
/// <para>
/// Hanunoo
/// </para>
/// </summary>

	PANGO_SCRIPT_HANUNOO = 43,
/// <summary>
/// <para>
/// Buhid
/// </para>
/// </summary>

	PANGO_SCRIPT_BUHID = 44,
/// <summary>
/// <para>
/// Tagbanwa
/// </para>
/// </summary>

	PANGO_SCRIPT_TAGBANWA = 45,
/// <summary>
/// <para>
/// Braille
/// </para>
/// </summary>

	PANGO_SCRIPT_BRAILLE = 46,
/// <summary>
/// <para>
/// Cypriot
/// </para>
/// </summary>

	PANGO_SCRIPT_CYPRIOT = 47,
/// <summary>
/// <para>
/// Limbu
/// </para>
/// </summary>

	PANGO_SCRIPT_LIMBU = 48,
/// <summary>
/// <para>
/// Osmanya
/// </para>
/// </summary>

	PANGO_SCRIPT_OSMANYA = 49,
/// <summary>
/// <para>
/// Shavian
/// </para>
/// </summary>

	PANGO_SCRIPT_SHAVIAN = 50,
/// <summary>
/// <para>
/// Linear B
/// </para>
/// </summary>

	PANGO_SCRIPT_LINEAR_B = 51,
/// <summary>
/// <para>
/// Tai Le
/// </para>
/// </summary>

	PANGO_SCRIPT_TAI_LE = 52,
/// <summary>
/// <para>
/// Ugaritic
/// </para>
/// </summary>

	PANGO_SCRIPT_UGARITIC = 53,
/// <summary>
/// <para>
/// New Tai Lue. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_NEW_TAI_LUE = 54,
/// <summary>
/// <para>
/// Buginese. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_BUGINESE = 55,
/// <summary>
/// <para>
/// Glagolitic. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_GLAGOLITIC = 56,
/// <summary>
/// <para>
/// Tifinagh. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_TIFINAGH = 57,
/// <summary>
/// <para>
/// Syloti Nagri. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_SYLOTI_NAGRI = 58,
/// <summary>
/// <para>
/// Old Persian. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_OLD_PERSIAN = 59,
/// <summary>
/// <para>
/// Kharoshthi. Since 1.10
/// </para>
/// </summary>

	PANGO_SCRIPT_KHAROSHTHI = 60,
/// <summary>
/// <para>
/// an unassigned code point. Since 1.14
/// </para>
/// </summary>

	PANGO_SCRIPT_UNKNOWN = 61,
/// <summary>
/// <para>
/// Balinese. Since 1.14
/// </para>
/// </summary>

	PANGO_SCRIPT_BALINESE = 62,
/// <summary>
/// <para>
/// Cuneiform. Since 1.14
/// </para>
/// </summary>

	PANGO_SCRIPT_CUNEIFORM = 63,
/// <summary>
/// <para>
/// Phoenician. Since 1.14
/// </para>
/// </summary>

	PANGO_SCRIPT_PHOENICIAN = 64,
/// <summary>
/// <para>
/// Phags-pa. Since 1.14
/// </para>
/// </summary>

	PANGO_SCRIPT_PHAGS_PA = 65,
/// <summary>
/// <para>
/// N&apos;Ko. Since 1.14
/// </para>
/// </summary>

	PANGO_SCRIPT_NKO = 66,
/// <summary>
/// <para>
/// Kayah Li. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_KAYAH_LI = 67,
/// <summary>
/// <para>
/// Lepcha. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_LEPCHA = 68,
/// <summary>
/// <para>
/// Rejang. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_REJANG = 69,
/// <summary>
/// <para>
/// Sundanese. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_SUNDANESE = 70,
/// <summary>
/// <para>
/// Saurashtra. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_SAURASHTRA = 71,
/// <summary>
/// <para>
/// Cham. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_CHAM = 72,
/// <summary>
/// <para>
/// Ol Chiki. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_OL_CHIKI = 73,
/// <summary>
/// <para>
/// Vai. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_VAI = 74,
/// <summary>
/// <para>
/// Carian. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_CARIAN = 75,
/// <summary>
/// <para>
/// Lycian. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_LYCIAN = 76,
/// <summary>
/// <para>
/// Lydian. Since 1.20.1
/// </para>
/// </summary>

	PANGO_SCRIPT_LYDIAN = 77,
/// <summary>
/// <para>
/// Batak. Since 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_BATAK = 78,
/// <summary>
/// <para>
/// Brahmi. Since 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_BRAHMI = 79,
/// <summary>
/// <para>
/// Mandaic. Since 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_MANDAIC = 80,
/// <summary>
/// <para>
/// Chakma. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_CHAKMA = 81,
/// <summary>
/// <para>
/// Meroitic Cursive. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_MEROITIC_CURSIVE = 82,
/// <summary>
/// <para>
/// Meroitic Hieroglyphs. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_MEROITIC_HIEROGLYPHS = 83,
/// <summary>
/// <para>
/// Miao. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_MIAO = 84,
/// <summary>
/// <para>
/// Sharada. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_SHARADA = 85,
/// <summary>
/// <para>
/// Sora Sompeng. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_SORA_SOMPENG = 86,
/// <summary>
/// <para>
/// Takri. Since: 1.32
/// </para>
/// </summary>

	PANGO_SCRIPT_TAKRI = 87,
/// <summary>
/// <para>
/// Bassa. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_BASSA_VAH = 88,
/// <summary>
/// <para>
/// Caucasian Albanian. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_CAUCASIAN_ALBANIAN = 89,
/// <summary>
/// <para>
/// Duployan. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_DUPLOYAN = 90,
/// <summary>
/// <para>
/// Elbasan. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_ELBASAN = 91,
/// <summary>
/// <para>
/// Grantha. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_GRANTHA = 92,
/// <summary>
/// <para>
/// Kjohki. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_KHOJKI = 93,
/// <summary>
/// <para>
/// Khudawadi, Sindhi. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_KHUDAWADI = 94,
/// <summary>
/// <para>
/// Linear A. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_LINEAR_A = 95,
/// <summary>
/// <para>
/// Mahajani. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_MAHAJANI = 96,
/// <summary>
/// <para>
/// Manichaean. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_MANICHAEAN = 97,
/// <summary>
/// <para>
/// Mende Kikakui. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_MENDE_KIKAKUI = 98,
/// <summary>
/// <para>
/// Modi. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_MODI = 99,
/// <summary>
/// <para>
/// Mro. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_MRO = 100,
/// <summary>
/// <para>
/// Nabataean. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_NABATAEAN = 101,
/// <summary>
/// <para>
/// Old North Arabian. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_OLD_NORTH_ARABIAN = 102,
/// <summary>
/// <para>
/// Old Permic. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_OLD_PERMIC = 103,
/// <summary>
/// <para>
/// Pahawh Hmong. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_PAHAWH_HMONG = 104,
/// <summary>
/// <para>
/// Palmyrene. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_PALMYRENE = 105,
/// <summary>
/// <para>
/// Pau Cin Hau. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_PAU_CIN_HAU = 106,
/// <summary>
/// <para>
/// Psalter Pahlavi. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_PSALTER_PAHLAVI = 107,
/// <summary>
/// <para>
/// Siddham. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_SIDDHAM = 108,
/// <summary>
/// <para>
/// Tirhuta. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_TIRHUTA = 109,
/// <summary>
/// <para>
/// Warang Citi. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_WARANG_CITI = 110,
/// <summary>
/// <para>
/// Ahom. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_AHOM = 111,
/// <summary>
/// <para>
/// Anatolian Hieroglyphs. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_ANATOLIAN_HIEROGLYPHS = 112,
/// <summary>
/// <para>
/// Hatran. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_HATRAN = 113,
/// <summary>
/// <para>
/// Multani. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_MULTANI = 114,
/// <summary>
/// <para>
/// Old Hungarian. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_OLD_HUNGARIAN = 115,
/// <summary>
/// <para>
/// Signwriting. Since: 1.40
/// </para>
/// </summary>

	PANGO_SCRIPT_SIGNWRITING = 116
}
