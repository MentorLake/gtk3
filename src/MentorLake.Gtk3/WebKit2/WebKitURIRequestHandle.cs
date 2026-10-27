namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents a URI request.
/// </para>
/// <para>
/// A #WebKitURIRequest can be created with a URI using the
/// webkit_uri_request_new() method, and you can get the URI of an
/// existing request with the webkit_uri_request_get_uri() one.
/// </para>
/// </summary>

public class WebKitURIRequestHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitURIRequest for the given URI.
/// </para>
/// </summary>

/// <param name="uri">
/// an URI
/// </param>
/// <return>
/// a new #WebKitURIRequest
/// </return>

	public static MentorLake.WebKit2.WebKitURIRequestHandle New(string uri)
	{
		return WebKitURIRequestHandleExterns.webkit_uri_request_new(uri);
	}

}

public static class WebKitURIRequestHandleExtensions
{
/// <summary>
/// <para>
/// Get the HTTP headers of a #WebKitURIRequest as a #SoupMessageHeaders.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURIRequest
/// </param>
/// <return>
/// a #SoupMessageHeaders with the HTTP headers of @request
///    or %NULL if @request is not an HTTP request.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetHttpHeaders(this MentorLake.WebKit2.WebKitURIRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURIRequestHandle)");
		return WebKitURIRequestHandleExterns.webkit_uri_request_get_http_headers(request);
	}

/// <summary>
/// <para>
/// Get the HTTP method of the #WebKitURIRequest.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURIRequest
/// </param>
/// <return>
/// the HTTP method of the #WebKitURIRequest or %NULL if @request is not
///    an HTTP request.
/// </return>

	public static string GetHttpMethod(this MentorLake.WebKit2.WebKitURIRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURIRequestHandle)");
		return WebKitURIRequestHandleExterns.webkit_uri_request_get_http_method(request);
	}

/// <summary>
/// <para>
/// Obtains the request URI.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURIRequest
/// </param>
/// <return>
/// request URI, as a string.
/// </return>

	public static string GetUri(this MentorLake.WebKit2.WebKitURIRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURIRequestHandle)");
		return WebKitURIRequestHandleExterns.webkit_uri_request_get_uri(request);
	}

/// <summary>
/// <para>
/// Set the URI of @request
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitURIRequest
/// </param>
/// <param name="uri">
/// an URI
/// </param>

	public static T SetUri<T>(this T request, string uri) where T : WebKitURIRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitURIRequestHandle)");
		WebKitURIRequestHandleExterns.webkit_uri_request_set_uri(request, uri);
		return request;
	}

}

internal class WebKitURIRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIRequestHandle webkit_uri_request_new(string uri);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle webkit_uri_request_get_http_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_request_get_http_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_request_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_uri_request_set_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request, string uri);

}
