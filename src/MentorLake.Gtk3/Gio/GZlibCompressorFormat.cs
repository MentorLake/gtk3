namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Used to select the type of data format to use for #GZlibDecompressor
/// and #GZlibCompressor.
/// </para>
/// </summary>

[Flags]
public enum GZlibCompressorFormat
{
/// <summary>
/// <para>
/// deflate compression with zlib header
/// </para>
/// </summary>

	G_ZLIB_COMPRESSOR_FORMAT_ZLIB = 0,
/// <summary>
/// <para>
/// gzip file format
/// </para>
/// </summary>

	G_ZLIB_COMPRESSOR_FORMAT_GZIP = 1,
/// <summary>
/// <para>
/// deflate compression with no header
/// </para>
/// </summary>

	G_ZLIB_COMPRESSOR_FORMAT_RAW = 2
}
