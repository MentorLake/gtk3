namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GDataStreamByteOrder is used to ensure proper endianness of streaming data sources
/// across various machine architectures.
/// </para>
/// </summary>

[Flags]
public enum GDataStreamByteOrder
{
/// <summary>
/// <para>
/// Selects Big Endian byte order.
/// </para>
/// </summary>

	G_DATA_STREAM_BYTE_ORDER_BIG_ENDIAN = 0,
/// <summary>
/// <para>
/// Selects Little Endian byte order.
/// </para>
/// </summary>

	G_DATA_STREAM_BYTE_ORDER_LITTLE_ENDIAN = 1,
/// <summary>
/// <para>
/// Selects endianness based on host machine's architecture.
/// </para>
/// </summary>

	G_DATA_STREAM_BYTE_ORDER_HOST_ENDIAN = 2
}
