namespace MentorLake.GdkPixdata;

/// <summary>
/// <para>
/// An enumeration containing three sets of flags for a #GdkPixdata struct:
/// one for the used colorspace, one for the width of the samples and one
/// for the encoding of the pixel data.
/// </para>
/// </summary>

[Flags]
public enum GdkPixdataType : uint
{
/// <summary>
/// <para>
/// each pixel has red, green and blue samples.
/// </para>
/// </summary>

	GDK_PIXDATA_COLOR_TYPE_RGB = 1,
/// <summary>
/// <para>
/// each pixel has red, green and blue samples
///    and an alpha value.
/// </para>
/// </summary>

	GDK_PIXDATA_COLOR_TYPE_RGBA = 2,
/// <summary>
/// <para>
/// mask for the colortype flags of the enum.
/// </para>
/// </summary>

	GDK_PIXDATA_COLOR_TYPE_MASK = 255,
/// <summary>
/// <para>
/// each sample has 8 bits.
/// </para>
/// </summary>

	GDK_PIXDATA_SAMPLE_WIDTH_8 = 65536,
/// <summary>
/// <para>
/// mask for the sample width flags of the enum.
/// </para>
/// </summary>

	GDK_PIXDATA_SAMPLE_WIDTH_MASK = 983040,
/// <summary>
/// <para>
/// the pixel data is in raw form.
/// </para>
/// </summary>

	GDK_PIXDATA_ENCODING_RAW = 16777216,
/// <summary>
/// <para>
/// the pixel data is run-length encoded. Runs may
///    be up to 127 bytes long; their length is stored in a single byte
///    preceding the pixel data for the run. If a run is constant, its length
///    byte has the high bit set and the pixel data consists of a single pixel
///    which must be repeated.
/// </para>
/// </summary>

	GDK_PIXDATA_ENCODING_RLE = 33554432,
/// <summary>
/// <para>
/// mask for the encoding flags of the enum.
/// </para>
/// </summary>

	GDK_PIXDATA_ENCODING_MASK = 251658240
}
