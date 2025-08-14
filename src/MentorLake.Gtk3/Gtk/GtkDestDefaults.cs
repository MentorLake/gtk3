namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkDestDefaults enumeration specifies the various
/// types of action that will be taken on behalf
/// of the user for a drag destination site.
/// </para>
/// </summary>

[Flags]
public enum GtkDestDefaults : uint
{
/// <summary>
/// <para>
/// If set for a widget, GTK+, during a drag over this
///   widget will check if the drag matches this widget’s list of possible targets
///   and actions.
///   GTK+ will then call gdk_drag_status() as appropriate.
/// </para>
/// </summary>

	GTK_DEST_DEFAULT_MOTION = 1,
/// <summary>
/// <para>
/// If set for a widget, GTK+ will draw a highlight on
///   this widget as long as a drag is over this widget and the widget drag format
///   and action are acceptable.
/// </para>
/// </summary>

	GTK_DEST_DEFAULT_HIGHLIGHT = 2,
/// <summary>
/// <para>
/// If set for a widget, when a drop occurs, GTK+ will
///   will check if the drag matches this widget’s list of possible targets and
///   actions. If so, GTK+ will call gtk_drag_get_data() on behalf of the widget.
///   Whether or not the drop is successful, GTK+ will call gtk_drag_finish(). If
///   the action was a move, then if the drag was successful, then %TRUE will be
///   passed for the @delete parameter to gtk_drag_finish().
/// </para>
/// </summary>

	GTK_DEST_DEFAULT_DROP = 4,
/// <summary>
/// <para>
/// If set, specifies that all default actions should
///   be taken.
/// </para>
/// </summary>

	GTK_DEST_DEFAULT_ALL = 7
}
