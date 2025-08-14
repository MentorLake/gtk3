namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies properties of a text cluster mapping.
/// </para>
/// </summary>

[Flags]
public enum cairo_text_cluster_flags_t
{
/// <summary>
/// <para>
/// The clusters in the cluster array
/// map to glyphs in the glyph array from end to start. (Since 1.8)
/// </para>
/// </summary>

	CAIRO_TEXT_CLUSTER_FLAG_BACKWARD = 1
}
