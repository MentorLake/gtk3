namespace MentorLake.Gio;

public class GZlibCompressorHandle : GObjectHandle, GConverterHandle
{
	public static MentorLake.Gio.GZlibCompressorHandle New(MentorLake.Gio.GZlibCompressorFormat format, int level)
	{
		return GZlibCompressorHandleExterns.g_zlib_compressor_new(format, level);
	}

}

public static class GZlibCompressorHandleExtensions
{
	public static MentorLake.Gio.GFileInfoHandle GetFileInfo(this MentorLake.Gio.GZlibCompressorHandle compressor)
	{
		return GZlibCompressorHandleExterns.g_zlib_compressor_get_file_info(compressor);
	}

	public static T SetFileInfo<T>(this T compressor, MentorLake.Gio.GFileInfoHandle file_info) where T : GZlibCompressorHandle
	{
		GZlibCompressorHandleExterns.g_zlib_compressor_set_file_info(compressor, file_info);
		return compressor;
	}

}

internal class GZlibCompressorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GZlibCompressorHandle g_zlib_compressor_new(MentorLake.Gio.GZlibCompressorFormat format, int level);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_zlib_compressor_get_file_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GZlibCompressorHandle>))] MentorLake.Gio.GZlibCompressorHandle compressor);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_zlib_compressor_set_file_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GZlibCompressorHandle>))] MentorLake.Gio.GZlibCompressorHandle compressor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle file_info);

}
