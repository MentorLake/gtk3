namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GUnicodeScript enumeration identifies different writing
/// systems. The values correspond to the names as defined in the
/// Unicode standard. The enumeration has been added in GLib 2.14,
/// and is interchangeable with #PangoScript.
/// </para>
/// <para>
/// Note that new types may be added in the future. Applications
/// should be ready to handle unknown values.
/// See [Unicode Standard Annex #24: Script names](http://www.unicode.org/reports/tr24/).
/// </para>
/// </summary>

[Flags]
public enum GUnicodeScript
{
/// <summary>
/// <para>
/// a value never returned from g_unichar_get_script()
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_INVALID_CODE = -1,
/// <summary>
/// <para>
/// a character used by multiple different scripts
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_COMMON = 0,
/// <summary>
/// <para>
/// a mark glyph that takes its script from the
///                               base glyph to which it is attached
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_INHERITED = 1,
/// <summary>
/// <para>
/// Arabic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ARABIC = 2,
/// <summary>
/// <para>
/// Armenian
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ARMENIAN = 3,
/// <summary>
/// <para>
/// Bengali
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BENGALI = 4,
/// <summary>
/// <para>
/// Bopomofo
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BOPOMOFO = 5,
/// <summary>
/// <para>
/// Cherokee
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CHEROKEE = 6,
/// <summary>
/// <para>
/// Coptic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_COPTIC = 7,
/// <summary>
/// <para>
/// Cyrillic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CYRILLIC = 8,
/// <summary>
/// <para>
/// Deseret
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_DESERET = 9,
/// <summary>
/// <para>
/// Devanagari
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_DEVANAGARI = 10,
/// <summary>
/// <para>
/// Ethiopic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ETHIOPIC = 11,
/// <summary>
/// <para>
/// Georgian
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GEORGIAN = 12,
/// <summary>
/// <para>
/// Gothic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GOTHIC = 13,
/// <summary>
/// <para>
/// Greek
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GREEK = 14,
/// <summary>
/// <para>
/// Gujarati
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GUJARATI = 15,
/// <summary>
/// <para>
/// Gurmukhi
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GURMUKHI = 16,
/// <summary>
/// <para>
/// Han
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HAN = 17,
/// <summary>
/// <para>
/// Hangul
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HANGUL = 18,
/// <summary>
/// <para>
/// Hebrew
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HEBREW = 19,
/// <summary>
/// <para>
/// Hiragana
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HIRAGANA = 20,
/// <summary>
/// <para>
/// Kannada
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KANNADA = 21,
/// <summary>
/// <para>
/// Katakana
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KATAKANA = 22,
/// <summary>
/// <para>
/// Khmer
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KHMER = 23,
/// <summary>
/// <para>
/// Lao
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LAO = 24,
/// <summary>
/// <para>
/// Latin
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LATIN = 25,
/// <summary>
/// <para>
/// Malayalam
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MALAYALAM = 26,
/// <summary>
/// <para>
/// Mongolian
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MONGOLIAN = 27,
/// <summary>
/// <para>
/// Myanmar
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MYANMAR = 28,
/// <summary>
/// <para>
/// Ogham
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OGHAM = 29,
/// <summary>
/// <para>
/// Old Italic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_ITALIC = 30,
/// <summary>
/// <para>
/// Oriya
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ORIYA = 31,
/// <summary>
/// <para>
/// Runic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_RUNIC = 32,
/// <summary>
/// <para>
/// Sinhala
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SINHALA = 33,
/// <summary>
/// <para>
/// Syriac
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SYRIAC = 34,
/// <summary>
/// <para>
/// Tamil
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAMIL = 35,
/// <summary>
/// <para>
/// Telugu
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TELUGU = 36,
/// <summary>
/// <para>
/// Thaana
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_THAANA = 37,
/// <summary>
/// <para>
/// Thai
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_THAI = 38,
/// <summary>
/// <para>
/// Tibetan
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TIBETAN = 39,
/// <summary>
/// <para>
/// Canadian Aboriginal
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CANADIAN_ABORIGINAL = 40,
/// <summary>
/// <para>
/// Yi
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_YI = 41,
/// <summary>
/// <para>
/// Tagalog
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAGALOG = 42,
/// <summary>
/// <para>
/// Hanunoo
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HANUNOO = 43,
/// <summary>
/// <para>
/// Buhid
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BUHID = 44,
/// <summary>
/// <para>
/// Tagbanwa
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAGBANWA = 45,
/// <summary>
/// <para>
/// Braille
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BRAILLE = 46,
/// <summary>
/// <para>
/// Cypriot
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CYPRIOT = 47,
/// <summary>
/// <para>
/// Limbu
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LIMBU = 48,
/// <summary>
/// <para>
/// Osmanya
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OSMANYA = 49,
/// <summary>
/// <para>
/// Shavian
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SHAVIAN = 50,
/// <summary>
/// <para>
/// Linear B
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LINEAR_B = 51,
/// <summary>
/// <para>
/// Tai Le
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAI_LE = 52,
/// <summary>
/// <para>
/// Ugaritic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_UGARITIC = 53,
/// <summary>
/// <para>
/// New Tai Lue
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NEW_TAI_LUE = 54,
/// <summary>
/// <para>
/// Buginese
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BUGINESE = 55,
/// <summary>
/// <para>
/// Glagolitic
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GLAGOLITIC = 56,
/// <summary>
/// <para>
/// Tifinagh
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TIFINAGH = 57,
/// <summary>
/// <para>
/// Syloti Nagri
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SYLOTI_NAGRI = 58,
/// <summary>
/// <para>
/// Old Persian
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_PERSIAN = 59,
/// <summary>
/// <para>
/// Kharoshthi
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KHAROSHTHI = 60,
/// <summary>
/// <para>
/// an unassigned code point
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_UNKNOWN = 61,
/// <summary>
/// <para>
/// Balinese
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BALINESE = 62,
/// <summary>
/// <para>
/// Cuneiform
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CUNEIFORM = 63,
/// <summary>
/// <para>
/// Phoenician
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_PHOENICIAN = 64,
/// <summary>
/// <para>
/// Phags-pa
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_PHAGS_PA = 65,
/// <summary>
/// <para>
/// N'Ko
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NKO = 66,
/// <summary>
/// <para>
/// Kayah Li. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KAYAH_LI = 67,
/// <summary>
/// <para>
/// Lepcha. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LEPCHA = 68,
/// <summary>
/// <para>
/// Rejang. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_REJANG = 69,
/// <summary>
/// <para>
/// Sundanese. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SUNDANESE = 70,
/// <summary>
/// <para>
/// Saurashtra. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SAURASHTRA = 71,
/// <summary>
/// <para>
/// Cham. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CHAM = 72,
/// <summary>
/// <para>
/// Ol Chiki. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OL_CHIKI = 73,
/// <summary>
/// <para>
/// Vai. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_VAI = 74,
/// <summary>
/// <para>
/// Carian. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CARIAN = 75,
/// <summary>
/// <para>
/// Lycian. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LYCIAN = 76,
/// <summary>
/// <para>
/// Lydian. Since 2.16.3
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LYDIAN = 77,
/// <summary>
/// <para>
/// Avestan. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_AVESTAN = 78,
/// <summary>
/// <para>
/// Bamum. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BAMUM = 79,
/// <summary>
/// <para>
/// Egyptian Hieroglpyhs. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_EGYPTIAN_HIEROGLYPHS = 80,
/// <summary>
/// <para>
/// Imperial Aramaic. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_IMPERIAL_ARAMAIC = 81,
/// <summary>
/// <para>
/// Inscriptional Pahlavi. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_INSCRIPTIONAL_PAHLAVI = 82,
/// <summary>
/// <para>
/// Inscriptional Parthian. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_INSCRIPTIONAL_PARTHIAN = 83,
/// <summary>
/// <para>
/// Javanese. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_JAVANESE = 84,
/// <summary>
/// <para>
/// Kaithi. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KAITHI = 85,
/// <summary>
/// <para>
/// Lisu. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LISU = 86,
/// <summary>
/// <para>
/// Meetei Mayek. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MEETEI_MAYEK = 87,
/// <summary>
/// <para>
/// Old South Arabian. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_SOUTH_ARABIAN = 88,
/// <summary>
/// <para>
/// Old Turkic. Since 2.28
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_TURKIC = 89,
/// <summary>
/// <para>
/// Samaritan. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SAMARITAN = 90,
/// <summary>
/// <para>
/// Tai Tham. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAI_THAM = 91,
/// <summary>
/// <para>
/// Tai Viet. Since 2.26
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAI_VIET = 92,
/// <summary>
/// <para>
/// Batak. Since 2.28
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BATAK = 93,
/// <summary>
/// <para>
/// Brahmi. Since 2.28
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BRAHMI = 94,
/// <summary>
/// <para>
/// Mandaic. Since 2.28
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MANDAIC = 95,
/// <summary>
/// <para>
/// Chakma. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CHAKMA = 96,
/// <summary>
/// <para>
/// Meroitic Cursive. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MEROITIC_CURSIVE = 97,
/// <summary>
/// <para>
/// Meroitic Hieroglyphs. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MEROITIC_HIEROGLYPHS = 98,
/// <summary>
/// <para>
/// Miao. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MIAO = 99,
/// <summary>
/// <para>
/// Sharada. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SHARADA = 100,
/// <summary>
/// <para>
/// Sora Sompeng. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SORA_SOMPENG = 101,
/// <summary>
/// <para>
/// Takri. Since: 2.32
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TAKRI = 102,
/// <summary>
/// <para>
/// Bassa. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BASSA_VAH = 103,
/// <summary>
/// <para>
/// Caucasian Albanian. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CAUCASIAN_ALBANIAN = 104,
/// <summary>
/// <para>
/// Duployan. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_DUPLOYAN = 105,
/// <summary>
/// <para>
/// Elbasan. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ELBASAN = 106,
/// <summary>
/// <para>
/// Grantha. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GRANTHA = 107,
/// <summary>
/// <para>
/// Kjohki. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KHOJKI = 108,
/// <summary>
/// <para>
/// Khudawadi, Sindhi. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KHUDAWADI = 109,
/// <summary>
/// <para>
/// Linear A. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_LINEAR_A = 110,
/// <summary>
/// <para>
/// Mahajani. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MAHAJANI = 111,
/// <summary>
/// <para>
/// Manichaean. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MANICHAEAN = 112,
/// <summary>
/// <para>
/// Mende Kikakui. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MENDE_KIKAKUI = 113,
/// <summary>
/// <para>
/// Modi. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MODI = 114,
/// <summary>
/// <para>
/// Mro. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MRO = 115,
/// <summary>
/// <para>
/// Nabataean. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NABATAEAN = 116,
/// <summary>
/// <para>
/// Old North Arabian. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_NORTH_ARABIAN = 117,
/// <summary>
/// <para>
/// Old Permic. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_PERMIC = 118,
/// <summary>
/// <para>
/// Pahawh Hmong. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_PAHAWH_HMONG = 119,
/// <summary>
/// <para>
/// Palmyrene. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_PALMYRENE = 120,
/// <summary>
/// <para>
/// Pau Cin Hau. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_PAU_CIN_HAU = 121,
/// <summary>
/// <para>
/// Psalter Pahlavi. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_PSALTER_PAHLAVI = 122,
/// <summary>
/// <para>
/// Siddham. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SIDDHAM = 123,
/// <summary>
/// <para>
/// Tirhuta. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TIRHUTA = 124,
/// <summary>
/// <para>
/// Warang Citi. Since: 2.42
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_WARANG_CITI = 125,
/// <summary>
/// <para>
/// Ahom. Since: 2.48
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_AHOM = 126,
/// <summary>
/// <para>
/// Anatolian Hieroglyphs. Since: 2.48
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ANATOLIAN_HIEROGLYPHS = 127,
/// <summary>
/// <para>
/// Hatran. Since: 2.48
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HATRAN = 128,
/// <summary>
/// <para>
/// Multani. Since: 2.48
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MULTANI = 129,
/// <summary>
/// <para>
/// Old Hungarian. Since: 2.48
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_HUNGARIAN = 130,
/// <summary>
/// <para>
/// Signwriting. Since: 2.48
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SIGNWRITING = 131,
/// <summary>
/// <para>
/// Adlam. Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ADLAM = 132,
/// <summary>
/// <para>
/// Bhaiksuki. Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_BHAIKSUKI = 133,
/// <summary>
/// <para>
/// Marchen. Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MARCHEN = 134,
/// <summary>
/// <para>
/// Newa. Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NEWA = 135,
/// <summary>
/// <para>
/// Osage. Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OSAGE = 136,
/// <summary>
/// <para>
/// Tangut. Since: 2.50
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TANGUT = 137,
/// <summary>
/// <para>
/// Masaram Gondi. Since: 2.54
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MASARAM_GONDI = 138,
/// <summary>
/// <para>
/// Nushu. Since: 2.54
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NUSHU = 139,
/// <summary>
/// <para>
/// Soyombo. Since: 2.54
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SOYOMBO = 140,
/// <summary>
/// <para>
/// Zanabazar Square. Since: 2.54
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ZANABAZAR_SQUARE = 141,
/// <summary>
/// <para>
/// Dogra. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_DOGRA = 142,
/// <summary>
/// <para>
/// Gunjala Gondi. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GUNJALA_GONDI = 143,
/// <summary>
/// <para>
/// Hanifi Rohingya. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_HANIFI_ROHINGYA = 144,
/// <summary>
/// <para>
/// Makasar. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MAKASAR = 145,
/// <summary>
/// <para>
/// Medefaidrin. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MEDEFAIDRIN = 146,
/// <summary>
/// <para>
/// Old Sogdian. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_SOGDIAN = 147,
/// <summary>
/// <para>
/// Sogdian. Since: 2.58
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SOGDIAN = 148,
/// <summary>
/// <para>
/// Elym. Since: 2.62
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_ELYMAIC = 149,
/// <summary>
/// <para>
/// Nand. Since: 2.62
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NANDINAGARI = 150,
/// <summary>
/// <para>
/// Rohg. Since: 2.62
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NYIAKENG_PUACHUE_HMONG = 151,
/// <summary>
/// <para>
/// Wcho. Since: 2.62
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_WANCHO = 152,
/// <summary>
/// <para>
/// Chorasmian. Since: 2.66
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CHORASMIAN = 153,
/// <summary>
/// <para>
/// Dives Akuru. Since: 2.66
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_DIVES_AKURU = 154,
/// <summary>
/// <para>
/// Khitan small script. Since: 2.66
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KHITAN_SMALL_SCRIPT = 155,
/// <summary>
/// <para>
/// Yezidi. Since: 2.66
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_YEZIDI = 156,
/// <summary>
/// <para>
/// Cypro-Minoan. Since: 2.72
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_CYPRO_MINOAN = 157,
/// <summary>
/// <para>
/// Old Uyghur. Since: 2.72
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OLD_UYGHUR = 158,
/// <summary>
/// <para>
/// Tangsa. Since: 2.72
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TANGSA = 159,
/// <summary>
/// <para>
/// Toto. Since: 2.72
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TOTO = 160,
/// <summary>
/// <para>
/// Vithkuqi. Since: 2.72
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_VITHKUQI = 161,
/// <summary>
/// <para>
/// Mathematical notation. Since: 2.72
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_MATH = 162,
/// <summary>
/// <para>
/// Kawi. Since 2.74
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KAWI = 163,
/// <summary>
/// <para>
/// Nag Mundari. Since 2.74
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_NAG_MUNDARI = 164,
/// <summary>
/// <para>
/// Todhri. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TODHRI = 165,
/// <summary>
/// <para>
/// Garay. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GARAY = 166,
/// <summary>
/// <para>
/// Tulu-Tigalari. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_TULU_TIGALARI = 167,
/// <summary>
/// <para>
/// Sunuwar. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_SUNUWAR = 168,
/// <summary>
/// <para>
/// Gurung Khema. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_GURUNG_KHEMA = 169,
/// <summary>
/// <para>
/// Kirat Rai. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_KIRAT_RAI = 170,
/// <summary>
/// <para>
/// Ol Onal. Since: 2.84
/// </para>
/// </summary>

	G_UNICODE_SCRIPT_OL_ONAL = 171
}
