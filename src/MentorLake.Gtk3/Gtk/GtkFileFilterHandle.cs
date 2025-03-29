namespace MentorLake.Gtk;

public class GtkFileFilterHandle : GInitiallyUnownedHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkFileFilterHandle New()
	{
		return GtkFileFilterHandleExterns.gtk_file_filter_new();
	}

	public static MentorLake.Gtk.GtkFileFilterHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkFileFilterHandleExterns.gtk_file_filter_new_from_gvariant(variant);
	}

}

public static class GtkFileFilterHandleExtensions
{
	public static T AddCustom<T>(this T filter, MentorLake.Gtk.GtkFileFilterFlags needed, MentorLake.Gtk.GtkFileFilterFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_custom(filter, needed, func, data, notify);
		return filter;
	}

	public static T AddMimeType<T>(this T filter, string mime_type) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_mime_type(filter, mime_type);
		return filter;
	}

	public static T AddPattern<T>(this T filter, string pattern) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_pattern(filter, pattern);
		return filter;
	}

	public static T AddPixbufFormats<T>(this T filter) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_add_pixbuf_formats(filter);
		return filter;
	}

	public static bool Filter(this MentorLake.Gtk.GtkFileFilterHandle filter, MentorLake.Gtk.GtkFileFilterInfoHandle filter_info)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_filter(filter, filter_info);
	}

	public static string GetName(this MentorLake.Gtk.GtkFileFilterHandle filter)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_get_name(filter);
	}

	public static MentorLake.Gtk.GtkFileFilterFlags GetNeeded(this MentorLake.Gtk.GtkFileFilterHandle filter)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_get_needed(filter);
	}

	public static T SetName<T>(this T filter, string name) where T : GtkFileFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		GtkFileFilterHandleExterns.gtk_file_filter_set_name(filter, name);
		return filter;
	}

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkFileFilterHandle filter)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkFileFilterHandle)");
		return GtkFileFilterHandleExterns.gtk_file_filter_to_gvariant(filter);
	}

}

internal class GtkFileFilterHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileFilterHandle gtk_file_filter_new();

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.GLib.GVariantHandle gtk_file_filter_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

}
