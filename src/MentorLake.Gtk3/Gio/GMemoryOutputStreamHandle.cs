namespace MentorLake.Gio;

public class GMemoryOutputStreamHandle : GOutputStreamHandle, GPollableOutputStreamHandle, GSeekableHandle
{
	public static MentorLake.Gio.GMemoryOutputStreamHandle New(IntPtr data, UIntPtr size, MentorLake.Gio.GReallocFunc realloc_function, MentorLake.GLib.GDestroyNotify destroy_function)
	{
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_new(data, size, realloc_function, destroy_function);
	}

	public static MentorLake.Gio.GMemoryOutputStreamHandle NewResizable()
	{
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_new_resizable();
	}

}

public static class GMemoryOutputStreamHandleExtensions
{
	public static IntPtr GetData(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_get_data(ostream);
	}

	public static UIntPtr GetDataSize(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_get_data_size(ostream);
	}

	public static UIntPtr GetSize(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_get_size(ostream);
	}

	public static MentorLake.GLib.GBytesHandle StealAsBytes(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_steal_as_bytes(ostream);
	}

	public static IntPtr StealData(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_steal_data(ostream);
	}

}

internal class GMemoryOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GMemoryOutputStreamHandle g_memory_output_stream_new(IntPtr data, UIntPtr size, MentorLake.Gio.GReallocFunc realloc_function, MentorLake.GLib.GDestroyNotify destroy_function);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GMemoryOutputStreamHandle g_memory_output_stream_new_resizable();

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_memory_output_stream_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))] MentorLake.Gio.GMemoryOutputStreamHandle ostream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_memory_output_stream_get_data_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))] MentorLake.Gio.GMemoryOutputStreamHandle ostream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_memory_output_stream_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))] MentorLake.Gio.GMemoryOutputStreamHandle ostream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_memory_output_stream_steal_as_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))] MentorLake.Gio.GMemoryOutputStreamHandle ostream);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_memory_output_stream_steal_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryOutputStreamHandle>))] MentorLake.Gio.GMemoryOutputStreamHandle ostream);

}
