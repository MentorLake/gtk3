namespace MentorLake.GLib;

public class GStringHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GStringHandle New(string init)
	{
		return GStringExterns.g_string_new(init);
	}

	public static MentorLake.GLib.GStringHandle NewLen(string init, UIntPtr len)
	{
		return GStringExterns.g_string_new_len(init, len);
	}

	public static MentorLake.GLib.GStringHandle NewTake(string init)
	{
		return GStringExterns.g_string_new_take(init);
	}

	public static MentorLake.GLib.GStringHandle SizedNew(UIntPtr dfl_size)
	{
		return GStringExterns.g_string_sized_new(dfl_size);
	}

}


public static class GStringExtensions
{
	public static MentorLake.GLib.GStringHandle Append(this MentorLake.GLib.GStringHandle @string, string val)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_append(@string, val);
	}

	public static MentorLake.GLib.GStringHandle AppendC(this MentorLake.GLib.GStringHandle @string, char c)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_append_c(@string, c);
	}

	public static MentorLake.GLib.GStringHandle AppendLen(this MentorLake.GLib.GStringHandle @string, string val, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_append_len(@string, val, len);
	}

	public static void AppendPrintf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		GStringExterns.g_string_append_printf(@string, format, @__arglist);
	}

	public static MentorLake.GLib.GStringHandle AppendUnichar(this MentorLake.GLib.GStringHandle @string, char wc)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_append_unichar(@string, wc);
	}

	public static MentorLake.GLib.GStringHandle AppendUriEscaped(this MentorLake.GLib.GStringHandle @string, string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_append_uri_escaped(@string, unescaped, reserved_chars_allowed, allow_utf8);
	}

	public static void AppendVprintf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr args)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		GStringExterns.g_string_append_vprintf(@string, format, args);
	}

	public static MentorLake.GLib.GStringHandle AsciiDown(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_ascii_down(@string);
	}

	public static MentorLake.GLib.GStringHandle AsciiUp(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_ascii_up(@string);
	}

	public static MentorLake.GLib.GStringHandle Assign(this MentorLake.GLib.GStringHandle @string, string rval)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_assign(@string, rval);
	}

	public static MentorLake.GLib.GStringHandle Down(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_down(@string);
	}

	public static bool Equal(this MentorLake.GLib.GStringHandle v, MentorLake.GLib.GStringHandle v2)
	{
		if (v.IsInvalid || v.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_equal(v, v2);
	}

	public static MentorLake.GLib.GStringHandle Erase(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_erase(@string, pos, len);
	}

	public static string Free(this MentorLake.GLib.GStringHandle @string, bool free_segment)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_free(@string, free_segment);
	}

	public static string FreeAndSteal(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_free_and_steal(@string);
	}

	public static MentorLake.GLib.GBytesHandle FreeToBytes(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_free_to_bytes(@string);
	}

	public static uint Hash(this MentorLake.GLib.GStringHandle str)
	{
		if (str.IsInvalid || str.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_hash(str);
	}

	public static MentorLake.GLib.GStringHandle Insert(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_insert(@string, pos, val);
	}

	public static MentorLake.GLib.GStringHandle InsertC(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, char c)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_insert_c(@string, pos, c);
	}

	public static MentorLake.GLib.GStringHandle InsertLen(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_insert_len(@string, pos, val, len);
	}

	public static MentorLake.GLib.GStringHandle InsertUnichar(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, char wc)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_insert_unichar(@string, pos, wc);
	}

	public static MentorLake.GLib.GStringHandle Overwrite(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_overwrite(@string, pos, val);
	}

	public static MentorLake.GLib.GStringHandle OverwriteLen(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_overwrite_len(@string, pos, val, len);
	}

	public static MentorLake.GLib.GStringHandle Prepend(this MentorLake.GLib.GStringHandle @string, string val)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_prepend(@string, val);
	}

	public static MentorLake.GLib.GStringHandle PrependC(this MentorLake.GLib.GStringHandle @string, char c)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_prepend_c(@string, c);
	}

	public static MentorLake.GLib.GStringHandle PrependLen(this MentorLake.GLib.GStringHandle @string, string val, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_prepend_len(@string, val, len);
	}

	public static MentorLake.GLib.GStringHandle PrependUnichar(this MentorLake.GLib.GStringHandle @string, char wc)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_prepend_unichar(@string, wc);
	}

	public static void Printf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		GStringExterns.g_string_printf(@string, format, @__arglist);
	}

	public static uint Replace(this MentorLake.GLib.GStringHandle @string, string find, string replace, uint limit)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_replace(@string, find, replace, limit);
	}

	public static MentorLake.GLib.GStringHandle SetSize(this MentorLake.GLib.GStringHandle @string, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_set_size(@string, len);
	}

	public static MentorLake.GLib.GStringHandle Truncate(this MentorLake.GLib.GStringHandle @string, UIntPtr len)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_truncate(@string, len);
	}

	public static MentorLake.GLib.GStringHandle Up(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		return GStringExterns.g_string_up(@string);
	}

	public static void Vprintf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr args)
	{
		if (@string.IsInvalid || @string.IsClosed) throw new Exception("Invalid or closed handle (GString)");
		GStringExterns.g_string_vprintf(@string, format, args);
	}


	public static GString Dereference(this GStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GString>(x.DangerousGetHandle());
}
internal class GStringExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_new(string init);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_new_len(string init, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_new_take(string init);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_sized_new(UIntPtr dfl_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_c([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_append_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char wc);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_uri_escaped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_append_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_ascii_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_ascii_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_assign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string rval);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_string_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_erase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_free_and_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_string_free_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_string_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle str);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert_c([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, char wc);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_overwrite_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend_c([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char wc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_string_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string find, string replace, uint limit);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle g_string_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr args);

}

public struct GString
{
	public string str;
	public UIntPtr len;
	public UIntPtr allocated_len;
}
