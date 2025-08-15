namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A single target host/port that a network service is running on.
/// </para>
/// <para>
/// SRV (service) records are used by some network protocols to provide
/// service-specific aliasing and load-balancing. For example, XMPP
/// (Jabber) uses SRV records to locate the XMPP server for a domain;
/// rather than connecting directly to ‘example.com’ or assuming a
/// specific server hostname like ‘xmpp.example.com’, an XMPP client
/// would look up the `xmpp-client` SRV record for ‘example.com’, and
/// then connect to whatever host was pointed to by that record.
/// </para>
/// <para>
/// You can use [method@Gio.Resolver.lookup_service] or
/// [method@Gio.Resolver.lookup_service_async] to find the `GSrvTarget`s
/// for a given service. However, if you are simply planning to connect
/// to the remote service, you can use [class@Gio.NetworkService]’s
/// [iface@Gio.SocketConnectable] interface and not need to worry about
/// `GSrvTarget` at all.
/// </para>
/// </summary>

public class GSrvTargetHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GSrvTarget with the given parameters.
/// </para>
/// <para>
/// You should not need to use this; normally #GSrvTargets are
/// created by #GResolver.
/// </para>
/// </summary>

/// <param name="hostname">
/// the host that the service is running on
/// </param>
/// <param name="port">
/// the port that the service is running on
/// </param>
/// <param name="priority">
/// the target&apos;s priority
/// </param>
/// <param name="weight">
/// the target&apos;s weight
/// </param>
/// <return>
/// a new #GSrvTarget.
/// </return>

	public static MentorLake.Gio.GSrvTargetHandle New(string hostname, ushort port, ushort priority, ushort weight)
	{
		return GSrvTargetExterns.g_srv_target_new(hostname, port, priority, weight);
	}

}


public static class GSrvTargetExtensions
{
/// <summary>
/// <para>
/// Copies @target
/// </para>
/// </summary>

/// <param name="target">
/// a #GSrvTarget
/// </param>
/// <return>
/// a copy of @target
/// </return>

	public static MentorLake.Gio.GSrvTargetHandle Copy(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_copy(target);
	}

/// <summary>
/// <para>
/// Frees @target
/// </para>
/// </summary>

/// <param name="target">
/// a #GSrvTarget
/// </param>

	public static void Free(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		GSrvTargetExterns.g_srv_target_free(target);
	}

/// <summary>
/// <para>
/// Gets @target&apos;s hostname (in ASCII form; if you are going to present
/// this to the user, you should use g_hostname_is_ascii_encoded() to
/// check if it contains encoded Unicode segments, and use
/// g_hostname_to_unicode() to convert it if it does.)
/// </para>
/// </summary>

/// <param name="target">
/// a #GSrvTarget
/// </param>
/// <return>
/// @target&apos;s hostname
/// </return>

	public static string GetHostname(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_hostname(target);
	}

/// <summary>
/// <para>
/// Gets @target&apos;s port
/// </para>
/// </summary>

/// <param name="target">
/// a #GSrvTarget
/// </param>
/// <return>
/// @target&apos;s port
/// </return>

	public static ushort GetPort(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_port(target);
	}

/// <summary>
/// <para>
/// Gets @target&apos;s priority. You should not need to look at this;
/// #GResolver already sorts the targets according to the algorithm in
/// RFC 2782.
/// </para>
/// </summary>

/// <param name="target">
/// a #GSrvTarget
/// </param>
/// <return>
/// @target&apos;s priority
/// </return>

	public static ushort GetPriority(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_priority(target);
	}

/// <summary>
/// <para>
/// Gets @target&apos;s weight. You should not need to look at this;
/// #GResolver already sorts the targets according to the algorithm in
/// RFC 2782.
/// </para>
/// </summary>

/// <param name="target">
/// a #GSrvTarget
/// </param>
/// <return>
/// @target&apos;s weight
/// </return>

	public static ushort GetWeight(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_weight(target);
	}


	public static GSrvTarget Dereference(this GSrvTargetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSrvTarget>(x.DangerousGetHandle());
}
internal class GSrvTargetExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))]
	internal static extern MentorLake.Gio.GSrvTargetHandle g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))]
	internal static extern MentorLake.Gio.GSrvTargetHandle g_srv_target_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_srv_target_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_srv_target_get_hostname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_srv_target_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_srv_target_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_srv_target_get_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_srv_target_list_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

}

/// <summary>
/// <para>
/// A single target host/port that a network service is running on.
/// </para>
/// <para>
/// SRV (service) records are used by some network protocols to provide
/// service-specific aliasing and load-balancing. For example, XMPP
/// (Jabber) uses SRV records to locate the XMPP server for a domain;
/// rather than connecting directly to ‘example.com’ or assuming a
/// specific server hostname like ‘xmpp.example.com’, an XMPP client
/// would look up the `xmpp-client` SRV record for ‘example.com’, and
/// then connect to whatever host was pointed to by that record.
/// </para>
/// <para>
/// You can use [method@Gio.Resolver.lookup_service] or
/// [method@Gio.Resolver.lookup_service_async] to find the `GSrvTarget`s
/// for a given service. However, if you are simply planning to connect
/// to the remote service, you can use [class@Gio.NetworkService]’s
/// [iface@Gio.SocketConnectable] interface and not need to worry about
/// `GSrvTarget` at all.
/// </para>
/// </summary>

public struct GSrvTarget
{
/// <summary>
/// <para>
/// Sorts @targets in place according to the algorithm in RFC 2782.
/// </para>
/// </summary>

/// <param name="targets">
/// a #GList of #GSrvTarget
/// </param>
/// <return>
/// the head of the sorted list.
/// </return>

	public static MentorLake.GLib.GListHandle ListSort(MentorLake.GLib.GListHandle targets)
	{
		return GSrvTargetExterns.g_srv_target_list_sort(targets);
	}

}
