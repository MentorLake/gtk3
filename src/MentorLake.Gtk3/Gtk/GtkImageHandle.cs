namespace MentorLake.Gtk;

public class GtkImageHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkImageHandle New()
	{
		return GtkImageHandleExterns.gtk_image_new();
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromAnimation(MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		return GtkImageHandleExterns.gtk_image_new_from_animation(animation);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromFile(string filename)
	{
		return GtkImageHandleExterns.gtk_image_new_from_file(filename);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromGicon(MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_gicon(icon, size);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromIconName(string icon_name, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_icon_name(icon_name, size);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromIconSet(MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_icon_set(icon_set, size);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkImageHandleExterns.gtk_image_new_from_pixbuf(pixbuf);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromResource(string resource_path)
	{
		return GtkImageHandleExterns.gtk_image_new_from_resource(resource_path);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromStock(string stock_id, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_stock(stock_id, size);
	}

	public static MentorLake.Gtk.GtkImageHandle NewFromSurface(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return GtkImageHandleExterns.gtk_image_new_from_surface(surface);
	}

}

public static class GtkImageHandleExtensions
{
	public static T Clear<T>(this T image) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_clear(image);
		return image;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle GetAnimation(this MentorLake.Gtk.GtkImageHandle image)
	{
		return GtkImageHandleExterns.gtk_image_get_animation(image);
	}

	public static T GetGicon<T>(this T image, out MentorLake.Gio.GIconHandle gicon, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_get_gicon(image, out gicon, out size);
		return image;
	}

	public static T GetIconName<T>(this T image, out string icon_name, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_get_icon_name(image, out icon_name, out size);
		return image;
	}

	public static T GetIconSet<T>(this T image, out MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_get_icon_set(image, out icon_set, out size);
		return image;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkImageHandle image)
	{
		return GtkImageHandleExterns.gtk_image_get_pixbuf(image);
	}

	public static int GetPixelSize(this MentorLake.Gtk.GtkImageHandle image)
	{
		return GtkImageHandleExterns.gtk_image_get_pixel_size(image);
	}

	public static T GetStock<T>(this T image, out string stock_id, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_get_stock(image, out stock_id, out size);
		return image;
	}

	public static MentorLake.Gtk.GtkImageType GetStorageType(this MentorLake.Gtk.GtkImageHandle image)
	{
		return GtkImageHandleExterns.gtk_image_get_storage_type(image);
	}

	public static T SetFromAnimation<T>(this T image, MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_animation(image, animation);
		return image;
	}

	public static T SetFromFile<T>(this T image, string filename) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_file(image, filename);
		return image;
	}

	public static T SetFromGicon<T>(this T image, MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_gicon(image, icon, size);
		return image;
	}

	public static T SetFromIconName<T>(this T image, string icon_name, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_icon_name(image, icon_name, size);
		return image;
	}

	public static T SetFromIconSet<T>(this T image, MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_icon_set(image, icon_set, size);
		return image;
	}

	public static T SetFromPixbuf<T>(this T image, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_pixbuf(image, pixbuf);
		return image;
	}

	public static T SetFromResource<T>(this T image, string resource_path) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_resource(image, resource_path);
		return image;
	}

	public static T SetFromStock<T>(this T image, string stock_id, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_stock(image, stock_id, size);
		return image;
	}

	public static T SetFromSurface<T>(this T image, MentorLake.cairo.cairo_surface_tHandle surface) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_from_surface(image, surface);
		return image;
	}

	public static T SetPixelSize<T>(this T image, int pixel_size) where T : GtkImageHandle
	{
		GtkImageHandleExterns.gtk_image_set_pixel_size(image, pixel_size);
		return image;
	}

}

internal class GtkImageHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_file(string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_icon_name(string icon_name, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_resource(string resource_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_stock(string stock_id, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gtk_image_get_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] out MentorLake.Gio.GIconHandle gicon, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, out string icon_name, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] out MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_image_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_image_get_pixel_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, out string stock_id, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageType gtk_image_get_storage_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, string icon_name, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, string resource_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, string stock_id, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_from_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_set_pixel_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, int pixel_size);

}
