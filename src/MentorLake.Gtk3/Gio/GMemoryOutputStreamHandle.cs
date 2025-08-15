namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GMemoryOutputStream` is a class for using arbitrary
/// memory chunks as output for GIO streaming output operations.
/// </para>
/// <para>
/// As of GLib 2.34, `GMemoryOutputStream` trivially implements
/// [iface@Gio.PollableOutputStream]: it always polls as ready.
/// </para>
/// </summary>

public class GMemoryOutputStreamHandle : GOutputStreamHandle, GPollableOutputStreamHandle, GSeekableHandle
{
/// <summary>
/// <para>
/// Creates a new #GMemoryOutputStream.
/// </para>
/// <para>
/// In most cases this is not the function you want.  See
/// g_memory_output_stream_new_resizable() instead.
/// </para>
/// <para>
/// If @data is non-%NULL, the stream will use that for its internal storage.
/// </para>
/// <para>
/// If @realloc_fn is non-%NULL, it will be used for resizing the internal
/// storage when necessary and the stream will be considered resizable.
/// In that case, the stream will start out being (conceptually) empty.
/// @size is used only as a hint for how big @data is.  Specifically,
/// seeking to the end of a newly-created stream will seek to zero, not
/// @size.  Seeking past the end of the stream and then writing will
/// introduce a zero-filled gap.
/// </para>
/// <para>
/// If @realloc_fn is %NULL then the stream is fixed-sized.  Seeking to
/// the end will seek to @size exactly.  Writing past the end will give
/// an &apos;out of space&apos; error.  Attempting to seek past the end will fail.
/// Unlike the resizable case, seeking to an offset within the stream and
/// writing will preserve the bytes passed in as @data before that point
/// and will return them as part of g_memory_output_stream_steal_data().
/// If you intend to seek you should probably therefore ensure that @data
/// is properly initialised.
/// </para>
/// <para>
/// It is probably only meaningful to provide @data and @size in the case
/// that you want a fixed-sized stream.  Put another way: if @realloc_fn
/// is non-%NULL then it makes most sense to give @data as %NULL and
/// @size as 0 (allowing #GMemoryOutputStream to do the initial
/// allocation for itself).
/// </para>
/// <code>
/// // a stream that can grow
/// // a stream that can grow
/// stream = g_memory_output_stream_new (NULL, 0, realloc, free);
/// 
/// // another stream that can grow
/// stream2 = g_memory_output_stream_new (NULL, 0, g_realloc, g_free);
/// 
/// // a fixed-size stream
/// data = malloc (200);
/// stream3 = g_memory_output_stream_new (data, 200, NULL, free);
/// </code>
/// </summary>

/// <param name="data">
/// pointer to a chunk of memory to use, or %NULL
/// </param>
/// <param name="size">
/// the size of @data
/// </param>
/// <param name="realloc_function">
/// a function with realloc() semantics (like g_realloc())
///     to be called when @data needs to be grown, or %NULL
/// </param>
/// <param name="destroy_function">
/// a function to be called on @data when the stream is
///     finalized, or %NULL
/// </param>
/// <return>
/// A newly created #GMemoryOutputStream object.
/// </return>

	public static MentorLake.Gio.GMemoryOutputStreamHandle New(IntPtr data, UIntPtr size, MentorLake.Gio.GReallocFunc realloc_function, MentorLake.GLib.GDestroyNotify destroy_function)
	{
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_new(data, size, realloc_function, destroy_function);
	}

/// <summary>
/// <para>
/// Creates a new #GMemoryOutputStream, using g_realloc() and g_free()
/// for memory allocation.
/// </para>
/// </summary>


	public static MentorLake.Gio.GMemoryOutputStreamHandle NewResizable()
	{
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_new_resizable();
	}

}

public static class GMemoryOutputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Gets any loaded data from the @ostream.
/// </para>
/// <para>
/// Note that the returned pointer may become invalid on the next
/// write or truncate operation on the stream.
/// </para>
/// </summary>

/// <param name="ostream">
/// a #GMemoryOutputStream
/// </param>
/// <return>
/// pointer to the stream&apos;s data, or %NULL if the data
///    has been stolen
/// </return>

	public static IntPtr GetData(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_get_data(ostream);
	}

/// <summary>
/// <para>
/// Returns the number of bytes from the start up to including the last
/// byte written in the stream that has not been truncated away.
/// </para>
/// </summary>

/// <param name="ostream">
/// a #GMemoryOutputStream
/// </param>
/// <return>
/// the number of bytes written to the stream
/// </return>

	public static UIntPtr GetDataSize(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_get_data_size(ostream);
	}

/// <summary>
/// <para>
/// Gets the size of the currently allocated data area (available from
/// g_memory_output_stream_get_data()).
/// </para>
/// <para>
/// You probably don&apos;t want to use this function on resizable streams.
/// See g_memory_output_stream_get_data_size() instead.  For resizable
/// streams the size returned by this function is an implementation
/// detail and may be change at any time in response to operations on the
/// stream.
/// </para>
/// <para>
/// If the stream is fixed-sized (ie: no realloc was passed to
/// g_memory_output_stream_new()) then this is the maximum size of the
/// stream and further writes will return %G_IO_ERROR_NO_SPACE.
/// </para>
/// <para>
/// In any case, if you want the number of bytes currently written to the
/// stream, use g_memory_output_stream_get_data_size().
/// </para>
/// </summary>

/// <param name="ostream">
/// a #GMemoryOutputStream
/// </param>
/// <return>
/// the number of bytes allocated for the data buffer
/// </return>

	public static UIntPtr GetSize(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_get_size(ostream);
	}

/// <summary>
/// <para>
/// Returns data from the @ostream as a #GBytes. @ostream must be
/// closed before calling this function.
/// </para>
/// </summary>

/// <param name="ostream">
/// a #GMemoryOutputStream
/// </param>
/// <return>
/// the stream&apos;s data
/// </return>

	public static MentorLake.GLib.GBytesHandle StealAsBytes(this MentorLake.Gio.GMemoryOutputStreamHandle ostream)
	{
		if (ostream.IsInvalid) throw new Exception("Invalid handle (GMemoryOutputStreamHandle)");
		return GMemoryOutputStreamHandleExterns.g_memory_output_stream_steal_as_bytes(ostream);
	}

/// <summary>
/// <para>
/// Gets any loaded data from the @ostream. Ownership of the data
/// is transferred to the caller; when no longer needed it must be
/// freed using the free function set in @ostream&apos;s
/// #GMemoryOutputStream:destroy-function property.
/// </para>
/// <para>
/// @ostream must be closed before calling this function.
/// </para>
/// </summary>

/// <param name="ostream">
/// a #GMemoryOutputStream
/// </param>
/// <return>
/// the stream&apos;s data, or %NULL if it has previously
///    been stolen
/// </return>

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
