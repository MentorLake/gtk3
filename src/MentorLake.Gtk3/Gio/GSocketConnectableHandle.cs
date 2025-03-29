namespace MentorLake.Gio;

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
	public static MentorLake.Gio.GSocketAddressEnumeratorHandle Enumerate(this MentorLake.Gio.GSocketConnectableHandle connectable)
	{
		if (connectable.IsInvalid || connectable.IsClosed) throw new Exception("Invalid or closed handle (GSocketConnectableHandle)");
		return GSocketConnectableHandleExterns.g_socket_connectable_enumerate(connectable);
	}

	public static MentorLake.Gio.GSocketAddressEnumeratorHandle ProxyEnumerate(this MentorLake.Gio.GSocketConnectableHandle connectable)
	{
		if (connectable.IsInvalid || connectable.IsClosed) throw new Exception("Invalid or closed handle (GSocketConnectableHandle)");
		return GSocketConnectableHandleExterns.g_socket_connectable_proxy_enumerate(connectable);
	}

	public static string ToString(this MentorLake.Gio.GSocketConnectableHandle connectable)
	{
		if (connectable.IsInvalid || connectable.IsClosed) throw new Exception("Invalid or closed handle (GSocketConnectableHandle)");
		return GSocketConnectableHandleExterns.g_socket_connectable_to_string(connectable);
	}

}

internal class GSocketConnectableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketAddressEnumeratorHandle g_socket_connectable_enumerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketAddressEnumeratorHandle g_socket_connectable_proxy_enumerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_socket_connectable_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable);

}
