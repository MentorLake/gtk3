namespace MentorLake.Gtk3.Gtk3;

public class GtkFileFilterHandle : GInitiallyUnownedHandle, GtkBuildableHandle
{
	public static GtkFileFilterHandle New()
	{
		return GtkFileFilterExterns.gtk_file_filter_new();
	}

	public static GtkFileFilterHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkFileFilterExterns.gtk_file_filter_new_from_gvariant(variant);
	}

}

public static class GtkFileFilterHandleExtensions
{
	public static T AddCustom<T>(this T filter, GtkFileFilterFlags needed, GtkFileFilterFunc func, IntPtr data, GDestroyNotify notify) where T : GtkFileFilterHandle
	{
		GtkFileFilterExterns.gtk_file_filter_add_custom(filter, needed, func, data, notify);
		return filter;
	}

	public static T AddMimeType<T>(this T filter, string mime_type) where T : GtkFileFilterHandle
	{
		GtkFileFilterExterns.gtk_file_filter_add_mime_type(filter, mime_type);
		return filter;
	}

	public static T AddPattern<T>(this T filter, string pattern) where T : GtkFileFilterHandle
	{
		GtkFileFilterExterns.gtk_file_filter_add_pattern(filter, pattern);
		return filter;
	}

	public static T AddPixbufFormats<T>(this T filter) where T : GtkFileFilterHandle
	{
		GtkFileFilterExterns.gtk_file_filter_add_pixbuf_formats(filter);
		return filter;
	}

	public static bool Filter(this GtkFileFilterHandle filter, GtkFileFilterInfoHandle filter_info)
	{
		return GtkFileFilterExterns.gtk_file_filter_filter(filter, filter_info);
	}

	public static string GetName(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_get_name(filter);
	}

	public static GtkFileFilterFlags GetNeeded(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_get_needed(filter);
	}

	public static T SetName<T>(this T filter, string name) where T : GtkFileFilterHandle
	{
		GtkFileFilterExterns.gtk_file_filter_set_name(filter, name);
		return filter;
	}

	public static GVariantHandle ToGvariant(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_to_gvariant(filter);
	}

}

internal class GtkFileFilterExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileFilterHandle gtk_file_filter_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileFilterHandle gtk_file_filter_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_filter_add_custom(GtkFileFilterHandle filter, GtkFileFilterFlags needed, GtkFileFilterFunc func, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_filter_add_mime_type(GtkFileFilterHandle filter, string mime_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_filter_add_pattern(GtkFileFilterHandle filter, string pattern);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_filter_add_pixbuf_formats(GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_filter_filter(GtkFileFilterHandle filter, GtkFileFilterInfoHandle filter_info);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_filter_get_name(GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileFilterFlags gtk_file_filter_get_needed(GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_filter_set_name(GtkFileFilterHandle filter, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GVariantHandle gtk_file_filter_to_gvariant(GtkFileFilterHandle filter);

}
