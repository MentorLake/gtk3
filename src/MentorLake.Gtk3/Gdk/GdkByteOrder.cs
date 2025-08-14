namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A set of values describing the possible byte-orders
/// for storing pixel values in memory.
/// </para>
/// </summary>

[Flags]
public enum GdkByteOrder
{
/// <summary>
/// <para>
/// The values are stored with the least-significant byte
///   first. For instance, the 32-bit value 0xffeecc would be stored
///   in memory as 0xcc, 0xee, 0xff, 0x00.
/// </para>
/// </summary>

	GDK_LSB_FIRST = 0,
/// <summary>
/// <para>
/// The values are stored with the most-significant byte
///   first. For instance, the 32-bit value 0xffeecc would be stored
///   in memory as 0x00, 0xff, 0xee, 0xcc.
/// </para>
/// </summary>

	GDK_MSB_FIRST = 1
}
