namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for scripts. Each #hb_script_t's value is an #hb_tag_t corresponding
/// to the four-letter values defined by [ISO 15924](https://unicode.org/iso15924/).
/// </para>
/// <para>
/// See also the Script (sc) property of the Unicode Character Database.
/// </para>
/// </summary>

[Flags]
public enum hb_script_t
{
/// <summary>
/// <para>
/// `Zyyy`
/// </para>
/// </summary>

	HB_SCRIPT_COMMON = 1517910393,
/// <summary>
/// <para>
/// `Zinh`
/// </para>
/// </summary>

	HB_SCRIPT_INHERITED = 1516858984,
/// <summary>
/// <para>
/// `Zzzz`
/// </para>
/// </summary>

	HB_SCRIPT_UNKNOWN = 1517976186,
/// <summary>
/// <para>
/// `Arab`
/// </para>
/// </summary>

	HB_SCRIPT_ARABIC = 1098015074,
/// <summary>
/// <para>
/// `Armn`
/// </para>
/// </summary>

	HB_SCRIPT_ARMENIAN = 1098018158,
/// <summary>
/// <para>
/// `Beng`
/// </para>
/// </summary>

	HB_SCRIPT_BENGALI = 1113943655,
/// <summary>
/// <para>
/// `Cyrl`
/// </para>
/// </summary>

	HB_SCRIPT_CYRILLIC = 1132032620,
/// <summary>
/// <para>
/// `Deva`
/// </para>
/// </summary>

	HB_SCRIPT_DEVANAGARI = 1147500129,
/// <summary>
/// <para>
/// `Geor`
/// </para>
/// </summary>

	HB_SCRIPT_GEORGIAN = 1197830002,
/// <summary>
/// <para>
/// `Grek`
/// </para>
/// </summary>

	HB_SCRIPT_GREEK = 1198679403,
/// <summary>
/// <para>
/// `Gujr`
/// </para>
/// </summary>

	HB_SCRIPT_GUJARATI = 1198877298,
/// <summary>
/// <para>
/// `Guru`
/// </para>
/// </summary>

	HB_SCRIPT_GURMUKHI = 1198879349,
/// <summary>
/// <para>
/// `Hang`
/// </para>
/// </summary>

	HB_SCRIPT_HANGUL = 1214344807,
/// <summary>
/// <para>
/// `Hani`
/// </para>
/// </summary>

	HB_SCRIPT_HAN = 1214344809,
/// <summary>
/// <para>
/// `Hebr`
/// </para>
/// </summary>

	HB_SCRIPT_HEBREW = 1214603890,
/// <summary>
/// <para>
/// `Hira`
/// </para>
/// </summary>

	HB_SCRIPT_HIRAGANA = 1214870113,
/// <summary>
/// <para>
/// `Knda`
/// </para>
/// </summary>

	HB_SCRIPT_KANNADA = 1265525857,
/// <summary>
/// <para>
/// `Kana`
/// </para>
/// </summary>

	HB_SCRIPT_KATAKANA = 1264676449,
/// <summary>
/// <para>
/// `Laoo`
/// </para>
/// </summary>

	HB_SCRIPT_LAO = 1281453935,
/// <summary>
/// <para>
/// `Latn`
/// </para>
/// </summary>

	HB_SCRIPT_LATIN = 1281455214,
/// <summary>
/// <para>
/// `Mlym`
/// </para>
/// </summary>

	HB_SCRIPT_MALAYALAM = 1298954605,
/// <summary>
/// <para>
/// `Orya`
/// </para>
/// </summary>

	HB_SCRIPT_ORIYA = 1332902241,
/// <summary>
/// <para>
/// `Taml`
/// </para>
/// </summary>

	HB_SCRIPT_TAMIL = 1415671148,
/// <summary>
/// <para>
/// `Telu`
/// </para>
/// </summary>

	HB_SCRIPT_TELUGU = 1415933045,
/// <summary>
/// <para>
/// `Thai`
/// </para>
/// </summary>

	HB_SCRIPT_THAI = 1416126825,
/// <summary>
/// <para>
/// `Tibt`
/// </para>
/// </summary>

	HB_SCRIPT_TIBETAN = 1416192628,
/// <summary>
/// <para>
/// `Bopo`
/// </para>
/// </summary>

	HB_SCRIPT_BOPOMOFO = 1114599535,
/// <summary>
/// <para>
/// `Brai`
/// </para>
/// </summary>

	HB_SCRIPT_BRAILLE = 1114792297,
/// <summary>
/// <para>
/// `Cans`
/// </para>
/// </summary>

	HB_SCRIPT_CANADIAN_SYLLABICS = 1130458739,
/// <summary>
/// <para>
/// `Cher`
/// </para>
/// </summary>

	HB_SCRIPT_CHEROKEE = 1130915186,
/// <summary>
/// <para>
/// `Ethi`
/// </para>
/// </summary>

	HB_SCRIPT_ETHIOPIC = 1165256809,
/// <summary>
/// <para>
/// `Khmr`
/// </para>
/// </summary>

	HB_SCRIPT_KHMER = 1265134962,
/// <summary>
/// <para>
/// `Mong`
/// </para>
/// </summary>

	HB_SCRIPT_MONGOLIAN = 1299148391,
/// <summary>
/// <para>
/// `Mymr`
/// </para>
/// </summary>

	HB_SCRIPT_MYANMAR = 1299803506,
/// <summary>
/// <para>
/// `Ogam`
/// </para>
/// </summary>

	HB_SCRIPT_OGHAM = 1332175213,
/// <summary>
/// <para>
/// `Runr`
/// </para>
/// </summary>

	HB_SCRIPT_RUNIC = 1383427698,
/// <summary>
/// <para>
/// `Sinh`
/// </para>
/// </summary>

	HB_SCRIPT_SINHALA = 1399418472,
/// <summary>
/// <para>
/// `Syrc`
/// </para>
/// </summary>

	HB_SCRIPT_SYRIAC = 1400468067,
/// <summary>
/// <para>
/// `Thaa`
/// </para>
/// </summary>

	HB_SCRIPT_THAANA = 1416126817,
/// <summary>
/// <para>
/// `Yiii`
/// </para>
/// </summary>

	HB_SCRIPT_YI = 1500080489,
/// <summary>
/// <para>
/// `Dsrt`
/// </para>
/// </summary>

	HB_SCRIPT_DESERET = 1148416628,
/// <summary>
/// <para>
/// `Goth`
/// </para>
/// </summary>

	HB_SCRIPT_GOTHIC = 1198486632,
/// <summary>
/// <para>
/// `Ital`
/// </para>
/// </summary>

	HB_SCRIPT_OLD_ITALIC = 1232363884,
/// <summary>
/// <para>
/// `Buhd`
/// </para>
/// </summary>

	HB_SCRIPT_BUHID = 1114990692,
/// <summary>
/// <para>
/// `Hano`
/// </para>
/// </summary>

	HB_SCRIPT_HANUNOO = 1214344815,
/// <summary>
/// <para>
/// `Tglg`
/// </para>
/// </summary>

	HB_SCRIPT_TAGALOG = 1416064103,
/// <summary>
/// <para>
/// `Tagb`
/// </para>
/// </summary>

	HB_SCRIPT_TAGBANWA = 1415669602,
/// <summary>
/// <para>
/// `Cprt`
/// </para>
/// </summary>

	HB_SCRIPT_CYPRIOT = 1131442804,
/// <summary>
/// <para>
/// `Limb`
/// </para>
/// </summary>

	HB_SCRIPT_LIMBU = 1281977698,
/// <summary>
/// <para>
/// `Linb`
/// </para>
/// </summary>

	HB_SCRIPT_LINEAR_B = 1281977954,
/// <summary>
/// <para>
/// `Osma`
/// </para>
/// </summary>

	HB_SCRIPT_OSMANYA = 1332964705,
/// <summary>
/// <para>
/// `Shaw`
/// </para>
/// </summary>

	HB_SCRIPT_SHAVIAN = 1399349623,
/// <summary>
/// <para>
/// `Tale`
/// </para>
/// </summary>

	HB_SCRIPT_TAI_LE = 1415670885,
/// <summary>
/// <para>
/// `Ugar`
/// </para>
/// </summary>

	HB_SCRIPT_UGARITIC = 1432838514,
/// <summary>
/// <para>
/// `Bugi`
/// </para>
/// </summary>

	HB_SCRIPT_BUGINESE = 1114990441,
/// <summary>
/// <para>
/// `Copt`
/// </para>
/// </summary>

	HB_SCRIPT_COPTIC = 1131376756,
/// <summary>
/// <para>
/// `Glag`
/// </para>
/// </summary>

	HB_SCRIPT_GLAGOLITIC = 1198285159,
/// <summary>
/// <para>
/// `Khar`
/// </para>
/// </summary>

	HB_SCRIPT_KHAROSHTHI = 1265131890,
/// <summary>
/// <para>
/// `Talu`
/// </para>
/// </summary>

	HB_SCRIPT_NEW_TAI_LUE = 1415670901,
/// <summary>
/// <para>
/// `Xpeo`
/// </para>
/// </summary>

	HB_SCRIPT_OLD_PERSIAN = 1483761007,
/// <summary>
/// <para>
/// `Sylo`
/// </para>
/// </summary>

	HB_SCRIPT_SYLOTI_NAGRI = 1400466543,
/// <summary>
/// <para>
/// `Tfng`
/// </para>
/// </summary>

	HB_SCRIPT_TIFINAGH = 1415999079,
/// <summary>
/// <para>
/// `Bali`
/// </para>
/// </summary>

	HB_SCRIPT_BALINESE = 1113681001,
/// <summary>
/// <para>
/// `Xsux`
/// </para>
/// </summary>

	HB_SCRIPT_CUNEIFORM = 1483961720,
/// <summary>
/// <para>
/// `Nkoo`
/// </para>
/// </summary>

	HB_SCRIPT_NKO = 1315663727,
/// <summary>
/// <para>
/// `Phag`
/// </para>
/// </summary>

	HB_SCRIPT_PHAGS_PA = 1349017959,
/// <summary>
/// <para>
/// `Phnx`
/// </para>
/// </summary>

	HB_SCRIPT_PHOENICIAN = 1349021304,
/// <summary>
/// <para>
/// `Cari`
/// </para>
/// </summary>

	HB_SCRIPT_CARIAN = 1130459753,
/// <summary>
/// <para>
/// `Cham`
/// </para>
/// </summary>

	HB_SCRIPT_CHAM = 1130914157,
/// <summary>
/// <para>
/// `Kali`
/// </para>
/// </summary>

	HB_SCRIPT_KAYAH_LI = 1264675945,
/// <summary>
/// <para>
/// `Lepc`
/// </para>
/// </summary>

	HB_SCRIPT_LEPCHA = 1281716323,
/// <summary>
/// <para>
/// `Lyci`
/// </para>
/// </summary>

	HB_SCRIPT_LYCIAN = 1283023721,
/// <summary>
/// <para>
/// `Lydi`
/// </para>
/// </summary>

	HB_SCRIPT_LYDIAN = 1283023977,
/// <summary>
/// <para>
/// `Olck`
/// </para>
/// </summary>

	HB_SCRIPT_OL_CHIKI = 1332503403,
/// <summary>
/// <para>
/// `Rjng`
/// </para>
/// </summary>

	HB_SCRIPT_REJANG = 1382706791,
/// <summary>
/// <para>
/// `Saur`
/// </para>
/// </summary>

	HB_SCRIPT_SAURASHTRA = 1398895986,
/// <summary>
/// <para>
/// `Sund`
/// </para>
/// </summary>

	HB_SCRIPT_SUNDANESE = 1400204900,
/// <summary>
/// <para>
/// `Vaii`
/// </para>
/// </summary>

	HB_SCRIPT_VAI = 1449224553,
/// <summary>
/// <para>
/// `Avst`
/// </para>
/// </summary>

	HB_SCRIPT_AVESTAN = 1098281844,
/// <summary>
/// <para>
/// `Bamu`
/// </para>
/// </summary>

	HB_SCRIPT_BAMUM = 1113681269,
/// <summary>
/// <para>
/// `Egyp`
/// </para>
/// </summary>

	HB_SCRIPT_EGYPTIAN_HIEROGLYPHS = 1164409200,
/// <summary>
/// <para>
/// `Armi`
/// </para>
/// </summary>

	HB_SCRIPT_IMPERIAL_ARAMAIC = 1098018153,
/// <summary>
/// <para>
/// `Phli`
/// </para>
/// </summary>

	HB_SCRIPT_INSCRIPTIONAL_PAHLAVI = 1349020777,
/// <summary>
/// <para>
/// `Prti`
/// </para>
/// </summary>

	HB_SCRIPT_INSCRIPTIONAL_PARTHIAN = 1349678185,
/// <summary>
/// <para>
/// `Java`
/// </para>
/// </summary>

	HB_SCRIPT_JAVANESE = 1247901281,
/// <summary>
/// <para>
/// `Kthi`
/// </para>
/// </summary>

	HB_SCRIPT_KAITHI = 1265920105,
/// <summary>
/// <para>
/// `Lisu`
/// </para>
/// </summary>

	HB_SCRIPT_LISU = 1281979253,
/// <summary>
/// <para>
/// `Mtei`
/// </para>
/// </summary>

	HB_SCRIPT_MEETEI_MAYEK = 1299473769,
/// <summary>
/// <para>
/// `Sarb`
/// </para>
/// </summary>

	HB_SCRIPT_OLD_SOUTH_ARABIAN = 1398895202,
/// <summary>
/// <para>
/// `Orkh`
/// </para>
/// </summary>

	HB_SCRIPT_OLD_TURKIC = 1332898664,
/// <summary>
/// <para>
/// `Samr`
/// </para>
/// </summary>

	HB_SCRIPT_SAMARITAN = 1398893938,
/// <summary>
/// <para>
/// `Lana`
/// </para>
/// </summary>

	HB_SCRIPT_TAI_THAM = 1281453665,
/// <summary>
/// <para>
/// `Tavt`
/// </para>
/// </summary>

	HB_SCRIPT_TAI_VIET = 1415673460,
/// <summary>
/// <para>
/// `Batk`
/// </para>
/// </summary>

	HB_SCRIPT_BATAK = 1113683051,
/// <summary>
/// <para>
/// `Brah`
/// </para>
/// </summary>

	HB_SCRIPT_BRAHMI = 1114792296,
/// <summary>
/// <para>
/// `Mand`
/// </para>
/// </summary>

	HB_SCRIPT_MANDAIC = 1298230884,
/// <summary>
/// <para>
/// `Cakm`
/// </para>
/// </summary>

	HB_SCRIPT_CHAKMA = 1130457965,
/// <summary>
/// <para>
/// `Merc`
/// </para>
/// </summary>

	HB_SCRIPT_MEROITIC_CURSIVE = 1298494051,
/// <summary>
/// <para>
/// `Mero`
/// </para>
/// </summary>

	HB_SCRIPT_MEROITIC_HIEROGLYPHS = 1298494063,
/// <summary>
/// <para>
/// `Plrd`
/// </para>
/// </summary>

	HB_SCRIPT_MIAO = 1349284452,
/// <summary>
/// <para>
/// `Shrd`
/// </para>
/// </summary>

	HB_SCRIPT_SHARADA = 1399353956,
/// <summary>
/// <para>
/// `Sora`
/// </para>
/// </summary>

	HB_SCRIPT_SORA_SOMPENG = 1399812705,
/// <summary>
/// <para>
/// `Takr`
/// </para>
/// </summary>

	HB_SCRIPT_TAKRI = 1415670642,
/// <summary>
/// <para>
/// `Bass`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_BASSA_VAH = 1113682803,
/// <summary>
/// <para>
/// `Aghb`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_CAUCASIAN_ALBANIAN = 1097295970,
/// <summary>
/// <para>
/// `Dupl`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_DUPLOYAN = 1148547180,
/// <summary>
/// <para>
/// `Elba`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_ELBASAN = 1164730977,
/// <summary>
/// <para>
/// `Gran`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_GRANTHA = 1198678382,
/// <summary>
/// <para>
/// `Khoj`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_KHOJKI = 1265135466,
/// <summary>
/// <para>
/// `Sind`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_KHUDAWADI = 1399418468,
/// <summary>
/// <para>
/// `Lina`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_LINEAR_A = 1281977953,
/// <summary>
/// <para>
/// `Mahj`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_MAHAJANI = 1298229354,
/// <summary>
/// <para>
/// `Mani`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_MANICHAEAN = 1298230889,
/// <summary>
/// <para>
/// `Mend`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_MENDE_KIKAKUI = 1298493028,
/// <summary>
/// <para>
/// `Modi`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_MODI = 1299145833,
/// <summary>
/// <para>
/// `Mroo`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_MRO = 1299345263,
/// <summary>
/// <para>
/// `Nbat`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_NABATAEAN = 1315070324,
/// <summary>
/// <para>
/// `Narb`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_OLD_NORTH_ARABIAN = 1315009122,
/// <summary>
/// <para>
/// `Perm`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_OLD_PERMIC = 1348825709,
/// <summary>
/// <para>
/// `Hmng`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_PAHAWH_HMONG = 1215131239,
/// <summary>
/// <para>
/// `Palm`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_PALMYRENE = 1348562029,
/// <summary>
/// <para>
/// `Pauc`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_PAU_CIN_HAU = 1348564323,
/// <summary>
/// <para>
/// `Phlp`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_PSALTER_PAHLAVI = 1349020784,
/// <summary>
/// <para>
/// `Sidd`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_SIDDHAM = 1399415908,
/// <summary>
/// <para>
/// `Tirh`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_TIRHUTA = 1416196712,
/// <summary>
/// <para>
/// `Wara`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_WARANG_CITI = 1466004065,
/// <summary>
/// <para>
/// `Ahom`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_AHOM = 1097363309,
/// <summary>
/// <para>
/// `Hluw`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_ANATOLIAN_HIEROGLYPHS = 1215067511,
/// <summary>
/// <para>
/// `Hatr`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_HATRAN = 1214346354,
/// <summary>
/// <para>
/// `Mult`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_MULTANI = 1299541108,
/// <summary>
/// <para>
/// `Hung`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_OLD_HUNGARIAN = 1215655527,
/// <summary>
/// <para>
/// `Sgnw`, Since: 0.9.30
/// </para>
/// </summary>

	HB_SCRIPT_SIGNWRITING = 1399287415,
/// <summary>
/// <para>
/// `Adlm`, Since: 1.3.0
/// </para>
/// </summary>

	HB_SCRIPT_ADLAM = 1097100397,
/// <summary>
/// <para>
/// `Bhks`, Since: 1.3.0
/// </para>
/// </summary>

	HB_SCRIPT_BHAIKSUKI = 1114139507,
/// <summary>
/// <para>
/// `Marc`, Since: 1.3.0
/// </para>
/// </summary>

	HB_SCRIPT_MARCHEN = 1298231907,
/// <summary>
/// <para>
/// `Osge`, Since: 1.3.0
/// </para>
/// </summary>

	HB_SCRIPT_OSAGE = 1332963173,
/// <summary>
/// <para>
/// `Tang`, Since: 1.3.0
/// </para>
/// </summary>

	HB_SCRIPT_TANGUT = 1415671399,
/// <summary>
/// <para>
/// `Newa`, Since: 1.3.0
/// </para>
/// </summary>

	HB_SCRIPT_NEWA = 1315272545,
/// <summary>
/// <para>
/// `Gonm`, Since: 1.6.0
/// </para>
/// </summary>

	HB_SCRIPT_MASARAM_GONDI = 1198485101,
/// <summary>
/// <para>
/// `Nshu`, Since: 1.6.0
/// </para>
/// </summary>

	HB_SCRIPT_NUSHU = 1316186229,
/// <summary>
/// <para>
/// `Soyo`, Since: 1.6.0
/// </para>
/// </summary>

	HB_SCRIPT_SOYOMBO = 1399814511,
/// <summary>
/// <para>
/// `Zanb`, Since: 1.6.0
/// </para>
/// </summary>

	HB_SCRIPT_ZANABAZAR_SQUARE = 1516334690,
/// <summary>
/// <para>
/// `Dogr`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_DOGRA = 1148151666,
/// <summary>
/// <para>
/// `Gong`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_GUNJALA_GONDI = 1198485095,
/// <summary>
/// <para>
/// `Rohg`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_HANIFI_ROHINGYA = 1383032935,
/// <summary>
/// <para>
/// `Maka`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_MAKASAR = 1298230113,
/// <summary>
/// <para>
/// `Medf`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_MEDEFAIDRIN = 1298490470,
/// <summary>
/// <para>
/// `Sogo`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_OLD_SOGDIAN = 1399809903,
/// <summary>
/// <para>
/// `Sogd`, Since: 1.8.0
/// </para>
/// </summary>

	HB_SCRIPT_SOGDIAN = 1399809892,
/// <summary>
/// <para>
/// `Elym`, Since: 2.4.0
/// </para>
/// </summary>

	HB_SCRIPT_ELYMAIC = 1164736877,
/// <summary>
/// <para>
/// `Nand`, Since: 2.4.0
/// </para>
/// </summary>

	HB_SCRIPT_NANDINAGARI = 1315008100,
/// <summary>
/// <para>
/// `Hmnp`, Since: 2.4.0
/// </para>
/// </summary>

	HB_SCRIPT_NYIAKENG_PUACHUE_HMONG = 1215131248,
/// <summary>
/// <para>
/// `Wcho`, Since: 2.4.0
/// </para>
/// </summary>

	HB_SCRIPT_WANCHO = 1466132591,
/// <summary>
/// <para>
/// `Chrs`, Since: 2.6.7
/// </para>
/// </summary>

	HB_SCRIPT_CHORASMIAN = 1130918515,
/// <summary>
/// <para>
/// `Diak`, Since: 2.6.7
/// </para>
/// </summary>

	HB_SCRIPT_DIVES_AKURU = 1147756907,
/// <summary>
/// <para>
/// `Kits`, Since: 2.6.7
/// </para>
/// </summary>

	HB_SCRIPT_KHITAN_SMALL_SCRIPT = 1265202291,
/// <summary>
/// <para>
/// `Yezi`, Since: 2.6.7
/// </para>
/// </summary>

	HB_SCRIPT_YEZIDI = 1499822697,
/// <summary>
/// <para>
/// `Cpmn`, Since: 3.0.0
/// </para>
/// </summary>

	HB_SCRIPT_CYPRO_MINOAN = 1131441518,
/// <summary>
/// <para>
/// `Ougr`, Since: 3.0.0
/// </para>
/// </summary>

	HB_SCRIPT_OLD_UYGHUR = 1333094258,
/// <summary>
/// <para>
/// `Tnsa`, Since: 3.0.0
/// </para>
/// </summary>

	HB_SCRIPT_TANGSA = 1416524641,
/// <summary>
/// <para>
/// `Toto`, Since: 3.0.0
/// </para>
/// </summary>

	HB_SCRIPT_TOTO = 1416590447,
/// <summary>
/// <para>
/// `Vith`, Since: 3.0.0
/// </para>
/// </summary>

	HB_SCRIPT_VITHKUQI = 1449751656,
/// <summary>
/// <para>
/// `Zmth`, Since: 3.4.0
/// </para>
/// </summary>

	HB_SCRIPT_MATH = 1517122664,
/// <summary>
/// <para>
/// `Kawi`, Since: 5.2.0
/// </para>
/// </summary>

	HB_SCRIPT_KAWI = 1264678761,
/// <summary>
/// <para>
/// `Nagm`, Since: 5.2.0
/// </para>
/// </summary>

	HB_SCRIPT_NAG_MUNDARI = 1315006317,
/// <summary>
/// <para>
/// No script set
/// </para>
/// </summary>

	HB_SCRIPT_INVALID = 0
}
