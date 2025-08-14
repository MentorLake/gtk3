namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes a widget state. Widget states are used to match the widget
/// against CSS pseudo-classes. Note that GTK extends the regular CSS
/// classes and sometimes uses different names.
/// </para>
/// </summary>

[Flags]
public enum GtkStateFlags : uint
{
/// <summary>
/// <para>
/// State during normal operation.
/// </para>
/// </summary>

	GTK_STATE_FLAG_NORMAL = 0,
/// <summary>
/// <para>
/// Widget is active.
/// </para>
/// </summary>

	GTK_STATE_FLAG_ACTIVE = 1,
/// <summary>
/// <para>
/// Widget has a mouse pointer over it.
/// </para>
/// </summary>

	GTK_STATE_FLAG_PRELIGHT = 2,
/// <summary>
/// <para>
/// Widget is selected.
/// </para>
/// </summary>

	GTK_STATE_FLAG_SELECTED = 4,
/// <summary>
/// <para>
/// Widget is insensitive.
/// </para>
/// </summary>

	GTK_STATE_FLAG_INSENSITIVE = 8,
/// <summary>
/// <para>
/// Widget is inconsistent.
/// </para>
/// </summary>

	GTK_STATE_FLAG_INCONSISTENT = 16,
/// <summary>
/// <para>
/// Widget has the keyboard focus.
/// </para>
/// </summary>

	GTK_STATE_FLAG_FOCUSED = 32,
/// <summary>
/// <para>
/// Widget is in a background toplevel window.
/// </para>
/// </summary>

	GTK_STATE_FLAG_BACKDROP = 64,
/// <summary>
/// <para>
/// Widget is in left-to-right text direction. Since 3.8
/// </para>
/// </summary>

	GTK_STATE_FLAG_DIR_LTR = 128,
/// <summary>
/// <para>
/// Widget is in right-to-left text direction. Since 3.8
/// </para>
/// </summary>

	GTK_STATE_FLAG_DIR_RTL = 256,
/// <summary>
/// <para>
/// Widget is a link. Since 3.12
/// </para>
/// </summary>

	GTK_STATE_FLAG_LINK = 512,
/// <summary>
/// <para>
/// The location the widget points to has already been visited. Since 3.12
/// </para>
/// </summary>

	GTK_STATE_FLAG_VISITED = 1024,
/// <summary>
/// <para>
/// Widget is checked. Since 3.14
/// </para>
/// </summary>

	GTK_STATE_FLAG_CHECKED = 2048,
/// <summary>
/// <para>
/// Widget is highlighted as a drop target for DND. Since 3.20
/// </para>
/// </summary>

	GTK_STATE_FLAG_DROP_ACTIVE = 4096
}
