namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkImage widget displays an image. Various kinds of object
/// can be displayed as an image; most typically, you would load a
/// #GdkPixbuf ("pixel buffer") from a file, and then display that.
/// There’s a convenience function to do this, gtk_image_new_from_file(),
/// used as follows:
/// |[<!-- language="C" -->
///   GtkWidget *image;
///   image = gtk_image_new_from_file ("myfile.png");
/// ]|
/// If the file isn’t loaded successfully, the image will contain a
/// “broken image” icon similar to that used in many web browsers.
/// If you want to handle errors in loading the file yourself,
/// for example by displaying an error message, then load the image with
/// gdk_pixbuf_new_from_file(), then create the #GtkImage with
/// gtk_image_new_from_pixbuf().
/// </para>
/// <para>
/// The image file may contain an animation, if so the #GtkImage will
/// display an animation (#GdkPixbufAnimation) instead of a static image.
/// </para>
/// <para>
/// #GtkImage is a subclass of #GtkMisc, which implies that you can
/// align it (center, left, right) and add padding to it, using
/// #GtkMisc methods.
/// </para>
/// <para>
/// #GtkImage is a “no window” widget (has no #GdkWindow of its own),
/// so by default does not receive events. If you want to receive events
/// on the image, such as button clicks, place the image inside a
/// #GtkEventBox, then connect to the event signals on the event box.
/// </para>
/// <para>
/// ## Handling button press events on a #GtkImage.
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   static gboolean
///   button_press_callback (GtkWidget      *event_box,
///                          GdkEventButton *event,
///                          gpointer        data)
///   {
///     g_print ("Event box clicked at coordinates %f,%f\n",
///              event->x, event->y);
/// </para>
/// <para>
///     // Returning TRUE means we handled the event, so the signal
///     // emission should be stopped (don’t call any further callbacks
///     // that may be connected). Return FALSE to continue invoking callbacks.
///     return TRUE;
///   }
/// </para>
/// <para>
///   static GtkWidget*
///   create_image (void)
///   {
///     GtkWidget *image;
///     GtkWidget *event_box;
/// </para>
/// <para>
///     image = gtk_image_new_from_file ("myfile.png");
/// </para>
/// <para>
///     event_box = gtk_event_box_new ();
/// </para>
/// <para>
///     gtk_container_add (GTK_CONTAINER (event_box), image);
/// </para>
/// <para>
///     g_signal_connect (G_OBJECT (event_box),
///                       "button_press_event",
///                       G_CALLBACK (button_press_callback),
///                       image);
/// </para>
/// <para>
///     return image;
///   }
/// ]|
/// </para>
/// <para>
/// When handling events on the event box, keep in mind that coordinates
/// in the image may be different from event box coordinates due to
/// the alignment and padding settings on the image (see #GtkMisc).
/// The simplest way to solve this is to set the alignment to 0.0
/// (left/top), and set the padding to zero. Then the origin of
/// the image will be the same as the origin of the event box.
/// </para>
/// <para>
/// Sometimes an application will want to avoid depending on external data
/// files, such as image files. GTK+ comes with a program to avoid this,
/// called “gdk-pixbuf-csource”. This library
/// allows you to convert an image into a C variable declaration, which
/// can then be loaded into a #GdkPixbuf using
/// gdk_pixbuf_new_from_inline().
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkImage has a single CSS node with the name image. The style classes
/// may appear on image CSS nodes: .icon-dropshadow, .lowres-icon.
/// </para>
/// </summary>

public class GtkImageHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new empty #GtkImage widget.
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkImage widget.
/// </return>

	public static MentorLake.Gtk.GtkImageHandle New()
	{
		return GtkImageHandleExterns.gtk_image_new();
	}

/// <summary>
/// <para>
/// Creates a #GtkImage displaying the given animation.
/// The #GtkImage does not assume a reference to the
/// animation; you still need to unref it if you own references.
/// #GtkImage will add its own reference rather than adopting yours.
/// </para>
/// <para>
/// Note that the animation frames are shown using a timeout with
/// #G_PRIORITY_DEFAULT. When using animations to indicate busyness,
/// keep in mind that the animation will only be shown if the main loop
/// is not busy with something that has a higher priority.
/// </para>
/// </summary>

/// <param name="animation">
/// an animation
/// </param>
/// <return>
/// a new #GtkImage widget
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromAnimation(MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		return GtkImageHandleExterns.gtk_image_new_from_animation(animation);
	}

/// <summary>
/// <para>
/// Creates a new #GtkImage displaying the file @filename. If the file
/// isn’t found or can’t be loaded, the resulting #GtkImage will
/// display a “broken image” icon. This function never returns %NULL,
/// it always returns a valid #GtkImage widget.
/// </para>
/// <para>
/// If the file contains an animation, the image will contain an
/// animation.
/// </para>
/// <para>
/// If you need to detect failures to load the file, use
/// gdk_pixbuf_new_from_file() to load the file yourself, then create
/// the #GtkImage from the pixbuf. (Or for animations, use
/// gdk_pixbuf_animation_new_from_file()).
/// </para>
/// <para>
/// The storage type (gtk_image_get_storage_type()) of the returned
/// image is not defined, it will be whatever is appropriate for
/// displaying the file.
/// </para>
/// </summary>

/// <param name="filename">
/// a filename
/// </param>
/// <return>
/// a new #GtkImage
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromFile(string filename)
	{
		return GtkImageHandleExterns.gtk_image_new_from_file(filename);
	}

/// <summary>
/// <para>
/// Creates a #GtkImage displaying an icon from the current icon theme.
/// If the icon name isn’t known, a “broken image” icon will be
/// displayed instead.  If the current icon theme is changed, the icon
/// will be updated appropriately.
/// </para>
/// </summary>

/// <param name="icon">
/// an icon
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>
/// <return>
/// a new #GtkImage displaying the themed icon
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromGicon(MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_gicon(icon, size);
	}

/// <summary>
/// <para>
/// Creates a #GtkImage displaying an icon from the current icon theme.
/// If the icon name isn’t known, a “broken image” icon will be
/// displayed instead.  If the current icon theme is changed, the icon
/// will be updated appropriately.
/// </para>
/// </summary>

/// <param name="icon_name">
/// an icon name or %NULL
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>
/// <return>
/// a new #GtkImage displaying the themed icon
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromIconName(string icon_name, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_icon_name(icon_name, size);
	}

/// <summary>
/// <para>
/// Creates a #GtkImage displaying an icon set. Sample stock sizes are
/// #GTK_ICON_SIZE_MENU, #GTK_ICON_SIZE_SMALL_TOOLBAR. Instead of using
/// this function, usually it’s better to create a #GtkIconFactory, put
/// your icon sets in the icon factory, add the icon factory to the
/// list of default factories with gtk_icon_factory_add_default(), and
/// then use gtk_image_new_from_stock(). This will allow themes to
/// override the icon you ship with your application.
/// </para>
/// <para>
/// The #GtkImage does not assume a reference to the
/// icon set; you still need to unref it if you own references.
/// #GtkImage will add its own reference rather than adopting yours.
/// </para>
/// </summary>

/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>
/// <return>
/// a new #GtkImage
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromIconSet(MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_icon_set(icon_set, size);
	}

/// <summary>
/// <para>
/// Creates a new #GtkImage displaying @pixbuf.
/// The #GtkImage does not assume a reference to the
/// pixbuf; you still need to unref it if you own references.
/// #GtkImage will add its own reference rather than adopting yours.
/// </para>
/// <para>
/// Note that this function just creates an #GtkImage from the pixbuf. The
/// #GtkImage created will not react to state changes. Should you want that,
/// you should use gtk_image_new_from_icon_name().
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a #GdkPixbuf, or %NULL
/// </param>
/// <return>
/// a new #GtkImage
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkImageHandleExterns.gtk_image_new_from_pixbuf(pixbuf);
	}

/// <summary>
/// <para>
/// Creates a new #GtkImage displaying the resource file @resource_path. If the file
/// isn’t found or can’t be loaded, the resulting #GtkImage will
/// display a “broken image” icon. This function never returns %NULL,
/// it always returns a valid #GtkImage widget.
/// </para>
/// <para>
/// If the file contains an animation, the image will contain an
/// animation.
/// </para>
/// <para>
/// If you need to detect failures to load the file, use
/// gdk_pixbuf_new_from_file() to load the file yourself, then create
/// the #GtkImage from the pixbuf. (Or for animations, use
/// gdk_pixbuf_animation_new_from_file()).
/// </para>
/// <para>
/// The storage type (gtk_image_get_storage_type()) of the returned
/// image is not defined, it will be whatever is appropriate for
/// displaying the file.
/// </para>
/// </summary>

/// <param name="resource_path">
/// a resource path
/// </param>
/// <return>
/// a new #GtkImage
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromResource(string resource_path)
	{
		return GtkImageHandleExterns.gtk_image_new_from_resource(resource_path);
	}

/// <summary>
/// <para>
/// Creates a #GtkImage displaying a stock icon. Sample stock icon
/// names are #GTK_STOCK_OPEN, #GTK_STOCK_QUIT. Sample stock sizes
/// are #GTK_ICON_SIZE_MENU, #GTK_ICON_SIZE_SMALL_TOOLBAR. If the stock
/// icon name isn’t known, the image will be empty.
/// You can register your own stock icon names, see
/// gtk_icon_factory_add_default() and gtk_icon_factory_add().
/// </para>
/// </summary>

/// <param name="stock_id">
/// a stock icon name
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>
/// <return>
/// a new #GtkImage displaying the stock icon
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromStock(string stock_id, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkImageHandleExterns.gtk_image_new_from_stock(stock_id, size);
	}

/// <summary>
/// <para>
/// Creates a new #GtkImage displaying @surface.
/// The #GtkImage does not assume a reference to the
/// surface; you still need to unref it if you own references.
/// #GtkImage will add its own reference rather than adopting yours.
/// </para>
/// </summary>

/// <param name="surface">
/// a #cairo_surface_t, or %NULL
/// </param>
/// <return>
/// a new #GtkImage
/// </return>

	public static MentorLake.Gtk.GtkImageHandle NewFromSurface(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return GtkImageHandleExterns.gtk_image_new_from_surface(surface);
	}

}

public static class GtkImageHandleExtensions
{
/// <summary>
/// <para>
/// Resets the image to be empty.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>

	public static T Clear<T>(this T image) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_clear(image);
		return image;
	}

/// <summary>
/// <para>
/// Gets the #GdkPixbufAnimation being displayed by the #GtkImage.
/// The storage type of the image must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_ANIMATION (see gtk_image_get_storage_type()).
/// The caller of this function does not own a reference to the
/// returned animation.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <return>
/// the displayed animation, or %NULL if
/// the image is empty
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle GetAnimation(this MentorLake.Gtk.GtkImageHandle image)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		return GtkImageHandleExterns.gtk_image_get_animation(image);
	}

/// <summary>
/// <para>
/// Gets the #GIcon and size being displayed by the #GtkImage.
/// The storage type of the image must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_GICON (see gtk_image_get_storage_type()).
/// The caller of this function does not own a reference to the
/// returned #GIcon.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="gicon">
/// place to store a
///     #GIcon, or %NULL
/// </param>
/// <param name="size">
/// place to store an icon size
///     (#GtkIconSize), or %NULL
/// </param>

	public static T GetGicon<T>(this T image, out MentorLake.Gio.GIconHandle gicon, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_get_gicon(image, out gicon, out size);
		return image;
	}

/// <summary>
/// <para>
/// Gets the icon name and size being displayed by the #GtkImage.
/// The storage type of the image must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_ICON_NAME (see gtk_image_get_storage_type()).
/// The returned string is owned by the #GtkImage and should not
/// be freed.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="icon_name">
/// place to store an
///     icon name, or %NULL
/// </param>
/// <param name="size">
/// place to store an icon size
///     (#GtkIconSize), or %NULL
/// </param>

	public static T GetIconName<T>(this T image, out string icon_name, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_get_icon_name(image, out icon_name, out size);
		return image;
	}

/// <summary>
/// <para>
/// Gets the icon set and size being displayed by the #GtkImage.
/// The storage type of the image must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_ICON_SET (see gtk_image_get_storage_type()).
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="icon_set">
/// location to store a
///     #GtkIconSet, or %NULL
/// </param>
/// <param name="size">
/// location to store a stock
///     icon size (#GtkIconSize), or %NULL
/// </param>

	public static T GetIconSet<T>(this T image, out MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_get_icon_set(image, out icon_set, out size);
		return image;
	}

/// <summary>
/// <para>
/// Gets the #GdkPixbuf being displayed by the #GtkImage.
/// The storage type of the image must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_PIXBUF (see gtk_image_get_storage_type()).
/// The caller of this function does not own a reference to the
/// returned pixbuf.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <return>
/// the displayed pixbuf, or %NULL if
/// the image is empty
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkImageHandle image)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		return GtkImageHandleExterns.gtk_image_get_pixbuf(image);
	}

/// <summary>
/// <para>
/// Gets the pixel size used for named icons.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <return>
/// the pixel size used for named icons.
/// </return>

	public static int GetPixelSize(this MentorLake.Gtk.GtkImageHandle image)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		return GtkImageHandleExterns.gtk_image_get_pixel_size(image);
	}

/// <summary>
/// <para>
/// Gets the stock icon name and size being displayed by the #GtkImage.
/// The storage type of the image must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_STOCK (see gtk_image_get_storage_type()).
/// The returned string is owned by the #GtkImage and should not
/// be freed.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="stock_id">
/// place to store a
///     stock icon name, or %NULL
/// </param>
/// <param name="size">
/// place to store a stock icon
///     size (#GtkIconSize), or %NULL
/// </param>

	public static T GetStock<T>(this T image, out string stock_id, out MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_get_stock(image, out stock_id, out size);
		return image;
	}

/// <summary>
/// <para>
/// Gets the type of representation being used by the #GtkImage
/// to store image data. If the #GtkImage has no image data,
/// the return value will be %GTK_IMAGE_EMPTY.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <return>
/// image representation being used
/// </return>

	public static MentorLake.Gtk.GtkImageType GetStorageType(this MentorLake.Gtk.GtkImageHandle image)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		return GtkImageHandleExterns.gtk_image_get_storage_type(image);
	}

/// <summary>
/// <para>
/// Causes the #GtkImage to display the given animation (or display
/// nothing, if you set the animation to %NULL).
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="animation">
/// the #GdkPixbufAnimation
/// </param>

	public static T SetFromAnimation<T>(this T image, MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_animation(image, animation);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_file() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="filename">
/// a filename or %NULL
/// </param>

	public static T SetFromFile<T>(this T image, string filename) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_file(image, filename);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_gicon() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="icon">
/// an icon
/// </param>
/// <param name="size">
/// an icon size (#GtkIconSize)
/// </param>

	public static T SetFromGicon<T>(this T image, MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_gicon(image, icon, size);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_icon_name() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="icon_name">
/// an icon name or %NULL
/// </param>
/// <param name="size">
/// an icon size (#GtkIconSize)
/// </param>

	public static T SetFromIconName<T>(this T image, string icon_name, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_icon_name(image, icon_name, size);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_icon_set() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="icon_set">
/// a #GtkIconSet
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>

	public static T SetFromIconSet<T>(this T image, MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_icon_set(image, icon_set, size);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_pixbuf() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf or %NULL
/// </param>

	public static T SetFromPixbuf<T>(this T image, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_pixbuf(image, pixbuf);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_resource() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="resource_path">
/// a resource path or %NULL
/// </param>

	public static T SetFromResource<T>(this T image, string resource_path) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_resource(image, resource_path);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_stock() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="stock_id">
/// a stock icon name
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>

	public static T SetFromStock<T>(this T image, string stock_id, MentorLake.Gtk.GtkIconSize size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_stock(image, stock_id, size);
		return image;
	}

/// <summary>
/// <para>
/// See gtk_image_new_from_surface() for details.
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="surface">
/// a cairo_surface_t or %NULL
/// </param>

	public static T SetFromSurface<T>(this T image, MentorLake.cairo.cairo_surface_tHandle surface) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_from_surface(image, surface);
		return image;
	}

/// <summary>
/// <para>
/// Sets the pixel size to use for named icons. If the pixel size is set
/// to a value != -1, it is used instead of the icon size set by
/// gtk_image_set_from_icon_name().
/// </para>
/// </summary>

/// <param name="image">
/// a #GtkImage
/// </param>
/// <param name="pixel_size">
/// the new pixel size
/// </param>

	public static T SetPixelSize<T>(this T image, int pixel_size) where T : GtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (GtkImageHandle)");
		GtkImageHandleExterns.gtk_image_set_pixel_size(image, pixel_size);
		return image;
	}

}

internal class GtkImageHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_file(string filename);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_icon_name(string icon_name, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_resource(string resource_path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_stock(string stock_id, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))]
	internal static extern MentorLake.Gtk.GtkImageHandle gtk_image_new_from_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gtk_image_get_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] out MentorLake.Gio.GIconHandle gicon, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, out string icon_name, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_get_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageHandle>))] MentorLake.Gtk.GtkImageHandle image, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] out MentorLake.Gtk.GtkIconSetHandle icon_set, out MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
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
