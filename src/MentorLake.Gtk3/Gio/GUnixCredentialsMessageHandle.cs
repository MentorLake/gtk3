namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This [class@Gio.SocketControlMessage] contains a [class@Gio.Credentials]
/// instance.  It may be sent using [method@Gio.Socket.send_message] and received
/// using [method@Gio.Socket.receive_message] over UNIX sockets (ie: sockets in
/// the `G_SOCKET_FAMILY_UNIX` family).
/// </para>
/// <para>
/// For an easier way to send and receive credentials over
/// stream-oriented UNIX sockets, see
/// [method@Gio.UnixConnection.send_credentials] and
/// [method@Gio.UnixConnection.receive_credentials]. To receive credentials of
/// a foreign process connected to a socket, use
/// [method@Gio.Socket.get_credentials].
/// </para>
/// <para>
/// Since GLib 2.72, `GUnixCredentialMessage` is available on all platforms. It
/// requires underlying system support (such as Windows 10 with `AF_UNIX`) at run
/// time.
/// </para>
/// <para>
/// Before GLib 2.72, `&amp;lt;gio/gunixcredentialsmessage.h&amp;gt;` belonged to the UNIX-specific
/// GIO interfaces, thus you had to use the `gio-unix-2.0.pc` pkg-config file
/// when using it. This is no longer necessary since GLib 2.72.
/// </para>
/// </summary>

public class GUnixCredentialsMessageHandle : GSocketControlMessageHandle
{
/// <summary>
/// <para>
/// Creates a new #GUnixCredentialsMessage with credentials matching the current processes.
/// </para>
/// </summary>

/// <return>
/// a new #GUnixCredentialsMessage
/// </return>

	public static MentorLake.Gio.GUnixCredentialsMessageHandle New()
	{
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_new();
	}

/// <summary>
/// <para>
/// Creates a new #GUnixCredentialsMessage holding @credentials.
/// </para>
/// </summary>

/// <param name="credentials">
/// A #GCredentials object.
/// </param>
/// <return>
/// a new #GUnixCredentialsMessage
/// </return>

	public static MentorLake.Gio.GUnixCredentialsMessageHandle NewWithCredentials(MentorLake.Gio.GCredentialsHandle credentials)
	{
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_new_with_credentials(credentials);
	}

/// <summary>
/// <para>
/// Checks if passing #GCredentials on a #GSocket is supported on this platform.
/// </para>
/// </summary>

/// <return>
/// %TRUE if supported, %FALSE otherwise
/// </return>

	public static bool IsSupported()
	{
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_is_supported();
	}

}

public static class GUnixCredentialsMessageHandleExtensions
{
/// <summary>
/// <para>
/// Gets the credentials stored in @message.
/// </para>
/// </summary>

/// <param name="message">
/// A #GUnixCredentialsMessage.
/// </param>
/// <return>
/// A #GCredentials instance. Do not free, it is owned by @message.
/// </return>

	public static MentorLake.Gio.GCredentialsHandle GetCredentials(this MentorLake.Gio.GUnixCredentialsMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GUnixCredentialsMessageHandle)");
		return GUnixCredentialsMessageHandleExterns.g_unix_credentials_message_get_credentials(message);
	}

}

internal class GUnixCredentialsMessageHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixCredentialsMessageHandle>))]
	internal static extern MentorLake.Gio.GUnixCredentialsMessageHandle g_unix_credentials_message_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixCredentialsMessageHandle>))]
	internal static extern MentorLake.Gio.GUnixCredentialsMessageHandle g_unix_credentials_message_new_with_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_credentials_message_get_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixCredentialsMessageHandle>))] MentorLake.Gio.GUnixCredentialsMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_credentials_message_is_supported();

}
