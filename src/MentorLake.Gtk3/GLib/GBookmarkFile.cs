namespace MentorLake.GLib;

public class GBookmarkFileHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GBookmarkFileHandle New()
	{
		return GBookmarkFileExterns.g_bookmark_file_new();
	}

}


public static class GBookmarkFileExtensions
{
	public static void AddApplication(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec)
	{
		GBookmarkFileExterns.g_bookmark_file_add_application(bookmark, uri, name, exec);
	}

	public static void AddGroup(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group)
	{
		GBookmarkFileExterns.g_bookmark_file_add_group(bookmark, uri, group);
	}

	public static MentorLake.GLib.GBookmarkFileHandle Copy(this MentorLake.GLib.GBookmarkFileHandle bookmark)
	{
		return GBookmarkFileExterns.g_bookmark_file_copy(bookmark);
	}

	public static void Free(this MentorLake.GLib.GBookmarkFileHandle bookmark)
	{
		GBookmarkFileExterns.g_bookmark_file_free(bookmark);
	}

	public static long GetAdded(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_added(bookmark, uri);
	}

	public static MentorLake.GLib.GDateTimeHandle GetAddedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_added_date_time(bookmark, uri);
	}

	public static bool GetAppInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out long stamp)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_app_info(bookmark, uri, name, out exec, out count, out stamp);
	}

	public static bool GetApplicationInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out MentorLake.GLib.GDateTimeHandle stamp)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_application_info(bookmark, uri, name, out exec, out count, out stamp);
	}

	public static string[] GetApplications(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_applications(bookmark, uri, out length);
	}

	public static string GetDescription(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_description(bookmark, uri);
	}

	public static string[] GetGroups(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_groups(bookmark, uri, out length);
	}

	public static bool GetIcon(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out string href, out string mime_type)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_icon(bookmark, uri, out href, out mime_type);
	}

	public static bool GetIsPrivate(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_is_private(bookmark, uri);
	}

	public static string GetMimeType(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_mime_type(bookmark, uri);
	}

	public static long GetModified(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_modified(bookmark, uri);
	}

	public static MentorLake.GLib.GDateTimeHandle GetModifiedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_modified_date_time(bookmark, uri);
	}

	public static int GetSize(this MentorLake.GLib.GBookmarkFileHandle bookmark)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_size(bookmark);
	}

	public static string GetTitle(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_title(bookmark, uri);
	}

	public static string[] GetUris(this MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_uris(bookmark, out length);
	}

	public static long GetVisited(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_visited(bookmark, uri);
	}

	public static MentorLake.GLib.GDateTimeHandle GetVisitedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_get_visited_date_time(bookmark, uri);
	}

	public static bool HasApplication(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_application(bookmark, uri, name);
	}

	public static bool HasGroup(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_group(bookmark, uri, group);
	}

	public static bool HasItem(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_has_item(bookmark, uri);
	}

	public static bool LoadFromData(this MentorLake.GLib.GBookmarkFileHandle bookmark, byte[] data, UIntPtr length)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_data(bookmark, data, length);
	}

	public static bool LoadFromDataDirs(this MentorLake.GLib.GBookmarkFileHandle bookmark, string file, out string full_path)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_data_dirs(bookmark, file, out full_path);
	}

	public static bool LoadFromFile(this MentorLake.GLib.GBookmarkFileHandle bookmark, string filename)
	{
		return GBookmarkFileExterns.g_bookmark_file_load_from_file(bookmark, filename);
	}

	public static bool MoveItem(this MentorLake.GLib.GBookmarkFileHandle bookmark, string old_uri, string new_uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_move_item(bookmark, old_uri, new_uri);
	}

	public static bool RemoveApplication(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_application(bookmark, uri, name);
	}

	public static bool RemoveGroup(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_group(bookmark, uri, group);
	}

	public static bool RemoveItem(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		return GBookmarkFileExterns.g_bookmark_file_remove_item(bookmark, uri);
	}

	public static void SetAdded(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long added)
	{
		GBookmarkFileExterns.g_bookmark_file_set_added(bookmark, uri, added);
	}

	public static void SetAddedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, MentorLake.GLib.GDateTimeHandle added)
	{
		GBookmarkFileExterns.g_bookmark_file_set_added_date_time(bookmark, uri, added);
	}

	public static bool SetAppInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, long stamp)
	{
		return GBookmarkFileExterns.g_bookmark_file_set_app_info(bookmark, uri, name, exec, count, stamp);
	}

	public static bool SetApplicationInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, MentorLake.GLib.GDateTimeHandle stamp)
	{
		return GBookmarkFileExterns.g_bookmark_file_set_application_info(bookmark, uri, name, exec, count, stamp);
	}

	public static void SetDescription(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string description)
	{
		GBookmarkFileExterns.g_bookmark_file_set_description(bookmark, uri, description);
	}

	public static void SetGroups(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string[] groups, UIntPtr length)
	{
		GBookmarkFileExterns.g_bookmark_file_set_groups(bookmark, uri, groups, length);
	}

	public static void SetIcon(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string href, string mime_type)
	{
		GBookmarkFileExterns.g_bookmark_file_set_icon(bookmark, uri, href, mime_type);
	}

	public static void SetIsPrivate(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, bool is_private)
	{
		GBookmarkFileExterns.g_bookmark_file_set_is_private(bookmark, uri, is_private);
	}

	public static void SetMimeType(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string mime_type)
	{
		GBookmarkFileExterns.g_bookmark_file_set_mime_type(bookmark, uri, mime_type);
	}

	public static void SetModified(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long modified)
	{
		GBookmarkFileExterns.g_bookmark_file_set_modified(bookmark, uri, modified);
	}

	public static void SetModifiedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, MentorLake.GLib.GDateTimeHandle modified)
	{
		GBookmarkFileExterns.g_bookmark_file_set_modified_date_time(bookmark, uri, modified);
	}

	public static void SetTitle(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string title)
	{
		GBookmarkFileExterns.g_bookmark_file_set_title(bookmark, uri, title);
	}

	public static void SetVisited(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long visited)
	{
		GBookmarkFileExterns.g_bookmark_file_set_visited(bookmark, uri, visited);
	}

	public static void SetVisitedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, MentorLake.GLib.GDateTimeHandle visited)
	{
		GBookmarkFileExterns.g_bookmark_file_set_visited_date_time(bookmark, uri, visited);
	}

	public static byte[] ToData(this MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length)
	{
		return GBookmarkFileExterns.g_bookmark_file_to_data(bookmark, out length);
	}

	public static bool ToFile(this MentorLake.GLib.GBookmarkFileHandle bookmark, string filename)
	{
		return GBookmarkFileExterns.g_bookmark_file_to_file(bookmark, filename);
	}


	public static GBookmarkFile Dereference(this GBookmarkFileHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBookmarkFile>(x.DangerousGetHandle());
}
internal class GBookmarkFileExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBookmarkFileHandle g_bookmark_file_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_add_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_add_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBookmarkFileHandle g_bookmark_file_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_bookmark_file_get_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_bookmark_file_get_added_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out long stamp);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] out MentorLake.GLib.GDateTimeHandle stamp);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_bookmark_file_get_applications([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_bookmark_file_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_bookmark_file_get_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out string href, out string mime_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_is_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_bookmark_file_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_bookmark_file_get_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_bookmark_file_get_modified_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bookmark_file_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_bookmark_file_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_bookmark_file_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_bookmark_file_get_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_bookmark_file_get_visited_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_has_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_has_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_load_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, byte[] data, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_load_from_data_dirs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string file, out string full_path);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_load_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_move_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string old_uri, string new_uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_remove_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_remove_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_remove_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long added);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_added_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle added);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_set_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, long stamp);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_set_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle stamp);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string description);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string[] groups, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string href, string mime_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_is_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, bool is_private);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string mime_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long modified);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_modified_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle modified);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string title);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long visited);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_visited_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle visited);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_bookmark_file_to_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_bookmark_file_error_quark();

}

public struct GBookmarkFile
{
	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GBookmarkFileExterns.g_bookmark_file_error_quark();
	}

}
