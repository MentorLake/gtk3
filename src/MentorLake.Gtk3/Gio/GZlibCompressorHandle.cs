namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GZlibCompressor` is an implementation of [iface@Gio.Converter] that
/// compresses data using zlib.
/// </para>
/// </summary>

public class GZlibCompressorHandle : GObjectHandle, GConverterHandle
{
/// <summary>
/// <para>
/// Creates a new #GZlibCompressor.
/// </para>
/// </summary>

/// <param name="format">
/// The format to use for the compressed data
/// </param>
/// <param name="level">
/// compression level (0-9), -1 for default
/// </param>
/// <return>
/// a new #GZlibCompressor
/// </return>

	public static MentorLake.Gio.GZlibCompressorHandle New(MentorLake.Gio.GZlibCompressorFormat format, int level)
	{
		return GZlibCompressorHandleExterns.g_zlib_compressor_new(format, level);
	}

}

public static class GZlibCompressorHandleExtensions
{
/// <summary>
/// <para>
/// Returns the #GZlibCompressor:file-info property.
/// </para>
/// </summary>

/// <param name="compressor">
/// a #GZlibCompressor
/// </param>
/// <return>
/// a #GFileInfo, or %NULL
/// </return>

	public static MentorLake.Gio.GFileInfoHandle GetFileInfo(this MentorLake.Gio.GZlibCompressorHandle compressor)
	{
		if (compressor.IsInvalid) throw new Exception("Invalid handle (GZlibCompressorHandle)");
		return GZlibCompressorHandleExterns.g_zlib_compressor_get_file_info(compressor);
	}

/// <summary>
/// <para>
/// Sets @file_info in @compressor. If non-%NULL, and @compressor's
/// #GZlibCompressor:format property is %G_ZLIB_COMPRESSOR_FORMAT_GZIP,
/// it will be used to set the file name and modification time in
/// the GZIP header of the compressed data.
/// </para>
/// <para>
/// Note: it is an error to call this function while a compression is in
/// progress; it may only be called immediately after creation of @compressor,
/// or after resetting it with g_converter_reset().
/// </para>
/// </summary>

/// <param name="compressor">
/// a #GZlibCompressor
/// </param>
/// <param name="file_info">
/// a #GFileInfo
/// </param>

	public static T SetFileInfo<T>(this T compressor, MentorLake.Gio.GFileInfoHandle file_info) where T : GZlibCompressorHandle
	{
		if (compressor.IsInvalid) throw new Exception("Invalid handle (GZlibCompressorHandle)");
		GZlibCompressorHandleExterns.g_zlib_compressor_set_file_info(compressor, file_info);
		return compressor;
	}

}

internal class GZlibCompressorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GZlibCompressorHandle>))]
	internal static extern MentorLake.Gio.GZlibCompressorHandle g_zlib_compressor_new(MentorLake.Gio.GZlibCompressorFormat format, int level);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_zlib_compressor_get_file_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GZlibCompressorHandle>))] MentorLake.Gio.GZlibCompressorHandle compressor);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_zlib_compressor_set_file_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GZlibCompressorHandle>))] MentorLake.Gio.GZlibCompressorHandle compressor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle file_info);

}
