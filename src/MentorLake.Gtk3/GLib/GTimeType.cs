namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Disambiguates a given time in two ways.
/// </para>
/// <para>
/// First, specifies if the given time is in universal or local time.
/// </para>
/// <para>
/// Second, if the time is in local time, specifies if it is local
/// standard time or local daylight time.  This is important for the case
/// where the same local time occurs twice (during daylight savings time
/// transitions, for example).
/// </para>
/// </summary>

[Flags]
public enum GTimeType
{
/// <summary>
/// <para>
/// the time is in local standard time
/// </para>
/// </summary>

	G_TIME_TYPE_STANDARD = 0,
/// <summary>
/// <para>
/// the time is in local daylight time
/// </para>
/// </summary>

	G_TIME_TYPE_DAYLIGHT = 1,
/// <summary>
/// <para>
/// the time is in UTC
/// </para>
/// </summary>

	G_TIME_TYPE_UNIVERSAL = 2
}
