namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents a URI scheme request.
/// </para>
/// <para>
/// If you register a particular URI scheme in a #WebKitWebContext,
/// using webkit_web_context_register_uri_scheme(), you have to provide
/// a #WebKitURISchemeRequestCallback. After that, when a URI request
/// is made with that particular scheme, your callback will be
/// called. There you will be able to access properties such as the
/// scheme, the URI and path, and the #WebKitWebView that initiated the
/// request, and also finish the request with
/// webkit_uri_scheme_request_finish().
/// </para>
/// </summary>

public class WebKitURISchemeRequestHandle : GObjectHandle
{
}

public static class WebKitURISchemeRequestHandleExtensions
{
/// <summary>
/// <para>
/// Finish a #WebKitURISchemeRequest by setting the contents of the request and its mime type.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <param name="stream">
/// a #GInputStream to read the contents of the request
/// </param>
/// <param name="stream_length">
/// the length of the stream or -1 if not known
/// </param>
/// <param name="content_type">
/// the content type of the stream or %NULL if not known
/// </param>

	public static T Finish<T>(this T request, MentorLake.Gio.GInputStreamHandle stream, long stream_length, string content_type) where T : WebKitURISchemeRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_finish(request, stream, stream_length, content_type);
		return request;
	}

/// <summary>
/// <para>
/// Finish a #WebKitURISchemeRequest with a #GError.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <param name="error">
/// a #GError that will be passed to the #WebKitWebView
/// </param>

	public static T FinishError<T>(this T request, MentorLake.GLib.GErrorHandle error) where T : WebKitURISchemeRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_finish_error(request, error);
		return request;
	}

/// <summary>
/// <para>
/// Finish a #WebKitURISchemeRequest by returning a #WebKitURISchemeResponse
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <param name="response">
/// a #WebKitURISchemeResponse
/// </param>

	public static T FinishWithResponse<T>(this T request, MentorLake.WebKit2.WebKitURISchemeResponseHandle response) where T : WebKitURISchemeRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_finish_with_response(request, response);
		return request;
	}

/// <summary>
/// <para>
/// Get the request body.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// (nullable): the body of the @request.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle GetHttpBody(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_http_body(request);
	}

/// <summary>
/// <para>
/// Get the #SoupMessageHeaders of the request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// the #SoupMessageHeaders of the @request.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetHttpHeaders(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_http_headers(request);
	}

/// <summary>
/// <para>
/// Get the HTTP method of the @request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// the HTTP method of the @request
/// </return>

	public static string GetHttpMethod(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_http_method(request);
	}

/// <summary>
/// <para>
/// Get the URI path of @request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// the URI path of @request
/// </return>

	public static string GetPath(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_path(request);
	}

/// <summary>
/// <para>
/// Get the URI scheme of @request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// the URI scheme of @request
/// </return>

	public static string GetScheme(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_scheme(request);
	}

/// <summary>
/// <para>
/// Get the URI of @request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// the full URI of @request
/// </return>

	public static string GetUri(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_uri(request);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebView that initiated the request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURISchemeRequest
/// </param>
/// <return>
/// the #WebKitWebView that initiated @request.
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle GetWebView(this MentorLake.WebKit2.WebKitURISchemeRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURISchemeRequestHandle)");
		return WebKitURISchemeRequestHandleExterns.webkit_uri_scheme_request_get_web_view(request);
	}

}

internal class WebKitURISchemeRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_scheme_request_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, long stream_length, string content_type);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_scheme_request_finish_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_scheme_request_finish_with_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeResponseHandle>))] MentorLake.WebKit2.WebKitURISchemeResponseHandle response);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle webkit_uri_scheme_request_get_http_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle webkit_uri_scheme_request_get_http_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_scheme_request_get_http_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_scheme_request_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_scheme_request_get_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_scheme_request_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_uri_scheme_request_get_web_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request);

}
