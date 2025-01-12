namespace MentorLake.Gtk3.GLib;

public class GUriHandle : BaseSafeHandle
{
}


public static class GUriHandleExtensions
{
	public static string GetAuthParams(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_auth_params(uri);
	}

	public static GUriFlags GetFlags(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_flags(uri);
	}

	public static string GetFragment(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_fragment(uri);
	}

	public static string GetHost(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_host(uri);
	}

	public static string GetPassword(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_password(uri);
	}

	public static string GetPath(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_path(uri);
	}

	public static int GetPort(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_port(uri);
	}

	public static string GetQuery(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_query(uri);
	}

	public static string GetScheme(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_scheme(uri);
	}

	public static string GetUser(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_user(uri);
	}

	public static string GetUserinfo(this GUriHandle uri)
	{
		return GUriExterns.g_uri_get_userinfo(uri);
	}

	public static GUriHandle ParseRelative(this GUriHandle base_uri, string uri_ref, GUriFlags flags, out GErrorHandle error)
	{
		return GUriExterns.g_uri_parse_relative(base_uri, uri_ref, flags, out error);
	}

	public static GUriHandle Ref(this GUriHandle uri)
	{
		return GUriExterns.g_uri_ref(uri);
	}

	public static string ToString(this GUriHandle uri)
	{
		return GUriExterns.g_uri_to_string(uri);
	}

	public static string ToStringPartial(this GUriHandle uri, GUriHideFlags flags)
	{
		return GUriExterns.g_uri_to_string_partial(uri, flags);
	}

	public static T Unref<T>(this T uri) where T : GUriHandle
	{
		GUriExterns.g_uri_unref(uri);
		return uri;
	}

	public static GUriHandle Build(GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_build(flags, scheme, userinfo, host, port, path, query, fragment);
	}

	public static GUriHandle BuildWithUser(GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_build_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

	public static GQuark ErrorQuark()
	{
		return GUriExterns.g_uri_error_quark();
	}

	public static string EscapeBytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed)
	{
		return GUriExterns.g_uri_escape_bytes(unescaped, length, reserved_chars_allowed);
	}

	public static string EscapeString(string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		return GUriExterns.g_uri_escape_string(unescaped, reserved_chars_allowed, allow_utf8);
	}

	public static bool IsValid(string uri_string, GUriFlags flags, out GErrorHandle error)
	{
		return GUriExterns.g_uri_is_valid(uri_string, flags, out error);
	}

	public static string Join(GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_join(flags, scheme, userinfo, host, port, path, query, fragment);
	}

	public static string JoinWithUser(GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_join_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

	public static IntPtr ListExtractUris(string uri_list)
	{
		return GUriExterns.g_uri_list_extract_uris(uri_list);
	}

	public static GUriHandle Parse(string uri_string, GUriFlags flags, out GErrorHandle error)
	{
		return GUriExterns.g_uri_parse(uri_string, flags, out error);
	}

	public static GHashTableHandle ParseParams(string @params, UIntPtr length, string separators, GUriParamsFlags flags, out GErrorHandle error)
	{
		return GUriExterns.g_uri_parse_params(@params, length, separators, flags, out error);
	}

	public static string ParseScheme(string uri)
	{
		return GUriExterns.g_uri_parse_scheme(uri);
	}

	public static string PeekScheme(string uri)
	{
		return GUriExterns.g_uri_peek_scheme(uri);
	}

	public static string ResolveRelative(string base_uri_string, string uri_ref, GUriFlags flags, out GErrorHandle error)
	{
		return GUriExterns.g_uri_resolve_relative(base_uri_string, uri_ref, flags, out error);
	}

	public static bool Split(string uri_ref, GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment, out GErrorHandle error)
	{
		return GUriExterns.g_uri_split(uri_ref, flags, out scheme, out userinfo, out host, out port, out path, out query, out fragment, out error);
	}

	public static bool SplitNetwork(string uri_string, GUriFlags flags, out string scheme, out string host, out int port, out GErrorHandle error)
	{
		return GUriExterns.g_uri_split_network(uri_string, flags, out scheme, out host, out port, out error);
	}

	public static bool SplitWithUser(string uri_ref, GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment, out GErrorHandle error)
	{
		return GUriExterns.g_uri_split_with_user(uri_ref, flags, out scheme, out user, out password, out auth_params, out host, out port, out path, out query, out fragment, out error);
	}

	public static GBytesHandle UnescapeBytes(string escaped_string, UIntPtr length, string illegal_characters, out GErrorHandle error)
	{
		return GUriExterns.g_uri_unescape_bytes(escaped_string, length, illegal_characters, out error);
	}

	public static string UnescapeSegment(string escaped_string, string escaped_string_end, string illegal_characters)
	{
		return GUriExterns.g_uri_unescape_segment(escaped_string, escaped_string_end, illegal_characters);
	}

	public static string UnescapeString(string escaped_string, string illegal_characters)
	{
		return GUriExterns.g_uri_unescape_string(escaped_string, illegal_characters);
	}

}
internal class GUriExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_auth_params(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern GUriFlags g_uri_get_flags(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_fragment(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_host(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_password(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_path(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern int g_uri_get_port(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_query(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_scheme(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_user(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_get_userinfo(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern GUriHandle g_uri_parse_relative(GUriHandle base_uri, string uri_ref, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GUriHandle g_uri_ref(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_to_string(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_to_string_partial(GUriHandle uri, GUriHideFlags flags);

	[DllImport(Libraries.GLib)]
	internal static extern void g_uri_unref(GUriHandle uri);

	[DllImport(Libraries.GLib)]
	internal static extern GUriHandle g_uri_build(GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib)]
	internal static extern GUriHandle g_uri_build_with_user(GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_uri_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_escape_bytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_uri_is_valid(string uri_string, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_join(GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_join_with_user(GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_uri_list_extract_uris(string uri_list);

	[DllImport(Libraries.GLib)]
	internal static extern GUriHandle g_uri_parse(string uri_string, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GHashTableHandle g_uri_parse_params(string @params, UIntPtr length, string separators, GUriParamsFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_parse_scheme(string uri);

	[DllImport(Libraries.GLib)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_peek_scheme(string uri);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_resolve_relative(string base_uri_string, string uri_ref, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_uri_split(string uri_ref, GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_uri_split_network(string uri_string, GUriFlags flags, out string scheme, out string host, out int port, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_uri_split_with_user(string uri_ref, GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_uri_unescape_bytes(string escaped_string, UIntPtr length, string illegal_characters, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);

	[DllImport(Libraries.GLib)]
	internal static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);

}

public struct GUri
{
}
