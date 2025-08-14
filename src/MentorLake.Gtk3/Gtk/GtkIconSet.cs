namespace MentorLake.Gtk;


public class GtkIconSetHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkIconSet. A #GtkIconSet represents a single icon
/// in various sizes and widget states. It can provide a #GdkPixbuf
/// for a given size and state on request, and automatically caches
/// some of the rendered #GdkPixbuf objects.
/// </para>
/// <para>
/// Normally you would use gtk_widget_render_icon_pixbuf() instead of
/// using #GtkIconSet directly. The one case where you’d use
/// #GtkIconSet is to create application-specific icon sets to place in
/// a #GtkIconFactory.
/// </para>
/// </summary>

/// <return>
/// a new #GtkIconSet
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle New()
	{
		return GtkIconSetExterns.gtk_icon_set_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkIconSet with @pixbuf as the default/fallback
/// source image. If you don’t add any additional #GtkIconSource to the
/// icon set, all variants of the icon will be created from @pixbuf,
/// using scaling, pixelation, etc. as required to adjust the icon size
/// or make the icon look insensitive/prelighted.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>
/// <return>
/// a new #GtkIconSet
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle NewFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkIconSetExterns.gtk_icon_set_new_from_pixbuf(pixbuf);
	}

}


public static class GtkIconSetExtensions
{
/// <summary>
/// <para>
/// Icon sets have a list of #GtkIconSource, which they use as base
/// icons for rendering icons in different states and sizes. Icons are
/// scaled, made to look insensitive, etc. in
/// gtk_icon_set_render_icon(), but #GtkIconSet needs base images to
/// work with. The base images and when to use them are described by
/// a #GtkIconSource.
/// </para>
/// <para>
/// This function copies @source, so you can reuse the same source immediately
/// without affecting the icon set.
/// </para>
/// <para>
/// An example of when you’d use this function: a web browser’s "Back
/// to Previous Page" icon might point in a different direction in
/// Hebrew and in English; it might look different when insensitive;
/// and it might change size depending on toolbar mode (small/large
/// icons). So a single icon set would contain all those variants of
/// the icon, and you might add a separate source for each one.
/// </para>
/// <para>
/// You should nearly always add a “default” icon source with all
/// fields wildcarded, which will be used as a fallback if no more
/// specific source matches. #GtkIconSet always prefers more specific
/// icon sources to more generic icon sources. The order in which you
/// add the sources to the icon set does not matter.
/// </para>
/// <para>
/// gtk_icon_set_new_from_pixbuf() creates a new icon set with a
/// default icon source based on the given pixbuf.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="source">
/// a #GtkIconSource
/// </param>

	public static void AddSource(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		GtkIconSetExterns.gtk_icon_set_add_source(icon_set, source);
	}

/// <summary>
/// <para>
/// Copies @icon_set by value.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <return>
/// a new #GtkIconSet identical to the first.
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle Copy(this MentorLake.Gtk.GtkIconSetHandle icon_set)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_copy(icon_set);
	}

/// <summary>
/// <para>
/// Obtains a list of icon sizes this icon set can render. The returned
/// array must be freed with g_free().
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="sizes">
/// return location
///     for array of sizes (#GtkIconSize)
/// </param>
/// <param name="n_sizes">
/// location to store number of elements in returned array
/// </param>

	public static void GetSizes(this MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize[] sizes, out int n_sizes)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		GtkIconSetExterns.gtk_icon_set_get_sizes(icon_set, out sizes, out n_sizes);
	}

/// <summary>
/// <para>
/// Increments the reference count on @icon_set.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet.
/// </param>
/// <return>
/// @icon_set.
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle Ref(this MentorLake.Gtk.GtkIconSetHandle icon_set)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_ref(icon_set);
	}

/// <summary>
/// <para>
/// Renders an icon using gtk_style_render_icon(). In most cases,
/// gtk_widget_render_icon() is better, since it automatically provides
/// most of the arguments from the current widget settings.  This
/// function never returns %NULL; if the icon can’t be rendered
/// (perhaps because an image file fails to load), a default "missing
/// image" icon will be returned instead.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="style">
/// a #GtkStyle associated with @widget, or %NULL
/// </param>
/// <param name="direction">
/// text direction
/// </param>
/// <param name="state">
/// widget state
/// </param>
/// <param name="size">
/// icon size (#GtkIconSize). A size of `(GtkIconSize)-1`
///        means render at the size of the source and don’t scale.
/// </param>
/// <param name="widget">
/// widget that will display the icon, or %NULL.
///          The only use that is typically made of this
///          is to determine the appropriate #GdkScreen.
/// </param>
/// <param name="detail">
/// detail to pass to the theme engine, or %NULL.
///          Note that passing a detail of anything but %NULL
///          will disable caching.
/// </param>
/// <return>
/// a #GdkPixbuf to be displayed
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIcon(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, MentorLake.Gtk.GtkWidgetHandle widget, string detail)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_render_icon(icon_set, style, direction, state, size, widget, detail);
	}

/// <summary>
/// <para>
/// Renders an icon using gtk_render_icon_pixbuf(). In most cases,
/// gtk_widget_render_icon_pixbuf() is better, since it automatically provides
/// most of the arguments from the current widget settings.  This
/// function never returns %NULL; if the icon can’t be rendered
/// (perhaps because an image file fails to load), a default "missing
/// image" icon will be returned instead.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="size">
/// icon size (#GtkIconSize). A size of `(GtkIconSize)-1`
///        means render at the size of the source and don’t scale.
/// </param>
/// <return>
/// a #GdkPixbuf to be displayed
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIconPixbuf(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSize size)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_render_icon_pixbuf(icon_set, context, size);
	}

/// <summary>
/// <para>
/// Renders an icon using gtk_render_icon_pixbuf() and converts it to a
/// cairo surface.
/// </para>
/// <para>
/// This function never returns %NULL; if the icon can’t be rendered
/// (perhaps because an image file fails to load), a default "missing
/// image" icon will be returned instead.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="size">
/// icon size (#GtkIconSize). A size of `(GtkIconSize)-1`
///        means render at the size of the source and don’t scale.
/// </param>
/// <param name="scale">
/// the window scale to render for
/// </param>
/// <param name="for_window">
/// #GdkWindow to optimize drawing for, or %NULL
/// </param>
/// <return>
/// a #cairo_surface_t to be displayed
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle RenderIconSurface(this MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSize size, int scale, MentorLake.Gdk.GdkWindowHandle for_window)
	{
		if (icon_set.IsInvalid) throw new Exception("Invalid handle (GtkIconSet)");
		return GtkIconSetExterns.gtk_icon_set_render_icon_surface(icon_set, context, size, scale, for_window);
	}

/// <summary>
/// <para>
/// Decrements the reference count on @icon_set, and frees memory
/// if the reference count reaches 0.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>

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
	internal static extern void gtk_icon_set_get_sizes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.Gtk.GtkIconSize[] sizes, out int n_sizes);

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
