namespace MentorLake.GLib;

public class GVariantDictHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GVariantDictHandle New(MentorLake.GLib.GVariantHandle from_asv)
	{
		return GVariantDictExterns.g_variant_dict_new(from_asv);
	}

}


public static class GVariantDictExtensions
{
	public static void Clear(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_clear(dict);
	}

	public static bool Contains(this MentorLake.GLib.GVariantDictHandle dict, string key)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_contains(dict, key);
	}

	public static MentorLake.GLib.GVariantHandle End(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_end(dict);
	}

	public static void Init(this MentorLake.GLib.GVariantDictHandle dict, MentorLake.GLib.GVariantHandle from_asv)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_init(dict, from_asv);
	}

	public static void Insert(this MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_insert(dict, key, format_string, @__arglist);
	}

	public static void InsertValue(this MentorLake.GLib.GVariantDictHandle dict, string key, MentorLake.GLib.GVariantHandle value)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_insert_value(dict, key, value);
	}

	public static bool Lookup(this MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_lookup(dict, key, format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle LookupValue(this MentorLake.GLib.GVariantDictHandle dict, string key, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_lookup_value(dict, key, expected_type);
	}

	public static MentorLake.GLib.GVariantDictHandle Ref(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_ref(dict);
	}

	public static bool Remove(this MentorLake.GLib.GVariantDictHandle dict, string key)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_remove(dict, key);
	}

	public static void Unref(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid || dict.IsClosed) throw new Exception("Invalid or closed handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_unref(dict);
	}


	public static GVariantDict Dereference(this GVariantDictHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantDict>(x.DangerousGetHandle());
}
internal class GVariantDictExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantDictHandle g_variant_dict_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle from_asv);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_dict_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_dict_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle from_asv);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_insert_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_dict_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_dict_lookup_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantDictHandle g_variant_dict_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_dict_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

}

public struct GVariantDict
{
}
