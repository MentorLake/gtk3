namespace MentorLake.Gtk3.Gtk3;

public class GtkImageHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkImageHandle New()
	{
		return GtkImageExterns.gtk_image_new();
	}

	public static GtkImageHandle NewFromAnimation(GdkPixbufAnimationHandle animation)
	{
		return GtkImageExterns.gtk_image_new_from_animation(animation);
	}

	public static GtkImageHandle NewFromFile(string filename)
	{
		return GtkImageExterns.gtk_image_new_from_file(filename);
	}

	public static GtkImageHandle NewFromGicon(GIconHandle icon, GtkIconSize size)
	{
		return GtkImageExterns.gtk_image_new_from_gicon(icon, size);
	}

	public static GtkImageHandle NewFromIconName(string icon_name, GtkIconSize size)
	{
		return GtkImageExterns.gtk_image_new_from_icon_name(icon_name, size);
	}

	public static GtkImageHandle NewFromIconSet(GtkIconSetHandle icon_set, GtkIconSize size)
	{
		return GtkImageExterns.gtk_image_new_from_icon_set(icon_set, size);
	}

	public static GtkImageHandle NewFromPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkImageExterns.gtk_image_new_from_pixbuf(pixbuf);
	}

	public static GtkImageHandle NewFromResource(string resource_path)
	{
		return GtkImageExterns.gtk_image_new_from_resource(resource_path);
	}

	public static GtkImageHandle NewFromStock(string stock_id, GtkIconSize size)
	{
		return GtkImageExterns.gtk_image_new_from_stock(stock_id, size);
	}

	public static GtkImageHandle NewFromSurface(cairo_surface_tHandle surface)
	{
		return GtkImageExterns.gtk_image_new_from_surface(surface);
	}

}

public static class GtkImageHandleExtensions
{
	public static GtkImageHandle Clear(this GtkImageHandle image)
	{
		GtkImageExterns.gtk_image_clear(image);
		return image;
	}

	public static GdkPixbufAnimationHandle GetAnimation(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_animation(image);
	}

	public static GtkImageHandle GetGicon(this GtkImageHandle image, out GIconHandle gicon, out GtkIconSize size)
	{
		GtkImageExterns.gtk_image_get_gicon(image, out gicon, out size);
		return image;
	}

	public static GtkImageHandle GetIconName(this GtkImageHandle image, out string icon_name, out GtkIconSize size)
	{
		GtkImageExterns.gtk_image_get_icon_name(image, out icon_name, out size);
		return image;
	}

	public static GtkImageHandle GetIconSet(this GtkImageHandle image, out GtkIconSetHandle icon_set, out GtkIconSize size)
	{
		GtkImageExterns.gtk_image_get_icon_set(image, out icon_set, out size);
		return image;
	}

	public static GdkPixbufHandle GetPixbuf(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_pixbuf(image);
	}

	public static int GetPixelSize(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_pixel_size(image);
	}

	public static GtkImageHandle GetStock(this GtkImageHandle image, out string stock_id, out GtkIconSize size)
	{
		GtkImageExterns.gtk_image_get_stock(image, out stock_id, out size);
		return image;
	}

	public static GtkImageType GetStorageType(this GtkImageHandle image)
	{
		return GtkImageExterns.gtk_image_get_storage_type(image);
	}

	public static GtkImageHandle SetFromAnimation(this GtkImageHandle image, GdkPixbufAnimationHandle animation)
	{
		GtkImageExterns.gtk_image_set_from_animation(image, animation);
		return image;
	}

	public static GtkImageHandle SetFromFile(this GtkImageHandle image, string filename)
	{
		GtkImageExterns.gtk_image_set_from_file(image, filename);
		return image;
	}

	public static GtkImageHandle SetFromGicon(this GtkImageHandle image, GIconHandle icon, GtkIconSize size)
	{
		GtkImageExterns.gtk_image_set_from_gicon(image, icon, size);
		return image;
	}

	public static GtkImageHandle SetFromIconName(this GtkImageHandle image, string icon_name, GtkIconSize size)
	{
		GtkImageExterns.gtk_image_set_from_icon_name(image, icon_name, size);
		return image;
	}

	public static GtkImageHandle SetFromIconSet(this GtkImageHandle image, GtkIconSetHandle icon_set, GtkIconSize size)
	{
		GtkImageExterns.gtk_image_set_from_icon_set(image, icon_set, size);
		return image;
	}

	public static GtkImageHandle SetFromPixbuf(this GtkImageHandle image, GdkPixbufHandle pixbuf)
	{
		GtkImageExterns.gtk_image_set_from_pixbuf(image, pixbuf);
		return image;
	}

	public static GtkImageHandle SetFromResource(this GtkImageHandle image, string resource_path)
	{
		GtkImageExterns.gtk_image_set_from_resource(image, resource_path);
		return image;
	}

	public static GtkImageHandle SetFromStock(this GtkImageHandle image, string stock_id, GtkIconSize size)
	{
		GtkImageExterns.gtk_image_set_from_stock(image, stock_id, size);
		return image;
	}

	public static GtkImageHandle SetFromSurface(this GtkImageHandle image, cairo_surface_tHandle surface)
	{
		GtkImageExterns.gtk_image_set_from_surface(image, surface);
		return image;
	}

	public static GtkImageHandle SetPixelSize(this GtkImageHandle image, int pixel_size)
	{
		GtkImageExterns.gtk_image_set_pixel_size(image, pixel_size);
		return image;
	}

}

internal class GtkImageExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_animation(GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_file(string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_gicon(GIconHandle icon, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_icon_name(string icon_name, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_icon_set(GtkIconSetHandle icon_set, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_resource(string resource_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_stock(string stock_id, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageHandle gtk_image_new_from_surface(cairo_surface_tHandle surface);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_clear(GtkImageHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufAnimationHandle gtk_image_get_animation(GtkImageHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_get_gicon(GtkImageHandle image, out GIconHandle gicon, out GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_get_icon_name(GtkImageHandle image, out string icon_name, out GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_get_icon_set(GtkImageHandle image, out GtkIconSetHandle icon_set, out GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_image_get_pixbuf(GtkImageHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_image_get_pixel_size(GtkImageHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_get_stock(GtkImageHandle image, out string stock_id, out GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageType gtk_image_get_storage_type(GtkImageHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_animation(GtkImageHandle image, GdkPixbufAnimationHandle animation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_file(GtkImageHandle image, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_gicon(GtkImageHandle image, GIconHandle icon, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_icon_name(GtkImageHandle image, string icon_name, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_icon_set(GtkImageHandle image, GtkIconSetHandle icon_set, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_pixbuf(GtkImageHandle image, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_resource(GtkImageHandle image, string resource_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_stock(GtkImageHandle image, string stock_id, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_from_surface(GtkImageHandle image, cairo_surface_tHandle surface);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_set_pixel_size(GtkImageHandle image, int pixel_size);

}
