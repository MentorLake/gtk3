namespace MentorLake.Gtk3.Gtk3;

public class GtkIconSetHandle : BaseSafeHandle
{
	public static GtkIconSetHandle New()
	{
		return GtkIconSetExterns.gtk_icon_set_new();
	}

	public static GtkIconSetHandle NewFromPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkIconSetExterns.gtk_icon_set_new_from_pixbuf(pixbuf);
	}

}


public static class GtkIconSetHandleExtensions
{
	public static T AddSource<T>(this T icon_set, GtkIconSourceHandle source) where T : GtkIconSetHandle
	{
		GtkIconSetExterns.gtk_icon_set_add_source(icon_set, source);
		return icon_set;
	}

	public static GtkIconSetHandle Copy(this GtkIconSetHandle icon_set)
	{
		return GtkIconSetExterns.gtk_icon_set_copy(icon_set);
	}

	public static T GetSizes<T>(this T icon_set, out GtkIconSize[] sizes, out int n_sizes) where T : GtkIconSetHandle
	{
		GtkIconSetExterns.gtk_icon_set_get_sizes(icon_set, out sizes, out n_sizes);
		return icon_set;
	}

	public static GtkIconSetHandle Ref(this GtkIconSetHandle icon_set)
	{
		return GtkIconSetExterns.gtk_icon_set_ref(icon_set);
	}

	public static GdkPixbufHandle RenderIcon(this GtkIconSetHandle icon_set, GtkStyleHandle style, GtkTextDirection direction, GtkStateType state, GtkIconSize size, GtkWidgetHandle widget, string detail)
	{
		return GtkIconSetExterns.gtk_icon_set_render_icon(icon_set, style, direction, state, size, widget, detail);
	}

	public static GdkPixbufHandle RenderIconPixbuf(this GtkIconSetHandle icon_set, GtkStyleContextHandle context, GtkIconSize size)
	{
		return GtkIconSetExterns.gtk_icon_set_render_icon_pixbuf(icon_set, context, size);
	}

	public static cairo_surface_tHandle RenderIconSurface(this GtkIconSetHandle icon_set, GtkStyleContextHandle context, GtkIconSize size, int scale, GdkWindowHandle for_window)
	{
		return GtkIconSetExterns.gtk_icon_set_render_icon_surface(icon_set, context, size, scale, for_window);
	}

	public static T Unref<T>(this T icon_set) where T : GtkIconSetHandle
	{
		GtkIconSetExterns.gtk_icon_set_unref(icon_set);
		return icon_set;
	}

}
internal class GtkIconSetExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_icon_set_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_icon_set_new_from_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_set_add_source(GtkIconSetHandle icon_set, GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_icon_set_copy(GtkIconSetHandle icon_set);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_set_get_sizes(GtkIconSetHandle icon_set, out GtkIconSize[] sizes, out int n_sizes);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_icon_set_ref(GtkIconSetHandle icon_set);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_set_render_icon(GtkIconSetHandle icon_set, GtkStyleHandle style, GtkTextDirection direction, GtkStateType state, GtkIconSize size, GtkWidgetHandle widget, string detail);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_set_render_icon_pixbuf(GtkIconSetHandle icon_set, GtkStyleContextHandle context, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_surface_tHandle gtk_icon_set_render_icon_surface(GtkIconSetHandle icon_set, GtkStyleContextHandle context, GtkIconSize size, int scale, GdkWindowHandle for_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_set_unref(GtkIconSetHandle icon_set);

}

public struct GtkIconSet
{
}
