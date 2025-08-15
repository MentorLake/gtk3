namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GZlibDecompressor` is an implementation of [iface@Gio.Converter] that
/// decompresses data compressed with zlib.
/// </para>
/// </summary>

public class GZlibDecompressorHandle : GObjectHandle, GConverterHandle
{
/// <summary>
/// <para>
/// Creates a new #GZlibDecompressor.
/// </para>
/// </summary>

/// <param name="format">
/// The format to use for the compressed data
/// </param>
/// <return>
/// a new #GZlibDecompressor
/// </return>

	public static MentorLake.Gio.GZlibDecompressorHandle New(MentorLake.Gio.GZlibCompressorFormat format)
	{
		return GZlibDecompressorHandleExterns.g_zlib_decompressor_new(format);
	}

}

public static class GZlibDecompressorHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the #GFileInfo constructed from the GZIP header data
/// of compressed data processed by @compressor, or %NULL if @decompressor&apos;s
/// #GZlibDecompressor:format property is not %G_ZLIB_COMPRESSOR_FORMAT_GZIP,
/// or the header data was not fully processed yet, or it not present in the
/// data stream at all.
/// </para>
/// </summary>

/// <param name="decompressor">
/// a #GZlibDecompressor
/// </param>
/// <return>
/// a #GFileInfo, or %NULL
/// </return>

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
