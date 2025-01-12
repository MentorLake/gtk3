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

	public static GtkIconSourceHandle Free(this GtkIconSourceHandle source)
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

	public static GtkIconSourceHandle SetDirection(this GtkIconSourceHandle source, GtkTextDirection direction)
	{
		GtkIconSourceExterns.gtk_icon_source_set_direction(source, direction);
		return source;
	}

	public static GtkIconSourceHandle SetDirectionWildcarded(this GtkIconSourceHandle source, bool setting)
	{
		GtkIconSourceExterns.gtk_icon_source_set_direction_wildcarded(source, setting);
		return source;
	}

	public static GtkIconSourceHandle SetFilename(this GtkIconSourceHandle source, string filename)
	{
		GtkIconSourceExterns.gtk_icon_source_set_filename(source, filename);
		return source;
	}

	public static GtkIconSourceHandle SetIconName(this GtkIconSourceHandle source, string icon_name)
	{
		GtkIconSourceExterns.gtk_icon_source_set_icon_name(source, icon_name);
		return source;
	}

	public static GtkIconSourceHandle SetPixbuf(this GtkIconSourceHandle source, GdkPixbufHandle pixbuf)
	{
		GtkIconSourceExterns.gtk_icon_source_set_pixbuf(source, pixbuf);
		return source;
	}

	public static GtkIconSourceHandle SetSize(this GtkIconSourceHandle source, GtkIconSize size)
	{
		GtkIconSourceExterns.gtk_icon_source_set_size(source, size);
		return source;
	}

	public static GtkIconSourceHandle SetSizeWildcarded(this GtkIconSourceHandle source, bool setting)
	{
		GtkIconSourceExterns.gtk_icon_source_set_size_wildcarded(source, setting);
		return source;
	}

	public static GtkIconSourceHandle SetState(this GtkIconSourceHandle source, GtkStateType state)
	{
		GtkIconSourceExterns.gtk_icon_source_set_state(source, state);
		return source;
	}

	public static GtkIconSourceHandle SetStateWildcarded(this GtkIconSourceHandle source, bool setting)
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
