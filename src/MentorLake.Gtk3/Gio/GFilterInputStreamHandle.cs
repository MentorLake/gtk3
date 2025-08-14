namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Base class for input stream implementations that perform some
/// kind of filtering operation on a base stream. Typical examples
/// of filtering operations are character set conversion, compression
/// and byte order flipping.
/// </para>
/// </summary>

public class GFilterInputStreamHandle : GInputStreamHandle
{
}

public static class GFilterInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Gets the base stream for the filter stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFilterInputStream.
/// </param>
/// <return>
/// a #GInputStream.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle GetBaseStream(this MentorLake.Gio.GFilterInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterInputStreamHandle)");
		return GFilterInputStreamHandleExterns.g_filter_input_stream_get_base_stream(stream);
	}

/// <summary>
/// <para>
/// Returns whether the base stream will be closed when @stream is
/// closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFilterInputStream.
/// </param>
/// <return>
/// %TRUE if the base stream will be closed.
/// </return>

	public static bool GetCloseBaseStream(this MentorLake.Gio.GFilterInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterInputStreamHandle)");
		return GFilterInputStreamHandleExterns.g_filter_input_stream_get_close_base_stream(stream);
	}

/// <summary>
/// <para>
/// Sets whether the base stream will be closed when @stream is closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFilterInputStream.
/// </param>
/// <param name="close_base">
/// %TRUE to close the base stream.
/// </param>

	public static T SetCloseBaseStream<T>(this T stream, bool close_base) where T : GFilterInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterInputStreamHandle)");
		GFilterInputStreamHandleExterns.g_filter_input_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_filter_input_stream_get_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterInputStreamHandle>))] MentorLake.Gio.GFilterInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_filter_input_stream_get_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterInputStreamHandle>))] MentorLake.Gio.GFilterInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_filter_input_stream_set_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterInputStreamHandle>))] MentorLake.Gio.GFilterInputStreamHandle stream, bool close_base);

}
