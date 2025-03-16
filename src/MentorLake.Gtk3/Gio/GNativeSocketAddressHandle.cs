namespace MentorLake.Gio;

public class GNativeSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
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
	internal static extern MentorLake.Gio.GNativeSocketAddressHandle g_native_socket_address_new(IntPtr native, UIntPtr len);

}
