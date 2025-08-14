namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of name used by a #GUnixSocketAddress.
/// %G_UNIX_SOCKET_ADDRESS_PATH indicates a traditional unix domain
/// socket bound to a filesystem path. %G_UNIX_SOCKET_ADDRESS_ANONYMOUS
/// indicates a socket not bound to any name (eg, a client-side socket,
/// or a socket created with socketpair()).
/// </para>
/// <para>
/// For abstract sockets, there are two incompatible ways of naming
/// them; the man pages suggest using the entire `struct sockaddr_un`
/// as the name, padding the unused parts of the %sun_path field with
/// zeroes; this corresponds to %G_UNIX_SOCKET_ADDRESS_ABSTRACT_PADDED.
/// However, many programs instead just use a portion of %sun_path, and
/// pass an appropriate smaller length to bind() or connect(). This is
/// %G_UNIX_SOCKET_ADDRESS_ABSTRACT.
/// </para>
/// </summary>

[Flags]
public enum GUnixSocketAddressType
{
/// <summary>
/// <para>
/// invalid
/// </para>
/// </summary>

	G_UNIX_SOCKET_ADDRESS_INVALID = 0,
/// <summary>
/// <para>
/// anonymous
/// </para>
/// </summary>

	G_UNIX_SOCKET_ADDRESS_ANONYMOUS = 1,
/// <summary>
/// <para>
/// a filesystem path
/// </para>
/// </summary>

	G_UNIX_SOCKET_ADDRESS_PATH = 2,
/// <summary>
/// <para>
/// an abstract name
/// </para>
/// </summary>

	G_UNIX_SOCKET_ADDRESS_ABSTRACT = 3,
/// <summary>
/// <para>
/// an abstract name, 0-padded
///   to the full length of a unix socket name
/// </para>
/// </summary>

	G_UNIX_SOCKET_ADDRESS_ABSTRACT_PADDED = 4
}
