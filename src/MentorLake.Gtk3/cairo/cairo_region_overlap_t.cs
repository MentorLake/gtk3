namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Used as the return value for cairo_region_contains_rectangle().
/// </para>
/// </summary>

[Flags]
public enum cairo_region_overlap_t
{
/// <summary>
/// <para>
/// The contents are entirely inside the region. (Since 1.10)
/// </para>
/// </summary>

	CAIRO_REGION_OVERLAP_IN = 0,
/// <summary>
/// <para>
/// The contents are entirely outside the region. (Since 1.10)
/// </para>
/// </summary>

	CAIRO_REGION_OVERLAP_OUT = 1,
/// <summary>
/// <para>
/// The contents are partially inside and
///     partially outside the region. (Since 1.10)
/// </para>
/// </summary>

	CAIRO_REGION_OVERLAP_PART = 2
}
