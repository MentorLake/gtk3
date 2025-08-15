namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Objects that describe one or more potential socket endpoints
/// implement `GSocketConnectable`. Callers can then use
/// [method@Gio.SocketConnectable.enumerate] to get a
/// [class@Gio.SocketAddressEnumerator] to try out each socket address in turn
/// until one succeeds, as shown in the sample code below.
/// </para>
/// <para>
/// ```c
/// MyConnectionType *
/// connect_to_host (const char    *hostname,
///                  guint16        port,
///                  GCancellable  *cancellable,
///                  GError       **error)
/// {
///   MyConnection *conn = NULL;
///   GSocketConnectable *addr;
///   GSocketAddressEnumerator *enumerator;
///   GSocketAddress *sockaddr;
///   GError *conn_error = NULL;
/// </para>
/// <para>
///   addr = g_network_address_new (hostname, port);
///   enumerator = g_socket_connectable_enumerate (addr);
///   g_object_unref (addr);
/// </para>
/// <para>
///   // Try each sockaddr until we succeed. Record the first connection error,
///   // but not any further ones (since they&apos;ll probably be basically the same
///   // as the first).
///   while (!conn &amp;&amp; (sockaddr = g_socket_address_enumerator_next (enumerator, cancellable, error))
///     {
///       conn = connect_to_sockaddr (sockaddr, conn_error ? NULL : &amp;conn_error);
///       g_object_unref (sockaddr);
///     }
///   g_object_unref (enumerator);
/// </para>
/// <para>
///   if (conn)
///     {
///       if (conn_error)
///         {
///           // We couldn&apos;t connect to the first address, but we succeeded
///           // in connecting to a later address.
///           g_error_free (conn_error);
///         }
///       return conn;
///     }
///   else if (error)
///     {
///       /// Either initial lookup failed, or else the caller cancelled us.
///       if (conn_error)
///         g_error_free (conn_error);
///       return NULL;
///     }
///   else
///     {
///       g_error_propagate (error, conn_error);
///       return NULL;
///     }
/// }
/// ```
/// </para>
/// </summary>

public interface GSocketConnectableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GSocketConnectableHandleImpl : BaseSafeHandle, GSocketConnectableHandle
{
}

public static class GSocketConnectableHandleExtensions
{
/// <summary>
/// <para>
/// Creates a #GSocketAddressEnumerator for @connectable.
/// </para>
/// </summary>

/// <param name="connectable">
/// a #GSocketConnectable
/// </param>
/// <return>
/// a new #GSocketAddressEnumerator.
/// </return>

	public static MentorLake.Gio.GSocketAddressEnumeratorHandle Enumerate(this MentorLake.Gio.GSocketConnectableHandle connectable)
	{
		if (connectable.IsInvalid) throw new Exception("Invalid handle (GSocketConnectableHandle)");
		return GSocketConnectableHandleExterns.g_socket_connectable_enumerate(connectable);
	}

/// <summary>
/// <para>
/// Creates a #GSocketAddressEnumerator for @connectable that will
/// return a #GProxyAddress for each of its addresses that you must connect
/// to via a proxy.
/// </para>
/// <para>
/// If @connectable does not implement
/// g_socket_connectable_proxy_enumerate(), this will fall back to
/// calling g_socket_connectable_enumerate().
/// </para>
/// </summary>

/// <param name="connectable">
/// a #GSocketConnectable
/// </param>
/// <return>
/// a new #GSocketAddressEnumerator.
/// </return>

	public static MentorLake.Gio.GSocketAddressEnumeratorHandle ProxyEnumerate(this MentorLake.Gio.GSocketConnectableHandle connectable)
	{
		if (connectable.IsInvalid) throw new Exception("Invalid handle (GSocketConnectableHandle)");
		return GSocketConnectableHandleExterns.g_socket_connectable_proxy_enumerate(connectable);
	}

/// <summary>
/// <para>
/// Format a #GSocketConnectable as a string. This is a human-readable format for
/// use in debugging output, and is not a stable serialization format. It is not
/// suitable for use in user interfaces as it exposes too much information for a
/// user.
/// </para>
/// <para>
/// If the #GSocketConnectable implementation does not support string formatting,
/// the implementation’s type name will be returned as a fallback.
/// </para>
/// </summary>

/// <param name="connectable">
/// a #GSocketConnectable
/// </param>
/// <return>
/// the formatted string
/// </return>

	public static string ToString(this MentorLake.Gio.GSocketConnectableHandle connectable)
	{
		if (connectable.IsInvalid) throw new Exception("Invalid handle (GSocketConnectableHandle)");
		return GSocketConnectableHandleExterns.g_socket_connectable_to_string(connectable);
	}

}

internal class GSocketConnectableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressEnumeratorHandle g_socket_connectable_enumerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressEnumeratorHandle g_socket_connectable_proxy_enumerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_socket_connectable_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable);

}
