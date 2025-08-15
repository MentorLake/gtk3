namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GSocket` is a low-level networking primitive. It is a more or less
/// direct mapping of the BSD socket API in a portable GObject based API.
/// It supports both the UNIX socket implementations and winsock2 on Windows.
/// </para>
/// <para>
/// `GSocket` is the platform independent base upon which the higher level
/// network primitives are based. Applications are not typically meant to
/// use it directly, but rather through classes like [class@Gio.SocketClient],
/// [class@Gio.SocketService] and [class@Gio.SocketConnection]. However there may
/// be cases where direct use of `GSocket` is useful.
/// </para>
/// <para>
/// `GSocket` implements the [iface@Gio.Initable] interface, so if it is manually
/// constructed by e.g. [ctor@GObject.Object.new] you must call
/// [method@Gio.Initable.init] and check the results before using the object.
/// This is done automatically in [ctor@Gio.Socket.new] and
/// [ctor@Gio.Socket.new_from_fd], so these functions can return `NULL`.
/// </para>
/// <para>
/// Sockets operate in two general modes, blocking or non-blocking. When
/// in blocking mode all operations (which don’t take an explicit blocking
/// parameter) block until the requested operation
/// is finished or there is an error. In non-blocking mode all calls that
/// would block return immediately with a `G_IO_ERROR_WOULD_BLOCK` error.
/// To know when a call would successfully run you can call
/// [method@Gio.Socket.condition_check], or [method@Gio.Socket.condition_wait].
/// You can also use [method@Gio.Socket.create_source] and attach it to a
/// [type@GLib.MainContext] to get callbacks when I/O is possible.
/// Note that all sockets are always set to non blocking mode in the system, and
/// blocking mode is emulated in `GSocket`.
/// </para>
/// <para>
/// When working in non-blocking mode applications should always be able to
/// handle getting a `G_IO_ERROR_WOULD_BLOCK` error even when some other
/// function said that I/O was possible. This can easily happen in case
/// of a race condition in the application, but it can also happen for other
/// reasons. For instance, on Windows a socket is always seen as writable
/// until a write returns `G_IO_ERROR_WOULD_BLOCK`.
/// </para>
/// <para>
/// `GSocket`s can be either connection oriented or datagram based.
/// For connection oriented types you must first establish a connection by
/// either connecting to an address or accepting a connection from another
/// address. For connectionless socket types the target/source address is
/// specified or received in each I/O operation.
/// </para>
/// <para>
/// All socket file descriptors are set to be close-on-exec.
/// </para>
/// <para>
/// Note that creating a `GSocket` causes the signal `SIGPIPE` to be
/// ignored for the remainder of the program. If you are writing a
/// command-line utility that uses `GSocket`, you may need to take into
/// account the fact that your program will not automatically be killed
/// if it tries to write to `stdout` after it has been closed.
/// </para>
/// <para>
/// Like most other APIs in GLib, `GSocket` is not inherently thread safe. To use
/// a `GSocket` concurrently from multiple threads, you must implement your own
/// locking.
/// </para>
/// <para>
/// ## Nagle’s algorithm
/// </para>
/// <para>
/// Since GLib 2.80, `GSocket` will automatically set the `TCP_NODELAY` option on
/// all `G_SOCKET_TYPE_STREAM` sockets. This disables
/// [Nagle’s algorithm](https://en.wikipedia.org/wiki/Nagle%27s_algorithm) as it
/// typically does more harm than good on modern networks.
/// </para>
/// <para>
/// If your application needs Nagle’s algorithm enabled, call
/// [method@Gio.Socket.set_option] after constructing a `GSocket` to enable it:
/// ```c
/// socket = g_socket_new (…, G_SOCKET_TYPE_STREAM, …);
/// if (socket != NULL)
///   {
///     g_socket_set_option (socket, IPPROTO_TCP, TCP_NODELAY, FALSE, &amp;local_error);
///     // handle error if needed
///   }
/// ```
/// </para>
/// </summary>

public class GSocketHandle : GObjectHandle, GDatagramBasedHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Creates a new #GSocket with the defined family, type and protocol.
/// If @protocol is 0 (%G_SOCKET_PROTOCOL_DEFAULT) the default protocol type
/// for the family and type is used.
/// </para>
/// <para>
/// The @protocol is a family and type specific int that specifies what
/// kind of protocol to use. #GSocketProtocol lists several common ones.
/// Many families only support one protocol, and use 0 for this, others
/// support several and using 0 means to use the default protocol for
/// the family and type.
/// </para>
/// <para>
/// The protocol id is passed directly to the operating
/// system, so you can use protocols not listed in #GSocketProtocol if you
/// know the protocol number used for it.
/// </para>
/// </summary>

/// <param name="family">
/// the socket family to use, e.g. %G_SOCKET_FAMILY_IPV4.
/// </param>
/// <param name="type">
/// the socket type to use.
/// </param>
/// <param name="protocol">
/// the id of the protocol to use, or 0 for default.
/// </param>
/// <return>
/// a #GSocket or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketHandle New(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol)
	{
		var externCallResult = GSocketHandleExterns.g_socket_new(family, type, protocol, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GSocket from a native file descriptor
/// or winsock SOCKET handle.
/// </para>
/// <para>
/// This reads all the settings from the file descriptor so that
/// all properties should work. Note that the file descriptor
/// will be set to non-blocking mode, independent on the blocking
/// mode of the #GSocket.
/// </para>
/// <para>
/// On success, the returned #GSocket takes ownership of @fd. On failure, the
/// caller must close @fd themselves.
/// </para>
/// <para>
/// Since GLib 2.46, it is no longer a fatal error to call this on a non-socket
/// descriptor.  Instead, a GError will be set with code %G_IO_ERROR_FAILED
/// </para>
/// </summary>

/// <param name="fd">
/// a native socket file descriptor.
/// </param>
/// <return>
/// a #GSocket or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketHandle NewFromFd(int fd)
	{
		var externCallResult = GSocketHandleExterns.g_socket_new_from_fd(fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GSocketHandleExtensions
{
/// <summary>
/// <para>
/// Accept incoming connections on a connection-based socket. This removes
/// the first outstanding connection request from the listening socket and
/// creates a #GSocket object for it.
/// </para>
/// <para>
/// The @socket must be bound to a local address with g_socket_bind() and
/// must be listening for incoming connections (g_socket_listen()).
/// </para>
/// <para>
/// If there are no outstanding connections then the operation will block
/// or return %G_IO_ERROR_WOULD_BLOCK if non-blocking I/O is enabled.
/// To be notified of an incoming connection, wait for the %G_IO_IN condition.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// a new #GSocket, or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketHandle Accept(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_accept(socket, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// When a socket is created it is attached to an address family, but it
/// doesn&apos;t have an address in this family. g_socket_bind() assigns the
/// address (sometimes called name) of the socket.
/// </para>
/// <para>
/// It is generally required to bind to a local address before you can
/// receive connections. (See g_socket_listen() and g_socket_accept() ).
/// In certain situations, you may also want to bind a socket that will be
/// used to initiate connections, though this is not normally required.
/// </para>
/// <para>
/// If @socket is a TCP socket, then @allow_reuse controls the setting
/// of the `SO_REUSEADDR` socket option; normally it should be %TRUE for
/// server sockets (sockets that you will eventually call
/// g_socket_accept() on), and %FALSE for client sockets. (Failing to
/// set this flag on a server socket may cause g_socket_bind() to return
/// %G_IO_ERROR_ADDRESS_IN_USE if the server program is stopped and then
/// immediately restarted.)
/// </para>
/// <para>
/// If @socket is a UDP socket, then @allow_reuse determines whether or
/// not other UDP sockets can be bound to the same address at the same
/// time. In particular, you can have several UDP sockets bound to the
/// same address, and they will all receive all of the multicast and
/// broadcast packets sent to that address. (The behavior of unicast
/// UDP packets to an address with multiple listeners is not defined.)
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="address">
/// a #GSocketAddress specifying the local address.
/// </param>
/// <param name="allow_reuse">
/// whether to allow reusing this address
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool Bind(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, bool allow_reuse)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_bind(socket, address, allow_reuse, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks and resets the pending connect error for the socket.
/// This is used to check for errors when g_socket_connect() is
/// used in non-blocking mode.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <return>
/// %TRUE if no error, %FALSE otherwise, setting @error to the error
/// </return>

	public static bool CheckConnectResult(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_check_connect_result(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Closes the socket, shutting down any active connection.
/// </para>
/// <para>
/// Closing a socket does not wait for all outstanding I/O operations
/// to finish, so the caller should not rely on them to be guaranteed
/// to complete even if the close returns with no error.
/// </para>
/// <para>
/// Once the socket is closed, all other operations will return
/// %G_IO_ERROR_CLOSED. Closing a socket multiple times will not
/// return an error.
/// </para>
/// <para>
/// Sockets will be automatically closed when the last reference
/// is dropped, but you might want to call this function to make sure
/// resources are released as early as possible.
/// </para>
/// <para>
/// Beware that due to the way that TCP works, it is possible for
/// recently-sent data to be lost if either you close a socket while the
/// %G_IO_IN condition is set, or else if the remote connection tries to
/// send something to you after you close the socket but before it has
/// finished reading all of the data you sent. There is no easy generic
/// way to avoid this problem; the easiest fix is to design the network
/// protocol such that the client will never send data &quot;out of turn&quot;.
/// Another solution is for the server to half-close the connection by
/// calling g_socket_shutdown() with only the @shutdown_write flag set,
/// and then wait for the client to notice this and close its side of the
/// connection, after which the server can safely call g_socket_close().
/// (This is what #GTcpConnection does if you call
/// g_tcp_connection_set_graceful_disconnect(). But of course, this
/// only works if the client will close its connection after the server
/// does.)
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error
/// </return>

	public static bool Close(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_close(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks on the readiness of @socket to perform operations.
/// The operations specified in @condition are checked for and masked
/// against the currently-satisfied conditions on @socket. The result
/// is returned.
/// </para>
/// <para>
/// Note that on Windows, it is possible for an operation to return
/// %G_IO_ERROR_WOULD_BLOCK even immediately after
/// g_socket_condition_check() has claimed that the socket is ready for
/// writing. Rather than calling g_socket_condition_check() and then
/// writing to the socket if it succeeds, it is generally better to
/// simply try writing to the socket right away, and try again later if
/// the initial attempt returns %G_IO_ERROR_WOULD_BLOCK.
/// </para>
/// <para>
/// It is meaningless to specify %G_IO_ERR or %G_IO_HUP in condition;
/// these conditions will always be set in the output if they are true.
/// </para>
/// <para>
/// This call never blocks.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="condition">
/// a #GIOCondition mask to check
/// </param>
/// <return>
/// the @GIOCondition mask of the current state
/// </return>

	public static MentorLake.GLib.GIOCondition ConditionCheck(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_condition_check(socket, condition);
	}

/// <summary>
/// <para>
/// Waits for up to @timeout_us microseconds for @condition to become true
/// on @socket. If the condition is met, %TRUE is returned.
/// </para>
/// <para>
/// If @cancellable is cancelled before the condition is met, or if
/// @timeout_us (or the socket&apos;s #GSocket:timeout) is reached before the
/// condition is met, then %FALSE is returned and @error, if non-%NULL,
/// is set to the appropriate value (%G_IO_ERROR_CANCELLED or
/// %G_IO_ERROR_TIMED_OUT).
/// </para>
/// <para>
/// If you don&apos;t want a timeout, use g_socket_condition_wait().
/// (Alternatively, you can pass -1 for @timeout_us.)
/// </para>
/// <para>
/// Note that although @timeout_us is in microseconds for consistency with
/// other GLib APIs, this function actually only has millisecond
/// resolution, and the behavior is undefined if @timeout_us is not an
/// exact number of milliseconds.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="condition">
/// a #GIOCondition mask to wait for
/// </param>
/// <param name="timeout_us">
/// the maximum time (in microseconds) to wait, or -1
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE if the condition was met, %FALSE otherwise
/// </return>

	public static bool ConditionTimedWait(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, long timeout_us, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_condition_timed_wait(socket, condition, timeout_us, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Waits for @condition to become true on @socket. When the condition
/// is met, %TRUE is returned.
/// </para>
/// <para>
/// If @cancellable is cancelled before the condition is met, or if the
/// socket has a timeout set and it is reached before the condition is
/// met, then %FALSE is returned and @error, if non-%NULL, is set to
/// the appropriate value (%G_IO_ERROR_CANCELLED or
/// %G_IO_ERROR_TIMED_OUT).
/// </para>
/// <para>
/// See also g_socket_condition_timed_wait().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="condition">
/// a #GIOCondition mask to wait for
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE if the condition was met, %FALSE otherwise
/// </return>

	public static bool ConditionWait(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_condition_wait(socket, condition, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Connect the socket to the specified remote address.
/// </para>
/// <para>
/// For connection oriented socket this generally means we attempt to make
/// a connection to the @address. For a connection-less socket it sets
/// the default address for g_socket_send() and discards all incoming datagrams
/// from other sources.
/// </para>
/// <para>
/// Generally connection oriented sockets can only connect once, but
/// connection-less sockets can connect multiple times to change the
/// default address.
/// </para>
/// <para>
/// If the connect call needs to do network I/O it will block, unless
/// non-blocking I/O is enabled. Then %G_IO_ERROR_PENDING is returned
/// and the user can be notified of the connection finishing by waiting
/// for the G_IO_OUT condition. The result of the connection must then be
/// checked with g_socket_check_connect_result().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="address">
/// a #GSocketAddress specifying the remote address.
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// %TRUE if connected, %FALSE on error.
/// </return>

	public static bool Connect(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_connect(socket, address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a #GSocketConnection subclass of the right type for
/// @socket.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <return>
/// a #GSocketConnection
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectionFactoryCreateConnection(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_connection_factory_create_connection(socket);
	}

/// <summary>
/// <para>
/// Creates a #GSource that can be attached to a %GMainContext to monitor
/// for the availability of the specified @condition on the socket. The #GSource
/// keeps a reference to the @socket.
/// </para>
/// <para>
/// The callback on the source is of the #GSocketSourceFunc type.
/// </para>
/// <para>
/// It is meaningless to specify %G_IO_ERR or %G_IO_HUP in @condition;
/// these conditions will always be reported output if they are true.
/// </para>
/// <para>
/// @cancellable if not %NULL can be used to cancel the source, which will
/// cause the source to trigger, reporting the current condition (which
/// is likely 0 unless cancellation happened at the same time as a
/// condition change). You can check for this in the callback using
/// g_cancellable_is_cancelled().
/// </para>
/// <para>
/// If @socket has a timeout set, and it is reached before @condition
/// occurs, the source will then trigger anyway, reporting %G_IO_IN or
/// %G_IO_OUT depending on @condition. However, @socket will have been
/// marked as having had a timeout, and so the next #GSocket I/O method
/// you call will then fail with a %G_IO_ERROR_TIMED_OUT.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="condition">
/// a #GIOCondition mask to monitor
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// a newly allocated %GSource, free with g_source_unref().
/// </return>

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_create_source(socket, condition, cancellable);
	}

/// <summary>
/// <para>
/// Get the amount of data pending in the OS input buffer, without blocking.
/// </para>
/// <para>
/// If @socket is a UDP or SCTP socket, this will return the size of
/// just the next packet, even if additional packets are buffered after
/// that one.
/// </para>
/// <para>
/// Note that on Windows, this function is rather inefficient in the
/// UDP case, and so if you know any plausible upper bound on the size
/// of the incoming packet, it is better to just do a
/// g_socket_receive() with a buffer of that size, rather than calling
/// g_socket_get_available_bytes() first and then doing a receive of
/// exactly the right size.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <return>
/// the number of bytes that can be read from the socket
/// without blocking or truncating, or -1 on error.
/// </return>

	public static UIntPtr GetAvailableBytes(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_available_bytes(socket);
	}

/// <summary>
/// <para>
/// Gets the blocking mode of the socket. For details on blocking I/O,
/// see g_socket_set_blocking().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// %TRUE if blocking I/O is used, %FALSE otherwise.
/// </return>

	public static bool GetBlocking(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_blocking(socket);
	}

/// <summary>
/// <para>
/// Gets the broadcast setting on @socket; if %TRUE,
/// it is possible to send packets to broadcast
/// addresses.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the broadcast setting on @socket
/// </return>

	public static bool GetBroadcast(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_broadcast(socket);
	}

/// <summary>
/// <para>
/// Returns the credentials of the foreign process connected to this
/// socket, if any (e.g. it is only supported for %G_SOCKET_FAMILY_UNIX
/// sockets).
/// </para>
/// <para>
/// If this operation isn&apos;t supported on the OS, the method fails with
/// the %G_IO_ERROR_NOT_SUPPORTED error. On Linux this is implemented
/// by reading the %SO_PEERCRED option on the underlying socket.
/// </para>
/// <para>
/// This method can be expected to be available on the following platforms:
/// </para>
/// <para>
/// - Linux since GLib 2.26
/// - OpenBSD since GLib 2.30
/// - Solaris, Illumos and OpenSolaris since GLib 2.40
/// - NetBSD since GLib 2.42
/// - macOS, tvOS, iOS since GLib 2.66
/// </para>
/// <para>
/// Other ways to obtain credentials from a foreign peer includes the
/// #GUnixCredentialsMessage type and
/// g_unix_connection_send_credentials() /
/// g_unix_connection_receive_credentials() functions.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// %NULL if @error is set, otherwise a #GCredentials object
/// that must be freed with g_object_unref().
/// </return>

	public static MentorLake.Gio.GCredentialsHandle GetCredentials(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_credentials(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the socket family of the socket.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// a #GSocketFamily
/// </return>

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_family(socket);
	}

/// <summary>
/// <para>
/// Returns the underlying OS socket object. On unix this
/// is a socket file descriptor, and on Windows this is
/// a Winsock2 SOCKET handle. This may be useful for
/// doing platform specific or otherwise unusual operations
/// on the socket.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the file descriptor of the socket.
/// </return>

	public static int GetFd(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_fd(socket);
	}

/// <summary>
/// <para>
/// Gets the keepalive mode of the socket. For details on this,
/// see g_socket_set_keepalive().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// %TRUE if keepalive is active, %FALSE otherwise.
/// </return>

	public static bool GetKeepalive(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_keepalive(socket);
	}

/// <summary>
/// <para>
/// Gets the listen backlog setting of the socket. For details on this,
/// see g_socket_set_listen_backlog().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the maximum number of pending connections.
/// </return>

	public static int GetListenBacklog(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_listen_backlog(socket);
	}

/// <summary>
/// <para>
/// Try to get the local address of a bound socket. This is only
/// useful if the socket has been bound to a local address,
/// either explicitly or implicitly when connecting.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// a #GSocketAddress or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_local_address(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the multicast loopback setting on @socket; if %TRUE (the
/// default), outgoing multicast packets will be looped back to
/// multicast listeners on the same host.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the multicast loopback setting on @socket
/// </return>

	public static bool GetMulticastLoopback(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_multicast_loopback(socket);
	}

/// <summary>
/// <para>
/// Gets the multicast time-to-live setting on @socket; see
/// g_socket_set_multicast_ttl() for more details.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the multicast time-to-live setting on @socket
/// </return>

	public static uint GetMulticastTtl(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_multicast_ttl(socket);
	}

/// <summary>
/// <para>
/// Gets the value of an integer-valued option on @socket, as with
/// getsockopt(). (If you need to fetch a  non-integer-valued option,
/// you will need to call getsockopt() directly.)
/// </para>
/// <para>
/// The &amp;lt;see href=&quot;networking.html&quot;&amp;gt;&amp;lt;gio/gnetworking.h&amp;gt;&amp;lt;/see&amp;gt;
/// header pulls in system headers that will define most of the
/// standard/portable socket options. For unusual socket protocols or
/// platform-dependent options, you may need to include additional
/// headers.
/// </para>
/// <para>
/// Note that even for socket options that are a single byte in size,
/// @value is still a pointer to a #gint variable, not a #guchar;
/// g_socket_get_option() will handle the conversion internally.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="level">
/// the &quot;API level&quot; of the option (eg, `SOL_SOCKET`)
/// </param>
/// <param name="optname">
/// the &quot;name&quot; of the option (eg, `SO_BROADCAST`)
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// success or failure. On failure, @error will be set, and
///   the system error value (`errno` or WSAGetLastError()) will still
///   be set to the result of the getsockopt() call.
/// </return>

	public static bool GetOption(this MentorLake.Gio.GSocketHandle socket, int level, int optname, out int value)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_option(socket, level, optname, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the socket protocol id the socket was created with.
/// In case the protocol is unknown, -1 is returned.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// a protocol id, or -1 if unknown
/// </return>

	public static MentorLake.Gio.GSocketProtocol GetProtocol(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_protocol(socket);
	}

/// <summary>
/// <para>
/// Try to get the remote address of a connected socket. This is only
/// useful for connection oriented sockets that have been connected.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// a #GSocketAddress or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetRemoteAddress(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_remote_address(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the socket type of the socket.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// a #GSocketType
/// </return>

	public static MentorLake.Gio.GSocketType GetSocketType(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_socket_type(socket);
	}

/// <summary>
/// <para>
/// Gets the timeout setting of the socket. For details on this, see
/// g_socket_set_timeout().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the timeout in seconds
/// </return>

	public static uint GetTimeout(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_timeout(socket);
	}

/// <summary>
/// <para>
/// Gets the unicast time-to-live setting on @socket; see
/// g_socket_set_ttl() for more details.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// the time-to-live setting on @socket
/// </return>

	public static uint GetTtl(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_ttl(socket);
	}

/// <summary>
/// <para>
/// Checks whether a socket is closed.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <return>
/// %TRUE if socket is closed, %FALSE otherwise
/// </return>

	public static bool IsClosed(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_is_closed(socket);
	}

/// <summary>
/// <para>
/// Check whether the socket is connected. This is only useful for
/// connection-oriented sockets.
/// </para>
/// <para>
/// If using g_socket_shutdown(), this function will return %TRUE until the
/// socket has been shut down for reading and writing. If you do a non-blocking
/// connect, this function will not return %TRUE until after you call
/// g_socket_check_connect_result().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// %TRUE if socket is connected, %FALSE otherwise.
/// </return>

	public static bool IsConnected(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_is_connected(socket);
	}

/// <summary>
/// <para>
/// Registers @socket to receive multicast messages sent to @group.
/// @socket must be a %G_SOCKET_TYPE_DATAGRAM socket, and must have
/// been bound to an appropriate interface and port with
/// g_socket_bind().
/// </para>
/// <para>
/// If @iface is %NULL, the system will automatically pick an interface
/// to bind to based on @group.
/// </para>
/// <para>
/// If @source_specific is %TRUE, source-specific multicast as defined
/// in RFC 4604 is used. Note that on older platforms this may fail
/// with a %G_IO_ERROR_NOT_SUPPORTED error.
/// </para>
/// <para>
/// To bind to a given source-specific multicast address, use
/// g_socket_join_multicast_group_ssm() instead.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="group">
/// a #GInetAddress specifying the group address to join.
/// </param>
/// <param name="source_specific">
/// %TRUE if source-specific multicast should be used
/// </param>
/// <param name="iface">
/// Name of the interface to use, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool JoinMulticastGroup(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, bool source_specific, string iface)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_join_multicast_group(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Registers @socket to receive multicast messages sent to @group.
/// @socket must be a %G_SOCKET_TYPE_DATAGRAM socket, and must have
/// been bound to an appropriate interface and port with
/// g_socket_bind().
/// </para>
/// <para>
/// If @iface is %NULL, the system will automatically pick an interface
/// to bind to based on @group.
/// </para>
/// <para>
/// If @source_specific is not %NULL, use source-specific multicast as
/// defined in RFC 4604. Note that on older platforms this may fail
/// with a %G_IO_ERROR_NOT_SUPPORTED error.
/// </para>
/// <para>
/// Note that this function can be called multiple times for the same
/// @group with different @source_specific in order to receive multicast
/// packets from more than one source.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="group">
/// a #GInetAddress specifying the group address to join.
/// </param>
/// <param name="source_specific">
/// a #GInetAddress specifying the
/// source-specific multicast address or %NULL to ignore.
/// </param>
/// <param name="iface">
/// Name of the interface to use, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool JoinMulticastGroupSsm(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, MentorLake.Gio.GInetAddressHandle source_specific, string iface)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_join_multicast_group_ssm(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes @socket from the multicast group defined by @group, @iface,
/// and @source_specific (which must all have the same values they had
/// when you joined the group).
/// </para>
/// <para>
/// @socket remains bound to its address and port, and can still receive
/// unicast messages after calling this.
/// </para>
/// <para>
/// To unbind to a given source-specific multicast address, use
/// g_socket_leave_multicast_group_ssm() instead.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="group">
/// a #GInetAddress specifying the group address to leave.
/// </param>
/// <param name="source_specific">
/// %TRUE if source-specific multicast was used
/// </param>
/// <param name="iface">
/// Interface used
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool LeaveMulticastGroup(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, bool source_specific, string iface)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_leave_multicast_group(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes @socket from the multicast group defined by @group, @iface,
/// and @source_specific (which must all have the same values they had
/// when you joined the group).
/// </para>
/// <para>
/// @socket remains bound to its address and port, and can still receive
/// unicast messages after calling this.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="group">
/// a #GInetAddress specifying the group address to leave.
/// </param>
/// <param name="source_specific">
/// a #GInetAddress specifying the
/// source-specific multicast address or %NULL to ignore.
/// </param>
/// <param name="iface">
/// Name of the interface to use, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool LeaveMulticastGroupSsm(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, MentorLake.Gio.GInetAddressHandle source_specific, string iface)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_leave_multicast_group_ssm(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Marks the socket as a server socket, i.e. a socket that is used
/// to accept incoming requests using g_socket_accept().
/// </para>
/// <para>
/// Before calling this the socket must be bound to a local address using
/// g_socket_bind().
/// </para>
/// <para>
/// To set the maximum amount of outstanding clients, use
/// g_socket_set_listen_backlog().
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool Listen(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_listen(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receive data (up to @size bytes) from a socket. This is mainly used by
/// connection-oriented sockets; it is identical to g_socket_receive_from()
/// with @address set to %NULL.
/// </para>
/// <para>
/// For %G_SOCKET_TYPE_DATAGRAM and %G_SOCKET_TYPE_SEQPACKET sockets,
/// g_socket_receive() will always read either 0 or 1 complete messages from
/// the socket. If the received message is too large to fit in @buffer, then
/// the data beyond @size bytes will be discarded, without any explicit
/// indication that this has occurred.
/// </para>
/// <para>
/// For %G_SOCKET_TYPE_STREAM sockets, g_socket_receive() can return any
/// number of bytes, up to @size. If more than @size bytes have been
/// received, the additional data will be returned in future calls to
/// g_socket_receive().
/// </para>
/// <para>
/// If the socket is in blocking mode the call will block until there
/// is some data to receive, the connection is closed, or there is an
/// error. If there is no data available and the socket is in
/// non-blocking mode, a %G_IO_ERROR_WOULD_BLOCK error will be
/// returned. To be notified when data is available, wait for the
/// %G_IO_IN condition.
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="buffer">
/// 
///     a buffer to read data into (which should be at least @size bytes long).
/// </param>
/// <param name="size">
/// the number of bytes you want to read from the socket
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes read, or 0 if the connection was closed by
/// the peer, or -1 on error
/// </return>

	public static UIntPtr Receive(this MentorLake.Gio.GSocketHandle socket, out byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive(socket, out buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receives data (up to @size bytes) from a socket.
/// </para>
/// <para>
/// This function is a variant of [method@Gio.Socket.receive] which returns a
/// [struct@GLib.Bytes] rather than a plain buffer.
/// </para>
/// <para>
/// Pass `-1` to @timeout_us to block indefinitely until data is received (or
/// the connection is closed, or there is an error). Pass `0` to use the default
/// timeout from [property@Gio.Socket:timeout], or pass a positive number to wait
/// for that many microseconds for data before returning `G_IO_ERROR_TIMED_OUT`.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="size">
/// the number of bytes you want to read from the socket
/// </param>
/// <param name="timeout_us">
/// the timeout to wait for, in microseconds, or `-1` to block
///   indefinitely
/// </param>
/// <param name="cancellable">
/// a %GCancellable, or `NULL`
/// </param>
/// <return>
/// a bytes buffer containing the
///   received bytes, or `NULL` on error
/// </return>

	public static MentorLake.GLib.GBytesHandle ReceiveBytes(this MentorLake.Gio.GSocketHandle socket, UIntPtr size, long timeout_us, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_bytes(socket, size, timeout_us, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receive data (up to @size bytes) from a socket.
/// </para>
/// <para>
/// This function is a variant of [method@Gio.Socket.receive_from] which returns
/// a [struct@GLib.Bytes] rather than a plain buffer.
/// </para>
/// <para>
/// If @address is non-%NULL then @address will be set equal to the
/// source address of the received packet.
/// </para>
/// <para>
/// The @address is owned by the caller.
/// </para>
/// <para>
/// Pass `-1` to @timeout_us to block indefinitely until data is received (or
/// the connection is closed, or there is an error). Pass `0` to use the default
/// timeout from [property@Gio.Socket:timeout], or pass a positive number to wait
/// for that many microseconds for data before returning `G_IO_ERROR_TIMED_OUT`.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="address">
/// return location for a #GSocketAddress
/// </param>
/// <param name="size">
/// the number of bytes you want to read from the socket
/// </param>
/// <param name="timeout_us">
/// the timeout to wait for, in microseconds, or `-1` to block
///   indefinitely
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or `NULL`
/// </param>
/// <return>
/// a bytes buffer containing the
///   received bytes, or `NULL` on error
/// </return>

	public static MentorLake.GLib.GBytesHandle ReceiveBytesFrom(this MentorLake.Gio.GSocketHandle socket, out MentorLake.Gio.GSocketAddressHandle address, UIntPtr size, long timeout_us, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_bytes_from(socket, out address, size, timeout_us, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receive data (up to @size bytes) from a socket.
/// </para>
/// <para>
/// If @address is non-%NULL then @address will be set equal to the
/// source address of the received packet.
/// @address is owned by the caller.
/// </para>
/// <para>
/// See g_socket_receive() for additional information.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="address">
/// a pointer to a #GSocketAddress
///     pointer, or %NULL
/// </param>
/// <param name="buffer">
/// 
///     a buffer to read data into (which should be at least @size bytes long).
/// </param>
/// <param name="size">
/// the number of bytes you want to read from the socket
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes read, or 0 if the connection was closed by
/// the peer, or -1 on error
/// </return>

	public static UIntPtr ReceiveFrom(this MentorLake.Gio.GSocketHandle socket, out MentorLake.Gio.GSocketAddressHandle address, out byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_from(socket, out address, out buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receive data from a socket.  For receiving multiple messages, see
/// g_socket_receive_messages(); for easier use, see
/// g_socket_receive() and g_socket_receive_from().
/// </para>
/// <para>
/// If @address is non-%NULL then @address will be set equal to the
/// source address of the received packet.
/// @address is owned by the caller.
/// </para>
/// <para>
/// @vector must point to an array of #GInputVector structs and
/// @num_vectors must be the length of this array.  These structs
/// describe the buffers that received data will be scattered into.
/// If @num_vectors is -1, then @vectors is assumed to be terminated
/// by a #GInputVector with a %NULL buffer pointer.
/// </para>
/// <para>
/// As a special case, if @num_vectors is 0 (in which case, @vectors
/// may of course be %NULL), then a single byte is received and
/// discarded. This is to facilitate the common practice of sending a
/// single &apos;\0&apos; byte for the purposes of transferring ancillary data.
/// </para>
/// <para>
/// @messages, if non-%NULL, will be set to point to a newly-allocated
/// array of #GSocketControlMessage instances or %NULL if no such
/// messages was received. These correspond to the control messages
/// received from the kernel, one #GSocketControlMessage per message
/// from the kernel. This array is %NULL-terminated and must be freed
/// by the caller using g_free() after calling g_object_unref() on each
/// element. If @messages is %NULL, any control messages received will
/// be discarded.
/// </para>
/// <para>
/// @num_messages, if non-%NULL, will be set to the number of control
/// messages received.
/// </para>
/// <para>
/// If both @messages and @num_messages are non-%NULL, then
/// @num_messages gives the number of #GSocketControlMessage instances
/// in @messages (ie: not including the %NULL terminator).
/// </para>
/// <para>
/// @flags is an in/out parameter. The commonly available arguments
/// for this are available in the #GSocketMsgFlags enum, but the
/// values there are the same as the system values, and the flags
/// are passed in as-is, so you can pass in system-specific flags too
/// (and g_socket_receive_message() may pass system-specific flags out).
/// Flags passed in to the parameter affect the receive operation; flags returned
/// out of it are relevant to the specific returned message.
/// </para>
/// <para>
/// As with g_socket_receive(), data may be discarded if @socket is
/// %G_SOCKET_TYPE_DATAGRAM or %G_SOCKET_TYPE_SEQPACKET and you do not
/// provide enough buffer space to read a complete message. You can pass
/// %G_SOCKET_MSG_PEEK in @flags to peek at the current message without
/// removing it from the receive queue, but there is no portable way to find
/// out the length of the message other than by reading it into a
/// sufficiently-large buffer.
/// </para>
/// <para>
/// If the socket is in blocking mode the call will block until there
/// is some data to receive, the connection is closed, or there is an
/// error. If there is no data available and the socket is in
/// non-blocking mode, a %G_IO_ERROR_WOULD_BLOCK error will be
/// returned. To be notified when data is available, wait for the
/// %G_IO_IN condition.
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="address">
/// a pointer to a #GSocketAddress
///     pointer, or %NULL
/// </param>
/// <param name="vectors">
/// an array of #GInputVector structs
/// </param>
/// <param name="num_vectors">
/// the number of elements in @vectors, or -1
/// </param>
/// <param name="messages">
/// a pointer
///    which may be filled with an array of #GSocketControlMessages, or %NULL
/// </param>
/// <param name="num_messages">
/// a pointer which will be filled with the number of
///    elements in @messages, or %NULL
/// </param>
/// <param name="flags">
/// a pointer to an int containing #GSocketMsgFlags flags,
///    which may additionally contain
///    [other platform specific flags](http://man7.org/linux/man-pages/man2/recv.2.html)
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes read, or 0 if the connection was closed by
/// the peer, or -1 on error
/// </return>

	public static UIntPtr ReceiveMessage(this MentorLake.Gio.GSocketHandle socket, out MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GInputVector[] vectors, int num_vectors, out MentorLake.Gio.GSocketControlMessageHandle[] messages, out int num_messages, ref int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_message(socket, out address, vectors, num_vectors, out messages, out num_messages, ref flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Receive multiple data messages from @socket in one go.  This is the most
/// complicated and fully-featured version of this call. For easier use, see
/// g_socket_receive(), g_socket_receive_from(), and g_socket_receive_message().
/// </para>
/// <para>
/// @messages must point to an array of #GInputMessage structs and
/// @num_messages must be the length of this array. Each #GInputMessage
/// contains a pointer to an array of #GInputVector structs describing the
/// buffers that the data received in each message will be written to. Using
/// multiple #GInputVectors is more memory-efficient than manually copying data
/// out of a single buffer to multiple sources, and more system-call-efficient
/// than making multiple calls to g_socket_receive(), such as in scenarios where
/// a lot of data packets need to be received (e.g. high-bandwidth video
/// streaming over RTP/UDP).
/// </para>
/// <para>
/// @flags modify how all messages are received. The commonly available
/// arguments for this are available in the #GSocketMsgFlags enum, but the
/// values there are the same as the system values, and the flags
/// are passed in as-is, so you can pass in system-specific flags too. These
/// flags affect the overall receive operation. Flags affecting individual
/// messages are returned in #GInputMessage.flags.
/// </para>
/// <para>
/// The other members of #GInputMessage are treated as described in its
/// documentation.
/// </para>
/// <para>
/// If #GSocket:blocking is %TRUE the call will block until @num_messages have
/// been received, or the end of the stream is reached.
/// </para>
/// <para>
/// If #GSocket:blocking is %FALSE the call will return up to @num_messages
/// without blocking, or %G_IO_ERROR_WOULD_BLOCK if no messages are queued in the
/// operating system to be received.
/// </para>
/// <para>
/// In blocking mode, if #GSocket:timeout is positive and is reached before any
/// messages are received, %G_IO_ERROR_TIMED_OUT is returned, otherwise up to
/// @num_messages are returned. (Note: This is effectively the
/// behaviour of `MSG_WAITFORONE` with recvmmsg().)
/// </para>
/// <para>
/// To be notified when messages are available, wait for the
/// %G_IO_IN condition. Note though that you may still receive
/// %G_IO_ERROR_WOULD_BLOCK from g_socket_receive_messages() even if you were
/// previously notified of a %G_IO_IN condition.
/// </para>
/// <para>
/// If the remote peer closes the connection, any messages queued in the
/// operating system will be returned, and subsequent calls to
/// g_socket_receive_messages() will return 0 (with no error set).
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly. An error will only
/// be returned if zero messages could be received; otherwise the number of
/// messages successfully received before the error will be returned.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="messages">
/// an array of #GInputMessage structs
/// </param>
/// <param name="num_messages">
/// the number of elements in @messages
/// </param>
/// <param name="flags">
/// an int containing #GSocketMsgFlags flags for the overall operation,
///    which may additionally contain
///    [other platform specific flags](http://man7.org/linux/man-pages/man2/recv.2.html)
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// number of messages received, or -1 on error. Note that the number
///     of messages received may be smaller than @num_messages if in non-blocking
///     mode, if the peer closed the connection, or if @num_messages
///     was larger than `UIO_MAXIOV` (1024), in which case the caller may re-try
///     to receive the remaining messages.
/// </return>

	public static int ReceiveMessages(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInputMessage[] messages, uint num_messages, int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_messages(socket, messages, num_messages, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This behaves exactly the same as g_socket_receive(), except that
/// the choice of blocking or non-blocking behavior is determined by
/// the @blocking argument rather than by @socket&apos;s properties.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="buffer">
/// 
///     a buffer to read data into (which should be at least @size bytes long).
/// </param>
/// <param name="size">
/// the number of bytes you want to read from the socket
/// </param>
/// <param name="blocking">
/// whether to do blocking or non-blocking I/O
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes read, or 0 if the connection was closed by
/// the peer, or -1 on error
/// </return>

	public static UIntPtr ReceiveWithBlocking(this MentorLake.Gio.GSocketHandle socket, out byte[] buffer, UIntPtr size, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_with_blocking(socket, out buffer, size, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to send @size bytes from @buffer on the socket. This is
/// mainly used by connection-oriented sockets; it is identical to
/// g_socket_send_to() with @address set to %NULL.
/// </para>
/// <para>
/// If the socket is in blocking mode the call will block until there is
/// space for the data in the socket queue. If there is no space available
/// and the socket is in non-blocking mode a %G_IO_ERROR_WOULD_BLOCK error
/// will be returned. To be notified when space is available, wait for the
/// %G_IO_OUT condition. Note though that you may still receive
/// %G_IO_ERROR_WOULD_BLOCK from g_socket_send() even if you were previously
/// notified of a %G_IO_OUT condition. (On Windows in particular, this is
/// very common due to the way the underlying APIs work.)
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="buffer">
/// the buffer
///     containing the data to send.
/// </param>
/// <param name="size">
/// the number of bytes to send
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes written (which may be less than @size), or -1
/// on error
/// </return>

	public static UIntPtr Send(this MentorLake.Gio.GSocketHandle socket, byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send(socket, buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Send data to @address on @socket.  For sending multiple messages see
/// g_socket_send_messages(); for easier use, see
/// g_socket_send() and g_socket_send_to().
/// </para>
/// <para>
/// If @address is %NULL then the message is sent to the default receiver
/// (set by g_socket_connect()).
/// </para>
/// <para>
/// @vectors must point to an array of #GOutputVector structs and
/// @num_vectors must be the length of this array. (If @num_vectors is -1,
/// then @vectors is assumed to be terminated by a #GOutputVector with a
/// %NULL buffer pointer.) The #GOutputVector structs describe the buffers
/// that the sent data will be gathered from. Using multiple
/// #GOutputVectors is more memory-efficient than manually copying
/// data from multiple sources into a single buffer, and more
/// network-efficient than making multiple calls to g_socket_send().
/// </para>
/// <para>
/// @messages, if non-%NULL, is taken to point to an array of @num_messages
/// #GSocketControlMessage instances. These correspond to the control
/// messages to be sent on the socket.
/// If @num_messages is -1 then @messages is treated as a %NULL-terminated
/// array.
/// </para>
/// <para>
/// @flags modify how the message is sent. The commonly available arguments
/// for this are available in the #GSocketMsgFlags enum, but the
/// values there are the same as the system values, and the flags
/// are passed in as-is, so you can pass in system-specific flags too.
/// </para>
/// <para>
/// If the socket is in blocking mode the call will block until there is
/// space for the data in the socket queue. If there is no space available
/// and the socket is in non-blocking mode a %G_IO_ERROR_WOULD_BLOCK error
/// will be returned. To be notified when space is available, wait for the
/// %G_IO_OUT condition. Note though that you may still receive
/// %G_IO_ERROR_WOULD_BLOCK from g_socket_send() even if you were previously
/// notified of a %G_IO_OUT condition. (On Windows in particular, this is
/// very common due to the way the underlying APIs work.)
/// </para>
/// <para>
/// The sum of the sizes of each #GOutputVector in vectors must not be
/// greater than %G_MAXSSIZE. If the message can be larger than this,
/// then it is mandatory to use the g_socket_send_message_with_timeout()
/// function.
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="address">
/// a #GSocketAddress, or %NULL
/// </param>
/// <param name="vectors">
/// an array of #GOutputVector structs
/// </param>
/// <param name="num_vectors">
/// the number of elements in @vectors, or -1
/// </param>
/// <param name="messages">
/// a pointer to an
///   array of #GSocketControlMessages, or %NULL.
/// </param>
/// <param name="num_messages">
/// number of elements in @messages, or -1.
/// </param>
/// <param name="flags">
/// an int containing #GSocketMsgFlags flags, which may additionally
///    contain [other platform specific flags](http://man7.org/linux/man-pages/man2/recv.2.html)
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes written (which may be less than @size), or -1
/// on error
/// </return>

	public static UIntPtr SendMessage(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GOutputVector[] vectors, int num_vectors, MentorLake.Gio.GSocketControlMessageHandle[] messages, int num_messages, int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_message(socket, address, vectors, num_vectors, messages, num_messages, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This behaves exactly the same as g_socket_send_message(), except that
/// the choice of timeout behavior is determined by the @timeout_us argument
/// rather than by @socket&apos;s properties.
/// </para>
/// <para>
/// On error %G_POLLABLE_RETURN_FAILED is returned and @error is set accordingly, or
/// if the socket is currently not writable %G_POLLABLE_RETURN_WOULD_BLOCK is
/// returned. @bytes_written will contain 0 in both cases.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="address">
/// a #GSocketAddress, or %NULL
/// </param>
/// <param name="vectors">
/// an array of #GOutputVector structs
/// </param>
/// <param name="num_vectors">
/// the number of elements in @vectors, or -1
/// </param>
/// <param name="messages">
/// a pointer to an
///   array of #GSocketControlMessages, or %NULL.
/// </param>
/// <param name="num_messages">
/// number of elements in @messages, or -1.
/// </param>
/// <param name="flags">
/// an int containing #GSocketMsgFlags flags, which may additionally
///    contain [other platform specific flags](http://man7.org/linux/man-pages/man2/recv.2.html)
/// </param>
/// <param name="timeout_us">
/// the maximum time (in microseconds) to wait, or -1
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that were written to the socket
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// %G_POLLABLE_RETURN_OK if all data was successfully written,
/// %G_POLLABLE_RETURN_WOULD_BLOCK if the socket is currently not writable, or
/// %G_POLLABLE_RETURN_FAILED if an error happened and @error is set.
/// </return>

	public static MentorLake.Gio.GPollableReturn SendMessageWithTimeout(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GOutputVector[] vectors, int num_vectors, MentorLake.Gio.GSocketControlMessageHandle[] messages, int num_messages, int flags, long timeout_us, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_message_with_timeout(socket, address, vectors, num_vectors, messages, num_messages, flags, timeout_us, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Send multiple data messages from @socket in one go.  This is the most
/// complicated and fully-featured version of this call. For easier use, see
/// g_socket_send(), g_socket_send_to(), and g_socket_send_message().
/// </para>
/// <para>
/// @messages must point to an array of #GOutputMessage structs and
/// @num_messages must be the length of this array. Each #GOutputMessage
/// contains an address to send the data to, and a pointer to an array of
/// #GOutputVector structs to describe the buffers that the data to be sent
/// for each message will be gathered from. Using multiple #GOutputVectors is
/// more memory-efficient than manually copying data from multiple sources
/// into a single buffer, and more network-efficient than making multiple
/// calls to g_socket_send(). Sending multiple messages in one go avoids the
/// overhead of making a lot of syscalls in scenarios where a lot of data
/// packets need to be sent (e.g. high-bandwidth video streaming over RTP/UDP),
/// or where the same data needs to be sent to multiple recipients.
/// </para>
/// <para>
/// @flags modify how the message is sent. The commonly available arguments
/// for this are available in the #GSocketMsgFlags enum, but the
/// values there are the same as the system values, and the flags
/// are passed in as-is, so you can pass in system-specific flags too.
/// </para>
/// <para>
/// If the socket is in blocking mode the call will block until there is
/// space for all the data in the socket queue. If there is no space available
/// and the socket is in non-blocking mode a %G_IO_ERROR_WOULD_BLOCK error
/// will be returned if no data was written at all, otherwise the number of
/// messages sent will be returned. To be notified when space is available,
/// wait for the %G_IO_OUT condition. Note though that you may still receive
/// %G_IO_ERROR_WOULD_BLOCK from g_socket_send() even if you were previously
/// notified of a %G_IO_OUT condition. (On Windows in particular, this is
/// very common due to the way the underlying APIs work.)
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly. An error will only
/// be returned if zero messages could be sent; otherwise the number of messages
/// successfully sent before the error will be returned.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="messages">
/// an array of #GOutputMessage structs
/// </param>
/// <param name="num_messages">
/// the number of elements in @messages
/// </param>
/// <param name="flags">
/// an int containing #GSocketMsgFlags flags, which may additionally
///    contain [other platform specific flags](http://man7.org/linux/man-pages/man2/recv.2.html)
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// number of messages sent, or -1 on error. Note that the number of
///     messages sent may be smaller than @num_messages if the socket is
///     non-blocking or if @num_messages was larger than UIO_MAXIOV (1024),
///     in which case the caller may re-try to send the remaining messages.
/// </return>

	public static int SendMessages(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GOutputMessage[] messages, uint num_messages, int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_messages(socket, messages, num_messages, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to send @size bytes from @buffer to @address. If @address is
/// %NULL then the message is sent to the default receiver (set by
/// g_socket_connect()).
/// </para>
/// <para>
/// See g_socket_send() for additional information.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="address">
/// a #GSocketAddress, or %NULL
/// </param>
/// <param name="buffer">
/// the buffer
///     containing the data to send.
/// </param>
/// <param name="size">
/// the number of bytes to send
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes written (which may be less than @size), or -1
/// on error
/// </return>

	public static UIntPtr SendTo(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_to(socket, address, buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This behaves exactly the same as g_socket_send(), except that
/// the choice of blocking or non-blocking behavior is determined by
/// the @blocking argument rather than by @socket&apos;s properties.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="buffer">
/// the buffer
///     containing the data to send.
/// </param>
/// <param name="size">
/// the number of bytes to send
/// </param>
/// <param name="blocking">
/// whether to do blocking or non-blocking I/O
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// Number of bytes written (which may be less than @size), or -1
/// on error
/// </return>

	public static UIntPtr SendWithBlocking(this MentorLake.Gio.GSocketHandle socket, byte[] buffer, UIntPtr size, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_with_blocking(socket, buffer, size, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the blocking mode of the socket. In blocking mode
/// all operations (which don’t take an explicit blocking parameter) block until
/// they succeed or there is an error. In
/// non-blocking mode all functions return results immediately or
/// with a %G_IO_ERROR_WOULD_BLOCK error.
/// </para>
/// <para>
/// All sockets are created in blocking mode. However, note that the
/// platform level socket is always non-blocking, and blocking mode
/// is a GSocket level feature.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="blocking">
/// Whether to use blocking I/O or not.
/// </param>

	public static T SetBlocking<T>(this T socket, bool blocking) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_blocking(socket, blocking);
		return socket;
	}

/// <summary>
/// <para>
/// Sets whether @socket should allow sending to broadcast addresses.
/// This is %FALSE by default.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="broadcast">
/// whether @socket should allow sending to broadcast
///     addresses
/// </param>

	public static T SetBroadcast<T>(this T socket, bool broadcast) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_broadcast(socket, broadcast);
		return socket;
	}

/// <summary>
/// <para>
/// Sets or unsets the %SO_KEEPALIVE flag on the underlying socket. When
/// this flag is set on a socket, the system will attempt to verify that the
/// remote socket endpoint is still present if a sufficiently long period of
/// time passes with no data being exchanged. If the system is unable to
/// verify the presence of the remote endpoint, it will automatically close
/// the connection.
/// </para>
/// <para>
/// This option is only functional on certain kinds of sockets. (Notably,
/// %G_SOCKET_PROTOCOL_TCP sockets.)
/// </para>
/// <para>
/// The exact time between pings is system- and protocol-dependent, but will
/// normally be at least two hours. Most commonly, you would set this flag
/// on a server socket if you want to allow clients to remain idle for long
/// periods of time, but also want to ensure that connections are eventually
/// garbage-collected if clients crash or become unreachable.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="keepalive">
/// Value for the keepalive flag
/// </param>

	public static T SetKeepalive<T>(this T socket, bool keepalive) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_keepalive(socket, keepalive);
		return socket;
	}

/// <summary>
/// <para>
/// Sets the maximum number of outstanding connections allowed
/// when listening on this socket. If more clients than this are
/// connecting to the socket and the application is not handling them
/// on time then the new connections will be refused.
/// </para>
/// <para>
/// Note that this must be called before g_socket_listen() and has no
/// effect if called after that.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="backlog">
/// the maximum number of pending connections.
/// </param>

	public static T SetListenBacklog<T>(this T socket, int backlog) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_listen_backlog(socket, backlog);
		return socket;
	}

/// <summary>
/// <para>
/// Sets whether outgoing multicast packets will be received by sockets
/// listening on that multicast address on the same host. This is %TRUE
/// by default.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="loopback">
/// whether @socket should receive messages sent to its
///   multicast groups from the local host
/// </param>

	public static T SetMulticastLoopback<T>(this T socket, bool loopback) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_multicast_loopback(socket, loopback);
		return socket;
	}

/// <summary>
/// <para>
/// Sets the time-to-live for outgoing multicast datagrams on @socket.
/// By default, this is 1, meaning that multicast packets will not leave
/// the local network.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="ttl">
/// the time-to-live value for all multicast datagrams on @socket
/// </param>

	public static T SetMulticastTtl<T>(this T socket, uint ttl) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_multicast_ttl(socket, ttl);
		return socket;
	}

/// <summary>
/// <para>
/// Sets the value of an integer-valued option on @socket, as with
/// setsockopt(). (If you need to set a non-integer-valued option,
/// you will need to call setsockopt() directly.)
/// </para>
/// <para>
/// The &amp;lt;see href=&quot;networking.html&quot;&amp;gt;&amp;lt;gio/gnetworking.h&amp;gt;&amp;lt;/see&amp;gt;
/// header pulls in system headers that will define most of the
/// standard/portable socket options. For unusual socket protocols or
/// platform-dependent options, you may need to include additional
/// headers.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="level">
/// the &quot;API level&quot; of the option (eg, `SOL_SOCKET`)
/// </param>
/// <param name="optname">
/// the &quot;name&quot; of the option (eg, `SO_BROADCAST`)
/// </param>
/// <param name="value">
/// the value to set the option to
/// </param>
/// <return>
/// success or failure. On failure, @error will be set, and
///   the system error value (`errno` or WSAGetLastError()) will still
///   be set to the result of the setsockopt() call.
/// </return>

	public static bool SetOption(this MentorLake.Gio.GSocketHandle socket, int level, int optname, int value)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_set_option(socket, level, optname, value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the time in seconds after which I/O operations on @socket will
/// time out if they have not yet completed.
/// </para>
/// <para>
/// On a blocking socket, this means that any blocking #GSocket
/// operation will time out after @timeout seconds of inactivity,
/// returning %G_IO_ERROR_TIMED_OUT.
/// </para>
/// <para>
/// On a non-blocking socket, calls to g_socket_condition_wait() will
/// also fail with %G_IO_ERROR_TIMED_OUT after the given time. Sources
/// created with g_socket_create_source() will trigger after
/// @timeout seconds of inactivity, with the requested condition
/// set, at which point calling g_socket_receive(), g_socket_send(),
/// g_socket_check_connect_result(), etc, will fail with
/// %G_IO_ERROR_TIMED_OUT.
/// </para>
/// <para>
/// If @timeout is 0 (the default), operations will never time out
/// on their own.
/// </para>
/// <para>
/// Note that if an I/O operation is interrupted by a signal, this may
/// cause the timeout to be reset.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="timeout">
/// the timeout for @socket, in seconds, or 0 for none
/// </param>

	public static T SetTimeout<T>(this T socket, uint timeout) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_timeout(socket, timeout);
		return socket;
	}

/// <summary>
/// <para>
/// Sets the time-to-live for outgoing unicast packets on @socket.
/// By default the platform-specific default value is used.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket.
/// </param>
/// <param name="ttl">
/// the time-to-live value for all unicast packets on @socket
/// </param>

	public static T SetTtl<T>(this T socket, uint ttl) where T : GSocketHandle
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_ttl(socket, ttl);
		return socket;
	}

/// <summary>
/// <para>
/// Shut down part or all of a full-duplex connection.
/// </para>
/// <para>
/// If @shutdown_read is %TRUE then the receiving side of the connection
/// is shut down, and further reading is disallowed.
/// </para>
/// <para>
/// If @shutdown_write is %TRUE then the sending side of the connection
/// is shut down, and further writing is disallowed.
/// </para>
/// <para>
/// It is allowed for both @shutdown_read and @shutdown_write to be %TRUE.
/// </para>
/// <para>
/// One example where it is useful to shut down only one side of a connection is
/// graceful disconnect for TCP connections where you close the sending side,
/// then wait for the other side to close the connection, thus ensuring that the
/// other side saw all sent data.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <param name="shutdown_read">
/// whether to shut down the read side
/// </param>
/// <param name="shutdown_write">
/// whether to shut down the write side
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error
/// </return>

	public static bool Shutdown(this MentorLake.Gio.GSocketHandle socket, bool shutdown_read, bool shutdown_write)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_shutdown(socket, shutdown_read, shutdown_write, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if a socket is capable of speaking IPv4.
/// </para>
/// <para>
/// IPv4 sockets are capable of speaking IPv4.  On some operating systems
/// and under some combinations of circumstances IPv6 sockets are also
/// capable of speaking IPv4.  See RFC 3493 section 3.7 for more
/// information.
/// </para>
/// <para>
/// No other types of sockets are currently considered as being capable
/// of speaking IPv4.
/// </para>
/// </summary>

/// <param name="socket">
/// a #GSocket
/// </param>
/// <return>
/// %TRUE if this socket can be used with IPv4.
/// </return>

	public static bool SpeaksIpv4(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid) throw new Exception("Invalid handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_speaks_ipv4(socket);
	}

}

internal class GSocketHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_new(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_new_from_fd(int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_accept([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, bool allow_reuse, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_check_connect_result([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GIOCondition g_socket_condition_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_condition_timed_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, long timeout_us, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_condition_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_connection_factory_create_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_socket_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_get_available_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_blocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_broadcast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_socket_get_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_socket_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_keepalive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_get_listen_backlog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_multicast_loopback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_socket_get_multicast_ttl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, int level, int optname, out int value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketProtocol g_socket_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_get_remote_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketType g_socket_get_socket_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_socket_get_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_socket_get_ttl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_is_connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_join_multicast_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle group, bool source_specific, string iface, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_join_multicast_group_ssm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle source_specific, string iface, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_leave_multicast_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle group, bool source_specific, string iface, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_leave_multicast_group_ssm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle source_specific, string iface, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_listen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_socket_receive_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, UIntPtr size, long timeout_us, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_socket_receive_bytes_from([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle address, UIntPtr size, long timeout_us, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive_from([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle address, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out byte[] buffer, UIntPtr size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GInputVector[] vectors, int num_vectors, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 5, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] out MentorLake.Gio.GSocketControlMessageHandle[] messages, out int num_messages, ref int flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_receive_messages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInputMessage[] messages, uint num_messages, int flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive_with_blocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr size, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_send([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, byte[] buffer, UIntPtr size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_send_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GOutputVector[] vectors, int num_vectors, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 5, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] MentorLake.Gio.GSocketControlMessageHandle[] messages, int num_messages, int flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GPollableReturn g_socket_send_message_with_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GOutputVector[] vectors, int num_vectors, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 5, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] MentorLake.Gio.GSocketControlMessageHandle[] messages, int num_messages, int flags, long timeout_us, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_send_messages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GOutputMessage[] messages, uint num_messages, int flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_send_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, byte[] buffer, UIntPtr size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_send_with_blocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, byte[] buffer, UIntPtr size, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_blocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, bool blocking);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_broadcast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, bool broadcast);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_keepalive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, bool keepalive);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_listen_backlog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, int backlog);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_multicast_loopback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, bool loopback);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_multicast_ttl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, uint ttl);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_set_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, int level, int optname, int value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, uint timeout);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_set_ttl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, uint ttl);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, bool shutdown_read, bool shutdown_write, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_speaks_ipv4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

}
