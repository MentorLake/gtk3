namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Converter output stream implements [class@Gio.OutputStream] and allows
/// conversion of data of various types during reading.
/// </para>
/// <para>
/// As of GLib 2.34, `GConverterOutputStream` implements
/// [iface@Gio.PollableOutputStream].
/// </para>
/// </summary>

public class GConverterOutputStreamHandle : GFilterOutputStreamHandle, GPollableOutputStreamHandle
{
/// <summary>
/// <para>
/// Creates a new converter output stream for the @base_stream.
/// </para>
/// </summary>

/// <param name="base_stream">
/// a #GOutputStream
/// </param>
/// <param name="converter">
/// a #GConverter
/// </param>
/// <return>
/// a new #GOutputStream.
/// </return>

	public static MentorLake.Gio.GConverterOutputStreamHandle New(MentorLake.Gio.GOutputStreamHandle base_stream, MentorLake.Gio.GConverterHandle converter)
	{
		return GConverterOutputStreamHandleExterns.g_converter_output_stream_new(base_stream, converter);
	}

}

public static class GConverterOutputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GConverter that is used by @converter_stream.
/// </para>
/// </summary>

/// <param name="converter_stream">
/// a #GConverterOutputStream
/// </param>
/// <return>
/// the converter of the converter output stream
/// </return>

	public static MentorLake.Gio.GConverterHandle GetConverter(this MentorLake.Gio.GConverterOutputStreamHandle converter_stream)
	{
		if (converter_stream.IsInvalid) throw new Exception("Invalid handle (GConverterOutputStreamHandle)");
		return GConverterOutputStreamHandleExterns.g_converter_output_stream_get_converter(converter_stream);
	}

}

internal class GConverterOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GConverterOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GConverterOutputStreamHandle g_converter_output_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))] MentorLake.Gio.GConverterHandle converter);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))]
	internal static extern MentorLake.Gio.GConverterHandle g_converter_output_stream_get_converter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterOutputStreamHandle>))] MentorLake.Gio.GConverterOutputStreamHandle converter_stream);

}
