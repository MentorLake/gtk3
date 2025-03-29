namespace MentorLake.Gio;

public class GSocketHandle : GObjectHandle, GDatagramBasedHandle, GInitableHandle
{
	public static MentorLake.Gio.GSocketHandle New(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol)
	{
		var externCallResult = GSocketHandleExterns.g_socket_new(family, type, protocol, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketHandle NewFromFd(int fd)
	{
		var externCallResult = GSocketHandleExterns.g_socket_new_from_fd(fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GSocketHandleExtensions
{
	public static MentorLake.Gio.GSocketHandle Accept(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_accept(socket, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool Bind(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, bool allow_reuse)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_bind(socket, address, allow_reuse, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool CheckConnectResult(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_check_connect_result(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool Close(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_close(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOCondition ConditionCheck(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_condition_check(socket, condition);
	}

	public static bool ConditionTimedWait(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, long timeout_us, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_condition_timed_wait(socket, condition, timeout_us, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ConditionWait(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_condition_wait(socket, condition, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool Connect(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_connect(socket, address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectionFactoryCreateConnection(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_connection_factory_create_connection(socket);
	}

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_create_source(socket, condition, cancellable);
	}

	public static UIntPtr GetAvailableBytes(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_available_bytes(socket);
	}

	public static bool GetBlocking(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_blocking(socket);
	}

	public static bool GetBroadcast(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_broadcast(socket);
	}

	public static MentorLake.Gio.GCredentialsHandle GetCredentials(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_credentials(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_family(socket);
	}

	public static int GetFd(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_fd(socket);
	}

	public static bool GetKeepalive(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_keepalive(socket);
	}

	public static int GetListenBacklog(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_listen_backlog(socket);
	}

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_local_address(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool GetMulticastLoopback(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_multicast_loopback(socket);
	}

	public static uint GetMulticastTtl(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_multicast_ttl(socket);
	}

	public static bool GetOption(this MentorLake.Gio.GSocketHandle socket, int level, int optname, out int value)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_option(socket, level, optname, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketProtocol GetProtocol(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_protocol(socket);
	}

	public static MentorLake.Gio.GSocketAddressHandle GetRemoteAddress(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_get_remote_address(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketType GetSocketType(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_socket_type(socket);
	}

	public static uint GetTimeout(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_timeout(socket);
	}

	public static uint GetTtl(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_get_ttl(socket);
	}

	public static bool IsClosed(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_is_closed(socket);
	}

	public static bool IsConnected(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_is_connected(socket);
	}

	public static bool JoinMulticastGroup(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, bool source_specific, string iface)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_join_multicast_group(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool JoinMulticastGroupSsm(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, MentorLake.Gio.GInetAddressHandle source_specific, string iface)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_join_multicast_group_ssm(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LeaveMulticastGroup(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, bool source_specific, string iface)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_leave_multicast_group(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LeaveMulticastGroupSsm(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInetAddressHandle group, MentorLake.Gio.GInetAddressHandle source_specific, string iface)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_leave_multicast_group_ssm(socket, group, source_specific, iface, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool Listen(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_listen(socket, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr Receive(this MentorLake.Gio.GSocketHandle socket, out byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive(socket, out buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GBytesHandle ReceiveBytes(this MentorLake.Gio.GSocketHandle socket, UIntPtr size, long timeout_us, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_bytes(socket, size, timeout_us, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GBytesHandle ReceiveBytesFrom(this MentorLake.Gio.GSocketHandle socket, out MentorLake.Gio.GSocketAddressHandle address, UIntPtr size, long timeout_us, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_bytes_from(socket, out address, size, timeout_us, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr ReceiveFrom(this MentorLake.Gio.GSocketHandle socket, out MentorLake.Gio.GSocketAddressHandle address, out byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_from(socket, out address, out buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr ReceiveMessage(this MentorLake.Gio.GSocketHandle socket, out MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GInputVector[] vectors, int num_vectors, out MentorLake.Gio.GSocketControlMessageHandle[] messages, out int num_messages, ref int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_message(socket, out address, vectors, num_vectors, out messages, out num_messages, ref flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int ReceiveMessages(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInputMessage[] messages, uint num_messages, int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_messages(socket, messages, num_messages, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr ReceiveWithBlocking(this MentorLake.Gio.GSocketHandle socket, out byte[] buffer, UIntPtr size, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_receive_with_blocking(socket, out buffer, size, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr Send(this MentorLake.Gio.GSocketHandle socket, byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send(socket, buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr SendMessage(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GOutputVector[] vectors, int num_vectors, MentorLake.Gio.GSocketControlMessageHandle[] messages, int num_messages, int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_message(socket, address, vectors, num_vectors, messages, num_messages, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GPollableReturn SendMessageWithTimeout(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GOutputVector[] vectors, int num_vectors, MentorLake.Gio.GSocketControlMessageHandle[] messages, int num_messages, int flags, long timeout_us, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_message_with_timeout(socket, address, vectors, num_vectors, messages, num_messages, flags, timeout_us, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int SendMessages(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GOutputMessage[] messages, uint num_messages, int flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_messages(socket, messages, num_messages, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr SendTo(this MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GSocketAddressHandle address, byte[] buffer, UIntPtr size, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_to(socket, address, buffer, size, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr SendWithBlocking(this MentorLake.Gio.GSocketHandle socket, byte[] buffer, UIntPtr size, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_send_with_blocking(socket, buffer, size, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetBlocking<T>(this T socket, bool blocking) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_blocking(socket, blocking);
		return socket;
	}

	public static T SetBroadcast<T>(this T socket, bool broadcast) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_broadcast(socket, broadcast);
		return socket;
	}

	public static T SetKeepalive<T>(this T socket, bool keepalive) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_keepalive(socket, keepalive);
		return socket;
	}

	public static T SetListenBacklog<T>(this T socket, int backlog) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_listen_backlog(socket, backlog);
		return socket;
	}

	public static T SetMulticastLoopback<T>(this T socket, bool loopback) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_multicast_loopback(socket, loopback);
		return socket;
	}

	public static T SetMulticastTtl<T>(this T socket, uint ttl) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_multicast_ttl(socket, ttl);
		return socket;
	}

	public static bool SetOption(this MentorLake.Gio.GSocketHandle socket, int level, int optname, int value)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_set_option(socket, level, optname, value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetTimeout<T>(this T socket, uint timeout) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_timeout(socket, timeout);
		return socket;
	}

	public static T SetTtl<T>(this T socket, uint ttl) where T : GSocketHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		GSocketHandleExterns.g_socket_set_ttl(socket, ttl);
		return socket;
	}

	public static bool Shutdown(this MentorLake.Gio.GSocketHandle socket, bool shutdown_read, bool shutdown_write)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		var externCallResult = GSocketHandleExterns.g_socket_shutdown(socket, shutdown_read, shutdown_write, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SpeaksIpv4(this MentorLake.Gio.GSocketHandle socket)
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GSocketHandle)");
		return GSocketHandleExterns.g_socket_speaks_ipv4(socket);
	}

}

internal class GSocketHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_new(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_new_from_fd(int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
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
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_connection_factory_create_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_socket_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.GLib.GIOCondition condition, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_get_available_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_blocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_get_broadcast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
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
	internal static extern UIntPtr g_socket_receive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out byte[] buffer, UIntPtr size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_socket_receive_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, UIntPtr size, long timeout_us, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_socket_receive_bytes_from([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle address, UIntPtr size, long timeout_us, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive_from([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle address, out byte[] buffer, UIntPtr size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GInputVector[] vectors, int num_vectors, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 5, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketControlMessageHandle>))] out MentorLake.Gio.GSocketControlMessageHandle[] messages, out int num_messages, ref int flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_socket_receive_messages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.Gio.GInputMessage[] messages, uint num_messages, int flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_receive_with_blocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, out byte[] buffer, UIntPtr size, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

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
