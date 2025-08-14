namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkCursor represents a cursor. Its contents are private.
/// </para>
/// </summary>

public class GdkCursorHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new cursor from the set of builtin cursors for the default display.
/// See gdk_cursor_new_for_display().
/// </para>
/// <para>
/// To make the cursor invisible, use %GDK_BLANK_CURSOR.
/// </para>
/// </summary>

/// <param name="cursor_type">
/// cursor to create
/// </param>
/// <return>
/// a new #GdkCursor
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle New(MentorLake.Gdk.GdkCursorType cursor_type)
	{
		return GdkCursorHandleExterns.gdk_cursor_new(cursor_type);
	}

/// <summary>
/// <para>
/// Creates a new cursor from the set of builtin cursors.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the cursor will be created
/// </param>
/// <param name="cursor_type">
/// cursor to create
/// </param>
/// <return>
/// a new #GdkCursor, or %NULL on failure
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle NewForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkCursorType cursor_type)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_for_display(display, cursor_type);
	}

/// <summary>
/// <para>
/// Creates a new cursor by looking up @name in the current cursor
/// theme.
/// </para>
/// <para>
/// A recommended set of cursor names that will work across different
/// platforms can be found in the CSS specification:
/// - "none"
/// - ![](default_cursor.png) "default"
/// - ![](help_cursor.png) "help"
/// - ![](pointer_cursor.png) "pointer"
/// - ![](context_menu_cursor.png) "context-menu"
/// - ![](progress_cursor.png) "progress"
/// - ![](wait_cursor.png) "wait"
/// - ![](cell_cursor.png) "cell"
/// - ![](crosshair_cursor.png) "crosshair"
/// - ![](text_cursor.png) "text"
/// - ![](vertical_text_cursor.png) "vertical-text"
/// - ![](alias_cursor.png) "alias"
/// - ![](copy_cursor.png) "copy"
/// - ![](no_drop_cursor.png) "no-drop"
/// - ![](move_cursor.png) "move"
/// - ![](not_allowed_cursor.png) "not-allowed"
/// - ![](grab_cursor.png) "grab"
/// - ![](grabbing_cursor.png) "grabbing"
/// - ![](all_scroll_cursor.png) "all-scroll"
/// - ![](col_resize_cursor.png) "col-resize"
/// - ![](row_resize_cursor.png) "row-resize"
/// - ![](n_resize_cursor.png) "n-resize"
/// - ![](e_resize_cursor.png) "e-resize"
/// - ![](s_resize_cursor.png) "s-resize"
/// - ![](w_resize_cursor.png) "w-resize"
/// - ![](ne_resize_cursor.png) "ne-resize"
/// - ![](nw_resize_cursor.png) "nw-resize"
/// - ![](sw_resize_cursor.png) "sw-resize"
/// - ![](se_resize_cursor.png) "se-resize"
/// - ![](ew_resize_cursor.png) "ew-resize"
/// - ![](ns_resize_cursor.png) "ns-resize"
/// - ![](nesw_resize_cursor.png) "nesw-resize"
/// - ![](nwse_resize_cursor.png) "nwse-resize"
/// - ![](zoom_in_cursor.png) "zoom-in"
/// - ![](zoom_out_cursor.png) "zoom-out"
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the cursor will be created
/// </param>
/// <param name="name">
/// the name of the cursor
/// </param>
/// <return>
/// a new #GdkCursor, or %NULL if there is no
///   cursor with the given name
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle NewFromName(MentorLake.Gdk.GdkDisplayHandle display, string name)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_from_name(display, name);
	}

/// <summary>
/// <para>
/// Creates a new cursor from a pixbuf.
/// </para>
/// <para>
/// Not all GDK backends support RGBA cursors. If they are not
/// supported, a monochrome approximation will be displayed.
/// The functions gdk_display_supports_cursor_alpha() and
/// gdk_display_supports_cursor_color() can be used to determine
/// whether RGBA cursors are supported;
/// gdk_display_get_default_cursor_size() and
/// gdk_display_get_maximal_cursor_size() give information about
/// cursor sizes.
/// </para>
/// <para>
/// If @x or @y are `-1`, the pixbuf must have
/// options named “x_hot” and “y_hot”, resp., containing
/// integer values between `0` and the width resp. height of
/// the pixbuf. (Since: 3.0)
/// </para>
/// <para>
/// On the X backend, support for RGBA cursors requires a
/// sufficently new version of the X Render extension.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the cursor will be created
/// </param>
/// <param name="pixbuf">
/// the #GdkPixbuf containing the cursor image
/// </param>
/// <param name="x">
/// the horizontal offset of the “hotspot” of the cursor.
/// </param>
/// <param name="y">
/// the vertical offset of the “hotspot” of the cursor.
/// </param>
/// <return>
/// a new #GdkCursor.
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle NewFromPixbuf(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int x, int y)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_from_pixbuf(display, pixbuf, x, y);
	}

/// <summary>
/// <para>
/// Creates a new cursor from a cairo image surface.
/// </para>
/// <para>
/// Not all GDK backends support RGBA cursors. If they are not
/// supported, a monochrome approximation will be displayed.
/// The functions gdk_display_supports_cursor_alpha() and
/// gdk_display_supports_cursor_color() can be used to determine
/// whether RGBA cursors are supported;
/// gdk_display_get_default_cursor_size() and
/// gdk_display_get_maximal_cursor_size() give information about
/// cursor sizes.
/// </para>
/// <para>
/// On the X backend, support for RGBA cursors requires a
/// sufficently new version of the X Render extension.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the cursor will be created
/// </param>
/// <param name="surface">
/// the cairo image surface containing the cursor pixel data
/// </param>
/// <param name="x">
/// the horizontal offset of the “hotspot” of the cursor
/// </param>
/// <param name="y">
/// the vertical offset of the “hotspot” of the cursor
/// </param>
/// <return>
/// a new #GdkCursor.
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle NewFromSurface(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.cairo.cairo_surface_tHandle surface, double x, double y)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_from_surface(display, surface, x, y);
	}

}

public static class GdkCursorHandleExtensions
{
/// <summary>
/// <para>
/// Returns the cursor type for this cursor.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor
/// </param>
/// <return>
/// a #GdkCursorType
/// </return>

	public static MentorLake.Gdk.GdkCursorType GetCursorType(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_cursor_type(cursor);
	}

/// <summary>
/// <para>
/// Returns the display on which the #GdkCursor is defined.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor.
/// </param>
/// <return>
/// the #GdkDisplay associated to @cursor
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_display(cursor);
	}

/// <summary>
/// <para>
/// Returns a #GdkPixbuf with the image used to display the cursor.
/// </para>
/// <para>
/// Note that depending on the capabilities of the windowing system and
/// on the cursor, GDK may not be able to obtain the image data. In this
/// case, %NULL is returned.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor
/// </param>
/// <return>
/// a #GdkPixbuf representing
///   @cursor, or %NULL
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetImage(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_image(cursor);
	}

/// <summary>
/// <para>
/// Returns a cairo image surface with the image used to display the cursor.
/// </para>
/// <para>
/// Note that depending on the capabilities of the windowing system and
/// on the cursor, GDK may not be able to obtain the image data. In this
/// case, %NULL is returned.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor
/// </param>
/// <param name="x_hot">
/// Location to store the hotspot x position,
///   or %NULL
/// </param>
/// <param name="y_hot">
/// Location to store the hotspot y position,
///   or %NULL
/// </param>
/// <return>
/// a #cairo_surface_t
///   representing @cursor, or %NULL
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle GetSurface(this MentorLake.Gdk.GdkCursorHandle cursor, out double x_hot, out double y_hot)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_surface(cursor, out x_hot, out y_hot);
	}

/// <summary>
/// <para>
/// Adds a reference to @cursor.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor
/// </param>
/// <return>
/// Same @cursor that was passed in
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle Ref(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_ref(cursor);
	}

/// <summary>
/// <para>
/// Removes a reference from @cursor, deallocating the cursor
/// if no references remain.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor
/// </param>

	public static T Unref<T>(this T cursor) where T : GdkCursorHandle
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		GdkCursorHandleExterns.gdk_cursor_unref(cursor);
		return cursor;
	}

}

internal class GdkCursorHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_new(MentorLake.Gdk.GdkCursorType cursor_type);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_new_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkCursorType cursor_type);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_new_from_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, string name);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_new_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int x, int y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_new_from_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x, double y);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkCursorType gdk_cursor_get_cursor_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_cursor_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_cursor_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gdk_cursor_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, out double x_hot, out double y_hot);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cursor_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

}
