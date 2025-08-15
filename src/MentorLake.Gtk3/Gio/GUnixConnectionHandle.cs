namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is the subclass of [class@Gio.SocketConnection] that is created
/// for UNIX domain sockets.
/// </para>
/// <para>
/// It contains functions to do some of the UNIX socket specific
/// functionality like passing file descriptors.
/// </para>
/// <para>
/// Since GLib 2.72, `GUnixConnection` is available on all platforms. It requires
/// underlying system support (such as Windows 10 with `AF_UNIX`) at run time.
/// </para>
/// <para>
/// Before GLib 2.72, `&amp;lt;gio/gunixconnection.h&amp;gt;` belonged to the UNIX-specific GIO
/// interfaces, thus you had to use the `gio-unix-2.0.pc` pkg-config file when
/// using it. This is no longer necessary since GLib 2.72.
/// </para>
/// </summary>

public class GUnixConnectionHandle : GSocketConnectionHandle
{
}

public static class GUnixConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Receives credentials from the sending end of the connection.  The
/// sending end has to call g_unix_connection_send_credentials() (or
/// similar) for this to work.
/// </para>
/// <para>
/// As well as reading the credentials this also reads (and discards) a
/// single byte from the stream, as this is required for credentials
/// passing to work on some implementations.
/// </para>
/// <para>
/// This method can be expected to be available on the following platforms:
/// </para>
/// <para>
/// - Linux since GLib 2.26
/// - FreeBSD since GLib 2.26
/// - GNU/kFreeBSD since GLib 2.36
/// - Solaris, Illumos and OpenSolaris since GLib 2.40
/// - GNU/Hurd since GLib 2.40
/// </para>
/// <para>
/// Other ways to exchange credentials with a foreign peer includes the
/// #GUnixCredentialsMessage type and g_socket_get_credentials() function.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GUnixConnection.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// Received credentials on success (free with
/// g_object_unref()), %NULL if @error is set.
/// </return>

	public static MentorLake.Gio.GCredentialsHandle ReceiveCredentials(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_receive_credentials(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously receive credentials.
/// </para>
/// <para>
/// For more details, see g_unix_connection_receive_credentials() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// g_unix_connection_receive_credentials_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GUnixConnection.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReceiveCredentialsAsync<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		GUnixConnectionHandleExterns.g_unix_connection_receive_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous receive credentials operation started with
/// g_unix_connection_receive_credentials_async().
/// </para>
/// </summary>

/// <param name="connection">
/// A #GUnixConnection.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #GCredentials, or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GCredentialsHandle ReceiveCredentialsFinish(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_receive_credentials_finish(connection, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receives a file descriptor from the sending end of the connection.
/// The sending end has to call g_unix_connection_send_fd() for this
/// to work.
/// </para>
/// <para>
/// As well as reading the fd this also reads a single byte from the
/// stream, as this is required for fd passing to work on some
/// implementations.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GUnixConnection
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <return>
/// a file descriptor on success, -1 on error.
/// </return>

	public static int ReceiveFd(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_receive_fd(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Passes the credentials of the current user the receiving side
/// of the connection. The receiving end has to call
/// g_unix_connection_receive_credentials() (or similar) to accept the
/// credentials.
/// </para>
/// <para>
/// As well as sending the credentials this also writes a single NUL
/// byte to the stream, as this is required for credentials passing to
/// work on some implementations.
/// </para>
/// <para>
/// This method can be expected to be available on the following platforms:
/// </para>
/// <para>
/// - Linux since GLib 2.26
/// - FreeBSD since GLib 2.26
/// - GNU/kFreeBSD since GLib 2.36
/// - Solaris, Illumos and OpenSolaris since GLib 2.40
/// - GNU/Hurd since GLib 2.40
/// </para>
/// <para>
/// Other ways to exchange credentials with a foreign peer includes the
/// #GUnixCredentialsMessage type and g_socket_get_credentials() function.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GUnixConnection.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// %TRUE on success, %FALSE if @error is set.
/// </return>

	public static bool SendCredentials(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_send_credentials(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously send credentials.
/// </para>
/// <para>
/// For more details, see g_unix_connection_send_credentials() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// g_unix_connection_send_credentials_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GUnixConnection.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T SendCredentialsAsync<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		GUnixConnectionHandleExterns.g_unix_connection_send_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous send credentials operation started with
/// g_unix_connection_send_credentials_async().
/// </para>
/// </summary>

/// <param name="connection">
/// A #GUnixConnection.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the operation was successful, otherwise %FALSE.
/// </return>

	public static bool SendCredentialsFinish(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_send_credentials_finish(connection, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Passes a file descriptor to the receiving side of the
/// connection. The receiving end has to call g_unix_connection_receive_fd()
/// to accept the file descriptor.
/// </para>
/// <para>
/// As well as sending the fd this also writes a single byte to the
/// stream, as this is required for fd passing to work on some
/// implementations.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GUnixConnection
/// </param>
/// <param name="fd">
/// a file descriptor
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a %TRUE on success, %NULL on error.
/// </return>

	public static bool SendFd(this MentorLake.Gio.GUnixConnectionHandle connection, int fd, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_send_fd(connection, fd, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GUnixConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_connection_receive_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_connection_receive_credentials_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_connection_receive_credentials_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_connection_receive_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_connection_send_credentials_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_credentials_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, int fd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
