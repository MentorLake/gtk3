namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration that affects baseline shifts between runs.
/// </para>
/// </summary>

[Flags]
public enum PangoBaselineShift
{
/// <summary>
/// <para>
/// Leave the baseline unchanged
/// </para>
/// </summary>

	PANGO_BASELINE_SHIFT_NONE = 0,
/// <summary>
/// <para>
/// Shift the baseline to the superscript position,
///   relative to the previous run
/// </para>
/// </summary>

	PANGO_BASELINE_SHIFT_SUPERSCRIPT = 1,
/// <summary>
/// <para>
/// Shift the baseline to the subscript position,
///   relative to the previous run
/// </para>
/// </summary>

	PANGO_BASELINE_SHIFT_SUBSCRIPT = 2
}
