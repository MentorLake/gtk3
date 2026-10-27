namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents a URI scheme response.
/// </para>
/// <para>
/// If you register a particular URI scheme in a #WebKitWebContext,
/// using webkit_web_context_register_uri_scheme(), you have to provide
/// a #WebKitURISchemeRequestCallback. After that, when a URI response
/// is made with that particular scheme, your callback will be
/// called. There you will be able to provide more response parameters
/// when the methods and properties of a #WebKitURISchemeRequest is not
/// enough.
/// </para>
/// <para>
/// When you finished setting up your #WebKitURISchemeResponse, call
/// webkit_uri_request_finish_with_response() with it to return the response.
/// </para>
/// </summary>

public class WebKitURISchemeResponseHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitURISchemeResponse
/// </para>
/// </summary>

/// <param name="input_stream">
/// a #GInputStream to read the contents of the request
/// </param>
/// <param name="stream_length">
/// the length of the stream or -1 if not known
/// </param>
/// <return>
/// the newly created #WebKitURISchemeResponse.
/// </return>

	public static MentorLake.WebKit2.WebKitURISchemeResponseHandle New(MentorLake.Gio.GInputStreamHandle input_stream, long stream_length)
	{
		return WebKitURISchemeResponseHandleExterns.webkit_uri_scheme_response_new(input_stream, stream_length);
	}

}

public static class WebKitURISchemeResponseHandleExtensions
{
/// <summary>
/// <para>
/// Sets the content type for the @response
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURISchemeResponse
/// </param>
/// <param name="content_type">
/// the content type of the stream
/// </param>

	public static T SetContentType<T>(this T response, string content_type) where T : WebKitURISchemeResponseHandle
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeResponseHandle)");
		WebKitURISchemeResponseHandleExterns.webkit_uri_scheme_response_set_content_type(response, content_type);
		return response;
	}

/// <summary>
/// <para>
/// Assign the provided #SoupMessageHeaders to the response.
/// </para>
/// <para>
/// @headers need to be of the type %SOUP_MESSAGE_HEADERS_RESPONSE.
/// Any existing headers will be overwritten.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURISchemeResponse
/// </param>
/// <param name="headers">
/// the HTTP headers to be set
/// </param>

	public static T SetHttpHeaders<T>(this T response, MentorLake.Soup.SoupMessageHeadersHandle headers) where T : WebKitURISchemeResponseHandle
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeResponseHandle)");
		WebKitURISchemeResponseHandleExterns.webkit_uri_scheme_response_set_http_headers(response, headers);
		return response;
	}

/// <summary>
/// <para>
/// Sets the status code and reason phrase for the @response.
/// </para>
/// <para>
/// If @status_code is a known value and @reason_phrase is %NULL, the @reason_phrase will be set automatically.
/// </para>
/// </summary>

/// <param name="response">
/// a #WebKitURISchemeResponse
/// </param>
/// <param name="status_code">
/// the HTTP status code to be returned
/// </param>
/// <param name="reason_phrase">
/// a reason phrase
/// </param>

	public static T SetStatus<T>(this T response, uint status_code, string reason_phrase) where T : WebKitURISchemeResponseHandle
	{
		if (response.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeResponseHandle)");
		WebKitURISchemeResponseHandleExterns.webkit_uri_scheme_response_set_status(response, status_code, reason_phrase);
		return response;
	}

}

internal class WebKitURISchemeResponseHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeResponseHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURISchemeResponseHandle webkit_uri_scheme_response_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle input_stream, long stream_length);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_scheme_response_set_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeResponseHandle>))] MentorLake.WebKit2.WebKitURISchemeResponseHandle response, string content_type);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_scheme_response_set_http_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeResponseHandle>))] MentorLake.WebKit2.WebKitURISchemeResponseHandle response, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle headers);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_scheme_response_set_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeResponseHandle>))] MentorLake.WebKit2.WebKitURISchemeResponseHandle response, uint status_code, string reason_phrase);

}
