namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// This type indicates the current state of a widget; the state determines how
/// the widget is drawn. The #GtkStateType enumeration is also used to
/// identify different colors in a #GtkStyle for drawing, so states can be
/// used for subparts of a widget as well as entire widgets.
/// </para>
/// </summary>

[Flags]
public enum GtkStateType
{
/// <summary>
/// <para>
/// State during normal operation.
/// </para>
/// </summary>

	GTK_STATE_NORMAL = 0,
/// <summary>
/// <para>
/// State of a currently active widget, such as a depressed button.
/// </para>
/// </summary>

	GTK_STATE_ACTIVE = 1,
/// <summary>
/// <para>
/// State indicating that the mouse pointer is over
///                      the widget and the widget will respond to mouse clicks.
/// </para>
/// </summary>

	GTK_STATE_PRELIGHT = 2,
/// <summary>
/// <para>
/// State of a selected item, such the selected row in a list.
/// </para>
/// </summary>

	GTK_STATE_SELECTED = 3,
/// <summary>
/// <para>
/// State indicating that the widget is
///                         unresponsive to user actions.
/// </para>
/// </summary>

	GTK_STATE_INSENSITIVE = 4,
/// <summary>
/// <para>
/// The widget is inconsistent, such as checkbuttons
///                          or radiobuttons that aren’t either set to %TRUE nor %FALSE,
///                          or buttons requiring the user attention.
/// </para>
/// </summary>

	GTK_STATE_INCONSISTENT = 5,
/// <summary>
/// <para>
/// The widget has the keyboard focus.
/// </para>
/// </summary>

	GTK_STATE_FOCUSED = 6
}
