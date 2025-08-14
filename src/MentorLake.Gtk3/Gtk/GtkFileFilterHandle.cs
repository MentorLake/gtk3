namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkFileFilter can be used to restrict the files being shown in a
/// #GtkFileChooser. Files can be filtered based on their name (with
/// gtk_file_filter_add_pattern()), on their mime type (with
/// gtk_file_filter_add_mime_type()), or by a custom filter function
/// (with gtk_file_filter_add_custom()).
/// </para>
/// <para>
/// Filtering by mime types handles aliasing and subclassing of mime
/// types; e.g. a filter for text/plain also matches a file with mime
/// type application/rtf, since application/rtf is a subclass of
/// text/plain. Note that #GtkFileFilter allows wildcards for the
/// subtype of a mime type, so you can e.g. filter for image/\*.
/// </para>
/// <para>
/// Normally, filters are used by adding them to a #GtkFileChooser,
/// see gtk_file_chooser_add_filter(), but it is also possible
/// to manually use a filter on a file with gtk_file_filter_filter().
/// </para>
/// <para>
/// # GtkFileFilter as GtkBuildable
/// </para>
/// <para>
/// The GtkFileFilter implementation of the GtkBuildable interface
/// supports adding rules using the `<mime-types>`, `<patterns>` and
/// `<applications>` elements and listing the rules within. Specifying
/// a `<mime-type>` or `<pattern>` has the same effect as as calling
/// gtk_file_filter_add_mime_type() or gtk_file_filter_add_pattern().
/// </para>
/// <para>
/// An example of a UI definition fragment specifying GtkFileFilter
/// rules:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkFileFilter">
///   <mime-types>
///     <mime-type>text/plain</mime-type>
///     <mime-type>image/ *</mime-type>
///   </mime-types>
///   <patterns>
///     <pattern>*.txt</pattern>
///     <pattern>*.png</pattern>
///   </patterns>
/// </object>
/// ]|
/// </para>
/// </summary>

public class GtkFileFilterHandle : GInitiallyUnownedHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFileFilter with no rules added to it.
/// Such a filter doesn’t accept any files, so is not
/// particularly useful until you add rules with
/// gtk_file_filter_add_mime_type(), gtk_file_filter_add_pattern(),
/// or gtk_file_filter_add_custom(). To create a filter
/// that accepts any file, use:
/// |[<!-- language="C" -->
/// GtkFileFilter *filter = gtk_file_filter_new ();
/// gtk_file_filter_add_pattern (filter, "*");
/// ]|
/// </para>
/// </summary>

/// <return>
/// a new #GtkFileFilter
/// </return>

	public static MentorLake.Gtk.GtkFileFilterHandle New()
	{
		return GtkFileFilterHandleExterns.gtk_file_filter_new();
	}

/// <summary>
/// <para>
/// Deserialize a file filter from an a{sv} variant in
/// the format produced by gtk_file_filter_to_gvariant().
/// </para>
/// </summary>

/// <param name="variant">
/// an a{sv} #GVariant
/// </param>
/// <return>
/// a new #GtkFileFilter object
/// </return>

	public static MentorLake.Gtk.GtkFileFilterHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkFileFilterHandleExterns.gtk_file_filter_new_from_gvariant(variant);
	}

}

public static class GtkFileFilterHandleExtensions
{
/// <summary>
/// <para>
/// Adds rule to a filter that allows files based on a custom callback
/// function. The bitfield @needed which is passed in provides information
/// about what sorts of information that the filter function needs;
/// this allows GTK+ to avoid retrieving expensive information when
/// it isn’t needed by the filter.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
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
/// <param name="notify">
/// function to call to free @data when it is no longer needed.
/// </param>

	public static T AddCustom<T>(this T filter, MentorLake.Gtk.GtkFileFilterFlags needed, MentorLake.Gtk.GtkFileFilterFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_custom(filter, needed, func, data, notify);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule allowing a given mime type to @filter.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkFileFilter
/// </param>
/// <param name="mime_type">
/// name of a MIME type
/// </param>

	public static T AddMimeType<T>(this T filter, string mime_type) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_mime_type(filter, mime_type);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule allowing a shell style glob to a filter.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>
/// <param name="pattern">
/// a shell style glob
/// </param>

	public static T AddPattern<T>(this T filter, string pattern) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_pattern(filter, pattern);
		return filter;
	}

/// <summary>
/// <para>
/// Adds a rule allowing image files in the formats supported
/// by GdkPixbuf.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>

	public static T AddPixbufFormats<T>(this T filter) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_pixbuf_formats(filter);
		return filter;
	}

/// <summary>
/// <para>
/// Tests whether a file should be displayed according to @filter.
/// The #GtkFileFilterInfo @filter_info should include
/// the fields returned from gtk_file_filter_get_needed().
/// </para>
/// <para>
/// This function will not typically be used by applications; it
/// is intended principally for use in the implementation of
/// #GtkFileChooser.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>
/// <param name="filter_info">
/// a #GtkFileFilterInfo containing information
///  about a file.
/// </param>
/// <return>
/// %TRUE if the file should be displayed
/// </return>

	public static bool Filter(this MentorLake.Gtk.GtkFileFilterHandle filter, MentorLake.Gtk.GtkFileFilterInfoHandle filter_info)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_filter(filter, filter_info);
	}

/// <summary>
/// <para>
/// Gets the human-readable name for the filter. See gtk_file_filter_set_name().
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>
/// <return>
/// The human-readable name of the filter,
///   or %NULL. This value is owned by GTK+ and must not
///   be modified or freed.
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkFileFilterHandle filter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_get_name(filter);
	}

/// <summary>
/// <para>
/// Gets the fields that need to be filled in for the #GtkFileFilterInfo
/// passed to gtk_file_filter_filter()
/// </para>
/// <para>
/// This function will not typically be used by applications; it
/// is intended principally for use in the implementation of
/// #GtkFileChooser.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>
/// <return>
/// bitfield of flags indicating needed fields when
///   calling gtk_file_filter_filter()
/// </return>

	public static MentorLake.Gtk.GtkFileFilterFlags GetNeeded(this MentorLake.Gtk.GtkFileFilterHandle filter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_get_needed(filter);
	}

/// <summary>
/// <para>
/// Sets the human-readable name of the filter; this is the string
/// that will be displayed in the file selector user interface if
/// there is a selectable list of filters.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>
/// <param name="name">
/// the human-readable-name for the filter, or %NULL
///   to remove any existing name.
/// </param>

	public static T SetName<T>(this T filter, string name) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_set_name(filter, name);
		return filter;
	}

/// <summary>
/// <para>
/// Serialize a file filter to an a{sv} variant.
/// </para>
/// </summary>

/// <param name="filter">
/// a #GtkFileFilter
/// </param>
/// <return>
/// a new, floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkFileFilterHandle filter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_to_gvariant(filter);
	}

}

internal class GtkFileFilterHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))]
	internal static extern MentorLake.Gtk.GtkFileFilterHandle gtk_file_filter_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))]
	internal static extern MentorLake.Gtk.GtkFileFilterHandle gtk_file_filter_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_filter_add_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter, MentorLake.Gtk.GtkFileFilterFlags needed, MentorLake.Gtk.GtkFileFilterFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_filter_add_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter, string mime_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_filter_add_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter, string pattern);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_filter_add_pixbuf_formats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_filter_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterInfoHandle>))] MentorLake.Gtk.GtkFileFilterInfoHandle filter_info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_filter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileFilterFlags gtk_file_filter_get_needed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_filter_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter, string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle gtk_file_filter_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

}
