namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSocketAddress` is the equivalent of
/// <see href="man:sockaddr(3type">struct sockaddr</see>) and its subtypes in the BSD sockets
/// API. This is an abstract class; use [class@Gio.InetSocketAddress] for
/// internet sockets, or [class@Gio.UnixSocketAddress] for UNIX domain sockets.
/// </para>
/// </summary>

public class GSocketAddressHandle : GObjectHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a #GSocketAddress subclass corresponding to the native
/// struct sockaddr @native.
/// </para>
/// </summary>

/// <param name="native">
/// a pointer to a struct sockaddr
/// </param>
/// <param name="len">
/// the size of the memory location pointed to by @native
/// </param>
/// <return>
/// a new #GSocketAddress if @native could successfully
///     be converted, otherwise %NULL
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle NewFromNative(IntPtr native, UIntPtr len)
	{
		return GSocketAddressHandleExterns.g_socket_address_new_from_native(native, len);
	}

}

public static class GSocketAddressHandleExtensions
{
/// <summary>
/// <para>
/// Gets the socket family type of @address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GSocketAddress
/// </param>
/// <return>
/// the socket family type of @address
/// </return>

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GSocketAddressHandle)");
		return GSocketAddressHandleExterns.g_socket_address_get_family(address);
	}

/// <summary>
/// <para>
/// Gets the size of @address's native struct sockaddr.
/// You can use this to allocate memory to pass to
/// g_socket_address_to_native().
/// </para>
/// </summary>

/// <param name="address">
/// a #GSocketAddress
/// </param>
/// <return>
/// the size of the native struct sockaddr that
///     @address represents
/// </return>

	public static UIntPtr GetNativeSize(this MentorLake.Gio.GSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GSocketAddressHandle)");
		return GSocketAddressHandleExterns.g_socket_address_get_native_size(address);
	}

/// <summary>
/// <para>
/// Converts a #GSocketAddress to a native struct sockaddr, which can
/// be passed to low-level functions like connect() or bind().
/// </para>
/// <para>
/// If not enough space is available, a %G_IO_ERROR_NO_SPACE error
/// is returned. If the address type is not known on the system
/// then a %G_IO_ERROR_NOT_SUPPORTED error is returned.
/// </para>
/// </summary>

/// <param name="address">
/// a #GSocketAddress
/// </param>
/// <param name="dest">
/// a pointer to a memory location that will contain the native
/// struct sockaddr
/// </param>
/// <param name="destlen">
/// the size of @dest. Must be at least as large as
///     g_socket_address_get_native_size()
/// </param>
/// <return>
/// %TRUE if @dest was filled in, %FALSE on error
/// </return>

	public static bool ToNative(this MentorLake.Gio.GSocketAddressHandle address, IntPtr dest, UIntPtr destlen)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GSocketAddressHandle)");
		var externCallResult = GSocketAddressHandleExterns.g_socket_address_to_native(address, dest, destlen, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GSocketAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_new_from_native(IntPtr native, UIntPtr len);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_socket_address_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_address_get_native_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_address_to_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, IntPtr dest, UIntPtr destlen, out MentorLake.GLib.GErrorHandle error);

}
