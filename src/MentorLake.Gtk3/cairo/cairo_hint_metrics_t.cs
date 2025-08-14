namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies whether to hint font metrics; hinting font metrics
/// means quantizing them so that they are integer values in
/// device space. Doing this improves the consistency of
/// letter and line spacing, however it also means that text
/// will be laid out differently at different zoom factors.
/// </para>
/// </summary>

[Flags]
public enum cairo_hint_metrics_t
{
/// <summary>
/// <para>
/// Hint metrics in the default
///  manner for the font backend and target device, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_METRICS_DEFAULT = 0,
/// <summary>
/// <para>
/// Do not hint font metrics, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_METRICS_OFF = 1,
/// <summary>
/// <para>
/// Hint font metrics, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_METRICS_ON = 2
}
