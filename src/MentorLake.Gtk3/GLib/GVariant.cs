namespace MentorLake.GLib;

public class GVariantHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GVariantHandle New(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new(format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle NewArray(MentorLake.GLib.GVariantTypeHandle child_type, MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children)
	{
		return GVariantExterns.g_variant_new_array(child_type, children, n_children);
	}

	public static MentorLake.GLib.GVariantHandle NewBoolean(bool value)
	{
		return GVariantExterns.g_variant_new_boolean(value);
	}

	public static MentorLake.GLib.GVariantHandle NewByte(byte value)
	{
		return GVariantExterns.g_variant_new_byte(value);
	}

	public static MentorLake.GLib.GVariantHandle NewBytestring(byte[] @string)
	{
		return GVariantExterns.g_variant_new_bytestring(@string);
	}

	public static MentorLake.GLib.GVariantHandle NewBytestringArray(string[] strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_bytestring_array(strv, length);
	}

	public static MentorLake.GLib.GVariantHandle NewDictEntry(MentorLake.GLib.GVariantHandle key, MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_dict_entry(key, value);
	}

	public static MentorLake.GLib.GVariantHandle NewDouble(double value)
	{
		return GVariantExterns.g_variant_new_double(value);
	}

	public static MentorLake.GLib.GVariantHandle NewFixedArray(MentorLake.GLib.GVariantTypeHandle element_type, IntPtr elements, UIntPtr n_elements, UIntPtr element_size)
	{
		return GVariantExterns.g_variant_new_fixed_array(element_type, elements, n_elements, element_size);
	}

	public static MentorLake.GLib.GVariantHandle NewFromBytes(MentorLake.GLib.GVariantTypeHandle type, MentorLake.GLib.GBytesHandle bytes, bool trusted)
	{
		return GVariantExterns.g_variant_new_from_bytes(type, bytes, trusted);
	}

	public static MentorLake.GLib.GVariantHandle NewFromData(MentorLake.GLib.GVariantTypeHandle type, byte[] data, UIntPtr size, bool trusted, MentorLake.GLib.GDestroyNotify notify, IntPtr user_data)
	{
		return GVariantExterns.g_variant_new_from_data(type, data, size, trusted, notify, user_data);
	}

	public static MentorLake.GLib.GVariantHandle NewHandle(int value)
	{
		return GVariantExterns.g_variant_new_handle(value);
	}

	public static MentorLake.GLib.GVariantHandle NewInt16(short value)
	{
		return GVariantExterns.g_variant_new_int16(value);
	}

	public static MentorLake.GLib.GVariantHandle NewInt32(int value)
	{
		return GVariantExterns.g_variant_new_int32(value);
	}

	public static MentorLake.GLib.GVariantHandle NewInt64(long value)
	{
		return GVariantExterns.g_variant_new_int64(value);
	}

	public static MentorLake.GLib.GVariantHandle NewMaybe(MentorLake.GLib.GVariantTypeHandle child_type, MentorLake.GLib.GVariantHandle child)
	{
		return GVariantExterns.g_variant_new_maybe(child_type, child);
	}

	public static MentorLake.GLib.GVariantHandle NewObjectPath(string object_path)
	{
		return GVariantExterns.g_variant_new_object_path(object_path);
	}

	public static MentorLake.GLib.GVariantHandle NewObjv(string[] strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_objv(strv, length);
	}

	public static MentorLake.GLib.GVariantHandle NewParsed(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed(format, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle NewParsedVa(string format, IntPtr app)
	{
		return GVariantExterns.g_variant_new_parsed_va(format, app);
	}

	public static MentorLake.GLib.GVariantHandle NewPrintf(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_printf(format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle NewSignature(string signature)
	{
		return GVariantExterns.g_variant_new_signature(signature);
	}

	public static MentorLake.GLib.GVariantHandle NewString(string @string)
	{
		return GVariantExterns.g_variant_new_string(@string);
	}

	public static MentorLake.GLib.GVariantHandle NewStrv(string[] strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_strv(strv, length);
	}

	public static MentorLake.GLib.GVariantHandle NewTakeString(string @string)
	{
		return GVariantExterns.g_variant_new_take_string(@string);
	}

	public static MentorLake.GLib.GVariantHandle NewTuple(MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children)
	{
		return GVariantExterns.g_variant_new_tuple(children, n_children);
	}

	public static MentorLake.GLib.GVariantHandle NewUint16(ushort value)
	{
		return GVariantExterns.g_variant_new_uint16(value);
	}

	public static MentorLake.GLib.GVariantHandle NewUint32(uint value)
	{
		return GVariantExterns.g_variant_new_uint32(value);
	}

	public static MentorLake.GLib.GVariantHandle NewUint64(ulong value)
	{
		return GVariantExterns.g_variant_new_uint64(value);
	}

	public static MentorLake.GLib.GVariantHandle NewVa(string format_string, string endptr, IntPtr app)
	{
		return GVariantExterns.g_variant_new_va(format_string, endptr, app);
	}

	public static MentorLake.GLib.GVariantHandle NewVariant(MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_variant(value);
	}

}


public static class GVariantExtensions
{
	public static MentorLake.GLib.GVariantHandle Byteswap(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_byteswap(value);
	}

	public static bool CheckFormatString(this MentorLake.GLib.GVariantHandle value, string format_string, bool copy_only)
	{
		return GVariantExterns.g_variant_check_format_string(value, format_string, copy_only);
	}

	public static MentorLake.GLib.GVariantClass Classify(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_classify(value);
	}

	public static int Compare(this MentorLake.GLib.GVariantHandle one, MentorLake.GLib.GVariantHandle two)
	{
		return GVariantExterns.g_variant_compare(one, two);
	}

	public static byte[] DupBytestring(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_bytestring(value, out length);
	}

	public static string[] DupBytestringArray(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_bytestring_array(value, out length);
	}

	public static string[] DupObjv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_objv(value, out length);
	}

	public static string DupString(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_string(value, out length);
	}

	public static string[] DupStrv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_strv(value, out length);
	}

	public static bool Equal(this MentorLake.GLib.GVariantHandle one, MentorLake.GLib.GVariantHandle two)
	{
		return GVariantExterns.g_variant_equal(one, two);
	}

	public static void Get(this MentorLake.GLib.GVariantHandle value, string format_string, IntPtr @__arglist)
	{
		GVariantExterns.g_variant_get(value, format_string, @__arglist);
	}

	public static bool GetBoolean(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_boolean(value);
	}

	public static byte GetByte(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_byte(value);
	}

	public static byte[] GetBytestring(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_bytestring(value);
	}

	public static string[] GetBytestringArray(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_bytestring_array(value, out length);
	}

	public static void GetChild(this MentorLake.GLib.GVariantHandle value, UIntPtr index_, string format_string, IntPtr @__arglist)
	{
		GVariantExterns.g_variant_get_child(value, index_, format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle GetChildValue(this MentorLake.GLib.GVariantHandle value, UIntPtr index_)
	{
		return GVariantExterns.g_variant_get_child_value(value, index_);
	}

	public static IntPtr GetData(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_data(value);
	}

	public static MentorLake.GLib.GBytesHandle GetDataAsBytes(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_data_as_bytes(value);
	}

	public static double GetDouble(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_double(value);
	}

	public static IntPtr[] GetFixedArray(this MentorLake.GLib.GVariantHandle value, out UIntPtr n_elements, UIntPtr element_size)
	{
		return GVariantExterns.g_variant_get_fixed_array(value, out n_elements, element_size);
	}

	public static int GetHandle(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_handle(value);
	}

	public static short GetInt16(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int16(value);
	}

	public static int GetInt32(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int32(value);
	}

	public static long GetInt64(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int64(value);
	}

	public static MentorLake.GLib.GVariantHandle GetMaybe(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_maybe(value);
	}

	public static MentorLake.GLib.GVariantHandle GetNormalForm(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_normal_form(value);
	}

	public static string[] GetObjv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_objv(value, out length);
	}

	public static UIntPtr GetSize(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_size(value);
	}

	public static string GetString(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_string(value, out length);
	}

	public static string[] GetStrv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_strv(value, out length);
	}

	public static MentorLake.GLib.GVariantTypeHandle GetType(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_type(value);
	}

	public static string GetTypeString(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_type_string(value);
	}

	public static ushort GetUint16(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint16(value);
	}

	public static uint GetUint32(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint32(value);
	}

	public static ulong GetUint64(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint64(value);
	}

	public static void GetVa(this MentorLake.GLib.GVariantHandle value, string format_string, string endptr, IntPtr app)
	{
		GVariantExterns.g_variant_get_va(value, format_string, endptr, app);
	}

	public static MentorLake.GLib.GVariantHandle GetVariant(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_variant(value);
	}

	public static uint Hash(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_hash(value);
	}

	public static bool IsContainer(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_container(value);
	}

	public static bool IsFloating(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_floating(value);
	}

	public static bool IsNormalForm(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_normal_form(value);
	}

	public static bool IsOfType(this MentorLake.GLib.GVariantHandle value, MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantExterns.g_variant_is_of_type(value, type);
	}

	public static MentorLake.GLib.GVariantIterHandle IterNew(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_iter_new(value);
	}

	public static bool Lookup(this MentorLake.GLib.GVariantHandle dictionary, string key, string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_lookup(dictionary, key, format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle LookupValue(this MentorLake.GLib.GVariantHandle dictionary, string key, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		return GVariantExterns.g_variant_lookup_value(dictionary, key, expected_type);
	}

	public static UIntPtr NChildren(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_n_children(value);
	}

	public static string Print(this MentorLake.GLib.GVariantHandle value, bool type_annotate)
	{
		return GVariantExterns.g_variant_print(value, type_annotate);
	}

	public static MentorLake.GLib.GStringHandle PrintString(this MentorLake.GLib.GVariantHandle value, MentorLake.GLib.GStringHandle @string, bool type_annotate)
	{
		return GVariantExterns.g_variant_print_string(value, @string, type_annotate);
	}

	public static MentorLake.GLib.GVariantHandle Ref(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_ref(value);
	}

	public static MentorLake.GLib.GVariantHandle RefSink(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_ref_sink(value);
	}

	public static void Store(this MentorLake.GLib.GVariantHandle value, IntPtr data)
	{
		GVariantExterns.g_variant_store(value, data);
	}

	public static MentorLake.GLib.GVariantHandle TakeRef(this MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_take_ref(value);
	}

	public static void Unref(this MentorLake.GLib.GVariantHandle value)
	{
		GVariantExterns.g_variant_unref(value);
	}


	public static GVariant Dereference(this GVariantHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariant>(x.DangerousGetHandle());
}
internal class GVariantExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new(string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle child_type, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_boolean(bool value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_byte(byte value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_bytestring(byte[] @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_bytestring_array(string[] strv, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_dict_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_double(double value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_fixed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle element_type, IntPtr elements, UIntPtr n_elements, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, bool trusted);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, byte[] data, UIntPtr size, bool trusted, MentorLake.GLib.GDestroyNotify notify, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_handle(int value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_int16(short value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_int32(int value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_int64(long value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle child_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle child);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_object_path(string object_path);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_objv(string[] strv, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_parsed(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_parsed_va(string format, IntPtr app);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_printf(string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_signature(string signature);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_strv(string[] strv, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_take_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_tuple([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_uint16(ushort value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_uint32(uint value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_uint64(ulong value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_va(string format_string, string endptr, IntPtr app);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_byteswap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_check_format_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, string format_string, bool copy_only);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantClass g_variant_classify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_variant_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle one, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle two);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_variant_dup_bytestring([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_dup_bytestring_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_dup_objv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_dup_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_dup_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle one, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle two);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_variant_get_byte([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_variant_get_bytestring([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_get_bytestring_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, UIntPtr index_, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_child_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, UIntPtr index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_variant_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_variant_get_data_as_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_variant_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr[] g_variant_get_fixed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr n_elements, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_variant_get_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern short g_variant_get_int16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_variant_get_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_variant_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_normal_form([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_get_objv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_get_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_get_type_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern ushort g_variant_get_uint16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_variant_get_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern ulong g_variant_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_get_va([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, string format_string, string endptr, IntPtr app);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_variant_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_container([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_floating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_normal_form([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_of_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantIterHandle g_variant_iter_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle dictionary, string key, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_lookup_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle dictionary, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, bool type_annotate);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_variant_print_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, bool type_annotate);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_ref_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_store([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_take_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_object_path(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_signature(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr, IntPtr error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_parse_error_print_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, string source_str);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_variant_parse_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_variant_parser_get_error_quark();

}

public struct GVariant
{
	public static bool IsObjectPath(string @string)
	{
		return GVariantExterns.g_variant_is_object_path(@string);
	}

	public static bool IsSignature(string @string)
	{
		return GVariantExterns.g_variant_is_signature(@string);
	}

	public static MentorLake.GLib.GVariantHandle Parse(MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr, IntPtr error)
	{
		return GVariantExterns.g_variant_parse(type, text, limit, endptr, error);
	}

	public static string ParseErrorPrintContext(MentorLake.GLib.GErrorHandle error, string source_str)
	{
		return GVariantExterns.g_variant_parse_error_print_context(error, source_str);
	}

	public static MentorLake.GLib.GQuark ParseErrorQuark()
	{
		return GVariantExterns.g_variant_parse_error_quark();
	}

	public static MentorLake.GLib.GQuark ParserGetErrorQuark()
	{
		return GVariantExterns.g_variant_parser_get_error_quark();
	}

}
