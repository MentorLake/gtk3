namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Contains information found when looking up an icon in
/// an icon theme.
/// </para>
/// </summary>

public class GtkIconInfoHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a #GtkIconInfo for a #GdkPixbuf.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="pixbuf">
/// the pixbuf to wrap in a #GtkIconInfo
/// </param>
/// <return>
/// a #GtkIconInfo
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle NewForPixbuf(MentorLake.Gtk.GtkIconThemeHandle icon_theme, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkIconInfoHandleExterns.gtk_icon_info_new_for_pixbuf(icon_theme, pixbuf);
	}

}

public static class GtkIconInfoHandleExtensions
{
/// <summary>
/// <para>
/// Make a copy of a #GtkIconInfo.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// the new GtkIconInfo
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle Copy(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_copy(icon_info);
	}

/// <summary>
/// <para>
/// Free a #GtkIconInfo and associated information
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>

	public static T Free<T>(this T icon_info) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_free(icon_info);
		return icon_info;
	}

/// <summary>
/// <para>
/// This function is deprecated and always returns %FALSE.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <param name="points">
/// location to store pointer
///     to an array of points, or %NULL free the array of points with g_free().
/// </param>
/// <param name="n_points">
/// location to store the number of points in @points,
///     or %NULL
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool GetAttachPoints(this MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.Gdk.GdkPoint[] points, out int n_points)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_attach_points(icon_info, out points, out n_points);
	}

/// <summary>
/// <para>
/// Gets the base scale for the icon. The base scale is a scale
/// for the icon that was specified by the icon theme creator.
/// For instance an icon drawn for a high-dpi screen with window
/// scale 2 for a base size of 32 will be 64 pixels tall and have
/// a base scale of 2.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// the base scale
/// </return>

	public static int GetBaseScale(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_base_scale(icon_info);
	}

/// <summary>
/// <para>
/// Gets the base size for the icon. The base size
/// is a size for the icon that was specified by
/// the icon theme creator. This may be different
/// than the actual size of image; an example of
/// this is small emblem icons that can be attached
/// to a larger icon. These icons will be given
/// the same base size as the larger icons to which
/// they are attached.
/// </para>
/// <para>
/// Note that for scaled icons the base size does
/// not include the base scale.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// the base size, or 0, if no base
///     size is known for the icon.
/// </return>

	public static int GetBaseSize(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_base_size(icon_info);
	}

/// <summary>
/// <para>
/// Gets the built-in image for this icon, if any. To allow GTK+ to use
/// built in icon images, you must pass the %GTK_ICON_LOOKUP_USE_BUILTIN
/// to gtk_icon_theme_lookup_icon().
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// the built-in image pixbuf, or %NULL.
///     No extra reference is added to the returned pixbuf, so if
///     you want to keep it around, you must use g_object_ref().
///     The returned image must not be modified.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetBuiltinPixbuf(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_builtin_pixbuf(icon_info);
	}

/// <summary>
/// <para>
/// This function is deprecated and always returns %NULL.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// %NULL
/// </return>

	public static string GetDisplayName(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_display_name(icon_info);
	}

/// <summary>
/// <para>
/// This function is deprecated and always returns %FALSE.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <param name="rectangle">
/// #GdkRectangle in which to store embedded
///   rectangle coordinates; coordinates are only stored
///   when this function returns %TRUE.
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool GetEmbeddedRect(this MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.Gdk.GdkRectangle rectangle)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_embedded_rect(icon_info, out rectangle);
	}

/// <summary>
/// <para>
/// Gets the filename for the icon. If the %GTK_ICON_LOOKUP_USE_BUILTIN
/// flag was passed to gtk_icon_theme_lookup_icon(), there may be no
/// filename if a builtin icon is returned; in this case, you should
/// use gtk_icon_info_get_builtin_pixbuf().
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// the filename for the icon, or %NULL
///     if gtk_icon_info_get_builtin_pixbuf() should be used instead.
///     The return value is owned by GTK+ and should not be modified
///     or freed.
/// </return>

	public static string GetFilename(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_get_filename(icon_info);
	}

/// <summary>
/// <para>
/// Checks if the icon is symbolic or not. This currently uses only
/// the file name and not the file contents for determining this.
/// This behaviour may change in the future.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <return>
/// %TRUE if the icon is symbolic, %FALSE otherwise
/// </return>

	public static bool IsSymbolic(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		return GtkIconInfoHandleExterns.gtk_icon_info_is_symbolic(icon_info);
	}

/// <summary>
/// <para>
/// Renders an icon previously looked up in an icon theme using
/// gtk_icon_theme_lookup_icon(); the size will be based on the size
/// passed to gtk_icon_theme_lookup_icon(). Note that the resulting
/// pixbuf may not be exactly this size; an icon theme may have icons
/// that differ slightly from their nominal sizes, and in addition GTK+
/// will avoid scaling icons that it considers sufficiently close to the
/// requested size or for which the source image would have to be scaled
/// up too far. (This maintains sharpness.). This behaviour can be changed
/// by passing the %GTK_ICON_LOOKUP_FORCE_SIZE flag when obtaining
/// the #GtkIconInfo. If this flag has been specified, the pixbuf
/// returned by this function will be scaled to the exact size.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <return>
/// the rendered icon; this may be a newly
///     created icon or a new reference to an internal icon, so you must
///     not modify the icon. Use g_object_unref() to release your reference
///     to the icon.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIcon(this MentorLake.Gtk.GtkIconInfoHandle icon_info)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_icon(icon_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously load, render and scale an icon previously looked up
/// from the icon theme using gtk_icon_theme_lookup_icon().
/// </para>
/// <para>
/// For more details, see gtk_icon_info_load_icon() which is the synchronous
/// version of this call.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the
///     request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T LoadIconAsync<T>(this T icon_info, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_load_icon_async(icon_info, cancellable, callback, user_data);
		return icon_info;
	}

/// <summary>
/// <para>
/// Finishes an async icon load, see gtk_icon_info_load_icon_async().
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// the rendered icon; this may be a newly
///     created icon or a new reference to an internal icon, so you must
///     not modify the icon. Use g_object_unref() to release your reference
///     to the icon.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIconFinish(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_icon_finish(icon_info, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Renders an icon previously looked up in an icon theme using
/// gtk_icon_theme_lookup_icon(); the size will be based on the size
/// passed to gtk_icon_theme_lookup_icon(). Note that the resulting
/// surface may not be exactly this size; an icon theme may have icons
/// that differ slightly from their nominal sizes, and in addition GTK+
/// will avoid scaling icons that it considers sufficiently close to the
/// requested size or for which the source image would have to be scaled
/// up too far. (This maintains sharpness.). This behaviour can be changed
/// by passing the %GTK_ICON_LOOKUP_FORCE_SIZE flag when obtaining
/// the #GtkIconInfo. If this flag has been specified, the pixbuf
/// returned by this function will be scaled to the exact size.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="for_window">
/// #GdkWindow to optimize drawing for, or %NULL
/// </param>
/// <return>
/// the rendered icon; this may be a newly
///     created icon or a new reference to an internal icon, so you must
///     not modify the icon. Use cairo_surface_destroy() to release your
///     reference to the icon.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle LoadSurface(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gdk.GdkWindowHandle for_window)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_surface(icon_info, for_window, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads an icon, modifying it to match the system colours for the foreground,
/// success, warning and error colors provided. If the icon is not a symbolic
/// one, the function will return the result from gtk_icon_info_load_icon().
/// </para>
/// <para>
/// This allows loading symbolic icons that will match the system theme.
/// </para>
/// <para>
/// Unless you are implementing a widget, you will want to use
/// g_themed_icon_new_with_default_fallbacks() to load the icon.
/// </para>
/// <para>
/// As implementation details, the icon loaded needs to be of SVG type,
/// contain the “symbolic” term as the last component of the icon name,
/// and use the “fg”, “success”, “warning” and “error” CSS styles in the
/// SVG file itself.
/// </para>
/// <para>
/// See the [Symbolic Icons Specification](http://www.freedesktop.org/wiki/SymbolicIcons)
/// for more information about symbolic icons.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <param name="fg">
/// a #GdkRGBA representing the foreground color of the icon
/// </param>
/// <param name="success_color">
/// a #GdkRGBA representing the warning color
///     of the icon or %NULL to use the default color
/// </param>
/// <param name="warning_color">
/// a #GdkRGBA representing the warning color
///     of the icon or %NULL to use the default color
/// </param>
/// <param name="error_color">
/// a #GdkRGBA representing the error color
///     of the icon or %NULL to use the default color (allow-none)
/// </param>
/// <param name="was_symbolic">
/// a #gboolean, returns whether the
///     loaded icon was a symbolic one and whether the @fg color was
///     applied to it.
/// </param>
/// <return>
/// a #GdkPixbuf representing the loaded icon
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolic(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gdk.GdkRGBAHandle fg, MentorLake.Gdk.GdkRGBAHandle success_color, MentorLake.Gdk.GdkRGBAHandle warning_color, MentorLake.Gdk.GdkRGBAHandle error_color, out bool was_symbolic)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic(icon_info, fg, success_color, warning_color, error_color, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously load, render and scale a symbolic icon previously looked up
/// from the icon theme using gtk_icon_theme_lookup_icon().
/// </para>
/// <para>
/// For more details, see gtk_icon_info_load_symbolic() which is the synchronous
/// version of this call.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="fg">
/// a #GdkRGBA representing the foreground color of the icon
/// </param>
/// <param name="success_color">
/// a #GdkRGBA representing the warning color
///     of the icon or %NULL to use the default color
/// </param>
/// <param name="warning_color">
/// a #GdkRGBA representing the warning color
///     of the icon or %NULL to use the default color
/// </param>
/// <param name="error_color">
/// a #GdkRGBA representing the error color
///     of the icon or %NULL to use the default color (allow-none)
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///     %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the
///     request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T LoadSymbolicAsync<T>(this T icon_info, MentorLake.Gdk.GdkRGBAHandle fg, MentorLake.Gdk.GdkRGBAHandle success_color, MentorLake.Gdk.GdkRGBAHandle warning_color, MentorLake.Gdk.GdkRGBAHandle error_color, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_async(icon_info, fg, success_color, warning_color, error_color, cancellable, callback, user_data);
		return icon_info;
	}

/// <summary>
/// <para>
/// Finishes an async icon load, see gtk_icon_info_load_symbolic_async().
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <param name="was_symbolic">
/// a #gboolean, returns whether the
///     loaded icon was a symbolic one and whether the @fg color was
///     applied to it.
/// </param>
/// <return>
/// the rendered icon; this may be a newly
///     created icon or a new reference to an internal icon, so you must
///     not modify the icon. Use g_object_unref() to release your reference
///     to the icon.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicFinish(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_finish(icon_info, res, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads an icon, modifying it to match the system colors for the foreground,
/// success, warning and error colors provided. If the icon is not a symbolic
/// one, the function will return the result from gtk_icon_info_load_icon().
/// This function uses the regular foreground color and the symbolic colors
/// with the names “success_color”, “warning_color” and “error_color” from
/// the context.
/// </para>
/// <para>
/// This allows loading symbolic icons that will match the system theme.
/// </para>
/// <para>
/// See gtk_icon_info_load_symbolic() for more details.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="was_symbolic">
/// a #gboolean, returns whether the
///     loaded icon was a symbolic one and whether the @fg color was
///     applied to it.
/// </param>
/// <return>
/// a #GdkPixbuf representing the loaded icon
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicForContext(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gtk.GtkStyleContextHandle context, out bool was_symbolic)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_context(icon_info, context, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously load, render and scale a symbolic icon previously
/// looked up from the icon theme using gtk_icon_theme_lookup_icon().
/// </para>
/// <para>
/// For more details, see gtk_icon_info_load_symbolic_for_context()
/// which is the synchronous version of this call.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///     %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the
///     request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T LoadSymbolicForContextAsync<T>(this T icon_info, MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_context_async(icon_info, context, cancellable, callback, user_data);
		return icon_info;
	}

/// <summary>
/// <para>
/// Finishes an async icon load, see gtk_icon_info_load_symbolic_for_context_async().
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo from gtk_icon_theme_lookup_icon()
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <param name="was_symbolic">
/// a #gboolean, returns whether the
///     loaded icon was a symbolic one and whether the @fg color was
///     applied to it.
/// </param>
/// <return>
/// the rendered icon; this may be a newly
///     created icon or a new reference to an internal icon, so you must
///     not modify the icon. Use g_object_unref() to release your reference
///     to the icon.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicForContextFinish(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_context_finish(icon_info, res, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads an icon, modifying it to match the system colours for the foreground,
/// success, warning and error colors provided. If the icon is not a symbolic
/// one, the function will return the result from gtk_icon_info_load_icon().
/// </para>
/// <para>
/// This allows loading symbolic icons that will match the system theme.
/// </para>
/// <para>
/// See gtk_icon_info_load_symbolic() for more details.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <param name="style">
/// a #GtkStyle to take the colors from
/// </param>
/// <param name="state">
/// the widget state to use for colors
/// </param>
/// <param name="was_symbolic">
/// a #gboolean, returns whether the
///     loaded icon was a symbolic one and whether the @fg color was
///     applied to it.
/// </param>
/// <return>
/// a #GdkPixbuf representing the loaded icon
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadSymbolicForStyle(this MentorLake.Gtk.GtkIconInfoHandle icon_info, MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkStateType state, out bool was_symbolic)
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		var externCallResult = GtkIconInfoHandleExterns.gtk_icon_info_load_symbolic_for_style(icon_info, style, state, out was_symbolic, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets whether the coordinates returned by gtk_icon_info_get_embedded_rect()
/// and gtk_icon_info_get_attach_points() should be returned in their
/// original form as specified in the icon theme, instead of scaled
/// appropriately for the pixbuf returned by gtk_icon_info_load_icon().
/// </para>
/// <para>
/// Raw coordinates are somewhat strange; they are specified to be with
/// respect to the unscaled pixmap for PNG and XPM icons, but for SVG
/// icons, they are in a 1000x1000 coordinate space that is scaled
/// to the final size of the icon.  You can determine if the icon is an SVG
/// icon by using gtk_icon_info_get_filename(), and seeing if it is non-%NULL
/// and ends in “.svg”.
/// </para>
/// <para>
/// This function is provided primarily to allow compatibility wrappers
/// for older API's, and is not expected to be useful for applications.
/// </para>
/// </summary>

/// <param name="icon_info">
/// a #GtkIconInfo
/// </param>
/// <param name="raw_coordinates">
/// whether the coordinates of embedded rectangles
///     and attached points should be returned in their original
///     (unscaled) form.
/// </param>

	public static T SetRawCoordinates<T>(this T icon_info, bool raw_coordinates) where T : GtkIconInfoHandle
	{
		if (icon_info.IsInvalid) throw new Exception("Invalid handle (GtkIconInfoHandle)");
		GtkIconInfoHandleExterns.gtk_icon_info_set_raw_coordinates(icon_info, raw_coordinates);
		return icon_info;
	}

}

internal class GtkIconInfoHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_info_new_for_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_info_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_info_get_attach_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.Gdk.GdkPoint[] points, out int n_points);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_info_get_base_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_info_get_base_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_load_icon_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_icon_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_info_load_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle for_window, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle fg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle success_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle warning_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle error_color, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_load_symbolic_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle fg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle success_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle warning_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle error_color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_for_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_load_symbolic_for_context_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_for_context_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_info_load_symbolic_for_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkStateType state, out bool was_symbolic, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_info_set_raw_coordinates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))] MentorLake.Gtk.GtkIconInfoHandle icon_info, bool raw_coordinates);

}
