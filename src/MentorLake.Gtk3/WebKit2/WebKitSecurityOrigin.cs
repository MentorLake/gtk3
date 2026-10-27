namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A security boundary for websites.
/// </para>
/// <para>
/// #WebKitSecurityOrigin is a representation of a security domain
/// defined by websites. A security origin consists of a protocol, a
/// hostname, and an optional port number.
/// </para>
/// <para>
/// Resources with the same security origin can generally access each
/// other for client-side scripting or database access. When comparing
/// origins, beware that if both protocol and host are %NULL, the origins
/// should not be treated as equal.
/// </para>
/// </summary>

public class WebKitSecurityOriginHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new security origin from the provided protocol, host and
/// port.
/// </para>
/// </summary>

/// <param name="protocol">
/// The protocol for the new origin
/// </param>
/// <param name="host">
/// The host for the new origin
/// </param>
/// <param name="port">
/// The port number for the new origin, or 0 to indicate the
///        default port for @protocol
/// </param>
/// <return>
/// A #WebKitSecurityOrigin.
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityOriginHandle New(string protocol, string host, ushort port)
	{
		return WebKitSecurityOriginExterns.webkit_security_origin_new(protocol, host, port);
	}

/// <summary>
/// <para>
/// Create a new security origin from the provided.
/// </para>
/// <para>
/// Create a new security origin from the provided URI. Components of
/// @uri other than protocol, host, and port do not affect the created
/// #WebKitSecurityOrigin.
/// </para>
/// </summary>

/// <param name="uri">
/// The URI for the new origin
/// </param>
/// <return>
/// A #WebKitSecurityOrigin.
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityOriginHandle NewForUri(string uri)
	{
		return WebKitSecurityOriginExterns.webkit_security_origin_new_for_uri(uri);
	}

}


public static class WebKitSecurityOriginExtensions
{
/// <summary>
/// <para>
/// Gets the hostname of @origin.
/// </para>
/// <para>
/// It is reasonable for this to be %NULL
/// if its protocol does not require a host component.
/// </para>
/// </summary>

/// <param name="origin">
/// a #WebKitSecurityOrigin
/// </param>
/// <return>
/// The host of the #WebKitSecurityOrigin
/// </return>

	public static string GetHost(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		return WebKitSecurityOriginExterns.webkit_security_origin_get_host(origin);
	}

/// <summary>
/// <para>
/// Gets the port of @origin.
/// </para>
/// <para>
/// This function will always return 0 if the
/// port is the default port for the given protocol. For example,
/// http://example.com has the same security origin as
/// http://example.com:80, and this function will return 0 for a
/// #WebKitSecurityOrigin constructed from either URI.
/// </para>
/// </summary>

/// <param name="origin">
/// a #WebKitSecurityOrigin
/// </param>
/// <return>
/// The port of the #WebKitSecurityOrigin.
/// </return>

	public static ushort GetPort(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		return WebKitSecurityOriginExterns.webkit_security_origin_get_port(origin);
	}

/// <summary>
/// <para>
/// Gets the protocol of @origin.
/// </para>
/// </summary>

/// <param name="origin">
/// a #WebKitSecurityOrigin
/// </param>
/// <return>
/// The protocol of the #WebKitSecurityOrigin
/// </return>

	public static string GetProtocol(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		return WebKitSecurityOriginExterns.webkit_security_origin_get_protocol(origin);
	}

/// <summary>
/// <para>
/// This function returns %FALSE.
/// </para>
/// <para>
/// This function returns %FALSE. #WebKitSecurityOrigin is now a simple
/// wrapper around a &amp;lt;protocol, host, port&amp;gt; triplet, and no longer
/// represents an origin as defined by web standards that may be opaque.
/// </para>
/// </summary>

/// <param name="origin">
/// a #WebKitSecurityOrigin
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool IsOpaque(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		return WebKitSecurityOriginExterns.webkit_security_origin_is_opaque(origin);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @origin by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="origin">
/// a #WebKitSecurityOrigin
/// </param>
/// <return>
/// The passed #WebKitSecurityOrigin
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityOriginHandle Ref(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		return WebKitSecurityOriginExterns.webkit_security_origin_ref(origin);
	}

/// <summary>
/// <para>
/// Gets a string representation of @origin.
/// </para>
/// <para>
/// The string representation
/// is a valid URI with only protocol, host, and port components, or
/// %NULL.
/// </para>
/// </summary>

/// <param name="origin">
/// a #WebKitSecurityOrigin
/// </param>
/// <return>
/// a URI representing @origin.
/// </return>

	public static string ToString(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		return WebKitSecurityOriginExterns.webkit_security_origin_to_string(origin);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @origin by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by
/// #WebKitSecurityOrigin is released. This function is MT-safe and may be
/// called from any thread.
/// </para>
/// </summary>

/// <param name="origin">
/// A #WebKitSecurityOrigin
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitSecurityOriginHandle origin)
	{
		if (origin.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityOrigin)");
		WebKitSecurityOriginExterns.webkit_security_origin_unref(origin);
	}


	public static WebKitSecurityOrigin Dereference(this WebKitSecurityOriginHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitSecurityOrigin>(x.DangerousGetHandle());
}
internal class WebKitSecurityOriginExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityOriginHandle webkit_security_origin_new(string protocol, string host, ushort port);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityOriginHandle webkit_security_origin_new_for_uri(string uri);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_security_origin_get_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

	[DllImport(WebKit2Library.Name)]
	internal static extern ushort webkit_security_origin_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_security_origin_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_origin_is_opaque([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityOriginHandle webkit_security_origin_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_security_origin_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_origin_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))] MentorLake.WebKit2.WebKitSecurityOriginHandle origin);

}

/// <summary>
/// <para>
/// A security boundary for websites.
/// </para>
/// <para>
/// #WebKitSecurityOrigin is a representation of a security domain
/// defined by websites. A security origin consists of a protocol, a
/// hostname, and an optional port number.
/// </para>
/// <para>
/// Resources with the same security origin can generally access each
/// other for client-side scripting or database access. When comparing
/// origins, beware that if both protocol and host are %NULL, the origins
/// should not be treated as equal.
/// </para>
/// </summary>

public struct WebKitSecurityOrigin
{
}
