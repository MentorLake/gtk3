namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The mode of the size group determines the directions in which the size
/// group affects the requested sizes of its component widgets.
/// </para>
/// </summary>

[Flags]
public enum GtkSizeGroupMode
{
/// <summary>
/// <para>
/// group has no effect
/// </para>
/// </summary>

	GTK_SIZE_GROUP_NONE = 0,
/// <summary>
/// <para>
/// group affects horizontal requisition
/// </para>
/// </summary>

	GTK_SIZE_GROUP_HORIZONTAL = 1,
/// <summary>
/// <para>
/// group affects vertical requisition
/// </para>
/// </summary>

	GTK_SIZE_GROUP_VERTICAL = 2,
/// <summary>
/// <para>
/// group affects both horizontal and vertical requisition
/// </para>
/// </summary>

	GTK_SIZE_GROUP_BOTH = 3
}
