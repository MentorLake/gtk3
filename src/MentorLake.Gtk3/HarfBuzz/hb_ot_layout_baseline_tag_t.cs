namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Baseline tags from [Baseline Tags](https://docs.microsoft.com/en-us/typography/opentype/spec/baselinetags) registry.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_layout_baseline_tag_t
{
/// <summary>
/// <para>
/// The baseline used by alphabetic scripts such as Latin, Cyrillic and Greek.
/// In vertical writing mode, the alphabetic baseline for characters rotated 90 degrees clockwise.
/// (This would not apply to alphabetic characters that remain upright in vertical writing mode, since these
/// characters are not rotated.)
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_ROMAN = 1919905134,
/// <summary>
/// <para>
/// The hanging baseline. In horizontal direction, this is the horizontal
/// line from which syllables seem, to hang in Tibetan and other similar scripts. In vertical writing mode,
/// for Tibetan (or some other similar script) characters rotated 90 degrees clockwise.
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_HANGING = 1751215719,
/// <summary>
/// <para>
/// Ideographic character face bottom or left edge,
/// if the direction is horizontal or vertical, respectively.
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_IDEO_FACE_BOTTOM_OR_LEFT = 1768121954,
/// <summary>
/// <para>
/// Ideographic character face top or right edge,
/// if the direction is horizontal or vertical, respectively.
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_IDEO_FACE_TOP_OR_RIGHT = 1768121972,
/// <summary>
/// <para>
/// The center of the ideographic character face. Since: 4.0.0
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_IDEO_FACE_CENTRAL = 1231251043,
/// <summary>
/// <para>
/// Ideographic em-box bottom or left edge,
/// if the direction is horizontal or vertical, respectively.
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_IDEO_EMBOX_BOTTOM_OR_LEFT = 1768187247,
/// <summary>
/// <para>
/// Ideographic em-box top or right edge baseline,
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_IDEO_EMBOX_TOP_OR_RIGHT = 1768191088,
/// <summary>
/// <para>
/// The center of the ideographic em-box. Since: 4.0.0
/// if the direction is horizontal or vertical, respectively.
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_IDEO_EMBOX_CENTRAL = 1231315813,
/// <summary>
/// <para>
/// The baseline about which mathematical characters are centered.
/// In vertical writing mode when mathematical characters rotated 90 degrees clockwise, are centered.
/// </para>
/// </summary>

	HB_OT_LAYOUT_BASELINE_TAG_MATH = 1835103336
}
