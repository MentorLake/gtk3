namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the kind of crossing for #GdkEventCrossing.
/// </para>
/// <para>
/// See the X11 protocol specification of LeaveNotify for
/// full details of crossing event generation.
/// </para>
/// </summary>

[Flags]
public enum GdkNotifyType
{
/// <summary>
/// <para>
/// the window is entered from an ancestor or
///   left towards an ancestor.
/// </para>
/// </summary>

	GDK_NOTIFY_ANCESTOR = 0,
/// <summary>
/// <para>
/// the pointer moves between an ancestor and an
///   inferior of the window.
/// </para>
/// </summary>

	GDK_NOTIFY_VIRTUAL = 1,
/// <summary>
/// <para>
/// the window is entered from an inferior or
///   left towards an inferior.
/// </para>
/// </summary>

	GDK_NOTIFY_INFERIOR = 2,
/// <summary>
/// <para>
/// the window is entered from or left towards
///   a window which is neither an ancestor nor an inferior.
/// </para>
/// </summary>

	GDK_NOTIFY_NONLINEAR = 3,
/// <summary>
/// <para>
/// the pointer moves between two windows
///   which are not ancestors of each other and the window is part of
///   the ancestor chain between one of these windows and their least
///   common ancestor.
/// </para>
/// </summary>

	GDK_NOTIFY_NONLINEAR_VIRTUAL = 4,
/// <summary>
/// <para>
/// an unknown type of enter/leave event occurred.
/// </para>
/// </summary>

	GDK_NOTIFY_UNKNOWN = 5
}
