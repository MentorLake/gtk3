namespace MentorLake.Gtk;

public class GtkIconSetHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkIconSetHandle New()
	{
		return GtkIconSetExterns.gtk_icon_set_new();
	}

	public static MentorLake.Gtk.GtkIconSetHandle NewFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkIconSetExterns.gtk_icon_set_new_from_pixbuf(pixbuf);
	}

}


public static class GtkIconSetExtensions
{
	public static void AddSource(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		GtkIconSetExterns.gtk_icon_set_add_source(icon_set, source);
	}

	public static MentorLake.Gtk.GtkIconSetHandle Copy(this MentorLake.Gtk.GtkIconSetHandle icon_set)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_copy(icon_set);
	}

	public static void GetSizes(this MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize[] sizes, out int n_sizes)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		GtkIconSetExterns.gtk_icon_set_get_sizes(icon_set, out sizes, out n_sizes);
	}

	public static MentorLake.Gtk.GtkIconSetHandle Ref(this MentorLake.Gtk.GtkIconSetHandle icon_set)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_ref(icon_set);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIcon(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, MentorLake.Gtk.GtkWidgetHandle widget, string detail)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_render_icon(icon_set, style, direction, state, size, widget, detail);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIconPixbuf(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSize size)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_render_icon_pixbuf(icon_set, context, size);
	}

	public static MentorLake.cairo.cairo_surface_tHandle RenderIconSurface(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSize size, int scale, MentorLake.Gdk.GdkWindowHandle for_window)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_render_icon_surface(icon_set, context, size, scale, for_window);
	}

	public static void Unref(this MentorLake.Gtk.GtkIconSetHandle icon_set)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		GtkIconSetExterns.gtk_icon_set_unref(icon_set);
	}


	public static GtkIconSet Dereference(this GtkIconSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconSet>(x.DangerousGetHandle());
}
internal class GtkIconSetExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_set_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_set_new_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_set_add_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_set_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_set_get_sizes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize[] sizes, out int n_sizes);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_set_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_set_render_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_set_render_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_set_render_icon_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSize size, int scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle for_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_set_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set);

}

public struct GtkIconSet
{
}
