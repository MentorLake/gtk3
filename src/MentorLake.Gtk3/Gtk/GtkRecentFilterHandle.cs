namespace MentorLake.Gtk;

public class GtkRecentFilterHandle : GInitiallyUnownedHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkRecentFilterHandle New()
	{
		return GtkRecentFilterHandleExterns.gtk_recent_filter_new();
	}

}

public static class GtkRecentFilterHandleExtensions
{
	public static T AddAge<T>(this T filter, int days) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_age(filter, days);
		return filter;
	}

	public static T AddApplication<T>(this T filter, string application) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_application(filter, application);
		return filter;
	}

	public static T AddCustom<T>(this T filter, MentorLake.Gtk.GtkRecentFilterFlags needed, MentorLake.Gtk.GtkRecentFilterFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_custom(filter, needed, func, data, data_destroy);
		return filter;
	}

	public static T AddGroup<T>(this T filter, string group) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_group(filter, group);
		return filter;
	}

	public static T AddMimeType<T>(this T filter, string mime_type) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_mime_type(filter, mime_type);
		return filter;
	}

	public static T AddPattern<T>(this T filter, string pattern) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_pattern(filter, pattern);
		return filter;
	}

	public static T AddPixbufFormats<T>(this T filter) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_add_pixbuf_formats(filter);
		return filter;
	}

	public static bool Filter(this MentorLake.Gtk.GtkRecentFilterHandle filter, MentorLake.Gtk.GtkRecentFilterInfoHandle filter_info)
	{
		return GtkRecentFilterHandleExterns.gtk_recent_filter_filter(filter, filter_info);
	}

	public static string GetName(this MentorLake.Gtk.GtkRecentFilterHandle filter)
	{
		return GtkRecentFilterHandleExterns.gtk_recent_filter_get_name(filter);
	}

	public static MentorLake.Gtk.GtkRecentFilterFlags GetNeeded(this MentorLake.Gtk.GtkRecentFilterHandle filter)
	{
		return GtkRecentFilterHandleExterns.gtk_recent_filter_get_needed(filter);
	}

	public static T SetName<T>(this T filter, string name) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterHandleExterns.gtk_recent_filter_set_name(filter, name);
		return filter;
	}

}

internal class GtkRecentFilterHandleExterns
{
	[DllImport(GtkLibrary.Name)]
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
