namespace MentorLake.GObject;

public class GValueArrayHandle : BaseSafeHandle
{
	public static MentorLake.GObject.GValueArrayHandle New(uint n_prealloced)
	{
		return GValueArrayExterns.g_value_array_new(n_prealloced);
	}

}


public static class GValueArrayExtensions
{
	public static MentorLake.GObject.GValueArrayHandle Append(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GObject.GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_append(value_array, value);
	}

	public static MentorLake.GObject.GValueArrayHandle Copy(this MentorLake.GObject.GValueArrayHandle value_array)
	{
		return GValueArrayExterns.g_value_array_copy(value_array);
	}

	public static void Free(this MentorLake.GObject.GValueArrayHandle value_array)
	{
		GValueArrayExterns.g_value_array_free(value_array);
	}

	public static MentorLake.GObject.GValueHandle GetNth(this MentorLake.GObject.GValueArrayHandle value_array, uint index_)
	{
		return GValueArrayExterns.g_value_array_get_nth(value_array, index_);
	}

	public static MentorLake.GObject.GValueArrayHandle Insert(this MentorLake.GObject.GValueArrayHandle value_array, uint index_, MentorLake.GObject.GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_insert(value_array, index_, value);
	}

	public static MentorLake.GObject.GValueArrayHandle Prepend(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GObject.GValueHandle value)
	{
		return GValueArrayExterns.g_value_array_prepend(value_array, value);
	}

	public static MentorLake.GObject.GValueArrayHandle Remove(this MentorLake.GObject.GValueArrayHandle value_array, uint index_)
	{
		return GValueArrayExterns.g_value_array_remove(value_array, index_);
	}

	public static MentorLake.GObject.GValueArrayHandle Sort(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareFunc compare_func)
	{
		return GValueArrayExterns.g_value_array_sort(value_array, compare_func);
	}

	public static MentorLake.GObject.GValueArrayHandle SortWithData(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GValueArrayExterns.g_value_array_sort_with_data(value_array, compare_func, user_data);
	}


	public static GValueArray Dereference(this GValueArrayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GValueArray>(x.DangerousGetHandle());
}
internal class GValueArrayExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_new(uint n_prealloced);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueHandle g_value_array_get_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, uint index_);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, uint index_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, uint index_);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

}

public struct GValueArray
{
	public uint n_values;
	public IntPtr values;
}
