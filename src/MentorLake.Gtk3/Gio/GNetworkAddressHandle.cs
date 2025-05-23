namespace MentorLake.Gio;

public class GNetworkAddressHandle : GObjectHandle, GSocketConnectableHandle
{
	public static MentorLake.Gio.GNetworkAddressHandle New(string hostname, ushort port)
	{
		return GNetworkAddressHandleExterns.g_network_address_new(hostname, port);
	}

	public static MentorLake.Gio.GNetworkAddressHandle NewLoopback(ushort port)
	{
		return GNetworkAddressHandleExterns.g_network_address_new_loopback(port);
	}

	public static MentorLake.Gio.GSocketConnectableHandle Parse(string host_and_port, ushort default_port)
	{
		var externCallResult = GNetworkAddressHandleExterns.g_network_address_parse(host_and_port, default_port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketConnectableHandle ParseUri(string uri, ushort default_port)
	{
		var externCallResult = GNetworkAddressHandleExterns.g_network_address_parse_uri(uri, default_port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GNetworkAddressHandleExtensions
{
	public static string GetHostname(this MentorLake.Gio.GNetworkAddressHandle addr)
	{
		if (addr.IsInvalid) throw new Exception("Invalid handle (GNetworkAddressHandle)");
		return GNetworkAddressHandleExterns.g_network_address_get_hostname(addr);
	}

	public static ushort GetPort(this MentorLake.Gio.GNetworkAddressHandle addr)
	{
		if (addr.IsInvalid) throw new Exception("Invalid handle (GNetworkAddressHandle)");
		return GNetworkAddressHandleExterns.g_network_address_get_port(addr);
	}

	public static string GetScheme(this MentorLake.Gio.GNetworkAddressHandle addr)
	{
		if (addr.IsInvalid) throw new Exception("Invalid handle (GNetworkAddressHandle)");
		return GNetworkAddressHandleExterns.g_network_address_get_scheme(addr);
	}

}

internal class GNetworkAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))]
	internal static extern MentorLake.Gio.GNetworkAddressHandle g_network_address_new(string hostname, ushort port);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))]
	internal static extern MentorLake.Gio.GNetworkAddressHandle g_network_address_new_loopback(ushort port);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_address_get_hostname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))] MentorLake.Gio.GNetworkAddressHandle addr);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_network_address_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))] MentorLake.Gio.GNetworkAddressHandle addr);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_address_get_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))] MentorLake.Gio.GNetworkAddressHandle addr);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle g_network_address_parse(string host_and_port, ushort default_port, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle g_network_address_parse_uri(string uri, ushort default_port, out MentorLake.GLib.GErrorHandle error);

}
