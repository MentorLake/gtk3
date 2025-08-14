namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// These are hints originally defined by the Motif toolkit. The window manager
/// can use them when determining the functions to offer for the window. The
/// hint must be set before mapping the window.
/// </para>
/// </summary>

[Flags]
public enum GdkWMFunction : uint
{
/// <summary>
/// <para>
/// all functions should be offered.
/// </para>
/// </summary>

	GDK_FUNC_ALL = 1,
/// <summary>
/// <para>
/// the window should be resizable.
/// </para>
/// </summary>

	GDK_FUNC_RESIZE = 2,
/// <summary>
/// <para>
/// the window should be movable.
/// </para>
/// </summary>

	GDK_FUNC_MOVE = 4,
/// <summary>
/// <para>
/// the window should be minimizable.
/// </para>
/// </summary>

	GDK_FUNC_MINIMIZE = 8,
/// <summary>
/// <para>
/// the window should be maximizable.
/// </para>
/// </summary>

	GDK_FUNC_MAXIMIZE = 16,
/// <summary>
/// <para>
/// the window should be closable.
/// </para>
/// </summary>

	GDK_FUNC_CLOSE = 32
}
