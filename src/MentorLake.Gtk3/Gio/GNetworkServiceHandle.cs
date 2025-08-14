namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Like [class@Gio.NetworkAddress] does with hostnames, `GNetworkService`
/// provides an easy way to resolve a SRV record, and then attempt to
/// connect to one of the hosts that implements that service, handling
/// service priority/weighting, multiple IP addresses, and multiple
/// address families.
/// </para>
/// <para>
/// See [struct@Gio.SrvTarget] for more information about SRV records, and see
/// [iface@Gio.SocketConnectable] for an example of using the connectable
/// interface.
/// </para>
/// </summary>

public class GNetworkServiceHandle : GObjectHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a new #GNetworkService representing the given @service,
/// @protocol, and @domain. This will initially be unresolved; use the
/// #GSocketConnectable interface to resolve it.
/// </para>
/// </summary>

/// <param name="service">
/// the service type to look up (eg, "ldap")
/// </param>
/// <param name="protocol">
/// the networking protocol to use for @service (eg, "tcp")
/// </param>
/// <param name="domain">
/// the DNS domain to look up the service in
/// </param>
/// <return>
/// a new #GNetworkService
/// </return>

	public static MentorLake.Gio.GNetworkServiceHandle New(string service, string protocol, string domain)
	{
		return GNetworkServiceHandleExterns.g_network_service_new(service, protocol, domain);
	}

}

public static class GNetworkServiceHandleExtensions
{
/// <summary>
/// <para>
/// Gets the domain that @srv serves. This might be either UTF-8 or
/// ASCII-encoded, depending on what @srv was created with.
/// </para>
/// </summary>

/// <param name="srv">
/// a #GNetworkService
/// </param>
/// <return>
/// @srv's domain name
/// </return>

	public static string GetDomain(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid) throw new Exception("Invalid handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_domain(srv);
	}

/// <summary>
/// <para>
/// Gets @srv's protocol name (eg, "tcp").
/// </para>
/// </summary>

/// <param name="srv">
/// a #GNetworkService
/// </param>
/// <return>
/// @srv's protocol name
/// </return>

	public static string GetProtocol(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid) throw new Exception("Invalid handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_protocol(srv);
	}

/// <summary>
/// <para>
/// Gets the URI scheme used to resolve proxies. By default, the service name
/// is used as scheme.
/// </para>
/// </summary>

/// <param name="srv">
/// a #GNetworkService
/// </param>
/// <return>
/// @srv's scheme name
/// </return>

	public static string GetScheme(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid) throw new Exception("Invalid handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_scheme(srv);
	}

/// <summary>
/// <para>
/// Gets @srv's service name (eg, "ldap").
/// </para>
/// </summary>

/// <param name="srv">
/// a #GNetworkService
/// </param>
/// <return>
/// @srv's service name
/// </return>

	public static string GetService(this MentorLake.Gio.GNetworkServiceHandle srv)
	{
		if (srv.IsInvalid) throw new Exception("Invalid handle (GNetworkServiceHandle)");
		return GNetworkServiceHandleExterns.g_network_service_get_service(srv);
	}

/// <summary>
/// <para>
/// Set's the URI scheme used to resolve proxies. By default, the service name
/// is used as scheme.
/// </para>
/// </summary>

/// <param name="srv">
/// a #GNetworkService
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T SetScheme<T>(this T srv, string scheme) where T : GNetworkServiceHandle
	{
		if (srv.IsInvalid) throw new Exception("Invalid handle (GNetworkServiceHandle)");
		GNetworkServiceHandleExterns.g_network_service_set_scheme(srv, scheme);
		return srv;
	}

}

internal class GNetworkServiceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNetworkServiceHandle>))]
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
