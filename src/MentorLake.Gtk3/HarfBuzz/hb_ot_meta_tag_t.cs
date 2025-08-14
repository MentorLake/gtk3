namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Known metadata tags from https://docs.microsoft.com/en-us/typography/opentype/spec/meta
/// </para>
/// </summary>

[Flags]
public enum hb_ot_meta_tag_t
{
/// <summary>
/// <para>
/// Design languages. Text, using only
/// Basic Latin (ASCII) characters. Indicates languages and/or scripts
/// for the user audiences that the font was primarily designed for.
/// </para>
/// </summary>

	HB_OT_META_TAG_DESIGN_LANGUAGES = 1684827751,
/// <summary>
/// <para>
/// Supported languages. Text, using
/// only Basic Latin (ASCII) characters. Indicates languages and/or scripts
/// that the font is declared to be capable of supporting.
/// </para>
/// </summary>

	HB_OT_META_TAG_SUPPORTED_LANGUAGES = 1936485991
}
