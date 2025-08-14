namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Support for UNIX-domain (also known as local) sockets, corresponding to
/// `struct sockaddr_un`.
/// </para>
/// <para>
/// UNIX domain sockets are generally visible in the filesystem.
/// However, some systems support abstract socket names which are not
/// visible in the filesystem and not affected by the filesystem
/// permissions, visibility, etc. Currently this is only supported
/// under Linux. If you attempt to use abstract sockets on other
/// systems, function calls may return `G_IO_ERROR_NOT_SUPPORTED`
/// errors. You can use [func@Gio.UnixSocketAddress.abstract_names_supported]
/// to see if abstract names are supported.
/// </para>
/// <para>
/// Since GLib 2.72, `GUnixSocketAddress` is available on all platforms. It
/// requires underlying system support (such as Windows 10 with `AF_UNIX`) at
/// run time.
/// </para>
/// <para>
/// Before GLib 2.72, `<gio/gunixsocketaddress.h>` belonged to the UNIX-specific
/// GIO interfaces, thus you had to use the `gio-unix-2.0.pc` pkg-config file
/// when using it. This is no longer necessary since GLib 2.72.
/// </para>
/// </summary>

public class GUnixSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a new #GUnixSocketAddress for @path.
/// </para>
/// <para>
/// To create abstract socket addresses, on systems that support that,
/// use g_unix_socket_address_new_abstract().
/// </para>
/// </summary>

/// <param name="path">
/// the socket path
/// </param>
/// <return>
/// a new #GUnixSocketAddress
/// </return>

	public static MentorLake.Gio.GUnixSocketAddressHandle New(string path)
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_new(path);
	}

/// <summary>
/// <para>
/// Creates a new %G_UNIX_SOCKET_ADDRESS_ABSTRACT_PADDED
/// #GUnixSocketAddress for @path.
/// </para>
/// </summary>

/// <param name="path">
/// the abstract name
/// </param>
/// <param name="path_len">
/// the length of @path, or -1
/// </param>
/// <return>
/// a new #GUnixSocketAddress
/// </return>

	public static MentorLake.Gio.GUnixSocketAddressHandle NewAbstract(char[] path, int path_len)
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_new_abstract(path, path_len);
	}

/// <summary>
/// <para>
/// Creates a new #GUnixSocketAddress of type @type with name @path.
/// </para>
/// <para>
/// If @type is %G_UNIX_SOCKET_ADDRESS_PATH, this is equivalent to
/// calling g_unix_socket_address_new().
/// </para>
/// <para>
/// If @type is %G_UNIX_SOCKET_ADDRESS_ANONYMOUS, @path and @path_len will be
/// ignored.
/// </para>
/// <para>
/// If @path_type is %G_UNIX_SOCKET_ADDRESS_ABSTRACT, then @path_len
/// bytes of @path will be copied to the socket's path, and only those
/// bytes will be considered part of the name. (If @path_len is -1,
/// then @path is assumed to be NUL-terminated.) For example, if @path
/// was "test", then calling g_socket_address_get_native_size() on the
/// returned socket would return 7 (2 bytes of overhead, 1 byte for the
/// abstract-socket indicator byte, and 4 bytes for the name "test").
/// </para>
/// <para>
/// If @path_type is %G_UNIX_SOCKET_ADDRESS_ABSTRACT_PADDED, then
/// @path_len bytes of @path will be copied to the socket's path, the
/// rest of the path will be padded with 0 bytes, and the entire
/// zero-padded buffer will be considered the name. (As above, if
/// @path_len is -1, then @path is assumed to be NUL-terminated.) In
/// this case, g_socket_address_get_native_size() will always return
/// the full size of a `struct sockaddr_un`, although
/// g_unix_socket_address_get_path_len() will still return just the
/// length of @path.
/// </para>
/// <para>
/// %G_UNIX_SOCKET_ADDRESS_ABSTRACT is preferred over
/// %G_UNIX_SOCKET_ADDRESS_ABSTRACT_PADDED for new programs. Of course,
/// when connecting to a server created by another process, you must
/// use the appropriate type corresponding to how that process created
/// its listening socket.
/// </para>
/// </summary>

/// <param name="path">
/// the name
/// </param>
/// <param name="path_len">
/// the length of @path, or -1
/// </param>
/// <param name="type">
/// a #GUnixSocketAddressType
/// </param>
/// <return>
/// a new #GUnixSocketAddress
/// </return>

	public static MentorLake.Gio.GUnixSocketAddressHandle NewWithType(char[] path, int path_len, MentorLake.Gio.GUnixSocketAddressType type)
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_new_with_type(path, path_len, type);
	}

/// <summary>
/// <para>
/// Checks if abstract UNIX domain socket names are supported.
/// </para>
/// </summary>

/// <return>
/// %TRUE if supported, %FALSE otherwise
/// </return>

	public static bool AbstractNamesSupported()
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_abstract_names_supported();
	}

}

public static class GUnixSocketAddressHandleExtensions
{
/// <summary>
/// <para>
/// Gets @address's type.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetSocketAddress
/// </param>
/// <return>
/// a #GUnixSocketAddressType
/// </return>

	public static MentorLake.Gio.GUnixSocketAddressType GetAddressType(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_address_type(address);
	}

/// <summary>
/// <para>
/// Tests if @address is abstract.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetSocketAddress
/// </param>
/// <return>
/// %TRUE if the address is abstract, %FALSE otherwise
/// </return>

	public static bool GetIsAbstract(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_is_abstract(address);
	}

/// <summary>
/// <para>
/// Gets @address's path, or for abstract sockets the "name".
/// </para>
/// <para>
/// Guaranteed to be zero-terminated, but an abstract socket
/// may contain embedded zeros, and thus you should use
/// g_unix_socket_address_get_path_len() to get the true length
/// of this string.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetSocketAddress
/// </param>
/// <return>
/// the path for @address
/// </return>

	public static string GetPath(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_path(address);
	}

/// <summary>
/// <para>
/// Gets the length of @address's path.
/// </para>
/// <para>
/// For details, see g_unix_socket_address_get_path().
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetSocketAddress
/// </param>
/// <return>
/// the length of the path
/// </return>

	public static UIntPtr GetPathLen(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_path_len(address);
	}

}

internal class GUnixSocketAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GUnixSocketAddressHandle g_unix_socket_address_new(string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GUnixSocketAddressHandle g_unix_socket_address_new_abstract(char[] path, int path_len);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GUnixSocketAddressHandle g_unix_socket_address_new_with_type(char[] path, int path_len, MentorLake.Gio.GUnixSocketAddressType type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixSocketAddressType g_unix_socket_address_get_address_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_socket_address_get_is_abstract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_socket_address_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_unix_socket_address_get_path_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_socket_address_abstract_names_supported();

}
