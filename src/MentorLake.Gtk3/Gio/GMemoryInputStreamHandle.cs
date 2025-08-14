namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GMemoryInputStream` is a class for using arbitrary
/// memory chunks as input for GIO streaming input operations.
/// </para>
/// <para>
/// As of GLib 2.34, `GMemoryInputStream` implements
/// [iface@Gio.PollableInputStream].
/// </para>
/// </summary>

public class GMemoryInputStreamHandle : GInputStreamHandle, GPollableInputStreamHandle, GSeekableHandle
{
/// <summary>
/// <para>
/// Creates a new empty #GMemoryInputStream.
/// </para>
/// </summary>

/// <return>
/// a new #GInputStream
/// </return>

	public static MentorLake.Gio.GMemoryInputStreamHandle New()
	{
		return GMemoryInputStreamHandleExterns.g_memory_input_stream_new();
	}

/// <summary>
/// <para>
/// Creates a new #GMemoryInputStream with data from the given @bytes.
/// </para>
/// </summary>

/// <param name="bytes">
/// a #GBytes
/// </param>
/// <return>
/// new #GInputStream read from @bytes
/// </return>

	public static MentorLake.Gio.GMemoryInputStreamHandle NewFromBytes(MentorLake.GLib.GBytesHandle bytes)
	{
		return GMemoryInputStreamHandleExterns.g_memory_input_stream_new_from_bytes(bytes);
	}

/// <summary>
/// <para>
/// Creates a new #GMemoryInputStream with data in memory of a given size.
/// </para>
/// </summary>

/// <param name="data">
/// input data
/// </param>
/// <param name="len">
/// length of the data, may be -1 if @data is a nul-terminated string
/// </param>
/// <param name="destroy">
/// function that is called to free @data, or %NULL
/// </param>
/// <return>
/// new #GInputStream read from @data of @len bytes.
/// </return>

	public static MentorLake.Gio.GMemoryInputStreamHandle NewFromData(byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy)
	{
		return GMemoryInputStreamHandleExterns.g_memory_input_stream_new_from_data(data, len, destroy);
	}

}

public static class GMemoryInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Appends @bytes to data that can be read from the input stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GMemoryInputStream
/// </param>
/// <param name="bytes">
/// input data
/// </param>

	public static T AddBytes<T>(this T stream, MentorLake.GLib.GBytesHandle bytes) where T : GMemoryInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GMemoryInputStreamHandle)");
		GMemoryInputStreamHandleExterns.g_memory_input_stream_add_bytes(stream, bytes);
		return stream;
	}

/// <summary>
/// <para>
/// Appends @data to data that can be read from the input stream
/// </para>
/// </summary>

/// <param name="stream">
/// a #GMemoryInputStream
/// </param>
/// <param name="data">
/// input data
/// </param>
/// <param name="len">
/// length of the data, may be -1 if @data is a nul-terminated string
/// </param>
/// <param name="destroy">
/// function that is called to free @data, or %NULL
/// </param>

	public static T AddData<T>(this T stream, byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy) where T : GMemoryInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GMemoryInputStreamHandle)");
		GMemoryInputStreamHandleExterns.g_memory_input_stream_add_data(stream, data, len, destroy);
		return stream;
	}

}

internal class GMemoryInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))]
	internal static extern MentorLake.Gio.GMemoryInputStreamHandle g_memory_input_stream_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))]
	internal static extern MentorLake.Gio.GMemoryInputStreamHandle g_memory_input_stream_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))]
	internal static extern MentorLake.Gio.GMemoryInputStreamHandle g_memory_input_stream_new_from_data(byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_memory_input_stream_add_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))] MentorLake.Gio.GMemoryInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_memory_input_stream_add_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))] MentorLake.Gio.GMemoryInputStreamHandle stream, byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy);

}
