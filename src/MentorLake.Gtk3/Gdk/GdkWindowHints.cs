namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used to indicate which fields of a #GdkGeometry struct should be paid
/// attention to. Also, the presence/absence of @GDK_HINT_POS,
/// @GDK_HINT_USER_POS, and @GDK_HINT_USER_SIZE is significant, though they don&apos;t
/// directly refer to #GdkGeometry fields. @GDK_HINT_USER_POS will be set
/// automatically by #GtkWindow if you call gtk_window_move().
/// @GDK_HINT_USER_POS and @GDK_HINT_USER_SIZE should be set if the user
/// specified a size/position using a --geometry command-line argument;
/// gtk_window_parse_geometry() automatically sets these flags.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowHints : uint
{
/// <summary>
/// <para>
/// indicates that the program has positioned the window
/// </para>
/// </summary>

	GDK_HINT_POS = 1,
/// <summary>
/// <para>
/// min size fields are set
/// </para>
/// </summary>

	GDK_HINT_MIN_SIZE = 2,
/// <summary>
/// <para>
/// max size fields are set
/// </para>
/// </summary>

	GDK_HINT_MAX_SIZE = 4,
/// <summary>
/// <para>
/// base size fields are set
/// </para>
/// </summary>

	GDK_HINT_BASE_SIZE = 8,
/// <summary>
/// <para>
/// aspect ratio fields are set
/// </para>
/// </summary>

	GDK_HINT_ASPECT = 16,
/// <summary>
/// <para>
/// resize increment fields are set
/// </para>
/// </summary>

	GDK_HINT_RESIZE_INC = 32,
/// <summary>
/// <para>
/// window gravity field is set
/// </para>
/// </summary>

	GDK_HINT_WIN_GRAVITY = 64,
/// <summary>
/// <para>
/// indicates that the window’s position was explicitly set
///  by the user
/// </para>
/// </summary>

	GDK_HINT_USER_POS = 128,
/// <summary>
/// <para>
/// indicates that the window’s size was explicitly set by
///  the user
/// </para>
/// </summary>

	GDK_HINT_USER_SIZE = 256
}
