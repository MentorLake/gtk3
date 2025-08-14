namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoBidiType` represents the bidirectional character
/// type of a Unicode character.
/// </para>
/// <para>
/// The values in this enumeration are specified by the
/// [Unicode bidirectional algorithm](http://www.unicode.org/reports/tr9/).
/// </para>
/// </summary>

[Flags]
public enum PangoBidiType
{
/// <summary>
/// <para>
/// Left-to-Right
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_L = 0,
/// <summary>
/// <para>
/// Left-to-Right Embedding
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_LRE = 1,
/// <summary>
/// <para>
/// Left-to-Right Override
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_LRO = 2,
/// <summary>
/// <para>
/// Right-to-Left
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_R = 3,
/// <summary>
/// <para>
/// Right-to-Left Arabic
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_AL = 4,
/// <summary>
/// <para>
/// Right-to-Left Embedding
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_RLE = 5,
/// <summary>
/// <para>
/// Right-to-Left Override
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_RLO = 6,
/// <summary>
/// <para>
/// Pop Directional Format
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_PDF = 7,
/// <summary>
/// <para>
/// European Number
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_EN = 8,
/// <summary>
/// <para>
/// European Number Separator
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_ES = 9,
/// <summary>
/// <para>
/// European Number Terminator
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_ET = 10,
/// <summary>
/// <para>
/// Arabic Number
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_AN = 11,
/// <summary>
/// <para>
/// Common Number Separator
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_CS = 12,
/// <summary>
/// <para>
/// Nonspacing Mark
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_NSM = 13,
/// <summary>
/// <para>
/// Boundary Neutral
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_BN = 14,
/// <summary>
/// <para>
/// Paragraph Separator
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_B = 15,
/// <summary>
/// <para>
/// Segment Separator
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_S = 16,
/// <summary>
/// <para>
/// Whitespace
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_WS = 17,
/// <summary>
/// <para>
/// Other Neutrals
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_ON = 18,
/// <summary>
/// <para>
/// Left-to-Right isolate. Since 1.48.6
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_LRI = 19,
/// <summary>
/// <para>
/// Right-to-Left isolate. Since 1.48.6
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_RLI = 20,
/// <summary>
/// <para>
/// First strong isolate. Since 1.48.6
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_FSI = 21,
/// <summary>
/// <para>
/// Pop directional isolate. Since 1.48.6
/// </para>
/// </summary>

	PANGO_BIDI_TYPE_PDI = 22
}
