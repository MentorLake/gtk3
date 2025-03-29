namespace MentorLake.Gio;

public class GConverterOutputStreamHandle : GFilterOutputStreamHandle, GPollableOutputStreamHandle
{
	public static MentorLake.Gio.GConverterOutputStreamHandle New(MentorLake.Gio.GOutputStreamHandle base_stream, MentorLake.Gio.GConverterHandle converter)
	{
		return GConverterOutputStreamHandleExterns.g_converter_output_stream_new(base_stream, converter);
	}

}

public static class GConverterOutputStreamHandleExtensions
{
	public static MentorLake.Gio.GConverterHandle GetConverter(this MentorLake.Gio.GConverterOutputStreamHandle converter_stream)
	{
		if (converter_stream.IsInvalid || converter_stream.IsClosed) throw new Exception("Invalid or closed handle (GConverterOutputStreamHandle)");
		return GConverterOutputStreamHandleExterns.g_converter_output_stream_get_converter(converter_stream);
	}

}

internal class GConverterOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GConverterOutputStreamHandle g_converter_output_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))] MentorLake.Gio.GConverterHandle converter);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GConverterHandle g_converter_output_stream_get_converter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterOutputStreamHandle>))] MentorLake.Gio.GConverterOutputStreamHandle converter_stream);

}
