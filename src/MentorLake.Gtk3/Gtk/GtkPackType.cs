namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Represents the packing location #GtkBox children. (See: #GtkVBox,
/// #GtkHBox, and #GtkButtonBox).
/// </para>
/// </summary>

[Flags]
public enum GtkPackType
{
/// <summary>
/// <para>
/// The child is packed into the start of the box
/// </para>
/// </summary>

	GTK_PACK_START = 0,
/// <summary>
/// <para>
/// The child is packed into the end of the box
/// </para>
/// </summary>

	GTK_PACK_END = 1
}
