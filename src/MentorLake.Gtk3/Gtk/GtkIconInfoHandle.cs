namespace MentorLake.Gtk;

public class GtkIconInfoHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkIconInfoHandle NewForPixbuf(MentorLake.Gtk.GtkIconThemeHandle icon_theme, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkIconInfoHandleExterns.gtk_icon_info_new_for_pixbuf(icon_theme, pixbuf);
	}

}

public static class GtkIconInfoHandleExtensions
{
	public static MentorLake.Gtk.GtkIconInfoHandle Copy(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_copy(icon_info);
	}

	public static T Free<T>(this T icon_info) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_free(icon_info);
		return icon_info;
	}

	public static bool GetAttachPoints(this MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.Gdk.GdkPoint[] points, out int n_points)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_attach_points(icon_info, out points, out n_points);
	}

	public static int GetBaseScale(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_base_scale(icon_info);
	}

	public static int GetBaseSize(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_base_size(icon_info);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetBuiltinPixbuf(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_builtin_pixbuf(icon_info);
	}

	public static string GetDisplayName(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_display_name(icon_info);
	}

	public static bool GetEmbeddedRect(this MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.Gdk.GdkRectangle rectangle)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_embedded_rect(icon_info, out rectangle);
	}

	public static string GetFilename(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_filename(icon_info);
	}

	public static bool IsSymbolic(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_is_symbolic(icon_info);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIcon(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_icon(icon_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LoadIconAsync<T>(this T icon_info, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_load_icon_async(icon_info, cancellable, callback, user_data);
		return icon_info;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIconFinish(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_icon_finish(icon_info, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.cairo.cairo_surface_tHandle LoadSurface(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gdk.GdkWindowHandle for_window)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_surface(icon_info, for_window, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolic(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gdk.GdkRGBAHandle fg, MentorLake.Gdk.GdkRGBAHandle success_color, MentorLake.Gdk.GdkRGBAHandle warning_color, MentorLake.Gdk.GdkRGBAHandle error_color, out bool was_symbolic)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic(icon_info, fg, success_color, warning_color, error_color, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LoadSymbolicAsync<T>(this T icon_info, MentorLake.Gdk.GdkRGBAHandle fg, MentorLake.Gdk.GdkRGBAHandle success_color, MentorLake.Gdk.GdkRGBAHandle warning_color, MentorLake.Gdk.GdkRGBAHandle error_color, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_async(icon_info, fg, success_color, warning_color, error_color, cancellable, callback, user_data);
		return icon_info;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicFinish(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_finish(icon_info, res, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicForContext(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gtk.GtkStyleContextHandle context, out bool was_symbolic)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_context(icon_info, context, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LoadSymbolicForContextAsync<T>(this T icon_info, MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_context_async(icon_info, context, cancellable, callback, user_data);
		return icon_info;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicForContextFinish(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_context_finish(icon_info, res, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicForStyle(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkStateType state, out bool was_symbolic)
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_style(icon_info, style, state, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetRawCoordinates<T>(this T icon_info, bool raw_coordinates) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid || icon_info.IsClosed) throw new Exception("Invalid or closed handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_set_raw_coordinates(icon_info, raw_coordinates);
		return icon_info;
	}

}

internal class GtkIconInfoHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_info_new_for_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_info_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_info_get_attach_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.Gdk.GdkPoint[] points, out int n_points);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_info_get_base_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_info_get_base_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_get_builtin_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_info_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_info_get_embedded_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.Gdk.GdkRectangle rectangle);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_info_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_info_is_symbolic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_load_icon_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_icon_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_info_load_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle for_window, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle fg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle success_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle warning_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle error_color, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_load_symbolic_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle fg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle success_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle warning_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle error_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_for_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_load_symbolic_for_context_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_for_context_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_for_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkStateType state, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_set_raw_coordinates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, bool raw_coordinates);

}
