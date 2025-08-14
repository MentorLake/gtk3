namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A socket address of some unknown native type.
/// </para>
/// <para>
/// This corresponds to a general `struct sockaddr` of a type not otherwise
/// handled by GLib.
/// </para>
/// </summary>

public class GNativeSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a new #GNativeSocketAddress for @native and @len.
/// </para>
/// </summary>

/// <param name="native">
/// a native address object
/// </param>
/// <param name="len">
/// the length of @native, in bytes
/// </param>
/// <return>
/// a new #GNativeSocketAddress
/// </return>

	public static MentorLake.Gio.GNativeSocketAddressHandle New(IntPtr native, UIntPtr len)
	{
		return GNativeSocketAddressHandleExterns.g_native_socket_address_new(native, len);
	}

}

public static class GNativeSocketAddressHandleExtensions
{
}

internal class GNativeSocketAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNativeSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GNativeSocketAddressHandle g_native_socket_address_new(IntPtr native, UIntPtr len);

}
