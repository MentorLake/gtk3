namespace MentorLake.Gtk3.Gtk3;

public class GtkIconInfoHandle : GObjectHandle
{
	public static GtkIconInfoHandle NewForPixbuf(GtkIconThemeHandle icon_theme, GdkPixbufHandle pixbuf)
	{
		return GtkIconInfoExterns.gtk_icon_info_new_for_pixbuf(icon_theme, pixbuf);
	}

}

public static class GtkIconInfoHandleExtensions
{
	public static GtkIconInfoHandle Copy(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_copy(icon_info);
	}

	public static T Free<T>(this T icon_info) where T : GtkIconInfoHandle
	{
		GtkIconInfoExterns.gtk_icon_info_free(icon_info);
		return icon_info;
	}

	public static bool GetAttachPoints(this GtkIconInfoHandle icon_info, out GdkPoint[] points, out int n_points)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_attach_points(icon_info, out points, out n_points);
	}

	public static int GetBaseScale(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_base_scale(icon_info);
	}

	public static int GetBaseSize(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_base_size(icon_info);
	}

	public static GdkPixbufHandle GetBuiltinPixbuf(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_builtin_pixbuf(icon_info);
	}

	public static string GetDisplayName(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_display_name(icon_info);
	}

	public static bool GetEmbeddedRect(this GtkIconInfoHandle icon_info, out GdkRectangle rectangle)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_embedded_rect(icon_info, out rectangle);
	}

	public static string GetFilename(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_get_filename(icon_info);
	}

	public static bool IsSymbolic(this GtkIconInfoHandle icon_info)
	{
		return GtkIconInfoExterns.gtk_icon_info_is_symbolic(icon_info);
	}

	public static GdkPixbufHandle LoadIcon(this GtkIconInfoHandle icon_info, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_icon(icon_info, out error);
	}

	public static T LoadIconAsync<T>(this T icon_info, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		GtkIconInfoExterns.gtk_icon_info_load_icon_async(icon_info, cancellable, callback, user_data);
		return icon_info;
	}

	public static GdkPixbufHandle LoadIconFinish(this GtkIconInfoHandle icon_info, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_icon_finish(icon_info, res, out error);
	}

	public static cairo_surface_tHandle LoadSurface(this GtkIconInfoHandle icon_info, GdkWindowHandle for_window, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_surface(icon_info, for_window, out error);
	}

	public static GdkPixbufHandle LoadSymbolic(this GtkIconInfoHandle icon_info, GdkRGBAHandle fg, GdkRGBAHandle success_color, GdkRGBAHandle warning_color, GdkRGBAHandle error_color, out bool was_symbolic, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_symbolic(icon_info, fg, success_color, warning_color, error_color, out was_symbolic, out error);
	}

	public static T LoadSymbolicAsync<T>(this T icon_info, GdkRGBAHandle fg, GdkRGBAHandle success_color, GdkRGBAHandle warning_color, GdkRGBAHandle error_color, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		GtkIconInfoExterns.gtk_icon_info_load_symbolic_async(icon_info, fg, success_color, warning_color, error_color, cancellable, callback, user_data);
		return icon_info;
	}

	public static GdkPixbufHandle LoadSymbolicFinish(this GtkIconInfoHandle icon_info, GAsyncResultHandle res, out bool was_symbolic, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_symbolic_finish(icon_info, res, out was_symbolic, out error);
	}

	public static GdkPixbufHandle LoadSymbolicForContext(this GtkIconInfoHandle icon_info, GtkStyleContextHandle context, out bool was_symbolic, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_symbolic_for_context(icon_info, context, out was_symbolic, out error);
	}

	public static T LoadSymbolicForContextAsync<T>(this T icon_info, GtkStyleContextHandle context, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		GtkIconInfoExterns.gtk_icon_info_load_symbolic_for_context_async(icon_info, context, cancellable, callback, user_data);
		return icon_info;
	}

	public static GdkPixbufHandle LoadSymbolicForContextFinish(this GtkIconInfoHandle icon_info, GAsyncResultHandle res, out bool was_symbolic, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_symbolic_for_context_finish(icon_info, res, out was_symbolic, out error);
	}

	public static GdkPixbufHandle LoadSymbolicForStyle(this GtkIconInfoHandle icon_info, GtkStyleHandle style, GtkStateType state, out bool was_symbolic, out GErrorHandle error)
	{
		return GtkIconInfoExterns.gtk_icon_info_load_symbolic_for_style(icon_info, style, state, out was_symbolic, out error);
	}

	public static T SetRawCoordinates<T>(this T icon_info, bool raw_coordinates) where T : GtkIconInfoHandle
	{
		GtkIconInfoExterns.gtk_icon_info_set_raw_coordinates(icon_info, raw_coordinates);
		return icon_info;
	}

}

internal class GtkIconInfoExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_info_new_for_pixbuf(GtkIconThemeHandle icon_theme, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_info_copy(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_info_free(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_info_get_attach_points(GtkIconInfoHandle icon_info, out GdkPoint[] points, out int n_points);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_info_get_base_scale(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_info_get_base_size(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_get_builtin_pixbuf(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_info_get_display_name(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_info_get_embedded_rect(GtkIconInfoHandle icon_info, out GdkRectangle rectangle);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_info_get_filename(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_info_is_symbolic(GtkIconInfoHandle icon_info);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_icon(GtkIconInfoHandle icon_info, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_info_load_icon_async(GtkIconInfoHandle icon_info, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_icon_finish(GtkIconInfoHandle icon_info, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_surface_tHandle gtk_icon_info_load_surface(GtkIconInfoHandle icon_info, GdkWindowHandle for_window, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_symbolic(GtkIconInfoHandle icon_info, GdkRGBAHandle fg, GdkRGBAHandle success_color, GdkRGBAHandle warning_color, GdkRGBAHandle error_color, out bool was_symbolic, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_info_load_symbolic_async(GtkIconInfoHandle icon_info, GdkRGBAHandle fg, GdkRGBAHandle success_color, GdkRGBAHandle warning_color, GdkRGBAHandle error_color, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_symbolic_finish(GtkIconInfoHandle icon_info, GAsyncResultHandle res, out bool was_symbolic, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_symbolic_for_context(GtkIconInfoHandle icon_info, GtkStyleContextHandle context, out bool was_symbolic, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_info_load_symbolic_for_context_async(GtkIconInfoHandle icon_info, GtkStyleContextHandle context, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_symbolic_for_context_finish(GtkIconInfoHandle icon_info, GAsyncResultHandle res, out bool was_symbolic, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_info_load_symbolic_for_style(GtkIconInfoHandle icon_info, GtkStyleHandle style, GtkStateType state, out bool was_symbolic, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_info_set_raw_coordinates(GtkIconInfoHandle icon_info, bool raw_coordinates);

}
