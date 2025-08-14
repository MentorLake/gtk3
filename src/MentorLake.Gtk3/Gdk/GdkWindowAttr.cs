namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Attributes to use for a newly-created window.
/// </para>
/// </summary>

public class GdkWindowAttrHandle : BaseSafeHandle
{
}


public static class GdkWindowAttrExtensions
{

	public static GdkWindowAttr Dereference(this GdkWindowAttrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkWindowAttr>(x.DangerousGetHandle());
}
internal class GdkWindowAttrExterns
{
}

/// <summary>
/// <para>
/// Attributes to use for a newly-created window.
/// </para>
/// </summary>

public struct GdkWindowAttr
{
	/// <summary>
/// <para>
/// title of the window (for toplevel windows)
/// </para>
/// </summary>

public string title;
	/// <summary>
/// <para>
/// event mask (see gdk_window_set_events())
/// </para>
/// </summary>

public int event_mask;
	/// <summary>
/// <para>
/// X coordinate relative to parent window (see gdk_window_move())
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// Y coordinate relative to parent window (see gdk_window_move())
/// </para>
/// </summary>

public int y;
	/// <summary>
/// <para>
/// width of window
/// </para>
/// </summary>

public int width;
	/// <summary>
/// <para>
/// height of window
/// </para>
/// </summary>

public int height;
	/// <summary>
/// <para>
/// #GDK_INPUT_OUTPUT (normal window) or #GDK_INPUT_ONLY (invisible
///  window that receives events)
/// </para>
/// </summary>

public GdkWindowWindowClass wclass;
	/// <summary>
/// <para>
/// #GdkVisual for window
/// </para>
/// </summary>

public IntPtr visual;
	/// <summary>
/// <para>
/// type of window
/// </para>
/// </summary>

public GdkWindowType window_type;
	/// <summary>
/// <para>
/// cursor for the window (see gdk_window_set_cursor())
/// </para>
/// </summary>

public IntPtr cursor;
	/// <summary>
/// <para>
/// don’t use (see gtk_window_set_wmclass())
/// </para>
/// </summary>

public string wmclass_name;
	/// <summary>
/// <para>
/// don’t use (see gtk_window_set_wmclass())
/// </para>
/// </summary>

public string wmclass_class;
	/// <summary>
/// <para>
/// %TRUE to bypass the window manager
/// </para>
/// </summary>

public bool override_redirect;
	/// <summary>
/// <para>
/// a hint of the function of the window
/// </para>
/// </summary>

public GdkWindowTypeHint type_hint;
}
