namespace MentorLake.Gio;

public interface GConverterHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GConverterHandleImpl : BaseSafeHandle, GConverterHandle
{
}

public static class GConverterHandleExtensions
{
	public static MentorLake.Gio.GConverterResult Convert(this MentorLake.Gio.GConverterHandle converter, byte[] inbuf, UIntPtr inbuf_size, byte[] outbuf, UIntPtr outbuf_size, MentorLake.Gio.GConverterFlags flags, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GConverterHandle)");
		var externCallResult = GConverterHandleExterns.g_converter_convert(converter, inbuf, inbuf_size, outbuf, outbuf_size, flags, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GBytesHandle ConvertBytes(this MentorLake.Gio.GConverterHandle converter, MentorLake.GLib.GBytesHandle bytes)
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GConverterHandle)");
		var externCallResult = GConverterHandleExterns.g_converter_convert_bytes(converter, bytes, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Reset<T>(this T converter) where T : GConverterHandle
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GConverterHandle)");
		GConverterHandleExterns.g_converter_reset(converter);
		return converter;
	}

}

internal class GConverterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GConverterResult g_converter_convert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))] MentorLake.Gio.GConverterHandle converter, byte[] inbuf, UIntPtr inbuf_size, byte[] outbuf, UIntPtr outbuf_size, MentorLake.Gio.GConverterFlags flags, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_converter_convert_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))] MentorLake.Gio.GConverterHandle converter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_converter_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GConverterHandleImpl>))] MentorLake.Gio.GConverterHandle converter);

}
