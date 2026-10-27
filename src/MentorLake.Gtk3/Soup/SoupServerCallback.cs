namespace MentorLake.Soup;

/// <summary>
/// <para>
/// A callback used to handle requests to a [class@Server].
/// </para>
/// <para>
/// @path and @query contain the likewise-named components of the
/// Request-URI, subject to certain assumptions. By default,
/// [class@Server] decodes all percent-encoding in the URI path, such that
/// `&quot;/foo%2Fbar&quot;` is treated the same as `&quot;/foo/bar&quot;`. If your
/// server is serving resources in some non-POSIX-filesystem namespace,
/// you may want to distinguish those as two distinct paths. In that
/// case, you can set the [property@Server:raw-paths] property when creating
/// the [class@Server], and it will leave those characters undecoded.
/// </para>
/// <para>
/// @query contains the query component of the Request-URI parsed according to
/// the rules for HTML form handling. Although this is the only commonly-used
/// query string format in HTTP, there is nothing that actually requires that
/// HTTP URIs use that format; if your server needs to use some other format, you
/// can just ignore @query, and call [method@Message.get_uri] and parse the URI&apos;s
/// query field yourself.
/// </para>
/// <para>
/// See [method@Server.add_handler] and [method@Server.add_early_handler]
/// for details of what handlers can/should do.
/// </para>
/// </summary>

/// <param name="server">
/// the #SoupServer
/// </param>
/// <param name="msg">
/// the message being processed
/// </param>
/// <param name="path">
/// the path component of @msg&apos;s Request-URI
/// </param>
/// <param name="query">
/// the parsed query
///   component of @msg&apos;s Request-URI
/// </param>
/// <param name="user_data">
/// the data passed to [method@Server.add_handler] or
///   [method@Server.add_early_handler].
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SoupServerCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle query, IntPtr user_data);
