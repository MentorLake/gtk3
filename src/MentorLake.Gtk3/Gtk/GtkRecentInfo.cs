namespace MentorLake.Gtk;

public class GtkRecentInfoHandle : BaseSafeHandle
{
}


public static class GtkRecentInfoExtensions
{
	public static MentorLake.Gio.GAppInfoHandle CreateAppInfo(this MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, IntPtr error)
	{
		return GtkRecentInfoExterns.gtk_recent_info_create_app_info(info, app_name, error);
	}

	public static bool Exists(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_exists(info);
	}

	public static long GetAdded(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_added(info);
	}

	public static int GetAge(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_age(info);
	}

	public static bool GetApplicationInfo(this MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, out string app_exec, out uint count, out long time_)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_application_info(info, app_name, out app_exec, out count, out time_);
	}

	public static string[] GetApplications(this MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_applications(info, out length);
	}

	public static string GetDescription(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_description(info);
	}

	public static string GetDisplayName(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_display_name(info);
	}

	public static MentorLake.Gio.GIconHandle GetGicon(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_gicon(info);
	}

	public static string[] GetGroups(this MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_groups(info, out length);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetIcon(this MentorLake.Gtk.GtkRecentInfoHandle info, int size)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_icon(info, size);
	}

	public static string GetMimeType(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_mime_type(info);
	}

	public static long GetModified(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_modified(info);
	}

	public static bool GetPrivateHint(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_private_hint(info);
	}

	public static string GetShortName(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_short_name(info);
	}

	public static string GetUri(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_uri(info);
	}

	public static string GetUriDisplay(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_uri_display(info);
	}

	public static long GetVisited(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_visited(info);
	}

	public static bool HasApplication(this MentorLake.Gtk.GtkRecentInfoHandle info, string app_name)
	{
		return GtkRecentInfoExterns.gtk_recent_info_has_application(info, app_name);
	}

	public static bool HasGroup(this MentorLake.Gtk.GtkRecentInfoHandle info, string group_name)
	{
		return GtkRecentInfoExterns.gtk_recent_info_has_group(info, group_name);
	}

	public static bool IsLocal(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_is_local(info);
	}

	public static string LastApplication(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_last_application(info);
	}

	public static bool Match(this MentorLake.Gtk.GtkRecentInfoHandle info_a, MentorLake.Gtk.GtkRecentInfoHandle info_b)
	{
		return GtkRecentInfoExterns.gtk_recent_info_match(info_a, info_b);
	}

	public static MentorLake.Gtk.GtkRecentInfoHandle Ref(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_ref(info);
	}

	public static void Unref(this MentorLake.Gtk.GtkRecentInfoHandle info)
	{
		GtkRecentInfoExterns.gtk_recent_info_unref(info);
	}


	public static GtkRecentInfo Dereference(this GtkRecentInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentInfo>(x.DangerousGetHandle());
}
internal class GtkRecentInfoExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle gtk_recent_info_create_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, IntPtr error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_exists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern long gtk_recent_info_get_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_recent_info_get_age([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_get_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string app_name, out string app_exec, out uint count, out long time_);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_recent_info_get_applications([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_recent_info_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_recent_info_get_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_recent_info_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, int size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern long gtk_recent_info_get_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_get_private_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_short_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_uri_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern long gtk_recent_info_get_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_has_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string app_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info, string group_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_is_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_last_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_info_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info_a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info_b);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentInfoHandle gtk_recent_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle info);

}

public struct GtkRecentInfo
{
}
