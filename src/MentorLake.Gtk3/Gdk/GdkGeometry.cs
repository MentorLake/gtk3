namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// The #GdkGeometry struct gives the window manager information about
/// a window’s geometry constraints. Normally you would set these on
/// the GTK+ level using gtk_window_set_geometry_hints(). #GtkWindow
/// then sets the hints on the #GdkWindow it creates.
/// </para>
/// <para>
/// gdk_window_set_geometry_hints() expects the hints to be fully valid already
/// and simply passes them to the window manager; in contrast,
/// gtk_window_set_geometry_hints() performs some interpretation. For example,
/// #GtkWindow will apply the hints to the geometry widget instead of the
/// toplevel window, if you set a geometry widget. Also, the
/// @min_width/@min_height/@max_width/@max_height fields may be set to -1, and
/// #GtkWindow will substitute the size request of the window or geometry widget.
/// If the minimum size hint is not provided, #GtkWindow will use its requisition
/// as the minimum size. If the minimum size is provided and a geometry widget is
/// set, #GtkWindow will take the minimum size as the minimum size of the
/// geometry widget rather than the entire window. The base size is treated
/// similarly.
/// </para>
/// <para>
/// The canonical use-case for gtk_window_set_geometry_hints() is to get a
/// terminal widget to resize properly. Here, the terminal text area should be
/// the geometry widget; #GtkWindow will then automatically set the base size to
/// the size of other widgets in the terminal window, such as the menubar and
/// scrollbar. Then, the @width_inc and @height_inc fields should be set to the
/// size of one character in the terminal. Finally, the base size should be set
/// to the size of one character. The net effect is that the minimum size of the
/// terminal will have a 1x1 character terminal area, and only terminal sizes on
/// the “character grid” will be allowed.
/// </para>
/// <para>
/// Here’s an example of how the terminal example would be implemented, assuming
/// a terminal area widget called “terminal” and a toplevel window “toplevel”:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// 	GdkGeometry hints;
/// </para>
/// <para>
/// 	hints.base_width = terminal->char_width;
///         hints.base_height = terminal->char_height;
///         hints.min_width = terminal->char_width;
///         hints.min_height = terminal->char_height;
///         hints.width_inc = terminal->char_width;
///         hints.height_inc = terminal->char_height;
/// </para>
/// <para>
///  gtk_window_set_geometry_hints (GTK_WINDOW (toplevel),
///                                 GTK_WIDGET (terminal),
///                                 &hints,
///                                 GDK_HINT_RESIZE_INC |
///                                 GDK_HINT_MIN_SIZE |
///                                 GDK_HINT_BASE_SIZE);
/// ]|
/// </para>
/// <para>
/// The other useful fields are the @min_aspect and @max_aspect fields; these
/// contain a width/height ratio as a floating point number. If a geometry widget
/// is set, the aspect applies to the geometry widget rather than the entire
/// window. The most common use of these hints is probably to set @min_aspect and
/// @max_aspect to the same value, thus forcing the window to keep a constant
/// aspect ratio.
/// </para>
/// </summary>

public class GdkGeometryHandle : BaseSafeHandle
{
}


public static class GdkGeometryExtensions
{

	public static GdkGeometry Dereference(this GdkGeometryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkGeometry>(x.DangerousGetHandle());
}
internal class GdkGeometryExterns
{
}

/// <summary>
/// <para>
/// The #GdkGeometry struct gives the window manager information about
/// a window’s geometry constraints. Normally you would set these on
/// the GTK+ level using gtk_window_set_geometry_hints(). #GtkWindow
/// then sets the hints on the #GdkWindow it creates.
/// </para>
/// <para>
/// gdk_window_set_geometry_hints() expects the hints to be fully valid already
/// and simply passes them to the window manager; in contrast,
/// gtk_window_set_geometry_hints() performs some interpretation. For example,
/// #GtkWindow will apply the hints to the geometry widget instead of the
/// toplevel window, if you set a geometry widget. Also, the
/// @min_width/@min_height/@max_width/@max_height fields may be set to -1, and
/// #GtkWindow will substitute the size request of the window or geometry widget.
/// If the minimum size hint is not provided, #GtkWindow will use its requisition
/// as the minimum size. If the minimum size is provided and a geometry widget is
/// set, #GtkWindow will take the minimum size as the minimum size of the
/// geometry widget rather than the entire window. The base size is treated
/// similarly.
/// </para>
/// <para>
/// The canonical use-case for gtk_window_set_geometry_hints() is to get a
/// terminal widget to resize properly. Here, the terminal text area should be
/// the geometry widget; #GtkWindow will then automatically set the base size to
/// the size of other widgets in the terminal window, such as the menubar and
/// scrollbar. Then, the @width_inc and @height_inc fields should be set to the
/// size of one character in the terminal. Finally, the base size should be set
/// to the size of one character. The net effect is that the minimum size of the
/// terminal will have a 1x1 character terminal area, and only terminal sizes on
/// the “character grid” will be allowed.
/// </para>
/// <para>
/// Here’s an example of how the terminal example would be implemented, assuming
/// a terminal area widget called “terminal” and a toplevel window “toplevel”:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// 	GdkGeometry hints;
/// </para>
/// <para>
/// 	hints.base_width = terminal->char_width;
///         hints.base_height = terminal->char_height;
///         hints.min_width = terminal->char_width;
///         hints.min_height = terminal->char_height;
///         hints.width_inc = terminal->char_width;
///         hints.height_inc = terminal->char_height;
/// </para>
/// <para>
///  gtk_window_set_geometry_hints (GTK_WINDOW (toplevel),
///                                 GTK_WIDGET (terminal),
///                                 &hints,
///                                 GDK_HINT_RESIZE_INC |
///                                 GDK_HINT_MIN_SIZE |
///                                 GDK_HINT_BASE_SIZE);
/// ]|
/// </para>
/// <para>
/// The other useful fields are the @min_aspect and @max_aspect fields; these
/// contain a width/height ratio as a floating point number. If a geometry widget
/// is set, the aspect applies to the geometry widget rather than the entire
/// window. The most common use of these hints is probably to set @min_aspect and
/// @max_aspect to the same value, thus forcing the window to keep a constant
/// aspect ratio.
/// </para>
/// </summary>

public struct GdkGeometry
{
	/// <summary>
/// <para>
/// minimum width of window (or -1 to use requisition, with
///  #GtkWindow only)
/// </para>
/// </summary>

public int min_width;
	/// <summary>
/// <para>
/// minimum height of window (or -1 to use requisition, with
///  #GtkWindow only)
/// </para>
/// </summary>

public int min_height;
	/// <summary>
/// <para>
/// maximum width of window (or -1 to use requisition, with
///  #GtkWindow only)
/// </para>
/// </summary>

public int max_width;
	/// <summary>
/// <para>
/// maximum height of window (or -1 to use requisition, with
///  #GtkWindow only)
/// </para>
/// </summary>

public int max_height;
	/// <summary>
/// <para>
/// allowed window widths are @base_width + @width_inc * N where N
///  is any integer (-1 allowed with #GtkWindow)
/// </para>
/// </summary>

public int base_width;
	/// <summary>
/// <para>
/// allowed window widths are @base_height + @height_inc * N where
///  N is any integer (-1 allowed with #GtkWindow)
/// </para>
/// </summary>

public int base_height;
	/// <summary>
/// <para>
/// width resize increment
/// </para>
/// </summary>

public int width_inc;
	/// <summary>
/// <para>
/// height resize increment
/// </para>
/// </summary>

public int height_inc;
	/// <summary>
/// <para>
/// minimum width/height ratio
/// </para>
/// </summary>

public double min_aspect;
	/// <summary>
/// <para>
/// maximum width/height ratio
/// </para>
/// </summary>

public double max_aspect;
	/// <summary>
/// <para>
/// window gravity, see gtk_window_set_gravity()
/// </para>
/// </summary>

public GdkGravity win_gravity;
}
