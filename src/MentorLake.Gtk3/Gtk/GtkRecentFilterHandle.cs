namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkRecentFilter can be used to restrict the files being shown
/// in a #GtkRecentChooser.  Files can be filtered based on their name
/// (with gtk_recent_filter_add_pattern()), on their mime type (with
/// gtk_file_filter_add_mime_type()), on the application that has
/// registered them (with gtk_recent_filter_add_application()), or by
/// a custom filter function (with gtk_recent_filter_add_custom()).
/// </para>
/// <para>
/// Filtering by mime type handles aliasing and subclassing of mime
/// types; e.g. a filter for text/plain also matches a file with mime
/// type application/rtf, since application/rtf is a subclass of text/plain.
/// Note that #GtkRecentFilter allows wildcards for the subtype of a
/// mime type, so you can e.g. filter for image/\*.
/// </para>
/// <para>
/// Normally, filters are used by adding them to a #GtkRecentChooser,
/// see gtk_recent_chooser_add_filter(), but it is also possible to
/// manually use a filter on a file with gtk_recent_filter_filter().
/// </para>
/// <para>
/// Recently used files are supported since GTK+ 2.10.
/// </para>
/// <para>
/// ## GtkRecentFilter as GtkBuildable
/// </para>
/// <para>
/// The GtkRecentFilter implementation of the GtkBuildable interface
/// supports adding rules using the `&amp;lt;mime-types&amp;gt;`, `&amp;lt;patterns&amp;gt;` and
/// `&amp;lt;applications&amp;gt;` elements and listing the rules within. Specifying
/// a `&amp;lt;mime-type&amp;gt;`, `&amp;lt;pattern&amp;gt;` or `&amp;lt;application&amp;gt;` has the same effect as
/// calling gtk_recent_filter_add_mime_type(),
/// gtk_recent_filter_add_pattern() or gtk_recent_filter_add_application().
/// </para>
/// <para>
/// An example of a UI definition fragment specifying `GtkRecentFilter`
/// rules:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkRecentFilter&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkRecentFilter&quot;&amp;gt;
///   &amp;lt;mime-types&amp;gt;
///     &amp;lt;mime-type&amp;gt;text/plain&amp;lt;/mime-type&amp;gt;
///     &amp;lt;mime-type&amp;gt;image/png&amp;lt;/mime-type&amp;gt;
///   &amp;lt;/mime-types&amp;gt;
///   &amp;lt;patterns&amp;gt;
///     &amp;lt;pattern&amp;gt;*.txt&amp;lt;/pattern&amp;gt;
///     &amp;lt;pattern&amp;gt;*.png&amp;lt;/pattern&amp;gt;
///   &amp;lt;/patterns&amp;gt;
///   &amp;lt;applications&amp;gt;
///     &amp;lt;application&amp;gt;gimp&amp;lt;/application&amp;gt;
///     &amp;lt;application&amp;gt;gedit&amp;lt;/application&amp;gt;
///     &amp;lt;application&amp;gt;glade&amp;lt;/application&amp;gt;
///   &amp;lt;/applications&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// </summary>

public class GtkRecentFilterHandle : GInitiallyUnownedHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRecentFilter with no rules added to it.
/// Such filter does not accept any recently used resources, so is not
/// particularly useful until you add rules with
/// gtk_recent_filter_add_pattern(), gtk_recent_filter_add_mime_type(),
/// gtk_recent_filter_add_application(), gtk_recent_filter_add_age().
/// To create a filter that accepts any recently used resource, use:
/// <code>
/// GtkRecentFilter *filter = gtk_recent_filter_new ();
/// GtkRecentFilter *filter = gtk_recent_filter_new ();
/// gtk_recent_filter_add_pattern (filter, &quot;*&quot;);
/// </code>
/// </para>
/// </summary>

/// <return>
/// a new #GtkRecentFilter
/// </return>

	public static MentorLake.Gtk.GtkRecentFilterHandle New()
	{
		return GtkRecentFilterHandleExterns.gtk_recent_filter_new();
	}

}

public static class GtkRecentFilterHandleExtensions
{
/// <summary>
/// <para>
/// Adds a rule that allows resources based on their age - that is, the number
/// of days elapsed since they were last modified.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="days">
/// number of days
/// </param>

	public static T AddAge<T>(this T filter, int days) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_age(filter, days);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule that allows resources based on the name of the application
/// that has registered them.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="application">
/// an application name
/// </param>

	public static T AddApplication<T>(this T filter, string application) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_application(filter, application);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule to a filter that allows resources based on a custom callback
/// function. The bitfield @needed which is passed in provides information
/// about what sorts of information that the filter function needs;
/// this allows GTK+ to avoid retrieving expensive information when
/// it isn’t needed by the filter.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="needed">
/// bitfield of flags indicating the information that the custom
///          filter function needs.
/// </param>
/// <param name="func">
/// callback function; if the function returns %TRUE, then
///   the file will be displayed.
/// </param>
/// <param name="data">
/// data to pass to @func
/// </param>
/// <param name="data_destroy">
/// function to call to free @data when it is no longer needed.
/// </param>

	public static T AddCustom<T>(this T filter, MentorLake.Gtk.GtkRecentFilterFlags needed, MentorLake.Gtk.GtkRecentFilterFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_custom(filter, needed, func, data, data_destroy);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule that allows resources based on the name of the group
/// to which they belong
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="group">
/// a group name
/// </param>

	public static T AddGroup<T>(this T filter, string group) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_group(filter, group);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule that allows resources based on their registered MIME type.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="mime_type">
/// a MIME type
/// </param>

	public static T AddMimeType<T>(this T filter, string mime_type) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_mime_type(filter, mime_type);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule that allows resources based on a pattern matching their
/// display name.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="pattern">
/// a file pattern
/// </param>

	public static T AddPattern<T>(this T filter, string pattern) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_pattern(filter, pattern);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule allowing image files in the formats supported
/// by GdkPixbuf.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>

	public static T AddPixbufFormats<T>(this T filter) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_pixbuf_formats(filter);
		return filter;
	}

/// <summary>
/// <para>
/// Tests whether a file should be displayed according to @filter.
/// The #GtkRecentFilterInfo @filter_info should include
/// the fields returned from gtk_recent_filter_get_needed(), and
/// must set the #GtkRecentFilterInfo.contains field of @filter_info
/// to indicate which fields have been set.
/// </para>
/// <para>
/// This function will not typically be used by applications; it
/// is intended principally for use in the implementation of
/// #GtkRecentChooser.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="filter_info">
/// a #GtkRecentFilterInfo containing information
///   about a recently used resource
/// </param>
/// <return>
/// %TRUE if the file should be displayed
/// </return>

	public static bool Filter(this MentorLake.Gtk.GtkRecentFilterHandle filter, MentorLake.Gtk.GtkRecentFilterInfoHandle filter_info)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		return GtkRecentFilterHandleExterns.gtk_recent_filter_filter(filter, filter_info);
	}

/// <summary>
/// <para>
/// Gets the human-readable name for the filter.
/// See gtk_recent_filter_set_name().
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <return>
/// the name of the filter, or %NULL.  The returned string
///   is owned by the filter object and should not be freed.
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkRecentFilterHandle filter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		return GtkRecentFilterHandleExterns.gtk_recent_filter_get_name(filter);
	}

/// <summary>
/// <para>
/// Gets the fields that need to be filled in for the #GtkRecentFilterInfo
/// passed to gtk_recent_filter_filter()
/// </para>
/// <para>
/// This function will not typically be used by applications; it
/// is intended principally for use in the implementation of
/// #GtkRecentChooser.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <return>
/// bitfield of flags indicating needed fields when
///   calling gtk_recent_filter_filter()
/// </return>

	public static MentorLake.Gtk.GtkRecentFilterFlags GetNeeded(this MentorLake.Gtk.GtkRecentFilterHandle filter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		return GtkRecentFilterHandleExterns.gtk_recent_filter_get_needed(filter);
	}

/// <summary>
/// <para>
/// Sets the human-readable name of the filter; this is the string
/// that will be displayed in the recently used resources selector
/// user interface if there is a selectable list of filters.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkRecentFilter
/// </param>
/// <param name="name">
/// then human readable name of @filter
/// </param>

	public static T SetName<T>(this T filter, string name) where T : GtkRecentFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkRecentFilterHandle)");
		GtkRecentFilterHandleExterns.gtk_recent_filter_set_name(filter, name);
		return filter;
	}

}

internal class GtkRecentFilterHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentFilterHandle gtk_recent_filter_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_age([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, int days);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, string application);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, MentorLake.Gtk.GtkRecentFilterFlags needed, MentorLake.Gtk.GtkRecentFilterFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, string group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, string mime_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, string pattern);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_add_pixbuf_formats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_filter_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterInfoHandle>))] MentorLake.Gtk.GtkRecentFilterInfoHandle filter_info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_filter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentFilterFlags gtk_recent_filter_get_needed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_filter_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterHandle>))] MentorLake.Gtk.GtkRecentFilterHandle filter, string name);

}
