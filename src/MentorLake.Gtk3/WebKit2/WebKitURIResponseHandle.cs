namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents an URI response.
/// </para>
/// <para>
/// A #WebKitURIResponse contains information such as the URI, the
/// status code, the content length, the mime type, the HTTP status or
/// the suggested filename.
/// </para>
/// </summary>

public class WebKitURIResponseHandle : GObjectHandle
{
}

public static class WebKitURIResponseHandleExtensions
{
/// <summary>
/// <para>
/// Get the expected content length of the #WebKitURIResponse.
/// </para>
/// <para>
/// It can be 0 if the server provided an incorrect or missing Content-Length.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURIResponse
/// </param>
/// <return>
/// the expected content length of @response.
/// </return>

	public static ulong GetContentLength(this MentorLake.WebKit2.WebKitURIResponseHandle response)
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURIResponseHandle)");
		return WebKitURIResponseHandleExterns.webkit_uri_response_get_content_length(response);
	}

/// <summary>
/// <para>
/// Get the HTTP headers of a #WebKitURIResponse as a #SoupMessageHeaders.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURIResponse
/// </param>
/// <return>
/// a #SoupMessageHeaders with the HTTP headers of @response
///    or %NULL if @response is not an HTTP response.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetHttpHeaders(this MentorLake.WebKit2.WebKitURIResponseHandle response)
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURIResponseHandle)");
		return WebKitURIResponseHandleExterns.webkit_uri_response_get_http_headers(response);
	}

/// <summary>
/// <para>
/// Gets the MIME type of the response.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURIResponse
/// </param>
/// <return>
/// MIME type, as a string.
/// </return>

	public static string GetMimeType(this MentorLake.WebKit2.WebKitURIResponseHandle response)
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURIResponseHandle)");
		return WebKitURIResponseHandleExterns.webkit_uri_response_get_mime_type(response);
	}

/// <summary>
/// <para>
/// Get the status code of the #WebKitURIResponse.
/// </para>
/// <para>
/// Get the status code of the #WebKitURIResponse as returned by
/// the server. It will normally be a #SoupKnownStatusCode, for
/// example %SOUP_STATUS_OK, though the server can respond with any
/// unsigned integer.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURIResponse
/// </param>
/// <return>
/// the status code of @response
/// </return>

	public static uint GetStatusCode(this MentorLake.WebKit2.WebKitURIResponseHandle response)
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURIResponseHandle)");
		return WebKitURIResponseHandleExterns.webkit_uri_response_get_status_code(response);
	}

/// <summary>
/// <para>
/// Get the suggested filename for @response.
/// </para>
/// <para>
/// Get the suggested filename for @response, as specified by
/// the &apos;Content-Disposition&apos; HTTP header, or %NULL if it&apos;s not
/// present.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURIResponse
/// </param>
/// <return>
/// the suggested filename or %NULL if
///    the &apos;Content-Disposition&apos; HTTP header is not present.
/// </return>

	public static string GetSuggestedFilename(this MentorLake.WebKit2.WebKitURIResponseHandle response)
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURIResponseHandle)");
		return WebKitURIResponseHandleExterns.webkit_uri_response_get_suggested_filename(response);
	}

/// <summary>
/// <para>
/// Gets the URI which resulted in the response.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURIResponse
/// </param>
/// <return>
/// response URI, as a string.
/// </return>

	public static string GetUri(this MentorLake.WebKit2.WebKitURIResponseHandle response)
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURIResponseHandle)");
		return WebKitURIResponseHandleExterns.webkit_uri_response_get_uri(response);
	}

}

internal class WebKitURIResponseHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern ulong webkit_uri_response_get_content_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle response);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle webkit_uri_response_get_http_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle response);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_response_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle response);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_uri_response_get_status_code([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle response);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_response_get_suggested_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle response);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_response_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle response);

}
