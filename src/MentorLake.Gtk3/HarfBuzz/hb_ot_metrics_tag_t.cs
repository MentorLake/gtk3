namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Metric tags corresponding to [MVAR Value
/// Tags](https://docs.microsoft.com/en-us/typography/opentype/spec/mvar#value-tags)
/// </para>
/// </summary>

[Flags]
public enum hb_ot_metrics_tag_t
{
/// <summary>
/// <para>
/// horizontal ascender.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_ASCENDER = 1751216995,
/// <summary>
/// <para>
/// horizontal descender.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_DESCENDER = 1751413603,
/// <summary>
/// <para>
/// horizontal line gap.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_LINE_GAP = 1751934832,
/// <summary>
/// <para>
/// horizontal clipping ascent.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_CLIPPING_ASCENT = 1751346273,
/// <summary>
/// <para>
/// horizontal clipping descent.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_CLIPPING_DESCENT = 1751346276,
/// <summary>
/// <para>
/// vertical ascender.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_VERTICAL_ASCENDER = 1986098019,
/// <summary>
/// <para>
/// vertical descender.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_VERTICAL_DESCENDER = 1986294627,
/// <summary>
/// <para>
/// vertical line gap.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_VERTICAL_LINE_GAP = 1986815856,
/// <summary>
/// <para>
/// horizontal caret rise.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_CARET_RISE = 1751347827,
/// <summary>
/// <para>
/// horizontal caret run.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_CARET_RUN = 1751347822,
/// <summary>
/// <para>
/// horizontal caret offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_HORIZONTAL_CARET_OFFSET = 1751347046,
/// <summary>
/// <para>
/// vertical caret rise.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_VERTICAL_CARET_RISE = 1986228851,
/// <summary>
/// <para>
/// vertical caret run.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_VERTICAL_CARET_RUN = 1986228846,
/// <summary>
/// <para>
/// vertical caret offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_VERTICAL_CARET_OFFSET = 1986228070,
/// <summary>
/// <para>
/// x height.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_X_HEIGHT = 2020108148,
/// <summary>
/// <para>
/// cap height.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_CAP_HEIGHT = 1668311156,
/// <summary>
/// <para>
/// subscript em x size.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUBSCRIPT_EM_X_SIZE = 1935833203,
/// <summary>
/// <para>
/// subscript em y size.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUBSCRIPT_EM_Y_SIZE = 1935833459,
/// <summary>
/// <para>
/// subscript em x offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUBSCRIPT_EM_X_OFFSET = 1935833199,
/// <summary>
/// <para>
/// subscript em y offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUBSCRIPT_EM_Y_OFFSET = 1935833455,
/// <summary>
/// <para>
/// superscript em x size.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUPERSCRIPT_EM_X_SIZE = 1936750707,
/// <summary>
/// <para>
/// superscript em y size.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUPERSCRIPT_EM_Y_SIZE = 1936750963,
/// <summary>
/// <para>
/// superscript em x offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUPERSCRIPT_EM_X_OFFSET = 1936750703,
/// <summary>
/// <para>
/// superscript em y offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_SUPERSCRIPT_EM_Y_OFFSET = 1936750959,
/// <summary>
/// <para>
/// strikeout size.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_STRIKEOUT_SIZE = 1937011315,
/// <summary>
/// <para>
/// strikeout offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_STRIKEOUT_OFFSET = 1937011311,
/// <summary>
/// <para>
/// underline size.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_UNDERLINE_SIZE = 1970168947,
/// <summary>
/// <para>
/// underline offset.
/// </para>
/// </summary>

	HB_OT_METRICS_TAG_UNDERLINE_OFFSET = 1970168943
}
