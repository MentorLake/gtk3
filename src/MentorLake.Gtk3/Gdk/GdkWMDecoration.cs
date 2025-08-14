namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// These are hints originally defined by the Motif toolkit.
/// The window manager can use them when determining how to decorate
/// the window. The hint must be set before mapping the window.
/// </para>
/// </summary>

[Flags]
public enum GdkWMDecoration : uint
{
/// <summary>
/// <para>
/// all decorations should be applied.
/// </para>
/// </summary>

	GDK_DECOR_ALL = 1,
/// <summary>
/// <para>
/// a frame should be drawn around the window.
/// </para>
/// </summary>

	GDK_DECOR_BORDER = 2,
/// <summary>
/// <para>
/// the frame should have resize handles.
/// </para>
/// </summary>

	GDK_DECOR_RESIZEH = 4,
/// <summary>
/// <para>
/// a titlebar should be placed above the window.
/// </para>
/// </summary>

	GDK_DECOR_TITLE = 8,
/// <summary>
/// <para>
/// a button for opening a menu should be included.
/// </para>
/// </summary>

	GDK_DECOR_MENU = 16,
/// <summary>
/// <para>
/// a minimize button should be included.
/// </para>
/// </summary>

	GDK_DECOR_MINIMIZE = 32,
/// <summary>
/// <para>
/// a maximize button should be included.
/// </para>
/// </summary>

	GDK_DECOR_MAXIMIZE = 64
}
