namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_format_t is used to identify the memory format of
/// image data.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_format_t
{
/// <summary>
/// <para>
/// no such format exists or is supported.
/// </para>
/// </summary>

	CAIRO_FORMAT_INVALID = -1,
/// <summary>
/// <para>
/// each pixel is a 32-bit quantity, with
///   alpha in the upper 8 bits, then red, then green, then blue.
///   The 32-bit quantities are stored native-endian. Pre-multiplied
///   alpha is used. (That is, 50% transparent red is 0x80800000,
///   not 0x80ff0000.) (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FORMAT_ARGB32 = 0,
/// <summary>
/// <para>
/// each pixel is a 32-bit quantity, with
///   the upper 8 bits unused. Red, Green, and Blue are stored
///   in the remaining 24 bits in that order. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FORMAT_RGB24 = 1,
/// <summary>
/// <para>
/// each pixel is a 8-bit quantity holding
///   an alpha value. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FORMAT_A8 = 2,
/// <summary>
/// <para>
/// each pixel is a 1-bit quantity holding
///   an alpha value. Pixels are packed together into 32-bit
///   quantities. The ordering of the bits matches the
///   endianness of the platform. On a big-endian machine, the
///   first pixel is in the uppermost bit, on a little-endian
///   machine the first pixel is in the least-significant bit. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FORMAT_A1 = 3,
/// <summary>
/// <para>
/// each pixel is a 16-bit quantity
///   with red in the upper 5 bits, then green in the middle
///   6 bits, and blue in the lower 5 bits. (Since 1.2)
/// </para>
/// </summary>

	CAIRO_FORMAT_RGB16_565 = 4,
/// <summary>
/// <para>
/// like RGB24 but with 10bpc. (Since 1.12)
/// </para>
/// </summary>

	CAIRO_FORMAT_RGB30 = 5
}
