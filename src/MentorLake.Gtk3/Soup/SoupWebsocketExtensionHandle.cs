namespace MentorLake.Soup;

/// <summary>
/// <para>
/// A WebSocket extension
/// </para>
/// <para>
/// [class@WebsocketExtension] is the base class for WebSocket extension objects.
/// </para>
/// </summary>

public class SoupWebsocketExtensionHandle : GObjectHandle
{
}

public static class SoupWebsocketExtensionHandleExtensions
{
/// <summary>
/// <para>
/// Configures @extension with the given @params.
/// </para>
/// </summary>

/// <param name="extension">
/// a #SoupWebsocketExtension
/// </param>
/// <param name="connection_type">
/// either %SOUP_WEBSOCKET_CONNECTION_CLIENT or %SOUP_WEBSOCKET_CONNECTION_SERVER
/// </param>
/// <param name="@params">
/// the parameters
/// </param>
/// <return>
/// %TRUE if extension could be configured with the given parameters, or %FALSE otherwise
/// </return>

	public static bool Configure(this MentorLake.Soup.SoupWebsocketExtensionHandle extension, MentorLake.Soup.SoupWebsocketConnectionType connection_type, MentorLake.GLib.GHashTableHandle @params)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketExtensionHandle)");
		var externCallResult = SoupWebsocketExtensionHandleExterns.soup_websocket_extension_configure(extension, connection_type, @params, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Get the parameters strings to be included in the request header.
/// </para>
/// <para>
/// If the extension doesn&apos;t include any parameter in the request, this function
/// returns %NULL.
/// </para>
/// </summary>

/// <param name="extension">
/// a #SoupWebsocketExtension
/// </param>
/// <return>
/// a new allocated string with the parameters
/// </return>

	public static string GetRequestParams(this MentorLake.Soup.SoupWebsocketExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketExtensionHandle)");
		return SoupWebsocketExtensionHandleExterns.soup_websocket_extension_get_request_params(extension);
	}

/// <summary>
/// <para>
/// Get the parameters strings to be included in the response header.
/// </para>
/// <para>
/// If the extension doesn&apos;t include any parameter in the response, this function
/// returns %NULL.
/// </para>
/// </summary>

/// <param name="extension">
/// a #SoupWebsocketExtension
/// </param>
/// <return>
/// a new allocated string with the parameters
/// </return>

	public static string GetResponseParams(this MentorLake.Soup.SoupWebsocketExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketExtensionHandle)");
		return SoupWebsocketExtensionHandleExterns.soup_websocket_extension_get_response_params(extension);
	}

/// <summary>
/// <para>
/// Process a message after it&apos;s received.
/// </para>
/// <para>
/// If the payload isn&apos;t changed the given @payload is just returned, otherwise
/// [method@GLib.Bytes.unref] is called on the given @payload and a new
/// [struct@GLib.Bytes] is returned with the new data.
/// </para>
/// <para>
/// Extensions using reserved bits of the header will reset them in @header.
/// </para>
/// </summary>

/// <param name="extension">
/// a #SoupWebsocketExtension
/// </param>
/// <param name="header">
/// the message header
/// </param>
/// <param name="payload">
/// the payload data
/// </param>
/// <return>
/// the message payload data, or %NULL in case of error
/// </return>

	public static MentorLake.GLib.GBytesHandle ProcessIncomingMessage(this MentorLake.Soup.SoupWebsocketExtensionHandle extension, ref byte header, MentorLake.GLib.GBytesHandle payload)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketExtensionHandle)");
		var externCallResult = SoupWebsocketExtensionHandleExterns.soup_websocket_extension_process_incoming_message(extension, ref header, payload, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Process a message before it&apos;s sent.
/// </para>
/// <para>
/// If the payload isn&apos;t changed the given @payload is just returned, otherwise
/// [method@Glib.Bytes.unref] is called on the given @payload and a new
/// [struct@GLib.Bytes] is returned with the new data.
/// </para>
/// <para>
/// Extensions using reserved bits of the header will change them in @header.
/// </para>
/// </summary>

/// <param name="extension">
/// a #SoupWebsocketExtension
/// </param>
/// <param name="header">
/// the message header
/// </param>
/// <param name="payload">
/// the payload data
/// </param>
/// <return>
/// the message payload data, or %NULL in case of error
/// </return>

	public static MentorLake.GLib.GBytesHandle ProcessOutgoingMessage(this MentorLake.Soup.SoupWebsocketExtensionHandle extension, ref byte header, MentorLake.GLib.GBytesHandle payload)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketExtensionHandle)");
		var externCallResult = SoupWebsocketExtensionHandleExterns.soup_websocket_extension_process_outgoing_message(extension, ref header, payload, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class SoupWebsocketExtensionHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_websocket_extension_configure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketExtensionHandle>))] MentorLake.Soup.SoupWebsocketExtensionHandle extension, MentorLake.Soup.SoupWebsocketConnectionType connection_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle @params, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_websocket_extension_get_request_params([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketExtensionHandle>))] MentorLake.Soup.SoupWebsocketExtensionHandle extension);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_websocket_extension_get_response_params([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketExtensionHandle>))] MentorLake.Soup.SoupWebsocketExtensionHandle extension);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_websocket_extension_process_incoming_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketExtensionHandle>))] MentorLake.Soup.SoupWebsocketExtensionHandle extension, ref byte header, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle payload, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_websocket_extension_process_outgoing_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketExtensionHandle>))] MentorLake.Soup.SoupWebsocketExtensionHandle extension, ref byte header, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle payload, out MentorLake.GLib.GErrorHandle error);

}
