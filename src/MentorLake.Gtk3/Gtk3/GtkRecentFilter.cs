namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentFilterHandle : GInitiallyUnownedHandle, GtkBuildableHandle
{
	public static GtkRecentFilterHandle New()
	{
		return GtkRecentFilterExterns.gtk_recent_filter_new();
	}

}

public static class GtkRecentFilterHandleExtensions
{
	public static T AddAge<T>(this T filter, int days) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_age(filter, days);
		return filter;
	}

	public static T AddApplication<T>(this T filter, string application) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_application(filter, application);
		return filter;
	}

	public static T AddCustom<T>(this T filter, GtkRecentFilterFlags needed, GtkRecentFilterFunc func, IntPtr data, GDestroyNotify data_destroy) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_custom(filter, needed, func, data, data_destroy);
		return filter;
	}

	public static T AddGroup<T>(this T filter, string group) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_group(filter, group);
		return filter;
	}

	public static T AddMimeType<T>(this T filter, string mime_type) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_mime_type(filter, mime_type);
		return filter;
	}

	public static T AddPattern<T>(this T filter, string pattern) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_pattern(filter, pattern);
		return filter;
	}

	public static T AddPixbufFormats<T>(this T filter) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_add_pixbuf_formats(filter);
		return filter;
	}

	public static bool Filter(this GtkRecentFilterHandle filter, GtkRecentFilterInfoHandle filter_info)
	{
		return GtkRecentFilterExterns.gtk_recent_filter_filter(filter, filter_info);
	}

	public static string GetName(this GtkRecentFilterHandle filter)
	{
		return GtkRecentFilterExterns.gtk_recent_filter_get_name(filter);
	}

	public static GtkRecentFilterFlags GetNeeded(this GtkRecentFilterHandle filter)
	{
		return GtkRecentFilterExterns.gtk_recent_filter_get_needed(filter);
	}

	public static T SetName<T>(this T filter, string name) where T : GtkRecentFilterHandle
	{
		GtkRecentFilterExterns.gtk_recent_filter_set_name(filter, name);
		return filter;
	}

}

internal class GtkRecentFilterExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentFilterHandle gtk_recent_filter_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_age(GtkRecentFilterHandle filter, int days);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_application(GtkRecentFilterHandle filter, string application);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_custom(GtkRecentFilterHandle filter, GtkRecentFilterFlags needed, GtkRecentFilterFunc func, IntPtr data, GDestroyNotify data_destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_group(GtkRecentFilterHandle filter, string group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_mime_type(GtkRecentFilterHandle filter, string mime_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_pattern(GtkRecentFilterHandle filter, string pattern);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_add_pixbuf_formats(GtkRecentFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_filter_filter(GtkRecentFilterHandle filter, GtkRecentFilterInfoHandle filter_info);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_filter_get_name(GtkRecentFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentFilterFlags gtk_recent_filter_get_needed(GtkRecentFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_filter_set_name(GtkRecentFilterHandle filter, string name);

}
