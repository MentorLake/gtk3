namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Flags from comparing two #hb_buffer_t's.
/// </para>
/// <para>
/// Buffer with different #hb_buffer_content_type_t cannot be meaningfully
/// compared in any further detail.
/// </para>
/// <para>
/// For buffers with differing length, the per-glyph comparison is not
/// attempted, though we do still scan reference buffer for dotted circle and
/// `.notdef` glyphs.
/// </para>
/// <para>
/// If the buffers have the same length, we compare them glyph-by-glyph and
/// report which aspect(s) of the glyph info/position are different.
/// </para>
/// </summary>

[Flags]
public enum hb_buffer_diff_flags_t : uint
{
/// <summary>
/// <para>
/// equal buffers.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_EQUAL = 0,
/// <summary>
/// <para>
/// buffers with different
///     #hb_buffer_content_type_t.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_CONTENT_TYPE_MISMATCH = 1,
/// <summary>
/// <para>
/// buffers with differing length.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_LENGTH_MISMATCH = 2,
/// <summary>
/// <para>
/// `.notdef` glyph is present in the
///     reference buffer.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_NOTDEF_PRESENT = 4,
/// <summary>
/// <para>
/// dotted circle glyph is present
///     in the reference buffer.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_DOTTED_CIRCLE_PRESENT = 8,
/// <summary>
/// <para>
/// difference in #hb_glyph_info_t.codepoint
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_CODEPOINT_MISMATCH = 16,
/// <summary>
/// <para>
/// difference in #hb_glyph_info_t.cluster
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_CLUSTER_MISMATCH = 32,
/// <summary>
/// <para>
/// difference in #hb_glyph_flags_t.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_GLYPH_FLAGS_MISMATCH = 64,
/// <summary>
/// <para>
/// difference in #hb_glyph_position_t.
/// </para>
/// </summary>

	HB_BUFFER_DIFF_FLAG_POSITION_MISMATCH = 128
}
