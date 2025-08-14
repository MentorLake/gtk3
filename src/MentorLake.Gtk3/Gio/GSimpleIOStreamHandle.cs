namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSimpleIOStream` creates a [class@Gio.IOStream] from an arbitrary
/// [class@Gio.InputStream] and [class@Gio.OutputStream]. This allows any pair of
/// input and output streams to be used with [class@Gio.IOStream] methods.
/// </para>
/// <para>
/// This is useful when you obtained a [class@Gio.InputStream] and a
/// [class@Gio.OutputStream] by other means, for instance creating them with
/// platform specific methods as
/// <see href="../gio-unix/ctor.UnixInputStream.new.html">g_unix_input_stream_new()</see>
/// (from `gio-unix-2.0.pc` / `GioUnix-2.0`), and you want to
/// take advantage of the methods provided by [class@Gio.IOStream].
/// </para>
/// </summary>

public class GSimpleIOStreamHandle : GIOStreamHandle
{
/// <summary>
/// <para>
/// Creates a new #GSimpleIOStream wrapping @input_stream and @output_stream.
/// See also #GIOStream.
/// </para>
/// </summary>

/// <param name="input_stream">
/// a #GInputStream.
/// </param>
/// <param name="output_stream">
/// a #GOutputStream.
/// </param>
/// <return>
/// a new #GSimpleIOStream instance.
/// </return>

	public static MentorLake.Gio.GSimpleIOStreamHandle New(MentorLake.Gio.GInputStreamHandle input_stream, MentorLake.Gio.GOutputStreamHandle output_stream)
	{
		return GSimpleIOStreamHandleExterns.g_simple_io_stream_new(input_stream, output_stream);
	}

}

public static class GSimpleIOStreamHandleExtensions
{
}

internal class GSimpleIOStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleIOStreamHandle>))]
	internal static extern MentorLake.Gio.GSimpleIOStreamHandle g_simple_io_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle input_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle output_stream);

}
