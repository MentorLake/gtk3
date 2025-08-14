namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkIconTheme provides a facility for looking up icons by name
/// and size. The main reason for using a name rather than simply
/// providing a filename is to allow different icons to be used
/// depending on what “icon theme” is selected
/// by the user. The operation of icon themes on Linux and Unix
/// follows the [Icon Theme Specification](http://www.freedesktop.org/Standards/icon-theme-spec)
/// There is a fallback icon theme, named `hicolor`, where applications
/// should install their icons, but additional icon themes can be installed
/// as operating system vendors and users choose.
/// </para>
/// <para>
/// Named icons are similar to the deprecated [Stock Items][gtkstock],
/// and the distinction between the two may be a bit confusing.
/// A few things to keep in mind:
/// </para>
/// <para>
/// - Stock images usually are used in conjunction with
///   [Stock Items][gtkstock], such as %GTK_STOCK_OK or
///   %GTK_STOCK_OPEN. Named icons are easier to set up and therefore
///   are more useful for new icons that an application wants to
///   add, such as application icons or window icons.
/// </para>
/// <para>
/// - Stock images can only be loaded at the symbolic sizes defined
///   by the #GtkIconSize enumeration, or by custom sizes defined
///   by gtk_icon_size_register(), while named icons are more flexible
///   and any pixel size can be specified.
/// </para>
/// <para>
/// - Because stock images are closely tied to stock items, and thus
///   to actions in the user interface, stock images may come in
///   multiple variants for different widget states or writing
///   directions.
/// </para>
/// <para>
/// A good rule of thumb is that if there is a stock image for what
/// you want to use, use it, otherwise use a named icon. It turns
/// out that internally stock images are generally defined in
/// terms of one or more named icons. (An example of the
/// more than one case is icons that depend on writing direction;
/// %GTK_STOCK_GO_FORWARD uses the two themed icons
/// “gtk-stock-go-forward-ltr” and “gtk-stock-go-forward-rtl”.)
/// </para>
/// <para>
/// In many cases, named themes are used indirectly, via #GtkImage
/// or stock items, rather than directly, but looking up icons
/// directly is also simple. The #GtkIconTheme object acts
/// as a database of all the icons in the current theme. You
/// can create new #GtkIconTheme objects, but it’s much more
/// efficient to use the standard icon theme for the #GdkScreen
/// so that the icon information is shared with other people
/// looking up icons.
/// |[<!-- language="C" -->
/// GError *error = NULL;
/// GtkIconTheme *icon_theme;
/// GdkPixbuf *pixbuf;
/// </para>
/// <para>
/// icon_theme = gtk_icon_theme_get_default ();
/// pixbuf = gtk_icon_theme_load_icon (icon_theme,
///                                    "my-icon-name", // icon name
///                                    48, // icon size
///                                    0,  // flags
///                                    &error);
/// if (!pixbuf)
///   {
///     g_warning ("Couldn’t load icon: %s", error->message);
///     g_error_free (error);
///   }
/// else
///   {
///     // Use the pixbuf
///     g_object_unref (pixbuf);
///   }
/// ]|
/// </para>
/// </summary>

public class GtkIconThemeHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new icon theme object. Icon theme objects are used
/// to lookup up an icon by name in a particular icon theme.
/// Usually, you’ll want to use gtk_icon_theme_get_default()
/// or gtk_icon_theme_get_for_screen() rather than creating
/// a new icon theme object for scratch.
/// </para>
/// </summary>

/// <return>
/// the newly created #GtkIconTheme object.
/// </return>

	public static MentorLake.Gtk.GtkIconThemeHandle New()
	{
		return GtkIconThemeHandleExterns.gtk_icon_theme_new();
	}

/// <summary>
/// <para>
/// Registers a built-in icon for icon theme lookups. The idea
/// of built-in icons is to allow an application or library
/// that uses themed icons to function requiring files to
/// be present in the file system. For instance, the default
/// images for all of GTK+’s stock icons are registered
/// as built-icons.
/// </para>
/// <para>
/// In general, if you use gtk_icon_theme_add_builtin_icon()
/// you should also install the icon in the icon theme, so
/// that the icon is generally available.
/// </para>
/// <para>
/// This function will generally be used with pixbufs loaded
/// via gdk_pixbuf_new_from_inline().
/// </para>
/// </summary>

/// <param name="icon_name">
/// the name of the icon to register
/// </param>
/// <param name="size">
/// the size in pixels at which to register the icon (different
///     images can be registered for the same icon name at different sizes.)
/// </param>
/// <param name="pixbuf">
/// #GdkPixbuf that contains the image to use for @icon_name
/// </param>

	public static void AddBuiltinIcon(string icon_name, int size, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		GtkIconThemeHandleExterns.gtk_icon_theme_add_builtin_icon(icon_name, size, pixbuf);
	}

/// <summary>
/// <para>
/// Gets the icon theme for the default screen. See
/// gtk_icon_theme_get_for_screen().
/// </para>
/// </summary>

/// <return>
/// A unique #GtkIconTheme associated with
///     the default screen. This icon theme is associated with
///     the screen and can be used as long as the screen
///     is open. Do not ref or unref it.
/// </return>

	public static MentorLake.Gtk.GtkIconThemeHandle GetDefault()
	{
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_default();
	}

/// <summary>
/// <para>
/// Gets the icon theme object associated with @screen; if this
/// function has not previously been called for the given
/// screen, a new icon theme object will be created and
/// associated with the screen. Icon theme objects are
/// fairly expensive to create, so using this function
/// is usually a better choice than calling than gtk_icon_theme_new()
/// and setting the screen yourself; by using this function
/// a single icon theme object will be shared between users.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// A unique #GtkIconTheme associated with
///  the given screen. This icon theme is associated with
///  the screen and can be used as long as the screen
///  is open. Do not ref or unref it.
/// </return>

	public static MentorLake.Gtk.GtkIconThemeHandle GetForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_for_screen(screen);
	}

}
public static class GtkIconThemeHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the current icon theme is switched or GTK+ detects
/// that a change has occurred in the contents of the current
/// icon theme.
/// </para>
/// </summary>

	public static IObservable<GtkIconThemeHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkIconThemeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconThemeHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkIconThemeHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkIconThemeHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconThemeHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkIconThemeHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkIconThemeHandle Self;

	public IntPtr UserData;
}
}

public static class GtkIconThemeHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the current icon theme is switched or GTK+ detects
/// that a change has occurred in the contents of the current
/// icon theme.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle self, IntPtr user_data);

}


public static class GtkIconThemeHandleExtensions
{
/// <summary>
/// <para>
/// Adds a resource path that will be looked at when looking
/// for icons, similar to search paths.
/// </para>
/// <para>
/// This function should be used to make application-specific icons
/// available as part of the icon theme.
/// </para>
/// <para>
/// The resources are considered as part of the hicolor icon theme
/// and must be located in subdirectories that are defined in the
/// hicolor icon theme, such as `@path/16x16/actions/run.png`.
/// Icons that are directly placed in the resource path instead
/// of a subdirectory are also considered as ultimate fallback.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="path">
/// a resource path
/// </param>

	public static T AddResourcePath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_add_resource_path(icon_theme, path);
		return icon_theme;
	}

/// <summary>
/// <para>
/// Appends a directory to the search path.
/// See gtk_icon_theme_set_search_path().
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="path">
/// directory name to append to the icon path
/// </param>

	public static T AppendSearchPath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_append_search_path(icon_theme, path);
		return icon_theme;
	}

/// <summary>
/// <para>
/// Looks up a named icon and returns a #GtkIconInfo containing
/// information such as the filename of the icon. The icon
/// can then be rendered into a pixbuf using
/// gtk_icon_info_load_icon(). (gtk_icon_theme_load_icon()
/// combines these two steps if all you need is the pixbuf.)
/// </para>
/// <para>
/// If @icon_names contains more than one name, this function
/// tries them all in the given order before falling back to
/// inherited icon themes.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_names">
/// %NULL-terminated array of
///     icon names to lookup
/// </param>
/// <param name="size">
/// desired icon size
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// a #GtkIconInfo object
/// containing information about the icon, or %NULL if the icon wasn’t
/// found.
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle ChooseIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_choose_icon(icon_theme, icon_names, size, flags);
	}

/// <summary>
/// <para>
/// Looks up a named icon for a particular window scale and returns
/// a #GtkIconInfo containing information such as the filename of the
/// icon. The icon can then be rendered into a pixbuf using
/// gtk_icon_info_load_icon(). (gtk_icon_theme_load_icon()
/// combines these two steps if all you need is the pixbuf.)
/// </para>
/// <para>
/// If @icon_names contains more than one name, this function
/// tries them all in the given order before falling back to
/// inherited icon themes.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_names">
/// %NULL-terminated
///     array of icon names to lookup
/// </param>
/// <param name="size">
/// desired icon size
/// </param>
/// <param name="scale">
/// desired scale
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// a #GtkIconInfo object
///     containing information about the icon, or %NULL if the
///     icon wasn’t found.
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle ChooseIconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_choose_icon_for_scale(icon_theme, icon_names, size, scale, flags);
	}

/// <summary>
/// <para>
/// Gets the name of an icon that is representative of the
/// current theme (for instance, to use when presenting
/// a list of themes to the user.)
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <return>
/// the name of an example icon or %NULL.
///     Free with g_free().
/// </return>

	public static string GetExampleIconName(this MentorLake.Gtk.GtkIconThemeHandle icon_theme)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_example_icon_name(icon_theme);
	}

/// <summary>
/// <para>
/// Returns an array of integers describing the sizes at which
/// the icon is available without scaling. A size of -1 means
/// that the icon is available in a scalable format. The array
/// is zero-terminated.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of an icon
/// </param>
/// <return>
/// An newly
/// allocated array describing the sizes at which the icon is
/// available. The array should be freed with g_free() when it is no
/// longer needed.
/// </return>

	public static int[] GetIconSizes(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_icon_sizes(icon_theme, icon_name);
	}

/// <summary>
/// <para>
/// Gets the current search path. See gtk_icon_theme_set_search_path().
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="path">
/// 
///     location to store a list of icon theme path directories or %NULL.
///     The stored value should be freed with g_strfreev().
/// </param>
/// <param name="n_elements">
/// location to store number of elements in @path, or %NULL
/// </param>

	public static T GetSearchPath<T>(this T icon_theme, out string[] path, out int n_elements) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_get_search_path(icon_theme, out path, out n_elements);
		return icon_theme;
	}

/// <summary>
/// <para>
/// Checks whether an icon theme includes an icon
/// for a particular name.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of an icon
/// </param>
/// <return>
/// %TRUE if @icon_theme includes an
///  icon for @icon_name.
/// </return>

	public static bool HasIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_has_icon(icon_theme, icon_name);
	}

/// <summary>
/// <para>
/// Gets the list of contexts available within the current
/// hierarchy of icon themes.
/// See gtk_icon_theme_list_icons() for details about contexts.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <return>
/// a #GList list
///     holding the names of all the contexts in the theme. You must first
///     free each element in the list with g_free(), then free the list
///     itself with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle ListContexts(this MentorLake.Gtk.GtkIconThemeHandle icon_theme)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_list_contexts(icon_theme);
	}

/// <summary>
/// <para>
/// Lists the icons in the current icon theme. Only a subset
/// of the icons can be listed by providing a context string.
/// The set of values for the context string is system dependent,
/// but will typically include such values as “Applications” and
/// “MimeTypes”. Contexts are explained in the
/// [Icon Theme Specification](http://www.freedesktop.org/wiki/Specifications/icon-theme-spec).
/// The standard contexts are listed in the
/// [Icon Naming Specification](http://www.freedesktop.org/wiki/Specifications/icon-naming-spec).
/// Also see gtk_icon_theme_list_contexts().
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="context">
/// a string identifying a particular type of
///           icon, or %NULL to list all icons.
/// </param>
/// <return>
/// a #GList list
///     holding the names of all the icons in the theme. You must
///     first free each element in the list with g_free(), then
///     free the list itself with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle ListIcons(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string context)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_list_icons(icon_theme, context);
	}

/// <summary>
/// <para>
/// Looks up an icon in an icon theme, scales it to the given size
/// and renders it into a pixbuf. This is a convenience function;
/// if more details about the icon are needed, use
/// gtk_icon_theme_lookup_icon() followed by gtk_icon_info_load_icon().
/// </para>
/// <para>
/// Note that you probably want to listen for icon theme changes and
/// update the icon. This is usually done by connecting to the
/// GtkWidget::style-set signal. If for some reason you do not want to
/// update the icon when the icon theme changes, you should consider
/// using gdk_pixbuf_copy() to make a private copy of the pixbuf
/// returned by this function. Otherwise GTK+ may need to keep the old
/// icon theme loaded, which would be a waste of memory.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of the icon to lookup
/// </param>
/// <param name="size">
/// the desired icon size. The resulting icon may not be
///     exactly this size; see gtk_icon_info_load_icon().
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// the rendered icon; this may be
///     a newly created icon or a new reference to an internal icon, so
///     you must not modify the icon. Use g_object_unref() to release
///     your reference to the icon. %NULL if the icon isn’t found.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		var externCallResult = GtkIconThemeHandleExterns.gtk_icon_theme_load_icon(icon_theme, icon_name, size, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks up an icon in an icon theme for a particular window scale,
/// scales it to the given size and renders it into a pixbuf. This is a
/// convenience function; if more details about the icon are needed,
/// use gtk_icon_theme_lookup_icon() followed by
/// gtk_icon_info_load_icon().
/// </para>
/// <para>
/// Note that you probably want to listen for icon theme changes and
/// update the icon. This is usually done by connecting to the
/// GtkWidget::style-set signal. If for some reason you do not want to
/// update the icon when the icon theme changes, you should consider
/// using gdk_pixbuf_copy() to make a private copy of the pixbuf
/// returned by this function. Otherwise GTK+ may need to keep the old
/// icon theme loaded, which would be a waste of memory.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of the icon to lookup
/// </param>
/// <param name="size">
/// the desired icon size. The resulting icon may not be
///     exactly this size; see gtk_icon_info_load_icon().
/// </param>
/// <param name="scale">
/// desired scale
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// the rendered icon; this may be
///     a newly created icon or a new reference to an internal icon, so
///     you must not modify the icon. Use g_object_unref() to release
///     your reference to the icon. %NULL if the icon isn’t found.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		var externCallResult = GtkIconThemeHandleExterns.gtk_icon_theme_load_icon_for_scale(icon_theme, icon_name, size, scale, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks up an icon in an icon theme for a particular window scale,
/// scales it to the given size and renders it into a cairo surface. This is a
/// convenience function; if more details about the icon are needed,
/// use gtk_icon_theme_lookup_icon() followed by
/// gtk_icon_info_load_surface().
/// </para>
/// <para>
/// Note that you probably want to listen for icon theme changes and
/// update the icon. This is usually done by connecting to the
/// GtkWidget::style-set signal.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of the icon to lookup
/// </param>
/// <param name="size">
/// the desired icon size. The resulting icon may not be
///     exactly this size; see gtk_icon_info_load_icon().
/// </param>
/// <param name="scale">
/// desired scale
/// </param>
/// <param name="for_window">
/// #GdkWindow to optimize drawing for, or %NULL
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// the rendered icon; this may be
///     a newly created icon or a new reference to an internal icon, so
///     you must not modify the icon. Use cairo_surface_destroy() to
///     release your reference to the icon. %NULL if the icon isn’t
///     found.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle LoadSurface(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gdk.GdkWindowHandle for_window, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		var externCallResult = GtkIconThemeHandleExterns.gtk_icon_theme_load_surface(icon_theme, icon_name, size, scale, for_window, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks up an icon and returns a #GtkIconInfo containing information
/// such as the filename of the icon. The icon can then be rendered
/// into a pixbuf using gtk_icon_info_load_icon().
/// </para>
/// <para>
/// When rendering on displays with high pixel densities you should not
/// use a @size multiplied by the scaling factor returned by functions
/// like gdk_window_get_scale_factor(). Instead, you should use
/// gtk_icon_theme_lookup_by_gicon_for_scale(), as the assets loaded
/// for a given scaling factor may be different.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon">
/// the #GIcon to look up
/// </param>
/// <param name="size">
/// desired icon size
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// a #GtkIconInfo containing
///     information about the icon, or %NULL if the icon wasn’t
///     found. Unref with g_object_unref()
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle LookupByGicon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, MentorLake.Gio.GIconHandle icon, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_by_gicon(icon_theme, icon, size, flags);
	}

/// <summary>
/// <para>
/// Looks up an icon and returns a #GtkIconInfo containing information
/// such as the filename of the icon. The icon can then be rendered into
/// a pixbuf using gtk_icon_info_load_icon().
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon">
/// the #GIcon to look up
/// </param>
/// <param name="size">
/// desired icon size
/// </param>
/// <param name="scale">
/// the desired scale
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// a #GtkIconInfo containing
///     information about the icon, or %NULL if the icon wasn’t
///     found. Unref with g_object_unref()
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle LookupByGiconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, MentorLake.Gio.GIconHandle icon, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_by_gicon_for_scale(icon_theme, icon, size, scale, flags);
	}

/// <summary>
/// <para>
/// Looks up a named icon and returns a #GtkIconInfo containing
/// information such as the filename of the icon. The icon
/// can then be rendered into a pixbuf using
/// gtk_icon_info_load_icon(). (gtk_icon_theme_load_icon()
/// combines these two steps if all you need is the pixbuf.)
/// </para>
/// <para>
/// When rendering on displays with high pixel densities you should not
/// use a @size multiplied by the scaling factor returned by functions
/// like gdk_window_get_scale_factor(). Instead, you should use
/// gtk_icon_theme_lookup_icon_for_scale(), as the assets loaded
/// for a given scaling factor may be different.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of the icon to lookup
/// </param>
/// <param name="size">
/// desired icon size
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// a #GtkIconInfo object
///     containing information about the icon, or %NULL if the
///     icon wasn’t found.
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle LookupIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_icon(icon_theme, icon_name, size, flags);
	}

/// <summary>
/// <para>
/// Looks up a named icon for a particular window scale and returns a
/// #GtkIconInfo containing information such as the filename of the
/// icon. The icon can then be rendered into a pixbuf using
/// gtk_icon_info_load_icon(). (gtk_icon_theme_load_icon() combines
/// these two steps if all you need is the pixbuf.)
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="icon_name">
/// the name of the icon to lookup
/// </param>
/// <param name="size">
/// desired icon size
/// </param>
/// <param name="scale">
/// the desired scale
/// </param>
/// <param name="flags">
/// flags modifying the behavior of the icon lookup
/// </param>
/// <return>
/// a #GtkIconInfo object
///     containing information about the icon, or %NULL if the
///     icon wasn’t found.
/// </return>

	public static MentorLake.Gtk.GtkIconInfoHandle LookupIconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_icon_for_scale(icon_theme, icon_name, size, scale, flags);
	}

/// <summary>
/// <para>
/// Prepends a directory to the search path.
/// See gtk_icon_theme_set_search_path().
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="path">
/// directory name to prepend to the icon path
/// </param>

	public static T PrependSearchPath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_prepend_search_path(icon_theme, path);
		return icon_theme;
	}

/// <summary>
/// <para>
/// Checks to see if the icon theme has changed; if it has, any
/// currently cached information is discarded and will be reloaded
/// next time @icon_theme is accessed.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <return>
/// %TRUE if the icon theme has changed and needed
///     to be reloaded.
/// </return>

	public static bool RescanIfNeeded(this MentorLake.Gtk.GtkIconThemeHandle icon_theme)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_rescan_if_needed(icon_theme);
	}

/// <summary>
/// <para>
/// Sets the name of the icon theme that the #GtkIconTheme object uses
/// overriding system configuration. This function cannot be called
/// on the icon theme objects returned from gtk_icon_theme_get_default()
/// and gtk_icon_theme_get_for_screen().
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="theme_name">
/// name of icon theme to use instead of
///   configured theme, or %NULL to unset a previously set custom theme
/// </param>

	public static T SetCustomTheme<T>(this T icon_theme, string theme_name) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_set_custom_theme(icon_theme, theme_name);
		return icon_theme;
	}

/// <summary>
/// <para>
/// Sets the screen for an icon theme; the screen is used
/// to track the user’s currently configured icon theme,
/// which might be different for different screens.
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static T SetScreen<T>(this T icon_theme, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_set_screen(icon_theme, screen);
		return icon_theme;
	}

/// <summary>
/// <para>
/// Sets the search path for the icon theme object. When looking
/// for an icon theme, GTK+ will search for a subdirectory of
/// one or more of the directories in @path with the same name
/// as the icon theme containing an index.theme file. (Themes from
/// multiple of the path elements are combined to allow themes to be
/// extended by adding icons in the user’s home directory.)
/// </para>
/// <para>
/// In addition if an icon found isn’t found either in the current
/// icon theme or the default icon theme, and an image file with
/// the right name is found directly in one of the elements of
/// @path, then that image will be used for the icon name.
/// (This is legacy feature, and new icons should be put
/// into the fallback icon theme, which is called hicolor,
/// rather than directly on the icon path.)
/// </para>
/// </summary>

/// <param name="icon_theme">
/// a #GtkIconTheme
/// </param>
/// <param name="path">
/// array of
///     directories that are searched for icon themes
/// </param>
/// <param name="n_elements">
/// number of elements in @path.
/// </param>

	public static T SetSearchPath<T>(this T icon_theme, string[] path, int n_elements) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_set_search_path(icon_theme, path, n_elements);
		return icon_theme;
	}

}

internal class GtkIconThemeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))]
	internal static extern MentorLake.Gtk.GtkIconThemeHandle gtk_icon_theme_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_add_resource_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_append_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_choose_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_choose_icon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_theme_get_example_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme);

	[DllImport(GtkLibrary.Name)]
	internal static extern int[] gtk_icon_theme_get_icon_sizes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_get_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out string[] path, out int n_elements);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_theme_has_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_icon_theme_list_contexts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_icon_theme_list_icons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_theme_load_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_theme_load_icon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_theme_load_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle for_window, MentorLake.Gtk.GtkIconLookupFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_by_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, int size, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_by_gicon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_icon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_prepend_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_theme_rescan_if_needed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_set_custom_theme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string theme_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_set_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] path, int n_elements);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_add_builtin_icon(string icon_name, int size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))]
	internal static extern MentorLake.Gtk.GtkIconThemeHandle gtk_icon_theme_get_default();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))]
	internal static extern MentorLake.Gtk.GtkIconThemeHandle gtk_icon_theme_get_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}
