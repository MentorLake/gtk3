namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Controls security settings in a #WebKitWebContext.
/// </para>
/// <para>
/// The #WebKitSecurityManager defines security settings for URI
/// schemes in a #WebKitWebContext. Get it from the context with
/// webkit_web_context_get_security_manager(), and use it to register a
/// URI scheme with a certain security level, or to check if it already
/// has it.
/// </para>
/// </summary>

public class WebKitSecurityManagerHandle : GObjectHandle
{
}

public static class WebKitSecurityManagerHandleExtensions
{
/// <summary>
/// <para>
/// Register @scheme as a CORS (Cross-origin resource sharing) enabled scheme.
/// </para>
/// <para>
/// This means that CORS requests are allowed. See W3C CORS specification
/// http://www.w3.org/TR/cors/.
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T RegisterUriSchemeAsCorsEnabled<T>(this T security_manager, string scheme) where T : WebKitSecurityManagerHandle
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		WebKitSecurityManagerHandleExterns.webkit_security_manager_register_uri_scheme_as_cors_enabled(security_manager, scheme);
		return security_manager;
	}

/// <summary>
/// <para>
/// Register @scheme as a display isolated scheme.
/// </para>
/// <para>
/// This means that pages cannot
/// display these URIs unless they are from the same scheme.
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T RegisterUriSchemeAsDisplayIsolated<T>(this T security_manager, string scheme) where T : WebKitSecurityManagerHandle
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		WebKitSecurityManagerHandleExterns.webkit_security_manager_register_uri_scheme_as_display_isolated(security_manager, scheme);
		return security_manager;
	}

/// <summary>
/// <para>
/// Register @scheme as an empty document scheme.
/// </para>
/// <para>
/// This means that
/// they are allowed to commit synchronously.
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T RegisterUriSchemeAsEmptyDocument<T>(this T security_manager, string scheme) where T : WebKitSecurityManagerHandle
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		WebKitSecurityManagerHandleExterns.webkit_security_manager_register_uri_scheme_as_empty_document(security_manager, scheme);
		return security_manager;
	}

/// <summary>
/// <para>
/// Register @scheme as a local scheme.
/// </para>
/// <para>
/// This means that other non-local pages
/// cannot link to or access URIs of this scheme.
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T RegisterUriSchemeAsLocal<T>(this T security_manager, string scheme) where T : WebKitSecurityManagerHandle
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		WebKitSecurityManagerHandleExterns.webkit_security_manager_register_uri_scheme_as_local(security_manager, scheme);
		return security_manager;
	}

/// <summary>
/// <para>
/// Register @scheme as a no-access scheme.
/// </para>
/// <para>
/// This means that pages loaded
/// with this URI scheme cannot access pages loaded with any other URI scheme.
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T RegisterUriSchemeAsNoAccess<T>(this T security_manager, string scheme) where T : WebKitSecurityManagerHandle
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		WebKitSecurityManagerHandleExterns.webkit_security_manager_register_uri_scheme_as_no_access(security_manager, scheme);
		return security_manager;
	}

/// <summary>
/// <para>
/// Register @scheme as a secure scheme.
/// </para>
/// <para>
/// This means that mixed
/// content warnings won&apos;t be generated for this scheme when
/// included by an HTTPS page.
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>

	public static T RegisterUriSchemeAsSecure<T>(this T security_manager, string scheme) where T : WebKitSecurityManagerHandle
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		WebKitSecurityManagerHandleExterns.webkit_security_manager_register_uri_scheme_as_secure(security_manager, scheme);
		return security_manager;
	}

/// <summary>
/// <para>
/// Whether @scheme is considered as a CORS enabled scheme.
/// </para>
/// <para>
/// See also webkit_security_manager_register_uri_scheme_as_cors_enabled().
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>
/// <return>
/// %TRUE if @scheme is a CORS enabled scheme or %FALSE otherwise.
/// </return>

	public static bool UriSchemeIsCorsEnabled(this MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme)
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		return WebKitSecurityManagerHandleExterns.webkit_security_manager_uri_scheme_is_cors_enabled(security_manager, scheme);
	}

/// <summary>
/// <para>
/// Whether @scheme is considered as a display isolated scheme.
/// </para>
/// <para>
/// See also webkit_security_manager_register_uri_scheme_as_display_isolated().
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>
/// <return>
/// %TRUE if @scheme is a display isolated scheme or %FALSE otherwise.
/// </return>

	public static bool UriSchemeIsDisplayIsolated(this MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme)
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		return WebKitSecurityManagerHandleExterns.webkit_security_manager_uri_scheme_is_display_isolated(security_manager, scheme);
	}

/// <summary>
/// <para>
/// Whether @scheme is considered as an empty document scheme.
/// </para>
/// <para>
/// See also webkit_security_manager_register_uri_scheme_as_empty_document().
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>
/// <return>
/// %TRUE if @scheme is an empty document scheme or %FALSE otherwise.
/// </return>

	public static bool UriSchemeIsEmptyDocument(this MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme)
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		return WebKitSecurityManagerHandleExterns.webkit_security_manager_uri_scheme_is_empty_document(security_manager, scheme);
	}

/// <summary>
/// <para>
/// Whether @scheme is considered as a local scheme.
/// </para>
/// <para>
/// See also webkit_security_manager_register_uri_scheme_as_local().
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>
/// <return>
/// %TRUE if @scheme is a local scheme or %FALSE otherwise.
/// </return>

	public static bool UriSchemeIsLocal(this MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme)
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		return WebKitSecurityManagerHandleExterns.webkit_security_manager_uri_scheme_is_local(security_manager, scheme);
	}

/// <summary>
/// <para>
/// Whether @scheme is considered as a no-access scheme.
/// </para>
/// <para>
/// See also webkit_security_manager_register_uri_scheme_as_no_access().
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>
/// <return>
/// %TRUE if @scheme is a no-access scheme or %FALSE otherwise.
/// </return>

	public static bool UriSchemeIsNoAccess(this MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme)
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		return WebKitSecurityManagerHandleExterns.webkit_security_manager_uri_scheme_is_no_access(security_manager, scheme);
	}

/// <summary>
/// <para>
/// Whether @scheme is considered as a secure scheme.
/// </para>
/// <para>
/// See also webkit_security_manager_register_uri_scheme_as_secure().
/// </para>
/// </summary>

/// <param name="security_manager">
/// a #WebKitSecurityManager
/// </param>
/// <param name="scheme">
/// a URI scheme
/// </param>
/// <return>
/// %TRUE if @scheme is a secure scheme or %FALSE otherwise.
/// </return>

	public static bool UriSchemeIsSecure(this MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme)
	{
		if (security_manager.IsInvalid) throw new Exception("Invalid handle (WebKitSecurityManagerHandle)");
		return WebKitSecurityManagerHandleExterns.webkit_security_manager_uri_scheme_is_secure(security_manager, scheme);
	}

}

internal class WebKitSecurityManagerHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_manager_register_uri_scheme_as_cors_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_manager_register_uri_scheme_as_display_isolated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_manager_register_uri_scheme_as_empty_document([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_manager_register_uri_scheme_as_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_manager_register_uri_scheme_as_no_access([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_security_manager_register_uri_scheme_as_secure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_manager_uri_scheme_is_cors_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_manager_uri_scheme_is_display_isolated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_manager_uri_scheme_is_empty_document([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_manager_uri_scheme_is_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_manager_uri_scheme_is_no_access([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_security_manager_uri_scheme_is_secure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityManagerHandle>))] MentorLake.WebKit2.WebKitSecurityManagerHandle security_manager, string scheme);

}
