namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the type of a property change for a #GdkEventProperty.
/// </para>
/// </summary>

[Flags]
public enum GdkPropertyState
{
/// <summary>
/// <para>
/// the property value was changed.
/// </para>
/// </summary>

	GDK_PROPERTY_NEW_VALUE = 0,
/// <summary>
/// <para>
/// the property was deleted.
/// </para>
/// </summary>

	GDK_PROPERTY_DELETE = 1
}
