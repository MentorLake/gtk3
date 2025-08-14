namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Flags for math glyph parts.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_math_glyph_part_flags_t : uint
{
/// <summary>
/// <para>
/// This is an extender glyph part that
/// can be repeated to reach the desired length.
/// </para>
/// </summary>

	HB_OT_MATH_GLYPH_PART_FLAG_EXTENDER = 1
}
