namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Flags that control what glyph information are serialized in hb_buffer_serialize_glyphs().
/// </para>
/// </summary>

[Flags]
public enum hb_buffer_serialize_flags_t : uint
{
/// <summary>
/// <para>
/// serialize glyph names, clusters and positions.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_DEFAULT = 0,
/// <summary>
/// <para>
/// do not serialize glyph cluster.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS = 1,
/// <summary>
/// <para>
/// do not serialize glyph position information.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_NO_POSITIONS = 2,
/// <summary>
/// <para>
/// do no serialize glyph name.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_NO_GLYPH_NAMES = 4,
/// <summary>
/// <para>
/// serialize glyph extents.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_GLYPH_EXTENTS = 8,
/// <summary>
/// <para>
/// serialize glyph flags. Since: 1.5.0
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_GLYPH_FLAGS = 16,
/// <summary>
/// <para>
/// do not serialize glyph advances,
///  glyph offsets will reflect absolute glyph positions. Since: 1.8.0
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_NO_ADVANCES = 32,
/// <summary>
/// <para>
/// All currently defined flags. Since: 4.4.0
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FLAG_DEFINED = 63
}
