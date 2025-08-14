namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Denotes the expansion properties that a widget will have when it (or its
/// parent) is resized.
/// </para>
/// </summary>

[Flags]
public enum GtkAttachOptions : uint
{
/// <summary>
/// <para>
/// the widget should expand to take up any extra space in its
/// container that has been allocated.
/// </para>
/// </summary>

	GTK_EXPAND = 1,
/// <summary>
/// <para>
/// the widget should shrink as and when possible.
/// </para>
/// </summary>

	GTK_SHRINK = 2,
/// <summary>
/// <para>
/// the widget should fill the space allocated to it.
/// </para>
/// </summary>

	GTK_FILL = 4
}
