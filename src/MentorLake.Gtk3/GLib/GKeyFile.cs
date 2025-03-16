namespace MentorLake.GLib;

public class GKeyFileHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GKeyFileHandle New()
	{
		return GKeyFileExterns.g_key_file_new();
	}

}


public static class GKeyFileExtensions
{
	public static void Free(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		GKeyFileExterns.g_key_file_free(key_file);
	}

	public static bool GetBoolean(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_boolean(key_file, group_name, key);
	}

	public static bool[] GetBooleanList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_boolean_list(key_file, group_name, key, out length);
	}

	public static string GetComment(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_comment(key_file, group_name, key);
	}

	public static double GetDouble(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_double(key_file, group_name, key);
	}

	public static double[] GetDoubleList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_double_list(key_file, group_name, key, out length);
	}

	public static string[] GetGroups(this MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_groups(key_file, out length);
	}

	public static long GetInt64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_int64(key_file, group_name, key);
	}

	public static int GetInteger(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_integer(key_file, group_name, key);
	}

	public static int[] GetIntegerList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_integer_list(key_file, group_name, key, out length);
	}

	public static string[] GetKeys(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_keys(key_file, group_name, out length);
	}

	public static string GetLocaleForKey(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale)
	{
		return GKeyFileExterns.g_key_file_get_locale_for_key(key_file, group_name, key, locale);
	}

	public static string GetLocaleString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale)
	{
		return GKeyFileExterns.g_key_file_get_locale_string(key_file, group_name, key, locale);
	}

	public static string[] GetLocaleStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_locale_string_list(key_file, group_name, key, locale, out length);
	}

	public static string GetStartGroup(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		return GKeyFileExterns.g_key_file_get_start_group(key_file);
	}

	public static string GetString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_string(key_file, group_name, key);
	}

	public static string[] GetStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_string_list(key_file, group_name, key, out length);
	}

	public static ulong GetUint64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_uint64(key_file, group_name, key);
	}

	public static string GetValue(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_get_value(key_file, group_name, key);
	}

	public static bool HasGroup(this MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		return GKeyFileExterns.g_key_file_has_group(key_file, group_name);
	}

	public static bool HasKey(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_has_key(key_file, group_name, key);
	}

	public static bool LoadFromBytes(this MentorLake.GLib.GKeyFileHandle key_file, MentorLake.GLib.GBytesHandle bytes, MentorLake.GLib.GKeyFileFlags flags)
	{
		return GKeyFileExterns.g_key_file_load_from_bytes(key_file, bytes, flags);
	}

	public static bool LoadFromData(this MentorLake.GLib.GKeyFileHandle key_file, string data, UIntPtr length, MentorLake.GLib.GKeyFileFlags flags)
	{
		return GKeyFileExterns.g_key_file_load_from_data(key_file, data, length, flags);
	}

	public static bool LoadFromDataDirs(this MentorLake.GLib.GKeyFileHandle key_file, char file, out char full_path, MentorLake.GLib.GKeyFileFlags flags)
	{
		return GKeyFileExterns.g_key_file_load_from_data_dirs(key_file, file, out full_path, flags);
	}

	public static bool LoadFromDirs(this MentorLake.GLib.GKeyFileHandle key_file, char file, string[] search_dirs, out char full_path, MentorLake.GLib.GKeyFileFlags flags)
	{
		return GKeyFileExterns.g_key_file_load_from_dirs(key_file, file, search_dirs, out full_path, flags);
	}

	public static bool LoadFromFile(this MentorLake.GLib.GKeyFileHandle key_file, char file, MentorLake.GLib.GKeyFileFlags flags)
	{
		return GKeyFileExterns.g_key_file_load_from_file(key_file, file, flags);
	}

	public static MentorLake.GLib.GKeyFileHandle Ref(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		return GKeyFileExterns.g_key_file_ref(key_file);
	}

	public static bool RemoveComment(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_remove_comment(key_file, group_name, key);
	}

	public static bool RemoveGroup(this MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		return GKeyFileExterns.g_key_file_remove_group(key_file, group_name);
	}

	public static bool RemoveKey(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		return GKeyFileExterns.g_key_file_remove_key(key_file, group_name, key);
	}

	public static bool SaveToFile(this MentorLake.GLib.GKeyFileHandle key_file, string filename)
	{
		return GKeyFileExterns.g_key_file_save_to_file(key_file, filename);
	}

	public static void SetBoolean(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool value)
	{
		GKeyFileExterns.g_key_file_set_boolean(key_file, group_name, key, value);
	}

	public static void SetBooleanList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool[] list, UIntPtr length)
	{
		GKeyFileExterns.g_key_file_set_boolean_list(key_file, group_name, key, list, length);
	}

	public static bool SetComment(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string comment)
	{
		return GKeyFileExterns.g_key_file_set_comment(key_file, group_name, key, comment);
	}

	public static void SetDouble(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double value)
	{
		GKeyFileExterns.g_key_file_set_double(key_file, group_name, key, value);
	}

	public static void SetDoubleList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double[] list, UIntPtr length)
	{
		GKeyFileExterns.g_key_file_set_double_list(key_file, group_name, key, list, length);
	}

	public static void SetInt64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, long value)
	{
		GKeyFileExterns.g_key_file_set_int64(key_file, group_name, key, value);
	}

	public static void SetInteger(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int value)
	{
		GKeyFileExterns.g_key_file_set_integer(key_file, group_name, key, value);
	}

	public static void SetIntegerList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int[] list, UIntPtr length)
	{
		GKeyFileExterns.g_key_file_set_integer_list(key_file, group_name, key, list, length);
	}

	public static void SetListSeparator(this MentorLake.GLib.GKeyFileHandle key_file, char separator)
	{
		GKeyFileExterns.g_key_file_set_list_separator(key_file, separator);
	}

	public static void SetLocaleString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string @string)
	{
		GKeyFileExterns.g_key_file_set_locale_string(key_file, group_name, key, locale, @string);
	}

	public static void SetLocaleStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string[] list, UIntPtr length)
	{
		GKeyFileExterns.g_key_file_set_locale_string_list(key_file, group_name, key, locale, list, length);
	}

	public static void SetString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string @string)
	{
		GKeyFileExterns.g_key_file_set_string(key_file, group_name, key, @string);
	}

	public static void SetStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string[] list, UIntPtr length)
	{
		GKeyFileExterns.g_key_file_set_string_list(key_file, group_name, key, list, length);
	}

	public static void SetUint64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, ulong value)
	{
		GKeyFileExterns.g_key_file_set_uint64(key_file, group_name, key, value);
	}

	public static void SetValue(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string value)
	{
		GKeyFileExterns.g_key_file_set_value(key_file, group_name, key, value);
	}

	public static string ToData(this MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_to_data(key_file, out length);
	}

	public static void Unref(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		GKeyFileExterns.g_key_file_unref(key_file);
	}


	public static GKeyFile Dereference(this GKeyFileHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GKeyFile>(x.DangerousGetHandle());
}
internal class GKeyFileExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GKeyFileHandle g_key_file_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool[] g_key_file_get_boolean_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_key_file_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern double[] g_key_file_get_double_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_key_file_get_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_key_file_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_key_file_get_integer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern int[] g_key_file_get_integer_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_key_file_get_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_locale_for_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_locale_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_key_file_get_locale_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_start_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern string[] g_key_file_get_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern ulong g_key_file_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_has_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, MentorLake.GLib.GKeyFileFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string data, UIntPtr length, MentorLake.GLib.GKeyFileFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_data_dirs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, char file, out char full_path, MentorLake.GLib.GKeyFileFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_dirs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, char file, string[] search_dirs, out char full_path, MentorLake.GLib.GKeyFileFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, char file, MentorLake.GLib.GKeyFileFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GKeyFileHandle g_key_file_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_remove_comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_remove_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_remove_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_save_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_boolean_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_set_comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string comment);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_double_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, long value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_integer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_integer_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_list_separator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, char separator);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_locale_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_locale_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, ulong value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_to_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_key_file_error_quark();

}

public struct GKeyFile
{
	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GKeyFileExterns.g_key_file_error_quark();
	}

}
