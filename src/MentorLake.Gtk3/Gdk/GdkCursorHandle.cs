namespace MentorLake.Gdk;

public class GdkCursorHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkCursorHandle New(MentorLake.Gdk.GdkCursorType cursor_type)
	{
		return GdkCursorHandleExterns.gdk_cursor_new(cursor_type);
	}

	public static MentorLake.Gdk.GdkCursorHandle NewForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkCursorType cursor_type)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_for_display(display, cursor_type);
	}

	public static MentorLake.Gdk.GdkCursorHandle NewFromName(MentorLake.Gdk.GdkDisplayHandle display, string name)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_from_name(display, name);
	}

	public static MentorLake.Gdk.GdkCursorHandle NewFromPixbuf(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int x, int y)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_from_pixbuf(display, pixbuf, x, y);
	}

	public static MentorLake.Gdk.GdkCursorHandle NewFromSurface(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.cairo.cairo_surface_tHandle surface, double x, double y)
	{
		return GdkCursorHandleExterns.gdk_cursor_new_from_surface(display, surface, x, y);
	}

}

public static class GdkCursorHandleExtensions
{
	public static MentorLake.Gdk.GdkCursorType GetCursorType(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_cursor_type(cursor);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_display(cursor);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetImage(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_image(cursor);
	}

	public static MentorLake.cairo.cairo_surface_tHandle GetSurface(this MentorLake.Gdk.GdkCursorHandle cursor, out double x_hot, out double y_hot)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_get_surface(cursor, out x_hot, out y_hot);
	}

	public static MentorLake.Gdk.GdkCursorHandle Ref(this MentorLake.Gdk.GdkCursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkCursorHandle)");
		return GdkCursorHandleExterns.gdk_cursor_ref(cursor);
	}

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_cursor_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gdk_cursor_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, out double x_hot, out double y_hot);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_cursor_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cursor_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

}
