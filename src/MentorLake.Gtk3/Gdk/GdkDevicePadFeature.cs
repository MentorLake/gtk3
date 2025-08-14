namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A pad feature.
/// </para>
/// </summary>

[Flags]
public enum GdkDevicePadFeature
{
/// <summary>
/// <para>
/// a button
/// </para>
/// </summary>

	GDK_DEVICE_PAD_FEATURE_BUTTON = 0,
/// <summary>
/// <para>
/// a ring-shaped interactive area
/// </para>
/// </summary>

	GDK_DEVICE_PAD_FEATURE_RING = 1,
/// <summary>
/// <para>
/// a straight interactive area
/// </para>
/// </summary>

	GDK_DEVICE_PAD_FEATURE_STRIP = 2
}
