namespace MentorLake.Gio;

public class GSimpleIOStreamHandle : GIOStreamHandle
{
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
	internal static extern MentorLake.Gio.GSimpleIOStreamHandle g_simple_io_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle input_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle output_stream);

}
