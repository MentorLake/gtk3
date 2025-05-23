namespace MentorLake.Gio;

public class GZlibDecompressorHandle : GObjectHandle, GConverterHandle
{
	public static MentorLake.Gio.GZlibDecompressorHandle New(MentorLake.Gio.GZlibCompressorFormat format)
	{
		return GZlibDecompressorHandleExterns.g_zlib_decompressor_new(format);
	}

}

public static class GZlibDecompressorHandleExtensions
{
	public static MentorLake.Gio.GFileInfoHandle GetFileInfo(this MentorLake.Gio.GZlibDecompressorHandle decompressor)
	{
		if (decompressor.IsInvalid) throw new Exception("Invalid handle (GZlibDecompressorHandle)");
		return GZlibDecompressorHandleExterns.g_zlib_decompressor_get_file_info(decompressor);
	}

}

internal class GZlibDecompressorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GZlibDecompressorHandle>))]
	internal static extern MentorLake.Gio.GZlibDecompressorHandle g_zlib_decompressor_new(MentorLake.Gio.GZlibCompressorFormat format);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_zlib_decompressor_get_file_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GZlibDecompressorHandle>))] MentorLake.Gio.GZlibDecompressorHandle decompressor);

}
