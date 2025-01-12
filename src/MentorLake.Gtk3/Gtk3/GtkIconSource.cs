namespace MentorLake.Gtk3.Gtk3;

public class GtkIconSourceHandle : BaseSafeHandle
{
	public static GtkIconSourceHandle New()
	{
		return GtkIconSourceExterns.gtk_icon_source_new();
	}

}


public static class GtkIconSourceHandleExtensions
{
	public static GtkIconSourceHandle Copy(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_copy(source);
	}

	public static T Free<T>(this T source) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_free(source);
		return source;
	}

	public static GtkTextDirection GetDirection(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_direction(source);
	}

	public static bool GetDirectionWildcarded(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_direction_wildcarded(source);
	}

	public static string GetFilename(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_filename(source);
	}

	public static string GetIconName(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_icon_name(source);
	}

	public static GdkPixbufHandle GetPixbuf(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_pixbuf(source);
	}

	public static GtkIconSize GetSize(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_size(source);
	}

	public static bool GetSizeWildcarded(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_size_wildcarded(source);
	}

	public static GtkStateType GetState(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_state(source);
	}

	public static bool GetStateWildcarded(this GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_state_wildcarded(source);
	}

	public static T SetDirection<T>(this T source, GtkTextDirection direction) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_direction(source, direction);
		return source;
	}

	public static T SetDirectionWildcarded<T>(this T source, bool setting) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_direction_wildcarded(source, setting);
		return source;
	}

	public static T SetFilename<T>(this T source, string filename) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_filename(source, filename);
		return source;
	}

	public static T SetIconName<T>(this T source, string icon_name) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_icon_name(source, icon_name);
		return source;
	}

	public static T SetPixbuf<T>(this T source, GdkPixbufHandle pixbuf) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_pixbuf(source, pixbuf);
		return source;
	}

	public static T SetSize<T>(this T source, GtkIconSize size) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_size(source, size);
		return source;
	}

	public static T SetSizeWildcarded<T>(this T source, bool setting) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_size_wildcarded(source, setting);
		return source;
	}

	public static T SetState<T>(this T source, GtkStateType state) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_state(source, state);
		return source;
	}

	public static T SetStateWildcarded<T>(this T source, bool setting) where T : GtkIconSourceHandle
	{
		GtkIconSourceExterns.gtk_icon_source_set_state_wildcarded(source, setting);
		return source;
	}

}
internal class GtkIconSourceExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSourceHandle gtk_icon_source_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSourceHandle gtk_icon_source_copy(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_free(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextDirection gtk_icon_source_get_direction(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_source_get_direction_wildcarded(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_source_get_filename(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_source_get_icon_name(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_source_get_pixbuf(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSize gtk_icon_source_get_size(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_source_get_size_wildcarded(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateType gtk_icon_source_get_state(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_source_get_state_wildcarded(GtkIconSourceHandle source);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_direction(GtkIconSourceHandle source, GtkTextDirection direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_direction_wildcarded(GtkIconSourceHandle source, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_filename(GtkIconSourceHandle source, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_icon_name(GtkIconSourceHandle source, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_pixbuf(GtkIconSourceHandle source, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_size(GtkIconSourceHandle source, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_size_wildcarded(GtkIconSourceHandle source, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_state(GtkIconSourceHandle source, GtkStateType state);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_source_set_state_wildcarded(GtkIconSourceHandle source, bool setting);

}

public struct GtkIconSource
{
}
