namespace MentorLake.Soup;

/// <summary>
/// <para>
/// A callback used to handle WebSocket requests to a [class@Server].
/// </para>
/// <para>
/// The callback will be invoked after sending the handshake response back to the
/// client (and is only invoked if the handshake was successful).
/// </para>
/// <para>
/// @path contains the path of the Request-URI, subject to the same
/// rules as [callback@ServerCallback] `(qv)`.
/// </para>
/// </summary>

/// <param name="server">
/// the #SoupServer
/// </param>
/// <param name="msg">
/// the #SoupServerMessage
/// </param>
/// <param name="path">
/// the path component of @msg&apos;s Request-URI
/// </param>
/// <param name="connection">
/// the newly created WebSocket connection
/// </param>
/// <param name="user_data">
/// the data passed to @soup_server_add_handler
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SoupServerWebsocketCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle connection, IntPtr user_data);
