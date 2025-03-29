namespace MentorLake.Gio;

public class GNetworkServiceHandle : GObjectHandle, GSocketConnectableHandle
{
	public static MentorLake.Gio.GNetworkServiceHandle New(string service, string protocol, string domain)
	{
		return GNetworkServiceHandleExterns.g_network_service_new(service, protocol, domain);
	}

}

public static class GNetworkServiceHandleExtensions
{
	public static string GetDomain(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid || srv.IsClosed) throw new Exception("Invalid or closed handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_domain(srv);
	}

	public static string GetProtocol(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid || srv.IsClosed) throw new Exception("Invalid or closed handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_protocol(srv);
	}

	public static string GetScheme(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid || srv.IsClosed) throw new Exception("Invalid or closed handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_scheme(srv);
	}

	public static string GetService(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid || srv.IsClosed) throw new Exception("Invalid or closed handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_service(srv);
	}

	public static T SetScheme<T>(this T srv, string scheme) where T : GNetworkServiceHandle
	{
		if (srv.IsInvalid || srv.IsClosed) throw new Exception("Invalid or closed handle (GNetworkServiceHandle)");
		GNetworkServiceHandleExterns.g_network_service_set_scheme(srv, scheme);
		return srv;
	}

}

internal class GNetworkServiceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GNetworkServiceHandle g_network_service_new(string service, string protocol, string domain);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_service_get_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkServiceHandle>))] MentorLake.Gio.GNetworkServiceHandle srv);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_service_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkServiceHandle>))] MentorLake.Gio.GNetworkServiceHandle srv);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_service_get_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkServiceHandle>))] MentorLake.Gio.GNetworkServiceHandle srv);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_service_get_service([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkServiceHandle>))] MentorLake.Gio.GNetworkServiceHandle srv);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_network_service_set_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkServiceHandle>))] MentorLake.Gio.GNetworkServiceHandle srv, string scheme);

}
