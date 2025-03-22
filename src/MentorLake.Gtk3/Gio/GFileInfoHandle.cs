namespace MentorLake.Gio;

public class GFileInfoHandle : GObjectHandle
{
	public static MentorLake.Gio.GFileInfoHandle New()
	{
		return GFileInfoHandleExterns.g_file_info_new();
	}

}

public static class GFileInfoHandleExtensions
{
	public static T ClearStatus<T>(this T info) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_clear_status(info);
		return info;
	}

	public static T CopyInto<T>(this T src_info, MentorLake.Gio.GFileInfoHandle dest_info) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_copy_into(src_info, dest_info);
		return src_info;
	}

	public static MentorLake.Gio.GFileInfoHandle Dup(this MentorLake.Gio.GFileInfoHandle other)
	{
		return GFileInfoHandleExterns.g_file_info_dup(other);
	}

	public static MentorLake.GLib.GDateTimeHandle GetAccessDateTime(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_access_date_time(info);
	}

	public static string GetAttributeAsString(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_as_string(info, attribute);
	}

	public static bool GetAttributeBoolean(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_boolean(info, attribute);
	}

	public static string GetAttributeByteString(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_byte_string(info, attribute);
	}

	public static bool GetAttributeData(this MentorLake.Gio.GFileInfoHandle info, string attribute, out MentorLake.Gio.GFileAttributeType type, out IntPtr value_pp, out MentorLake.Gio.GFileAttributeStatus status)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_data(info, attribute, out type, out value_pp, out status);
	}

	public static string GetAttributeFilePath(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_file_path(info, attribute);
	}

	public static int GetAttributeInt32(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_int32(info, attribute);
	}

	public static long GetAttributeInt64(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_int64(info, attribute);
	}

	public static MentorLake.GObject.GObjectHandle GetAttributeObject(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_object(info, attribute);
	}

	public static MentorLake.Gio.GFileAttributeStatus GetAttributeStatus(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_status(info, attribute);
	}

	public static string GetAttributeString(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_string(info, attribute);
	}

	public static string[] GetAttributeStringv(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_stringv(info, attribute);
	}

	public static MentorLake.Gio.GFileAttributeType GetAttributeType(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_type(info, attribute);
	}

	public static uint GetAttributeUint32(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_uint32(info, attribute);
	}

	public static ulong GetAttributeUint64(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_get_attribute_uint64(info, attribute);
	}

	public static string GetContentType(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_content_type(info);
	}

	public static MentorLake.GLib.GDateTimeHandle GetCreationDateTime(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_creation_date_time(info);
	}

	public static MentorLake.GLib.GDateTimeHandle GetDeletionDate(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_deletion_date(info);
	}

	public static string GetDisplayName(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_display_name(info);
	}

	public static string GetEditName(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_edit_name(info);
	}

	public static string GetEtag(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_etag(info);
	}

	public static MentorLake.Gio.GFileType GetFileType(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_file_type(info);
	}

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_icon(info);
	}

	public static bool GetIsBackup(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_is_backup(info);
	}

	public static bool GetIsHidden(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_is_hidden(info);
	}

	public static bool GetIsSymlink(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_is_symlink(info);
	}

	public static MentorLake.GLib.GDateTimeHandle GetModificationDateTime(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_modification_date_time(info);
	}

	public static T GetModificationTime<T>(this T info, out MentorLake.GLib.GTimeVal result) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_get_modification_time(info, out result);
		return info;
	}

	public static string GetName(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_name(info);
	}

	public static int GetSize(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_size(info);
	}

	public static int GetSortOrder(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_sort_order(info);
	}

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_symbolic_icon(info);
	}

	public static string GetSymlinkTarget(this MentorLake.Gio.GFileInfoHandle info)
	{
		return GFileInfoHandleExterns.g_file_info_get_symlink_target(info);
	}

	public static bool HasAttribute(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		return GFileInfoHandleExterns.g_file_info_has_attribute(info, attribute);
	}

	public static bool HasNamespace(this MentorLake.Gio.GFileInfoHandle info, string name_space)
	{
		return GFileInfoHandleExterns.g_file_info_has_namespace(info, name_space);
	}

	public static string[] ListAttributes(this MentorLake.Gio.GFileInfoHandle info, string name_space)
	{
		return GFileInfoHandleExterns.g_file_info_list_attributes(info, name_space);
	}

	public static T RemoveAttribute<T>(this T info, string attribute) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_remove_attribute(info, attribute);
		return info;
	}

	public static T SetAccessDateTime<T>(this T info, MentorLake.GLib.GDateTimeHandle atime) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_access_date_time(info, atime);
		return info;
	}

	public static T SetAttribute<T>(this T info, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute(info, attribute, type, value_p);
		return info;
	}

	public static T SetAttributeBoolean<T>(this T info, string attribute, bool attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_boolean(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeByteString<T>(this T info, string attribute, string attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_byte_string(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeFilePath<T>(this T info, string attribute, string attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_file_path(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeInt32<T>(this T info, string attribute, int attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_int32(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeInt64<T>(this T info, string attribute, long attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_int64(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeMask<T>(this T info, MentorLake.Gio.GFileAttributeMatcherHandle mask) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_mask(info, mask);
		return info;
	}

	public static T SetAttributeObject<T>(this T info, string attribute, MentorLake.GObject.GObjectHandle attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_object(info, attribute, attr_value);
		return info;
	}

	public static bool SetAttributeStatus(this MentorLake.Gio.GFileInfoHandle info, string attribute, MentorLake.Gio.GFileAttributeStatus status)
	{
		return GFileInfoHandleExterns.g_file_info_set_attribute_status(info, attribute, status);
	}

	public static T SetAttributeString<T>(this T info, string attribute, string attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_string(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeStringv<T>(this T info, string attribute, string[] attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_stringv(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeUint32<T>(this T info, string attribute, uint attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_uint32(info, attribute, attr_value);
		return info;
	}

	public static T SetAttributeUint64<T>(this T info, string attribute, ulong attr_value) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_attribute_uint64(info, attribute, attr_value);
		return info;
	}

	public static T SetContentType<T>(this T info, string content_type) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_content_type(info, content_type);
		return info;
	}

	public static T SetCreationDateTime<T>(this T info, MentorLake.GLib.GDateTimeHandle creation_time) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_creation_date_time(info, creation_time);
		return info;
	}

	public static T SetDisplayName<T>(this T info, string display_name) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_display_name(info, display_name);
		return info;
	}

	public static T SetEditName<T>(this T info, string edit_name) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_edit_name(info, edit_name);
		return info;
	}

	public static T SetFileType<T>(this T info, MentorLake.Gio.GFileType type) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_file_type(info, type);
		return info;
	}

	public static T SetIcon<T>(this T info, MentorLake.Gio.GIconHandle icon) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_icon(info, icon);
		return info;
	}

	public static T SetIsHidden<T>(this T info, bool is_hidden) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_is_hidden(info, is_hidden);
		return info;
	}

	public static T SetIsSymlink<T>(this T info, bool is_symlink) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_is_symlink(info, is_symlink);
		return info;
	}

	public static T SetModificationDateTime<T>(this T info, MentorLake.GLib.GDateTimeHandle mtime) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_modification_date_time(info, mtime);
		return info;
	}

	public static T SetModificationTime<T>(this T info, MentorLake.GLib.GTimeValHandle mtime) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_modification_time(info, mtime);
		return info;
	}

	public static T SetName<T>(this T info, string name) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_name(info, name);
		return info;
	}

	public static T SetSize<T>(this T info, int size) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_size(info, size);
		return info;
	}

	public static T SetSortOrder<T>(this T info, int sort_order) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_sort_order(info, sort_order);
		return info;
	}

	public static T SetSymbolicIcon<T>(this T info, MentorLake.Gio.GIconHandle icon) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_symbolic_icon(info, icon);
		return info;
	}

	public static T SetSymlinkTarget<T>(this T info, string symlink_target) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_set_symlink_target(info, symlink_target);
		return info;
	}

	public static T UnsetAttributeMask<T>(this T info) where T : GFileInfoHandle
	{
		GFileInfoHandleExterns.g_file_info_unset_attribute_mask(info);
		return info;
	}

}

internal class GFileInfoHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_info_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_clear_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_copy_into([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle src_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle dest_info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_info_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle other);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_access_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_as_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_attribute_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_byte_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_attribute_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, out MentorLake.Gio.GFileAttributeType type, out IntPtr value_pp, out MentorLake.Gio.GFileAttributeStatus status);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_info_get_attribute_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern long g_file_info_get_attribute_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_file_info_get_attribute_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeStatus g_file_info_get_attribute_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_file_info_get_attribute_stringv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeType g_file_info_get_attribute_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_file_info_get_attribute_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_file_info_get_attribute_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_creation_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_deletion_date([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_edit_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_etag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileType g_file_info_get_file_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_file_info_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_is_backup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_is_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_is_symlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_modification_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_get_modification_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, out MentorLake.GLib.GTimeVal result);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_info_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_info_get_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_file_info_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_symlink_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_has_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_has_namespace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string name_space);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_file_info_list_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string name_space);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_remove_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_access_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle atime);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, bool attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_byte_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, int attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, long attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle mask);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_set_attribute_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, MentorLake.Gio.GFileAttributeStatus status);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_stringv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string[] attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, uint attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, ulong attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_creation_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle creation_time);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string display_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_edit_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string edit_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_file_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileType type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_is_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, bool is_hidden);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_is_symlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, bool is_symlink);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_modification_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle mtime);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_modification_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle mtime);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, int size);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, int sort_order);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_symlink_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string symlink_target);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_unset_attribute_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

}
