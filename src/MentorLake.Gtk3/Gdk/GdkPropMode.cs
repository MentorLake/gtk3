namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Describes how existing data is combined with new data when
/// using gdk_property_change().
/// </para>
/// </summary>

[Flags]
public enum GdkPropMode
{
/// <summary>
/// <para>
/// the new data replaces the existing data.
/// </para>
/// </summary>

	GDK_PROP_MODE_REPLACE = 0,
/// <summary>
/// <para>
/// the new data is prepended to the existing data.
/// </para>
/// </summary>

	GDK_PROP_MODE_PREPEND = 1,
/// <summary>
/// <para>
/// the new data is appended to the existing data.
/// </para>
/// </summary>

	GDK_PROP_MODE_APPEND = 2
}
