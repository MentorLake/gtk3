namespace MentorLake.Gtk3.GLib;

public class GVariantDictHandle : BaseSafeHandle
{
	public static GVariantDictHandle New(GVariantHandle from_asv)
	{
		return GVariantDictExterns.g_variant_dict_new(from_asv);
	}

}


public static class GVariantDictHandleExtensions
{
	public static T Clear<T>(this T dict) where T : GVariantDictHandle
	{
		GVariantDictExterns.g_variant_dict_clear(dict);
		return dict;
	}

	public static bool Contains(this GVariantDictHandle dict, string key)
	{
		return GVariantDictExterns.g_variant_dict_contains(dict, key);
	}

	public static GVariantHandle End(this GVariantDictHandle dict)
	{
		return GVariantDictExterns.g_variant_dict_end(dict);
	}

	public static T Init<T>(this T dict, GVariantHandle from_asv) where T : GVariantDictHandle
	{
		GVariantDictExterns.g_variant_dict_init(dict, from_asv);
		return dict;
	}

	public static T Insert<T>(this T dict, string key, string format_string, IntPtr @__arglist) where T : GVariantDictHandle
	{
		GVariantDictExterns.g_variant_dict_insert(dict, key, format_string, @__arglist);
		return dict;
	}

	public static T InsertValue<T>(this T dict, string key, GVariantHandle value) where T : GVariantDictHandle
	{
		GVariantDictExterns.g_variant_dict_insert_value(dict, key, value);
		return dict;
	}

	public static bool Lookup(this GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		return GVariantDictExterns.g_variant_dict_lookup(dict, key, format_string, @__arglist);
	}

	public static GVariantHandle LookupValue(this GVariantDictHandle dict, string key, GVariantTypeHandle expected_type)
	{
		return GVariantDictExterns.g_variant_dict_lookup_value(dict, key, expected_type);
	}

	public static GVariantDictHandle Ref(this GVariantDictHandle dict)
	{
		return GVariantDictExterns.g_variant_dict_ref(dict);
	}

	public static bool Remove(this GVariantDictHandle dict, string key)
	{
		return GVariantDictExterns.g_variant_dict_remove(dict, key);
	}

	public static T Unref<T>(this T dict) where T : GVariantDictHandle
	{
		GVariantDictExterns.g_variant_dict_unref(dict);
		return dict;
	}

}
internal class GVariantDictExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantDictHandle g_variant_dict_new(GVariantHandle from_asv);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_clear(GVariantDictHandle dict);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_dict_contains(GVariantDictHandle dict, string key);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_dict_end(GVariantDictHandle dict);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_init(GVariantDictHandle dict, GVariantHandle from_asv);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_insert(GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_insert_value(GVariantDictHandle dict, string key, GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_dict_lookup(GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_dict_lookup_value(GVariantDictHandle dict, string key, GVariantTypeHandle expected_type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantDictHandle g_variant_dict_ref(GVariantDictHandle dict);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_dict_remove(GVariantDictHandle dict, string key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_dict_unref(GVariantDictHandle dict);

}

public struct GVariantDict
{
}
