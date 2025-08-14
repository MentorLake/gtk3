namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GUri` type and related functions can be used to parse URIs into
/// their components, and build valid URIs from individual components.
/// </para>
/// <para>
/// Since `GUri` only represents absolute URIs, all `GUri`s will have a
/// URI scheme, so [method@GLib.Uri.get_scheme] will always return a non-`NULL`
/// answer. Likewise, by definition, all URIs have a path component, so
/// [method@GLib.Uri.get_path] will always return a non-`NULL` string (which may
/// be empty).
/// </para>
/// <para>
/// If the URI string has an
/// [‘authority’ component](https://tools.ietf.org/html/rfc3986#section-3) (that
/// is, if the scheme is followed by `://` rather than just `:`), then the
/// `GUri` will contain a hostname, and possibly a port and ‘userinfo’.
/// Additionally, depending on how the `GUri` was constructed/parsed (for example,
/// using the `G_URI_FLAGS_HAS_PASSWORD` and `G_URI_FLAGS_HAS_AUTH_PARAMS` flags),
/// the userinfo may be split out into a username, password, and
/// additional authorization-related parameters.
/// </para>
/// <para>
/// Normally, the components of a `GUri` will have all `%`-encoded
/// characters decoded. However, if you construct/parse a `GUri` with
/// `G_URI_FLAGS_ENCODED`, then the `%`-encoding will be preserved instead in
/// the userinfo, path, and query fields (and in the host field if also
/// created with `G_URI_FLAGS_NON_DNS`). In particular, this is necessary if
/// the URI may contain binary data or non-UTF-8 text, or if decoding
/// the components might change the interpretation of the URI.
/// </para>
/// <para>
/// For example, with the encoded flag:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GUri) uri = g_uri_parse ("http://host/path?query=http%3A%2F%2Fhost%2Fpath%3Fparam%3Dvalue", G_URI_FLAGS_ENCODED, &err);
/// g_assert_cmpstr (g_uri_get_query (uri), ==, "query=http%3A%2F%2Fhost%2Fpath%3Fparam%3Dvalue");
/// ```
/// </para>
/// <para>
/// While the default `%`-decoding behaviour would give:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GUri) uri = g_uri_parse ("http://host/path?query=http%3A%2F%2Fhost%2Fpath%3Fparam%3Dvalue", G_URI_FLAGS_NONE, &err);
/// g_assert_cmpstr (g_uri_get_query (uri), ==, "query=http://host/path?param=value");
/// ```
/// </para>
/// <para>
/// During decoding, if an invalid UTF-8 string is encountered, parsing will fail
/// with an error indicating the bad string location:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GUri) uri = g_uri_parse ("http://host/path?query=http%3A%2F%2Fhost%2Fpath%3Fbad%3D%00alue", G_URI_FLAGS_NONE, &err);
/// g_assert_error (err, G_URI_ERROR, G_URI_ERROR_BAD_QUERY);
/// ```
/// </para>
/// <para>
/// You should pass `G_URI_FLAGS_ENCODED` or `G_URI_FLAGS_ENCODED_QUERY` if you
/// need to handle that case manually. In particular, if the query string
/// contains `=` characters that are `%`-encoded, you should let
/// [func@GLib.Uri.parse_params] do the decoding once of the query.
/// </para>
/// <para>
/// `GUri` is immutable once constructed, and can safely be accessed from
/// multiple threads. Its reference counting is atomic.
/// </para>
/// <para>
/// Note that the scope of `GUri` is to help manipulate URIs in various applications,
/// following [RFC 3986](https://tools.ietf.org/html/rfc3986). In particular,
/// it doesn't intend to cover web browser needs, and doesn’t implement the
/// [WHATWG URL](https://url.spec.whatwg.org/) standard. No APIs are provided to
/// help prevent
/// [homograph attacks](https://en.wikipedia.org/wiki/IDN_homograph_attack), so
/// `GUri` is not suitable for formatting URIs for display to the user for making
/// security-sensitive decisions.
/// </para>
/// <para>
/// ## Relative and absolute URIs
/// </para>
/// <para>
/// As defined in [RFC 3986](https://tools.ietf.org/html/rfc3986#section-4), the
/// hierarchical nature of URIs means that they can either be ‘relative
/// references’ (sometimes referred to as ‘relative URIs’) or ‘URIs’ (for
/// clarity, ‘URIs’ are referred to in this documentation as
/// ‘absolute URIs’ — although
/// [in contrast to RFC 3986](https://tools.ietf.org/html/rfc3986#section-4.3),
/// fragment identifiers are always allowed).
/// </para>
/// <para>
/// Relative references have one or more components of the URI missing. In
/// particular, they have no scheme. Any other component, such as hostname,
/// query, etc. may be missing, apart from a path, which has to be specified (but
/// may be empty). The path may be relative, starting with `./` rather than `/`.
/// </para>
/// <para>
/// For example, a valid relative reference is `./path?query`,
/// `/?query#fragment` or `//example.com`.
/// </para>
/// <para>
/// Absolute URIs have a scheme specified. Any other components of the URI which
/// are missing are specified as explicitly unset in the URI, rather than being
/// resolved relative to a base URI using [method@GLib.Uri.parse_relative].
/// </para>
/// <para>
/// For example, a valid absolute URI is `file:///home/bob` or
/// `https://search.com?query=string`.
/// </para>
/// <para>
/// A `GUri` instance is always an absolute URI. A string may be an absolute URI
/// or a relative reference; see the documentation for individual functions as to
/// what forms they accept.
/// </para>
/// <para>
/// ## Parsing URIs
/// </para>
/// <para>
/// The most minimalist APIs for parsing URIs are [func@GLib.Uri.split] and
/// [func@GLib.Uri.split_with_user]. These split a URI into its component
/// parts, and return the parts; the difference between the two is that
/// [func@GLib.Uri.split] treats the ‘userinfo’ component of the URI as a
/// single element, while [func@GLib.Uri.split_with_user] can (depending on the
/// [flags@GLib.UriFlags] you pass) treat it as containing a username, password,
/// and authentication parameters. Alternatively, [func@GLib.Uri.split_network]
/// can be used when you are only interested in the components that are
/// needed to initiate a network connection to the service (scheme,
/// host, and port).
/// </para>
/// <para>
/// [func@GLib.Uri.parse] is similar to [func@GLib.Uri.split], but instead of
/// returning individual strings, it returns a `GUri` structure (and it requires
/// that the URI be an absolute URI).
/// </para>
/// <para>
/// [func@GLib.Uri.resolve_relative] and [method@GLib.Uri.parse_relative] allow
/// you to resolve a relative URI relative to a base URI.
/// [func@GLib.Uri.resolve_relative] takes two strings and returns a string,
/// and [method@GLib.Uri.parse_relative] takes a `GUri` and a string and returns a
/// `GUri`.
/// </para>
/// <para>
/// All of the parsing functions take a [flags@GLib.UriFlags] argument describing
/// exactly how to parse the URI; see the documentation for that type
/// for more details on the specific flags that you can pass. If you
/// need to choose different flags based on the type of URI, you can
/// use [func@GLib.Uri.peek_scheme] on the URI string to check the scheme
/// first, and use that to decide what flags to parse it with.
/// </para>
/// <para>
/// For example, you might want to use `G_URI_PARAMS_WWW_FORM` when parsing the
/// params for a web URI, so compare the result of [func@GLib.Uri.peek_scheme]
/// against `http` and `https`.
/// </para>
/// <para>
/// ## Building URIs
/// </para>
/// <para>
/// [func@GLib.Uri.join] and [func@GLib.Uri.join_with_user] can be used to construct
/// valid URI strings from a set of component strings. They are the
/// inverse of [func@GLib.Uri.split] and [func@GLib.Uri.split_with_user].
/// </para>
/// <para>
/// Similarly, [func@GLib.Uri.build] and [func@GLib.Uri.build_with_user] can be
/// used to construct a `GUri` from a set of component strings.
/// </para>
/// <para>
/// As with the parsing functions, the building functions take a
/// [flags@GLib.UriFlags] argument. In particular, it is important to keep in mind
/// whether the URI components you are using are already `%`-encoded. If so,
/// you must pass the `G_URI_FLAGS_ENCODED` flag.
/// </para>
/// <para>
/// ## `file://` URIs
/// </para>
/// <para>
/// Note that Windows and Unix both define special rules for parsing
/// `file://` URIs (involving non-UTF-8 character sets on Unix, and the
/// interpretation of path separators on Windows). `GUri` does not
/// implement these rules. Use [func@GLib.filename_from_uri] and
/// [func@GLib.filename_to_uri] if you want to properly convert between
/// `file://` URIs and local filenames.
/// </para>
/// <para>
/// ## URI Equality
/// </para>
/// <para>
/// Note that there is no `g_uri_equal ()` function, because comparing
/// URIs usefully requires scheme-specific knowledge that `GUri` does
/// not have. `GUri` can help with normalization if you use the various
/// encoded [flags@GLib.UriFlags] as well as `G_URI_FLAGS_SCHEME_NORMALIZE`
/// however it is not comprehensive.
/// For example, `data:,foo` and `data:;base64,Zm9v` resolve to the same
/// thing according to the `data:` URI specification which GLib does not
/// handle.
/// </para>
/// </summary>

public class GUriHandle : BaseSafeHandle
{
}


public static class GUriExtensions
{
/// <summary>
/// <para>
/// Gets @uri's authentication parameters, which may contain
/// `%`-encoding, depending on the flags with which @uri was created.
/// (If @uri was not created with %G_URI_FLAGS_HAS_AUTH_PARAMS then this will
/// be %NULL.)
/// </para>
/// <para>
/// Depending on the URI scheme, g_uri_parse_params() may be useful for
/// further parsing this information.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's authentication parameters.
/// </return>

	public static string GetAuthParams(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_auth_params(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's flags set upon construction.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's flags.
/// </return>

	public static MentorLake.GLib.GUriFlags GetFlags(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_flags(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's fragment, which may contain `%`-encoding, depending on
/// the flags with which @uri was created.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's fragment.
/// </return>

	public static string GetFragment(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_fragment(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's host. This will never have `%`-encoded characters,
/// unless it is non-UTF-8 (which can only be the case if @uri was
/// created with %G_URI_FLAGS_NON_DNS).
/// </para>
/// <para>
/// If @uri contained an IPv6 address literal, this value will be just
/// that address, without the brackets around it that are necessary in
/// the string form of the URI. Note that in this case there may also
/// be a scope ID attached to the address. Eg, `fe80::1234%``em1` (or
/// `fe80::1234%``25em1` if the string is still encoded).
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's host.
/// </return>

	public static string GetHost(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_host(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's password, which may contain `%`-encoding, depending on
/// the flags with which @uri was created. (If @uri was not created
/// with %G_URI_FLAGS_HAS_PASSWORD then this will be %NULL.)
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's password.
/// </return>

	public static string GetPassword(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_password(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's path, which may contain `%`-encoding, depending on the
/// flags with which @uri was created.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's path.
/// </return>

	public static string GetPath(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_path(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's port.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's port, or `-1` if no port was specified.
/// </return>

	public static int GetPort(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_port(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's query, which may contain `%`-encoding, depending on the
/// flags with which @uri was created.
/// </para>
/// <para>
/// For queries consisting of a series of `name=value` parameters,
/// #GUriParamsIter or g_uri_parse_params() may be useful.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's query.
/// </return>

	public static string GetQuery(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_query(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's scheme. Note that this will always be all-lowercase,
/// regardless of the string or strings that @uri was created from.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's scheme.
/// </return>

	public static string GetScheme(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_scheme(uri);
	}

/// <summary>
/// <para>
/// Gets the ‘username’ component of @uri's userinfo, which may contain
/// `%`-encoding, depending on the flags with which @uri was created.
/// If @uri was not created with %G_URI_FLAGS_HAS_PASSWORD or
/// %G_URI_FLAGS_HAS_AUTH_PARAMS, this is the same as g_uri_get_userinfo().
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's user.
/// </return>

	public static string GetUser(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_user(uri);
	}

/// <summary>
/// <para>
/// Gets @uri's userinfo, which may contain `%`-encoding, depending on
/// the flags with which @uri was created.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri's userinfo.
/// </return>

	public static string GetUserinfo(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_get_userinfo(uri);
	}

/// <summary>
/// <para>
/// Parses @uri_ref according to @flags and, if it is a
/// [relative URI](#relative-and-absolute-uris), resolves it relative to @base_uri.
/// If the result is not a valid absolute URI, it will be discarded, and an error
/// returned.
/// </para>
/// </summary>

/// <param name="base_uri">
/// a base absolute URI
/// </param>
/// <param name="uri_ref">
/// a string representing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags describing how to parse @uri_ref
/// </param>
/// <return>
/// a new #GUri, or NULL on error.
/// </return>

	public static MentorLake.GLib.GUriHandle ParseRelative(this MentorLake.GLib.GUriHandle base_uri, string uri_ref, MentorLake.GLib.GUriFlags flags)
	{
		if (base_uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		var externCallResult = GUriExterns.g_uri_parse_relative(base_uri, uri_ref, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Increments the reference count of @uri by one.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// @uri
/// </return>

	public static MentorLake.GLib.GUriHandle Ref(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_ref(uri);
	}

/// <summary>
/// <para>
/// Returns a string representing @uri.
/// </para>
/// <para>
/// This is not guaranteed to return a string which is identical to the
/// string that @uri was parsed from. However, if the source URI was
/// syntactically correct (according to RFC 3986), and it was parsed
/// with %G_URI_FLAGS_ENCODED, then g_uri_to_string() is guaranteed to return
/// a string which is at least semantically equivalent to the source
/// URI (according to RFC 3986).
/// </para>
/// <para>
/// If @uri might contain sensitive details, such as authentication parameters,
/// or private data in its query string, and the returned string is going to be
/// logged, then consider using g_uri_to_string_partial() to redact parts.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// a string representing @uri,
///     which the caller must free.
/// </return>

	public static string ToString(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_to_string(uri);
	}

/// <summary>
/// <para>
/// Returns a string representing @uri, subject to the options in
/// @flags. See g_uri_to_string() and #GUriHideFlags for more details.
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>
/// <param name="flags">
/// flags describing what parts of @uri to hide
/// </param>
/// <return>
/// a string representing
///     @uri, which the caller must free.
/// </return>

	public static string ToStringPartial(this MentorLake.GLib.GUriHandle uri, MentorLake.GLib.GUriHideFlags flags)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		return GUriExterns.g_uri_to_string_partial(uri, flags);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @uri by one.
/// </para>
/// <para>
/// When the reference count reaches zero, the resources allocated by
/// @uri are freed
/// </para>
/// </summary>

/// <param name="uri">
/// a #GUri
/// </param>

	public static void Unref(this MentorLake.GLib.GUriHandle uri)
	{
		if (uri.IsInvalid) throw new Exception("Invalid handle (GUri)");
		GUriExterns.g_uri_unref(uri);
	}


	public static GUri Dereference(this GUriHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUri>(x.DangerousGetHandle());
}
internal class GUriExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_auth_params([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUriFlags g_uri_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_fragment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_uri_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_user([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_get_userinfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_parse_relative([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle base_uri, string uri_ref, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_to_string_partial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, MentorLake.GLib.GUriHideFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_uri_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_build(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_build_with_user(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_uri_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_escape_bytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_is_valid(string uri_string, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_join(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_join_with_user(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_uri_list_extract_uris(string uri_list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_parse(string uri_string, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_uri_parse_params(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_parse_scheme(string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_peek_scheme(string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_resolve_relative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split_network(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split_with_user(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_uri_unescape_bytes(string escaped_string, UIntPtr length, string illegal_characters, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);

}

/// <summary>
/// <para>
/// The `GUri` type and related functions can be used to parse URIs into
/// their components, and build valid URIs from individual components.
/// </para>
/// <para>
/// Since `GUri` only represents absolute URIs, all `GUri`s will have a
/// URI scheme, so [method@GLib.Uri.get_scheme] will always return a non-`NULL`
/// answer. Likewise, by definition, all URIs have a path component, so
/// [method@GLib.Uri.get_path] will always return a non-`NULL` string (which may
/// be empty).
/// </para>
/// <para>
/// If the URI string has an
/// [‘authority’ component](https://tools.ietf.org/html/rfc3986#section-3) (that
/// is, if the scheme is followed by `://` rather than just `:`), then the
/// `GUri` will contain a hostname, and possibly a port and ‘userinfo’.
/// Additionally, depending on how the `GUri` was constructed/parsed (for example,
/// using the `G_URI_FLAGS_HAS_PASSWORD` and `G_URI_FLAGS_HAS_AUTH_PARAMS` flags),
/// the userinfo may be split out into a username, password, and
/// additional authorization-related parameters.
/// </para>
/// <para>
/// Normally, the components of a `GUri` will have all `%`-encoded
/// characters decoded. However, if you construct/parse a `GUri` with
/// `G_URI_FLAGS_ENCODED`, then the `%`-encoding will be preserved instead in
/// the userinfo, path, and query fields (and in the host field if also
/// created with `G_URI_FLAGS_NON_DNS`). In particular, this is necessary if
/// the URI may contain binary data or non-UTF-8 text, or if decoding
/// the components might change the interpretation of the URI.
/// </para>
/// <para>
/// For example, with the encoded flag:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GUri) uri = g_uri_parse ("http://host/path?query=http%3A%2F%2Fhost%2Fpath%3Fparam%3Dvalue", G_URI_FLAGS_ENCODED, &err);
/// g_assert_cmpstr (g_uri_get_query (uri), ==, "query=http%3A%2F%2Fhost%2Fpath%3Fparam%3Dvalue");
/// ```
/// </para>
/// <para>
/// While the default `%`-decoding behaviour would give:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GUri) uri = g_uri_parse ("http://host/path?query=http%3A%2F%2Fhost%2Fpath%3Fparam%3Dvalue", G_URI_FLAGS_NONE, &err);
/// g_assert_cmpstr (g_uri_get_query (uri), ==, "query=http://host/path?param=value");
/// ```
/// </para>
/// <para>
/// During decoding, if an invalid UTF-8 string is encountered, parsing will fail
/// with an error indicating the bad string location:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GUri) uri = g_uri_parse ("http://host/path?query=http%3A%2F%2Fhost%2Fpath%3Fbad%3D%00alue", G_URI_FLAGS_NONE, &err);
/// g_assert_error (err, G_URI_ERROR, G_URI_ERROR_BAD_QUERY);
/// ```
/// </para>
/// <para>
/// You should pass `G_URI_FLAGS_ENCODED` or `G_URI_FLAGS_ENCODED_QUERY` if you
/// need to handle that case manually. In particular, if the query string
/// contains `=` characters that are `%`-encoded, you should let
/// [func@GLib.Uri.parse_params] do the decoding once of the query.
/// </para>
/// <para>
/// `GUri` is immutable once constructed, and can safely be accessed from
/// multiple threads. Its reference counting is atomic.
/// </para>
/// <para>
/// Note that the scope of `GUri` is to help manipulate URIs in various applications,
/// following [RFC 3986](https://tools.ietf.org/html/rfc3986). In particular,
/// it doesn't intend to cover web browser needs, and doesn’t implement the
/// [WHATWG URL](https://url.spec.whatwg.org/) standard. No APIs are provided to
/// help prevent
/// [homograph attacks](https://en.wikipedia.org/wiki/IDN_homograph_attack), so
/// `GUri` is not suitable for formatting URIs for display to the user for making
/// security-sensitive decisions.
/// </para>
/// <para>
/// ## Relative and absolute URIs
/// </para>
/// <para>
/// As defined in [RFC 3986](https://tools.ietf.org/html/rfc3986#section-4), the
/// hierarchical nature of URIs means that they can either be ‘relative
/// references’ (sometimes referred to as ‘relative URIs’) or ‘URIs’ (for
/// clarity, ‘URIs’ are referred to in this documentation as
/// ‘absolute URIs’ — although
/// [in contrast to RFC 3986](https://tools.ietf.org/html/rfc3986#section-4.3),
/// fragment identifiers are always allowed).
/// </para>
/// <para>
/// Relative references have one or more components of the URI missing. In
/// particular, they have no scheme. Any other component, such as hostname,
/// query, etc. may be missing, apart from a path, which has to be specified (but
/// may be empty). The path may be relative, starting with `./` rather than `/`.
/// </para>
/// <para>
/// For example, a valid relative reference is `./path?query`,
/// `/?query#fragment` or `//example.com`.
/// </para>
/// <para>
/// Absolute URIs have a scheme specified. Any other components of the URI which
/// are missing are specified as explicitly unset in the URI, rather than being
/// resolved relative to a base URI using [method@GLib.Uri.parse_relative].
/// </para>
/// <para>
/// For example, a valid absolute URI is `file:///home/bob` or
/// `https://search.com?query=string`.
/// </para>
/// <para>
/// A `GUri` instance is always an absolute URI. A string may be an absolute URI
/// or a relative reference; see the documentation for individual functions as to
/// what forms they accept.
/// </para>
/// <para>
/// ## Parsing URIs
/// </para>
/// <para>
/// The most minimalist APIs for parsing URIs are [func@GLib.Uri.split] and
/// [func@GLib.Uri.split_with_user]. These split a URI into its component
/// parts, and return the parts; the difference between the two is that
/// [func@GLib.Uri.split] treats the ‘userinfo’ component of the URI as a
/// single element, while [func@GLib.Uri.split_with_user] can (depending on the
/// [flags@GLib.UriFlags] you pass) treat it as containing a username, password,
/// and authentication parameters. Alternatively, [func@GLib.Uri.split_network]
/// can be used when you are only interested in the components that are
/// needed to initiate a network connection to the service (scheme,
/// host, and port).
/// </para>
/// <para>
/// [func@GLib.Uri.parse] is similar to [func@GLib.Uri.split], but instead of
/// returning individual strings, it returns a `GUri` structure (and it requires
/// that the URI be an absolute URI).
/// </para>
/// <para>
/// [func@GLib.Uri.resolve_relative] and [method@GLib.Uri.parse_relative] allow
/// you to resolve a relative URI relative to a base URI.
/// [func@GLib.Uri.resolve_relative] takes two strings and returns a string,
/// and [method@GLib.Uri.parse_relative] takes a `GUri` and a string and returns a
/// `GUri`.
/// </para>
/// <para>
/// All of the parsing functions take a [flags@GLib.UriFlags] argument describing
/// exactly how to parse the URI; see the documentation for that type
/// for more details on the specific flags that you can pass. If you
/// need to choose different flags based on the type of URI, you can
/// use [func@GLib.Uri.peek_scheme] on the URI string to check the scheme
/// first, and use that to decide what flags to parse it with.
/// </para>
/// <para>
/// For example, you might want to use `G_URI_PARAMS_WWW_FORM` when parsing the
/// params for a web URI, so compare the result of [func@GLib.Uri.peek_scheme]
/// against `http` and `https`.
/// </para>
/// <para>
/// ## Building URIs
/// </para>
/// <para>
/// [func@GLib.Uri.join] and [func@GLib.Uri.join_with_user] can be used to construct
/// valid URI strings from a set of component strings. They are the
/// inverse of [func@GLib.Uri.split] and [func@GLib.Uri.split_with_user].
/// </para>
/// <para>
/// Similarly, [func@GLib.Uri.build] and [func@GLib.Uri.build_with_user] can be
/// used to construct a `GUri` from a set of component strings.
/// </para>
/// <para>
/// As with the parsing functions, the building functions take a
/// [flags@GLib.UriFlags] argument. In particular, it is important to keep in mind
/// whether the URI components you are using are already `%`-encoded. If so,
/// you must pass the `G_URI_FLAGS_ENCODED` flag.
/// </para>
/// <para>
/// ## `file://` URIs
/// </para>
/// <para>
/// Note that Windows and Unix both define special rules for parsing
/// `file://` URIs (involving non-UTF-8 character sets on Unix, and the
/// interpretation of path separators on Windows). `GUri` does not
/// implement these rules. Use [func@GLib.filename_from_uri] and
/// [func@GLib.filename_to_uri] if you want to properly convert between
/// `file://` URIs and local filenames.
/// </para>
/// <para>
/// ## URI Equality
/// </para>
/// <para>
/// Note that there is no `g_uri_equal ()` function, because comparing
/// URIs usefully requires scheme-specific knowledge that `GUri` does
/// not have. `GUri` can help with normalization if you use the various
/// encoded [flags@GLib.UriFlags] as well as `G_URI_FLAGS_SCHEME_NORMALIZE`
/// however it is not comprehensive.
/// For example, `data:,foo` and `data:;base64,Zm9v` resolve to the same
/// thing according to the `data:` URI specification which GLib does not
/// handle.
/// </para>
/// </summary>

public struct GUri
{
/// <summary>
/// <para>
/// Creates a new #GUri from the given components according to @flags.
/// </para>
/// <para>
/// See also g_uri_build_with_user(), which allows specifying the
/// components of the "userinfo" separately.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the #GUri
/// </param>
/// <param name="scheme">
/// the URI scheme
/// </param>
/// <param name="userinfo">
/// the userinfo component, or %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// a new #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle Build(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_build(flags, scheme, userinfo, host, port, path, query, fragment);
	}

/// <summary>
/// <para>
/// Creates a new #GUri from the given components according to @flags
/// (%G_URI_FLAGS_HAS_PASSWORD is added unconditionally). The @flags must be
/// coherent with the passed values, in particular use `%`-encoded values with
/// %G_URI_FLAGS_ENCODED.
/// </para>
/// <para>
/// In contrast to g_uri_build(), this allows specifying the components
/// of the ‘userinfo’ field separately. Note that @user must be non-%NULL
/// if either @password or @auth_params is non-%NULL.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the #GUri
/// </param>
/// <param name="scheme">
/// the URI scheme
/// </param>
/// <param name="user">
/// the user component of the userinfo, or %NULL
/// </param>
/// <param name="password">
/// the password component of the userinfo, or %NULL
/// </param>
/// <param name="auth_params">
/// the auth params of the userinfo, or %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// a new #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle BuildWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_build_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}



	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GUriExterns.g_uri_error_quark();
	}

/// <summary>
/// <para>
/// Escapes arbitrary data for use in a URI.
/// </para>
/// <para>
/// Normally all characters that are not ‘unreserved’ (i.e. ASCII
/// alphanumerical characters plus dash, dot, underscore and tilde) are
/// escaped. But if you specify characters in @reserved_chars_allowed
/// they are not escaped. This is useful for the ‘reserved’ characters
/// in the URI specification, since those are allowed unescaped in some
/// portions of a URI.
/// </para>
/// <para>
/// Though technically incorrect, this will also allow escaping nul
/// bytes as `%``00`.
/// </para>
/// </summary>

/// <param name="unescaped">
/// the unescaped input data.
/// </param>
/// <param name="length">
/// the length of @unescaped
/// </param>
/// <param name="reserved_chars_allowed">
/// a string of reserved
///   characters that are allowed to be used, or %NULL.
/// </param>
/// <return>
/// an escaped version of @unescaped.
///     The returned string should be freed when no longer needed.
/// </return>

	public static string EscapeBytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed)
	{
		return GUriExterns.g_uri_escape_bytes(unescaped, length, reserved_chars_allowed);
	}

/// <summary>
/// <para>
/// Escapes a string for use in a URI.
/// </para>
/// <para>
/// Normally all characters that are not "unreserved" (i.e. ASCII
/// alphanumerical characters plus dash, dot, underscore and tilde) are
/// escaped. But if you specify characters in @reserved_chars_allowed
/// they are not escaped. This is useful for the "reserved" characters
/// in the URI specification, since those are allowed unescaped in some
/// portions of a URI.
/// </para>
/// </summary>

/// <param name="unescaped">
/// the unescaped input string.
/// </param>
/// <param name="reserved_chars_allowed">
/// a string of reserved
///   characters that are allowed to be used, or %NULL.
/// </param>
/// <param name="allow_utf8">
/// %TRUE if the result can include UTF-8 characters.
/// </param>
/// <return>
/// an escaped version of @unescaped. The
/// returned string should be freed when no longer needed.
/// </return>

	public static string EscapeString(string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		return GUriExterns.g_uri_escape_string(unescaped, reserved_chars_allowed, allow_utf8);
	}

/// <summary>
/// <para>
/// Parses @uri_string according to @flags, to determine whether it is a valid
/// [absolute URI](#relative-and-absolute-uris), i.e. it does not need to be resolved
/// relative to another URI using g_uri_parse_relative().
/// </para>
/// <para>
/// If it’s not a valid URI, an error is returned explaining how it’s invalid.
/// </para>
/// <para>
/// See g_uri_split(), and the definition of #GUriFlags, for more
/// information on the effect of @flags.
/// </para>
/// </summary>

/// <param name="uri_string">
/// a string containing an absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_string
/// </param>
/// <return>
/// %TRUE if @uri_string is a valid absolute URI, %FALSE on error.
/// </return>

	public static bool IsValid(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_is_valid(uri_string, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Joins the given components together according to @flags to create
/// an absolute URI string. @path may not be %NULL (though it may be the empty
/// string).
/// </para>
/// <para>
/// When @host is present, @path must either be empty or begin with a slash (`/`)
/// character. When @host is not present, @path cannot begin with two slash
/// characters (`//`). See
/// [RFC 3986, section 3](https://tools.ietf.org/html/rfc3986#section-3).
/// </para>
/// <para>
/// See also g_uri_join_with_user(), which allows specifying the
/// components of the ‘userinfo’ separately.
/// </para>
/// <para>
/// %G_URI_FLAGS_HAS_PASSWORD and %G_URI_FLAGS_HAS_AUTH_PARAMS are ignored if set
/// in @flags.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the URI string
/// </param>
/// <param name="scheme">
/// the URI scheme, or %NULL
/// </param>
/// <param name="userinfo">
/// the userinfo component, or %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// an absolute URI string
/// </return>

	public static string Join(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_join(flags, scheme, userinfo, host, port, path, query, fragment);
	}

/// <summary>
/// <para>
/// Joins the given components together according to @flags to create
/// an absolute URI string. @path may not be %NULL (though it may be the empty
/// string).
/// </para>
/// <para>
/// In contrast to g_uri_join(), this allows specifying the components
/// of the ‘userinfo’ separately. It otherwise behaves the same.
/// </para>
/// <para>
/// %G_URI_FLAGS_HAS_PASSWORD and %G_URI_FLAGS_HAS_AUTH_PARAMS are ignored if set
/// in @flags.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the URI string
/// </param>
/// <param name="scheme">
/// the URI scheme, or %NULL
/// </param>
/// <param name="user">
/// the user component of the userinfo, or %NULL
/// </param>
/// <param name="password">
/// the password component of the userinfo, or
///   %NULL
/// </param>
/// <param name="auth_params">
/// the auth params of the userinfo, or
///   %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// an absolute URI string
/// </return>

	public static string JoinWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_join_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

/// <summary>
/// <para>
/// Splits an URI list conforming to the text/uri-list
/// mime type defined in RFC 2483 into individual URIs,
/// discarding any comments. The URIs are not validated.
/// </para>
/// </summary>

/// <param name="uri_list">
/// an URI list
/// </param>
/// <return>
/// a newly allocated %NULL-terminated list
///   of strings holding the individual URIs. The array should be freed
///   with g_strfreev().
/// </return>

	public static string[] ListExtractUris(string uri_list)
	{
		return GUriExterns.g_uri_list_extract_uris(uri_list);
	}

/// <summary>
/// <para>
/// Parses @uri_string according to @flags. If the result is not a
/// valid [absolute URI](#relative-and-absolute-uris), it will be discarded, and an
/// error returned.
/// </para>
/// </summary>

/// <param name="uri_string">
/// a string representing an absolute URI
/// </param>
/// <param name="flags">
/// flags describing how to parse @uri_string
/// </param>
/// <return>
/// a new #GUri, or NULL on error.
/// </return>

	public static MentorLake.GLib.GUriHandle Parse(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_parse(uri_string, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Many URI schemes include one or more attribute/value pairs as part of the URI
/// value. This method can be used to parse them into a hash table. When an
/// attribute has multiple occurrences, the last value is the final returned
/// value. If you need to handle repeated attributes differently, use
/// #GUriParamsIter.
/// </para>
/// <para>
/// The @params string is assumed to still be `%`-encoded, but the returned
/// values will be fully decoded. (Thus it is possible that the returned values
/// may contain `=` or @separators, if the value was encoded in the input.)
/// Invalid `%`-encoding is treated as with the %G_URI_FLAGS_PARSE_RELAXED
/// rules for g_uri_parse(). (However, if @params is the path or query string
/// from a #GUri that was parsed without %G_URI_FLAGS_PARSE_RELAXED and
/// %G_URI_FLAGS_ENCODED, then you already know that it does not contain any
/// invalid encoding.)
/// </para>
/// <para>
/// %G_URI_PARAMS_WWW_FORM is handled as documented for g_uri_params_iter_init().
/// </para>
/// <para>
/// If %G_URI_PARAMS_CASE_INSENSITIVE is passed to @flags, attributes will be
/// compared case-insensitively, so a params string `attr=123&Attr=456` will only
/// return a single attribute–value pair, `Attr=456`. Case will be preserved in
/// the returned attributes.
/// </para>
/// <para>
/// If @params cannot be parsed (for example, it contains two @separators
/// characters in a row), then @error is set and %NULL is returned.
/// </para>
/// </summary>

/// <param name="@params">
/// a `%`-encoded string containing `attribute=value`
///   parameters
/// </param>
/// <param name="length">
/// the length of @params, or `-1` if it is nul-terminated
/// </param>
/// <param name="separators">
/// the separator byte character set between parameters. (usually
///   `&`, but sometimes `;` or both `&;`). Note that this function works on
///   bytes not characters, so it can't be used to delimit UTF-8 strings for
///   anything but ASCII characters. You may pass an empty set, in which case
///   no splitting will occur.
/// </param>
/// <param name="flags">
/// flags to modify the way the parameters are handled.
/// </param>
/// <return>
/// 
///     A hash table of attribute/value pairs, with both names and values
///     fully-decoded; or %NULL on error.
/// </return>

	public static MentorLake.GLib.GHashTableHandle ParseParams(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_parse_params(@params, length, separators, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the scheme portion of a URI string.
/// [RFC 3986](https://tools.ietf.org/html/rfc3986#section-3) decodes the scheme
/// as:
/// |[
/// URI = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
/// ]|
/// Common schemes include `file`, `https`, `svn+ssh`, etc.
/// </para>
/// </summary>

/// <param name="uri">
/// a valid URI.
/// </param>
/// <return>
/// The ‘scheme’ component of the URI, or
///     %NULL on error. The returned string should be freed when no longer needed.
/// </return>

	public static string ParseScheme(string uri)
	{
		return GUriExterns.g_uri_parse_scheme(uri);
	}

/// <summary>
/// <para>
/// Gets the scheme portion of a URI string.
/// [RFC 3986](https://tools.ietf.org/html/rfc3986#section-3) decodes the scheme
/// as:
/// |[
/// URI = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
/// ]|
/// Common schemes include `file`, `https`, `svn+ssh`, etc.
/// </para>
/// <para>
/// Unlike g_uri_parse_scheme(), the returned scheme is normalized to
/// all-lowercase and does not need to be freed.
/// </para>
/// </summary>

/// <param name="uri">
/// a valid URI.
/// </param>
/// <return>
/// The ‘scheme’ component of the URI, or
///     %NULL on error. The returned string is normalized to all-lowercase, and
///     interned via g_intern_string(), so it does not need to be freed.
/// </return>

	public static string PeekScheme(string uri)
	{
		return GUriExterns.g_uri_peek_scheme(uri);
	}

/// <summary>
/// <para>
/// Parses @uri_ref according to @flags and, if it is a
/// [relative URI](#relative-and-absolute-uris), resolves it relative to
/// @base_uri_string. If the result is not a valid absolute URI, it will be
/// discarded, and an error returned.
/// </para>
/// <para>
/// (If @base_uri_string is %NULL, this just returns @uri_ref, or
/// %NULL if @uri_ref is invalid or not absolute.)
/// </para>
/// </summary>

/// <param name="base_uri_string">
/// a string representing a base URI
/// </param>
/// <param name="uri_ref">
/// a string representing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags describing how to parse @uri_ref
/// </param>
/// <return>
/// the resolved URI string,
/// or NULL on error.
/// </return>

	public static string ResolveRelative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_resolve_relative(base_uri_string, uri_ref, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @uri_ref (which can be an
/// [absolute or relative URI](#relative-and-absolute-uris)) according to @flags, and
/// returns the pieces. Any component that doesn't appear in @uri_ref will be
/// returned as %NULL (but note that all URIs always have a path component,
/// though it may be the empty string).
/// </para>
/// <para>
/// If @flags contains %G_URI_FLAGS_ENCODED, then `%`-encoded characters in
/// @uri_ref will remain encoded in the output strings. (If not,
/// then all such characters will be decoded.) Note that decoding will
/// only work if the URI components are ASCII or UTF-8, so you will
/// need to use %G_URI_FLAGS_ENCODED if they are not.
/// </para>
/// <para>
/// Note that the %G_URI_FLAGS_HAS_PASSWORD and
/// %G_URI_FLAGS_HAS_AUTH_PARAMS @flags are ignored by g_uri_split(),
/// since it always returns only the full userinfo; use
/// g_uri_split_with_user() if you want it split up.
/// </para>
/// </summary>

/// <param name="uri_ref">
/// a string containing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_ref
/// </param>
/// <param name="scheme">
/// on return, contains
///    the scheme (converted to lowercase), or %NULL
/// </param>
/// <param name="userinfo">
/// on return, contains
///    the userinfo, or %NULL
/// </param>
/// <param name="host">
/// on return, contains the
///    host, or %NULL
/// </param>
/// <param name="port">
/// on return, contains the
///    port, or `-1`
/// </param>
/// <param name="path">
/// on return, contains the
///    path
/// </param>
/// <param name="query">
/// on return, contains the
///    query, or %NULL
/// </param>
/// <param name="fragment">
/// on return, contains
///    the fragment, or %NULL
/// </param>
/// <return>
/// %TRUE if @uri_ref parsed successfully, %FALSE
///   on error.
/// </return>

	public static bool Split(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment)
	{
		var externCallResult = GUriExterns.g_uri_split(uri_ref, flags, out scheme, out userinfo, out host, out port, out path, out query, out fragment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @uri_string (which must be an [absolute URI](#relative-and-absolute-uris))
/// according to @flags, and returns the pieces relevant to connecting to a host.
/// See the documentation for g_uri_split() for more details; this is
/// mostly a wrapper around that function with simpler arguments.
/// However, it will return an error if @uri_string is a relative URI,
/// or does not contain a hostname component.
/// </para>
/// </summary>

/// <param name="uri_string">
/// a string containing an absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_string
/// </param>
/// <param name="scheme">
/// on return, contains
///    the scheme (converted to lowercase), or %NULL
/// </param>
/// <param name="host">
/// on return, contains the
///    host, or %NULL
/// </param>
/// <param name="port">
/// on return, contains the
///    port, or `-1`
/// </param>
/// <return>
/// %TRUE if @uri_string parsed successfully,
///   %FALSE on error.
/// </return>

	public static bool SplitNetwork(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port)
	{
		var externCallResult = GUriExterns.g_uri_split_network(uri_string, flags, out scheme, out host, out port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @uri_ref (which can be an
/// [absolute or relative URI](#relative-and-absolute-uris)) according to @flags, and
/// returns the pieces. Any component that doesn't appear in @uri_ref will be
/// returned as %NULL (but note that all URIs always have a path component,
/// though it may be the empty string).
/// </para>
/// <para>
/// See g_uri_split(), and the definition of #GUriFlags, for more
/// information on the effect of @flags. Note that @password will only
/// be parsed out if @flags contains %G_URI_FLAGS_HAS_PASSWORD, and
/// @auth_params will only be parsed out if @flags contains
/// %G_URI_FLAGS_HAS_AUTH_PARAMS.
/// </para>
/// </summary>

/// <param name="uri_ref">
/// a string containing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_ref
/// </param>
/// <param name="scheme">
/// on return, contains
///    the scheme (converted to lowercase), or %NULL
/// </param>
/// <param name="user">
/// on return, contains
///    the user, or %NULL
/// </param>
/// <param name="password">
/// on return, contains
///    the password, or %NULL
/// </param>
/// <param name="auth_params">
/// on return, contains
///    the auth_params, or %NULL
/// </param>
/// <param name="host">
/// on return, contains the
///    host, or %NULL
/// </param>
/// <param name="port">
/// on return, contains the
///    port, or `-1`
/// </param>
/// <param name="path">
/// on return, contains the
///    path
/// </param>
/// <param name="query">
/// on return, contains the
///    query, or %NULL
/// </param>
/// <param name="fragment">
/// on return, contains
///    the fragment, or %NULL
/// </param>
/// <return>
/// %TRUE if @uri_ref parsed successfully, %FALSE
///   on error.
/// </return>

	public static bool SplitWithUser(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment)
	{
		var externCallResult = GUriExterns.g_uri_split_with_user(uri_ref, flags, out scheme, out user, out password, out auth_params, out host, out port, out path, out query, out fragment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unescapes a segment of an escaped string as binary data.
/// </para>
/// <para>
/// Note that in contrast to g_uri_unescape_string(), this does allow
/// nul bytes to appear in the output.
/// </para>
/// <para>
/// If any of the characters in @illegal_characters appears as an escaped
/// character in @escaped_string, then that is an error and %NULL will be
/// returned. This is useful if you want to avoid for instance having a slash
/// being expanded in an escaped path element, which might confuse pathname
/// handling.
/// </para>
/// </summary>

/// <param name="escaped_string">
/// A URI-escaped string
/// </param>
/// <param name="length">
/// the length (in bytes) of @escaped_string to escape, or `-1` if it
///   is nul-terminated.
/// </param>
/// <param name="illegal_characters">
/// a string of illegal characters
///   not to be allowed, or %NULL.
/// </param>
/// <return>
/// an unescaped version of @escaped_string
///     or %NULL on error (if decoding failed, using %G_URI_ERROR_FAILED error
///     code). The returned #GBytes should be unreffed when no longer needed.
/// </return>

	public static MentorLake.GLib.GBytesHandle UnescapeBytes(string escaped_string, UIntPtr length, string illegal_characters)
	{
		var externCallResult = GUriExterns.g_uri_unescape_bytes(escaped_string, length, illegal_characters, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unescapes a segment of an escaped string.
/// </para>
/// <para>
/// If any of the characters in @illegal_characters or the NUL
/// character appears as an escaped character in @escaped_string, then
/// that is an error and %NULL will be returned. This is useful if you
/// want to avoid for instance having a slash being expanded in an
/// escaped path element, which might confuse pathname handling.
/// </para>
/// <para>
/// Note: `NUL` byte is not accepted in the output, in contrast to
/// g_uri_unescape_bytes().
/// </para>
/// </summary>

/// <param name="escaped_string">
/// A string, may be %NULL
/// </param>
/// <param name="escaped_string_end">
/// Pointer to end of @escaped_string,
///   may be %NULL
/// </param>
/// <param name="illegal_characters">
/// An optional string of illegal
///   characters not to be allowed, may be %NULL
/// </param>
/// <return>
/// an unescaped version of @escaped_string,
/// or %NULL on error. The returned string should be freed when no longer
/// needed.  As a special case if %NULL is given for @escaped_string, this
/// function will return %NULL.
/// </return>

	public static string UnescapeSegment(string escaped_string, string escaped_string_end, string illegal_characters)
	{
		return GUriExterns.g_uri_unescape_segment(escaped_string, escaped_string_end, illegal_characters);
	}

/// <summary>
/// <para>
/// Unescapes a whole escaped string.
/// </para>
/// <para>
/// If any of the characters in @illegal_characters or the NUL
/// character appears as an escaped character in @escaped_string, then
/// that is an error and %NULL will be returned. This is useful if you
/// want to avoid for instance having a slash being expanded in an
/// escaped path element, which might confuse pathname handling.
/// </para>
/// </summary>

/// <param name="escaped_string">
/// an escaped string to be unescaped.
/// </param>
/// <param name="illegal_characters">
/// a string of illegal characters
///   not to be allowed, or %NULL.
/// </param>
/// <return>
/// an unescaped version of @escaped_string.
/// The returned string should be freed when no longer needed.
/// </return>

	public static string UnescapeString(string escaped_string, string illegal_characters)
	{
		return GUriExterns.g_uri_unescape_string(escaped_string, illegal_characters);
	}

}
