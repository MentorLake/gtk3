namespace MentorLake.Gtk;

public class GtkIconSourceHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkIconSourceHandle New()
	{
		return GtkIconSourceExterns.gtk_icon_source_new();
	}

}


public static class GtkIconSourceExtensions
{
	public static MentorLake.Gtk.GtkIconSourceHandle Copy(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_copy(source);
	}

	public static void Free(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		GtkIconSourceExterns.gtk_icon_source_free(source);
	}

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_direction(source);
	}

	public static bool GetDirectionWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_direction_wildcarded(source);
	}

	public static string GetFilename(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_filename(source);
	}

	public static string GetIconName(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_icon_name(source);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_pixbuf(source);
	}

	public static MentorLake.Gtk.GtkIconSize GetSize(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_size(source);
	}

	public static bool GetSizeWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_size_wildcarded(source);
	}

	public static MentorLake.Gtk.GtkStateType GetState(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_state(source);
	}

	public static bool GetStateWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		return GtkIconSourceExterns.gtk_icon_source_get_state_wildcarded(source);
	}

	public static void SetDirection(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction)
	{
		GtkIconSourceExterns.gtk_icon_source_set_direction(source, direction);
	}

	public static void SetDirectionWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source, bool setting)
	{
		GtkIconSourceExterns.gtk_icon_source_set_direction_wildcarded(source, setting);
	}

	public static void SetFilename(this MentorLake.Gtk.GtkIconSourceHandle source, string filename)
	{
		GtkIconSourceExterns.gtk_icon_source_set_filename(source, filename);
	}

	public static void SetIconName(this MentorLake.Gtk.GtkIconSourceHandle source, string icon_name)
	{
		GtkIconSourceExterns.gtk_icon_source_set_icon_name(source, icon_name);
	}

	public static void SetPixbuf(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		GtkIconSourceExterns.gtk_icon_source_set_pixbuf(source, pixbuf);
	}

	public static void SetSize(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size)
	{
		GtkIconSourceExterns.gtk_icon_source_set_size(source, size);
	}

	public static void SetSizeWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source, bool setting)
	{
		GtkIconSourceExterns.gtk_icon_source_set_size_wildcarded(source, setting);
	}

	public static void SetState(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkStateType state)
	{
		GtkIconSourceExterns.gtk_icon_source_set_state(source, state);
	}

	public static void SetStateWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source, bool setting)
	{
		GtkIconSourceExterns.gtk_icon_source_set_state_wildcarded(source, setting);
	}


	public static GtkIconSource Dereference(this GtkIconSourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconSource>(x.DangerousGetHandle());
}
internal class GtkIconSourceExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSourceHandle gtk_icon_source_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSourceHandle gtk_icon_source_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_icon_source_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_source_get_direction_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_source_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_source_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_source_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_icon_source_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_source_get_size_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateType gtk_icon_source_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_source_get_state_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_direction_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_size_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkStateType state);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_state_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, bool setting);

}

public struct GtkIconSource
{
}
