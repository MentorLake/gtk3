namespace MentorLake.GLib;

public class GBytesHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GBytesHandle New(byte[] data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new(data, size);
	}

	public static MentorLake.GLib.GBytesHandle NewStatic(byte[] data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new_static(data, size);
	}

	public static MentorLake.GLib.GBytesHandle NewTake(byte[] data, UIntPtr size)
	{
		return GBytesExterns.g_bytes_new_take(data, size);
	}

	public static MentorLake.GLib.GBytesHandle NewWithFreeFunc(byte[] data, UIntPtr size, MentorLake.GLib.GDestroyNotify free_func, IntPtr user_data)
	{
		return GBytesExterns.g_bytes_new_with_free_func(data, size, free_func, user_data);
	}

}


public static class GBytesExtensions
{
	public static int Compare(this MentorLake.GLib.GBytesHandle bytes1, MentorLake.GLib.GBytesHandle bytes2)
	{
		if (bytes1.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_compare(bytes1, bytes2);
	}

	public static bool Equal(this MentorLake.GLib.GBytesHandle bytes1, MentorLake.GLib.GBytesHandle bytes2)
	{
		if (bytes1.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_equal(bytes1, bytes2);
	}

	public static byte[] GetData(this MentorLake.GLib.GBytesHandle bytes, out UIntPtr size)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_get_data(bytes, out size);
	}

	public static IntPtr GetRegion(this MentorLake.GLib.GBytesHandle bytes, UIntPtr element_size, UIntPtr offset, UIntPtr n_elements)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_get_region(bytes, element_size, offset, n_elements);
	}

	public static UIntPtr GetSize(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_get_size(bytes);
	}

	public static uint Hash(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_hash(bytes);
	}

	public static MentorLake.GLib.GBytesHandle NewFromBytes(this MentorLake.GLib.GBytesHandle bytes, UIntPtr offset, UIntPtr length)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_new_from_bytes(bytes, offset, length);
	}

	public static MentorLake.GLib.GBytesHandle Ref(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_ref(bytes);
	}

	public static void Unref(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		GBytesExterns.g_bytes_unref(bytes);
	}

	public static MentorLake.GLib.GByteArrayHandle UnrefToArray(this MentorLake.GLib.GBytesHandle bytes)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_unref_to_array(bytes);
	}

	public static byte[] UnrefToData(this MentorLake.GLib.GBytesHandle bytes, out UIntPtr size)
	{
		if (bytes.IsInvalid) throw new Exception("Invalid handle (GBytes)");
		return GBytesExterns.g_bytes_unref_to_data(bytes, out size);
	}


	public static GBytes Dereference(this GBytesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBytes>(x.DangerousGetHandle());
}
internal class GBytesExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new(byte[] data, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_static(byte[] data, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_take(byte[] data, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_with_free_func(byte[] data, UIntPtr size, MentorLake.GLib.GDestroyNotify free_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bytes_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes2);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bytes_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes2);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_bytes_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, out UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_bytes_get_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, UIntPtr element_size, UIntPtr offset, UIntPtr n_elements);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_bytes_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_bytes_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, UIntPtr offset, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bytes_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_bytes_unref_to_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_bytes_unref_to_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, out UIntPtr size);

}

public struct GBytes
{
}
