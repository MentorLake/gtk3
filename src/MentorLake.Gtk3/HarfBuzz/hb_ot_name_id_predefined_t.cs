namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// An enum type representing the pre-defined name IDs.
/// </para>
/// <para>
/// For more information on these fields, see the
/// [OpenType spec](https://docs.microsoft.com/en-us/typography/opentype/spec/name#name-ids).
/// </para>
/// </summary>

[Flags]
public enum hb_ot_name_id_predefined_t
{
/// <summary>
/// <para>
/// Copyright notice
/// </para>
/// </summary>

	HB_OT_NAME_ID_COPYRIGHT = 0,
/// <summary>
/// <para>
/// Font Family name
/// </para>
/// </summary>

	HB_OT_NAME_ID_FONT_FAMILY = 1,
/// <summary>
/// <para>
/// Font Subfamily name
/// </para>
/// </summary>

	HB_OT_NAME_ID_FONT_SUBFAMILY = 2,
/// <summary>
/// <para>
/// Unique font identifier
/// </para>
/// </summary>

	HB_OT_NAME_ID_UNIQUE_ID = 3,
/// <summary>
/// <para>
/// Full font name that reflects
/// all family and relevant subfamily descriptors
/// </para>
/// </summary>

	HB_OT_NAME_ID_FULL_NAME = 4,
/// <summary>
/// <para>
/// Version string
/// </para>
/// </summary>

	HB_OT_NAME_ID_VERSION_STRING = 5,
/// <summary>
/// <para>
/// PostScript name for the font
/// </para>
/// </summary>

	HB_OT_NAME_ID_POSTSCRIPT_NAME = 6,
/// <summary>
/// <para>
/// Trademark
/// </para>
/// </summary>

	HB_OT_NAME_ID_TRADEMARK = 7,
/// <summary>
/// <para>
/// Manufacturer Name
/// </para>
/// </summary>

	HB_OT_NAME_ID_MANUFACTURER = 8,
/// <summary>
/// <para>
/// Designer
/// </para>
/// </summary>

	HB_OT_NAME_ID_DESIGNER = 9,
/// <summary>
/// <para>
/// Description
/// </para>
/// </summary>

	HB_OT_NAME_ID_DESCRIPTION = 10,
/// <summary>
/// <para>
/// URL of font vendor
/// </para>
/// </summary>

	HB_OT_NAME_ID_VENDOR_URL = 11,
/// <summary>
/// <para>
/// URL of typeface designer
/// </para>
/// </summary>

	HB_OT_NAME_ID_DESIGNER_URL = 12,
/// <summary>
/// <para>
/// License Description
/// </para>
/// </summary>

	HB_OT_NAME_ID_LICENSE = 13,
/// <summary>
/// <para>
/// URL where additional licensing
/// information can be found
/// </para>
/// </summary>

	HB_OT_NAME_ID_LICENSE_URL = 14,
/// <summary>
/// <para>
/// Typographic Family name
/// </para>
/// </summary>

	HB_OT_NAME_ID_TYPOGRAPHIC_FAMILY = 16,
/// <summary>
/// <para>
/// Typographic Subfamily name
/// </para>
/// </summary>

	HB_OT_NAME_ID_TYPOGRAPHIC_SUBFAMILY = 17,
/// <summary>
/// <para>
/// Compatible Full Name for MacOS
/// </para>
/// </summary>

	HB_OT_NAME_ID_MAC_FULL_NAME = 18,
/// <summary>
/// <para>
/// Sample text
/// </para>
/// </summary>

	HB_OT_NAME_ID_SAMPLE_TEXT = 19,
/// <summary>
/// <para>
/// PostScript CID findfont name
/// </para>
/// </summary>

	HB_OT_NAME_ID_CID_FINDFONT_NAME = 20,
/// <summary>
/// <para>
/// WWS Family Name
/// </para>
/// </summary>

	HB_OT_NAME_ID_WWS_FAMILY = 21,
/// <summary>
/// <para>
/// WWS Subfamily Name
/// </para>
/// </summary>

	HB_OT_NAME_ID_WWS_SUBFAMILY = 22,
/// <summary>
/// <para>
/// Light Background Palette
/// </para>
/// </summary>

	HB_OT_NAME_ID_LIGHT_BACKGROUND = 23,
/// <summary>
/// <para>
/// Dark Background Palette
/// </para>
/// </summary>

	HB_OT_NAME_ID_DARK_BACKGROUND = 24,
/// <summary>
/// <para>
/// Variations PostScript Name Prefix
/// </para>
/// </summary>

	HB_OT_NAME_ID_VARIATIONS_PS_PREFIX = 25,
/// <summary>
/// <para>
/// Value to represent a nonexistent name ID.
/// </para>
/// </summary>

	HB_OT_NAME_ID_INVALID = 65535
}
