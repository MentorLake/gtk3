namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when creating a #GSocket. Some protocols may not implement
/// all the socket types.
/// </para>
/// </summary>

[Flags]
public enum GSocketType
{
/// <summary>
/// <para>
/// Type unknown or wrong
/// </para>
/// </summary>

	G_SOCKET_TYPE_INVALID = 0,
/// <summary>
/// <para>
/// Reliable connection-based byte streams (e.g. TCP).
/// </para>
/// </summary>

	G_SOCKET_TYPE_STREAM = 1,
/// <summary>
/// <para>
/// Connectionless, unreliable datagram passing.
///     (e.g. UDP)
/// </para>
/// </summary>

	G_SOCKET_TYPE_DATAGRAM = 2,
/// <summary>
/// <para>
/// Reliable connection-based passing of datagrams
///     of fixed maximum length (e.g. SCTP).
/// </para>
/// </summary>

	G_SOCKET_TYPE_SEQPACKET = 3
}
