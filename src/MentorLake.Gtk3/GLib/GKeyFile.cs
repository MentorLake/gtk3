namespace MentorLake.Gtk3.GLib;

public class GKeyFileHandle : BaseSafeHandle
{
	public static GKeyFileHandle New()
	{
		return GKeyFileExterns.g_key_file_new();
	}

}


public static class GKeyFileHandleExtensions
{
	public static T Free<T>(this T key_file) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_free(key_file);
		return key_file;
	}

	public static bool GetBoolean(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_boolean(key_file, group_name, key, out error);
	}

	public static IntPtr GetBooleanList(this GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_boolean_list(key_file, group_name, key, out length, out error);
	}

	public static string GetComment(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_comment(key_file, group_name, key, out error);
	}

	public static double GetDouble(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_double(key_file, group_name, key, out error);
	}

	public static IntPtr GetDoubleList(this GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_double_list(key_file, group_name, key, out length, out error);
	}

	public static IntPtr GetGroups(this GKeyFileHandle key_file, out UIntPtr length)
	{
		return GKeyFileExterns.g_key_file_get_groups(key_file, out length);
	}

	public static long GetInt64(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_int64(key_file, group_name, key, out error);
	}

	public static int GetInteger(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_integer(key_file, group_name, key, out error);
	}

	public static IntPtr GetIntegerList(this GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_integer_list(key_file, group_name, key, out length, out error);
	}

	public static IntPtr GetKeys(this GKeyFileHandle key_file, string group_name, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_keys(key_file, group_name, out length, out error);
	}

	public static string GetLocaleForKey(this GKeyFileHandle key_file, string group_name, string key, string locale)
	{
		return GKeyFileExterns.g_key_file_get_locale_for_key(key_file, group_name, key, locale);
	}

	public static string GetLocaleString(this GKeyFileHandle key_file, string group_name, string key, string locale, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_locale_string(key_file, group_name, key, locale, out error);
	}

	public static IntPtr GetLocaleStringList(this GKeyFileHandle key_file, string group_name, string key, string locale, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_locale_string_list(key_file, group_name, key, locale, out length, out error);
	}

	public static string GetStartGroup(this GKeyFileHandle key_file)
	{
		return GKeyFileExterns.g_key_file_get_start_group(key_file);
	}

	public static string GetString(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_string(key_file, group_name, key, out error);
	}

	public static IntPtr GetStringList(this GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_string_list(key_file, group_name, key, out length, out error);
	}

	public static ulong GetUint64(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_uint64(key_file, group_name, key, out error);
	}

	public static string GetValue(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_get_value(key_file, group_name, key, out error);
	}

	public static bool HasGroup(this GKeyFileHandle key_file, string group_name)
	{
		return GKeyFileExterns.g_key_file_has_group(key_file, group_name);
	}

	public static bool HasKey(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_has_key(key_file, group_name, key, out error);
	}

	public static bool LoadFromBytes(this GKeyFileHandle key_file, GBytesHandle bytes, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_bytes(key_file, bytes, flags, out error);
	}

	public static bool LoadFromData(this GKeyFileHandle key_file, string data, UIntPtr length, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_data(key_file, data, length, flags, out error);
	}

	public static bool LoadFromDataDirs(this GKeyFileHandle key_file, string file, out string full_path, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_data_dirs(key_file, file, out full_path, flags, out error);
	}

	public static bool LoadFromDirs(this GKeyFileHandle key_file, string file, string[] search_dirs, out string full_path, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_dirs(key_file, file, search_dirs, out full_path, flags, out error);
	}

	public static bool LoadFromFile(this GKeyFileHandle key_file, string file, GKeyFileFlags flags, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_load_from_file(key_file, file, flags, out error);
	}

	public static GKeyFileHandle Ref(this GKeyFileHandle key_file)
	{
		return GKeyFileExterns.g_key_file_ref(key_file);
	}

	public static bool RemoveComment(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_remove_comment(key_file, group_name, key, out error);
	}

	public static bool RemoveGroup(this GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_remove_group(key_file, group_name, out error);
	}

	public static bool RemoveKey(this GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_remove_key(key_file, group_name, key, out error);
	}

	public static bool SaveToFile(this GKeyFileHandle key_file, string filename, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_save_to_file(key_file, filename, out error);
	}

	public static T SetBoolean<T>(this T key_file, string group_name, string key, bool value) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_boolean(key_file, group_name, key, value);
		return key_file;
	}

	public static T SetBooleanList<T>(this T key_file, string group_name, string key, bool[] list, UIntPtr length) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_boolean_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static bool SetComment(this GKeyFileHandle key_file, string group_name, string key, string comment, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_set_comment(key_file, group_name, key, comment, out error);
	}

	public static T SetDouble<T>(this T key_file, string group_name, string key, double value) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_double(key_file, group_name, key, value);
		return key_file;
	}

	public static T SetDoubleList<T>(this T key_file, string group_name, string key, double[] list, UIntPtr length) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_double_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static T SetInt64<T>(this T key_file, string group_name, string key, long value) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_int64(key_file, group_name, key, value);
		return key_file;
	}

	public static T SetInteger<T>(this T key_file, string group_name, string key, int value) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_integer(key_file, group_name, key, value);
		return key_file;
	}

	public static T SetIntegerList<T>(this T key_file, string group_name, string key, int[] list, UIntPtr length) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_integer_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static T SetListSeparator<T>(this T key_file, char separator) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_list_separator(key_file, separator);
		return key_file;
	}

	public static T SetLocaleString<T>(this T key_file, string group_name, string key, string locale, string @string) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_locale_string(key_file, group_name, key, locale, @string);
		return key_file;
	}

	public static T SetLocaleStringList<T>(this T key_file, string group_name, string key, string locale, string list, UIntPtr length) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_locale_string_list(key_file, group_name, key, locale, list, length);
		return key_file;
	}

	public static T SetString<T>(this T key_file, string group_name, string key, string @string) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_string(key_file, group_name, key, @string);
		return key_file;
	}

	public static T SetStringList<T>(this T key_file, string group_name, string key, string list, UIntPtr length) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_string_list(key_file, group_name, key, list, length);
		return key_file;
	}

	public static T SetUint64<T>(this T key_file, string group_name, string key, ulong value) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_uint64(key_file, group_name, key, value);
		return key_file;
	}

	public static T SetValue<T>(this T key_file, string group_name, string key, string value) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_set_value(key_file, group_name, key, value);
		return key_file;
	}

	public static string ToData(this GKeyFileHandle key_file, out UIntPtr length, out GErrorHandle error)
	{
		return GKeyFileExterns.g_key_file_to_data(key_file, out length, out error);
	}

	public static T Unref<T>(this T key_file) where T : GKeyFileHandle
	{
		GKeyFileExterns.g_key_file_unref(key_file);
		return key_file;
	}

	public static GQuark ErrorQuark()
	{
		return GKeyFileExterns.g_key_file_error_quark();
	}

}
internal class GKeyFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GKeyFileHandle g_key_file_new();

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_free(GKeyFileHandle key_file);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_get_boolean(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_boolean_list(GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_get_comment(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern double g_key_file_get_double(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_double_list(GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_groups(GKeyFileHandle key_file, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern long g_key_file_get_int64(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_key_file_get_integer(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_integer_list(GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_keys(GKeyFileHandle key_file, string group_name, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_get_locale_for_key(GKeyFileHandle key_file, string group_name, string key, string locale);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_get_locale_string(GKeyFileHandle key_file, string group_name, string key, string locale, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_locale_string_list(GKeyFileHandle key_file, string group_name, string key, string locale, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_get_start_group(GKeyFileHandle key_file);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_get_string(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_key_file_get_string_list(GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern ulong g_key_file_get_uint64(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_get_value(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_has_group(GKeyFileHandle key_file, string group_name);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_has_key(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_load_from_bytes(GKeyFileHandle key_file, GBytesHandle bytes, GKeyFileFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_load_from_data(GKeyFileHandle key_file, string data, UIntPtr length, GKeyFileFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_load_from_data_dirs(GKeyFileHandle key_file, string file, out string full_path, GKeyFileFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_load_from_dirs(GKeyFileHandle key_file, string file, string[] search_dirs, out string full_path, GKeyFileFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_load_from_file(GKeyFileHandle key_file, string file, GKeyFileFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GKeyFileHandle g_key_file_ref(GKeyFileHandle key_file);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_remove_comment(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_remove_group(GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_remove_key(GKeyFileHandle key_file, string group_name, string key, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_save_to_file(GKeyFileHandle key_file, string filename, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_boolean(GKeyFileHandle key_file, string group_name, string key, bool value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_boolean_list(GKeyFileHandle key_file, string group_name, string key, bool[] list, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_key_file_set_comment(GKeyFileHandle key_file, string group_name, string key, string comment, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_double(GKeyFileHandle key_file, string group_name, string key, double value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_double_list(GKeyFileHandle key_file, string group_name, string key, double[] list, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_int64(GKeyFileHandle key_file, string group_name, string key, long value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_integer(GKeyFileHandle key_file, string group_name, string key, int value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_integer_list(GKeyFileHandle key_file, string group_name, string key, int[] list, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_list_separator(GKeyFileHandle key_file, char separator);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_locale_string(GKeyFileHandle key_file, string group_name, string key, string locale, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_locale_string_list(GKeyFileHandle key_file, string group_name, string key, string locale, string list, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_string(GKeyFileHandle key_file, string group_name, string key, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_string_list(GKeyFileHandle key_file, string group_name, string key, string list, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_uint64(GKeyFileHandle key_file, string group_name, string key, ulong value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_set_value(GKeyFileHandle key_file, string group_name, string key, string value);

	[DllImport(Libraries.GLib)]
	internal static extern string g_key_file_to_data(GKeyFileHandle key_file, out UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_key_file_unref(GKeyFileHandle key_file);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_key_file_error_quark();

}

public struct GKeyFile
{
}
