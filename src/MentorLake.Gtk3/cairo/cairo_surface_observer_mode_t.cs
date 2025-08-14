namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Whether operations should be recorded.
/// </para>
/// </summary>

[Flags]
public enum cairo_surface_observer_mode_t
{
/// <summary>
/// <para>
/// no recording is done
/// </para>
/// </summary>

	CAIRO_SURFACE_OBSERVER_NORMAL = 0,
/// <summary>
/// <para>
/// operations are recorded
/// </para>
/// </summary>

	CAIRO_SURFACE_OBSERVER_RECORD_OPERATIONS = 1
}
