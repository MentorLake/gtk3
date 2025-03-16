namespace MentorLake.GLib;

public class GVariantTypeHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GVariantTypeHandle New(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_new(type_string);
	}

	public static MentorLake.GLib.GVariantTypeHandle NewArray(MentorLake.GLib.GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_array(element);
	}

	public static MentorLake.GLib.GVariantTypeHandle NewDictEntry(MentorLake.GLib.GVariantTypeHandle key, MentorLake.GLib.GVariantTypeHandle value)
	{
		return GVariantTypeExterns.g_variant_type_new_dict_entry(key, value);
	}

	public static MentorLake.GLib.GVariantTypeHandle NewMaybe(MentorLake.GLib.GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_maybe(element);
	}

	public static MentorLake.GLib.GVariantTypeHandle NewTuple(MentorLake.GLib.GVariantTypeHandle[] items, int length)
	{
		return GVariantTypeExterns.g_variant_type_new_tuple(items, length);
	}

}


public static class GVariantTypeExtensions
{
	public static MentorLake.GLib.GVariantTypeHandle Copy(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_copy(type);
	}

	public static string DupString(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_dup_string(type);
	}

	public static MentorLake.GLib.GVariantTypeHandle Element(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_element(type);
	}

	public static bool Equal(this MentorLake.GLib.GVariantTypeHandle type1, MentorLake.GLib.GVariantTypeHandle type2)
	{
		return GVariantTypeExterns.g_variant_type_equal(type1, type2);
	}

	public static MentorLake.GLib.GVariantTypeHandle First(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_first(type);
	}

	public static void Free(this MentorLake.GLib.GVariantTypeHandle type)
	{
		GVariantTypeExterns.g_variant_type_free(type);
	}

	public static UIntPtr GetStringLength(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_get_string_length(type);
	}

	public static uint Hash(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_hash(type);
	}

	public static bool IsArray(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_array(type);
	}

	public static bool IsBasic(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_basic(type);
	}

	public static bool IsContainer(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_container(type);
	}

	public static bool IsDefinite(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_definite(type);
	}

	public static bool IsDictEntry(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_dict_entry(type);
	}

	public static bool IsMaybe(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_maybe(type);
	}

	public static bool IsSubtypeOf(this MentorLake.GLib.GVariantTypeHandle type, MentorLake.GLib.GVariantTypeHandle supertype)
	{
		return GVariantTypeExterns.g_variant_type_is_subtype_of(type, supertype);
	}

	public static bool IsTuple(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_tuple(type);
	}

	public static bool IsVariant(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_variant(type);
	}

	public static MentorLake.GLib.GVariantTypeHandle Key(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_key(type);
	}

	public static UIntPtr NItems(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_n_items(type);
	}

	public static MentorLake.GLib.GVariantTypeHandle Next(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_next(type);
	}

	public static string PeekString(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_peek_string(type);
	}

	public static MentorLake.GLib.GVariantTypeHandle Value(this MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_value(type);
	}


	public static GVariantType Dereference(this GVariantTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantType>(x.DangerousGetHandle());
}
internal class GVariantTypeExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle element);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_dict_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle element);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_tuple([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle[] items, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_type_dup_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_element([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_type_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_get_string_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_variant_type_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_basic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_container([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_definite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_dict_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_subtype_of([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle supertype);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_tuple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_type_peek_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_checked_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_string_get_depth_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_is_valid(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_scan(string @string, string limit, out string endptr);

}

public struct GVariantType
{
	public static MentorLake.GLib.GVariantTypeHandle Checked(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_checked_(type_string);
	}

	public static UIntPtr StringGetDepth(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_string_get_depth_(type_string);
	}

	public static bool StringIsValid(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_string_is_valid(type_string);
	}

	public static bool StringScan(string @string, string limit, out string endptr)
	{
		return GVariantTypeExterns.g_variant_type_string_scan(@string, limit, out endptr);
	}

}
