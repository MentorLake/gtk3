namespace MentorLake.Gio;

public class GConverterInputStreamHandle : GFilterInputStreamHandle, GPollableInputStreamHandle
{
	public static MentorLake.Gio.GConverterInputStreamHandle New(MentorLake.Gio.GInputStreamHandle base_stream, MentorLake.Gio.GConverterHandle converter)
	{
		return GConverterInputStreamHandleExterns.g_converter_input_stream_new(base_stream, converter);
	}

}

public static class GConverterInputStreamHandleExtensions
{
	public static MentorLake.Gio.GConverterHandle GetConverter(this MentorLake.Gio.GConverterInputStreamHandle converter_stream)
	{
		if (converter_stream.IsInvalid) throw new Exception("Invalid handle (GConverterInputStreamHandle)");
		return GConverterInputStreamHandleExterns.g_converter_input_stream_get_converter(converter_stream);
	}

}

internal class GConverterInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GConverterInputStreamHandle>))]
	internal static extern MentorLake.Gio.GConverterInputStreamHandle g_converter_input_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle base_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))] MentorLake.Gio.GConverterHandle converter);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))]
	internal static extern MentorLake.Gio.GConverterHandle g_converter_input_stream_get_converter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterInputStreamHandle>))] MentorLake.Gio.GConverterInputStreamHandle converter_stream);

}
