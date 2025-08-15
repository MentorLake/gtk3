namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Buffered output stream implements [class@Gio.FilterOutputStream] and provides
/// for buffered writes.
/// </para>
/// <para>
/// By default, `GBufferedOutputStream`&apos;s buffer size is set at 4 kilobytes.
/// </para>
/// <para>
/// To create a buffered output stream, use [ctor@Gio.BufferedOutputStream.new],
/// or [ctor@Gio.BufferedOutputStream.new_sized] to specify the buffer&apos;s size
/// at construction.
/// </para>
/// <para>
/// To get the size of a buffer within a buffered input stream, use
/// [method@Gio.BufferedOutputStream.get_buffer_size]. To change the size of a
/// buffered output stream&apos;s buffer, use [method@Gio.BufferedOutputStream.set_buffer_size].
/// Note that the buffer&apos;s size cannot be reduced below the size of the data within the buffer.
/// </para>
/// </summary>

public class GBufferedOutputStreamHandle : GFilterOutputStreamHandle, GSeekableHandle
{
/// <summary>
/// <para>
/// Creates a new buffered output stream for a base stream.
/// </para>
/// </summary>

/// <param name="base_stream">
/// a [class@Gio.OutputStream].
/// </param>
/// <return>
/// a [class@Gio.OutputStream] for the given @base_stream.
/// </return>

	public static MentorLake.Gio.GBufferedOutputStreamHandle New(MentorLake.Gio.GOutputStreamHandle base_stream)
	{
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_new(base_stream);
	}

/// <summary>
/// <para>
/// Creates a new buffered output stream with a given buffer size.
/// </para>
/// </summary>

/// <param name="base_stream">
/// a [class@Gio.OutputStream].
/// </param>
/// <param name="size">
/// a #gsize.
/// </param>
/// <return>
/// a [class@Gio.OutputStream] with an internal buffer set to @size.
/// </return>

	public static MentorLake.Gio.GBufferedOutputStreamHandle NewSized(MentorLake.Gio.GOutputStreamHandle base_stream, UIntPtr size)
	{
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedOutputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Checks if the buffer automatically grows as data is added.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedOutputStream].
/// </param>
/// <return>
/// `TRUE` if the @stream&apos;s buffer automatically grows,
/// `FALSE` otherwise.
/// </return>

	public static bool GetAutoGrow(this MentorLake.Gio.GBufferedOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedOutputStreamHandle)");
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_get_auto_grow(stream);
	}

/// <summary>
/// <para>
/// Gets the size of the buffer in the @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedOutputStream].
/// </param>
/// <return>
/// the current size of the buffer.
/// </return>

	public static UIntPtr GetBufferSize(this MentorLake.Gio.GBufferedOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedOutputStreamHandle)");
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_get_buffer_size(stream);
	}

/// <summary>
/// <para>
/// Sets whether or not the @stream&apos;s buffer should automatically grow.
/// If @auto_grow is true, then each write will just make the buffer
/// larger, and you must manually flush the buffer to actually write out
/// the data to the underlying stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedOutputStream].
/// </param>
/// <param name="auto_grow">
/// a #gboolean.
/// </param>

	public static T SetAutoGrow<T>(this T stream, bool auto_grow) where T : GBufferedOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedOutputStreamHandle)");
		GBufferedOutputStreamHandleExterns.g_buffered_output_stream_set_auto_grow(stream, auto_grow);
		return stream;
	}

/// <summary>
/// <para>
/// Sets the size of the internal buffer to @size.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedOutputStream].
/// </param>
/// <param name="size">
/// a #gsize.
/// </param>

	public static T SetBufferSize<T>(this T stream, UIntPtr size) where T : GBufferedOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedOutputStreamHandle)");
		GBufferedOutputStreamHandleExterns.g_buffered_output_stream_set_buffer_size(stream, size);
		return stream;
	}

}

internal class GBufferedOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GBufferedOutputStreamHandle g_buffered_output_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GBufferedOutputStreamHandle g_buffered_output_stream_new_sized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream, UIntPtr size);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_buffered_output_stream_get_auto_grow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_output_stream_get_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_buffered_output_stream_set_auto_grow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream, bool auto_grow);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_buffered_output_stream_set_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream, UIntPtr size);

}
