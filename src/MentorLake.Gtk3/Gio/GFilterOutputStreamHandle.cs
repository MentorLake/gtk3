namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Base class for output stream implementations that perform some
/// kind of filtering operation on a base stream. Typical examples
/// of filtering operations are character set conversion, compression
/// and byte order flipping.
/// </para>
/// </summary>

public class GFilterOutputStreamHandle : GOutputStreamHandle
{
}

public static class GFilterOutputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Gets the base stream for the filter stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.FilterOutputStream].
/// </param>
/// <return>
/// a [class@Gio.OutputStream].
/// </return>

	public static MentorLake.Gio.GOutputStreamHandle GetBaseStream(this MentorLake.Gio.GFilterOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterOutputStreamHandle)");
		return GFilterOutputStreamHandleExterns.g_filter_output_stream_get_base_stream(stream);
	}

/// <summary>
/// <para>
/// Returns whether the base stream will be closed when @stream is
/// closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.FilterOutputStream].
/// </param>
/// <return>
/// `TRUE` if the base stream will be closed.
/// </return>

	public static bool GetCloseBaseStream(this MentorLake.Gio.GFilterOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterOutputStreamHandle)");
		return GFilterOutputStreamHandleExterns.g_filter_output_stream_get_close_base_stream(stream);
	}

/// <summary>
/// <para>
/// Sets whether the base stream will be closed when @stream is closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.FilterOutputStream].
/// </param>
/// <param name="close_base">
/// `TRUE` to close the base stream.
/// </param>

	public static T SetCloseBaseStream<T>(this T stream, bool close_base) where T : GFilterOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterOutputStreamHandle)");
		GFilterOutputStreamHandleExterns.g_filter_output_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GOutputStreamHandle g_filter_output_stream_get_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterOutputStreamHandle>))] MentorLake.Gio.GFilterOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_filter_output_stream_get_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterOutputStreamHandle>))] MentorLake.Gio.GFilterOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_filter_output_stream_set_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterOutputStreamHandle>))] MentorLake.Gio.GFilterOutputStreamHandle stream, bool close_base);

}
