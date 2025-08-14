namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used in g_socket_receive_message() and g_socket_send_message().
/// The flags listed in the enum are some commonly available flags, but the
/// values used for them are the same as on the platform, and any other flags
/// are passed in/out as is. So to use a platform specific flag, just include
/// the right system header and pass in the flag.
/// </para>
/// </summary>

[Flags]
public enum GSocketMsgFlags : uint
{
/// <summary>
/// <para>
/// No flags.
/// </para>
/// </summary>

	G_SOCKET_MSG_NONE = 0,
/// <summary>
/// <para>
/// Request to send/receive out of band data.
/// </para>
/// </summary>

	G_SOCKET_MSG_OOB = 1,
/// <summary>
/// <para>
/// Read data from the socket without removing it from
///     the queue.
/// </para>
/// </summary>

	G_SOCKET_MSG_PEEK = 2,
/// <summary>
/// <para>
/// Don't use a gateway to send out the packet,
///     only send to hosts on directly connected networks.
/// </para>
/// </summary>

	G_SOCKET_MSG_DONTROUTE = 4
}
