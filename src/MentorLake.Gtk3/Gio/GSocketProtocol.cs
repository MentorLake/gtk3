namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A protocol identifier is specified when creating a #GSocket, which is a
/// family/type specific identifier, where 0 means the default protocol for
/// the particular family/type.
/// </para>
/// <para>
/// This enum contains a set of commonly available and used protocols. You
/// can also pass any other identifiers handled by the platform in order to
/// use protocols not listed here.
/// </para>
/// </summary>

[Flags]
public enum GSocketProtocol
{
/// <summary>
/// <para>
/// The protocol type is unknown
/// </para>
/// </summary>

	G_SOCKET_PROTOCOL_UNKNOWN = -1,
/// <summary>
/// <para>
/// The default protocol for the family/type
/// </para>
/// </summary>

	G_SOCKET_PROTOCOL_DEFAULT = 0,
/// <summary>
/// <para>
/// TCP over IP
/// </para>
/// </summary>

	G_SOCKET_PROTOCOL_TCP = 6,
/// <summary>
/// <para>
/// UDP over IP
/// </para>
/// </summary>

	G_SOCKET_PROTOCOL_UDP = 17,
/// <summary>
/// <para>
/// SCTP over IP
/// </para>
/// </summary>

	G_SOCKET_PROTOCOL_SCTP = 132
}
