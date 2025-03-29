namespace MentorLake.GLib;

public class GUriHandle : BaseSafeHandle
{
}


public static class GUriExtensions
{
	public static string GetAuthParams(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_auth_params(uri);
	}

	public static MentorLake.GLib.GUriFlags GetFlags(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_flags(uri);
	}

	public static string GetFragment(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_fragment(uri);
	}

	public static string GetHost(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_host(uri);
	}

	public static string GetPassword(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_password(uri);
	}

	public static string GetPath(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_path(uri);
	}

	public static int GetPort(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_port(uri);
	}

	public static string GetQuery(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_query(uri);
	}

	public static string GetScheme(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_scheme(uri);
	}

	public static string GetUser(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_user(uri);
	}

	public static string GetUserinfo(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_get_userinfo(uri);
	}

	public static MentorLake.GLib.GUriHandle ParseRelative(this MentorLake.GLib.GUriHandle base_uri, string uri_ref, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_parse_relative(base_uri, uri_ref, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GUriHandle Ref(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_ref(uri);
	}

	public static string ToString(this MentorLake.GLib.GUriHandle uri)
	{
		return GUriExterns.g_uri_to_string(uri);
	}

	public static string ToStringPartial(this MentorLake.GLib.GUriHandle uri, MentorLake.GLib.GUriHideFlags flags)
	{
		return GUriExterns.g_uri_to_string_partial(uri, flags);
	}

	public static void Unref(this MentorLake.GLib.GUriHandle uri)
	{
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
	internal static extern MentorLake.GLib.GUriHandle g_uri_parse_relative([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle base_uri, string uri_ref, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
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
	internal static extern MentorLake.GLib.GUriHandle g_uri_build(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
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
	internal static extern MentorLake.GLib.GUriHandle g_uri_parse(string uri_string, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
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
	internal static extern MentorLake.GLib.GBytesHandle g_uri_unescape_bytes(string escaped_string, UIntPtr length, string illegal_characters, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);

}

public struct GUri
{
	public static MentorLake.GLib.GUriHandle Build(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_build(flags, scheme, userinfo, host, port, path, query, fragment);
	}

	public static MentorLake.GLib.GUriHandle BuildWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_build_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

	public static MentorLake.GLib.GQuark ErrorQuark()
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

	public static bool IsValid(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_is_valid(uri_string, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string Join(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_join(flags, scheme, userinfo, host, port, path, query, fragment);
	}

	public static string JoinWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GUriExterns.g_uri_join_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

	public static string[] ListExtractUris(string uri_list)
	{
		return GUriExterns.g_uri_list_extract_uris(uri_list);
	}

	public static MentorLake.GLib.GUriHandle Parse(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_parse(uri_string, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GHashTableHandle ParseParams(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_parse_params(@params, length, separators, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ParseScheme(string uri)
	{
		return GUriExterns.g_uri_parse_scheme(uri);
	}

	public static string PeekScheme(string uri)
	{
		return GUriExterns.g_uri_peek_scheme(uri);
	}

	public static string ResolveRelative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GUriExterns.g_uri_resolve_relative(base_uri_string, uri_ref, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool Split(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment)
	{
		var externCallResult = GUriExterns.g_uri_split(uri_ref, flags, out scheme, out userinfo, out host, out port, out path, out query, out fragment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SplitNetwork(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port)
	{
		var externCallResult = GUriExterns.g_uri_split_network(uri_string, flags, out scheme, out host, out port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SplitWithUser(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment)
	{
		var externCallResult = GUriExterns.g_uri_split_with_user(uri_ref, flags, out scheme, out user, out password, out auth_params, out host, out port, out path, out query, out fragment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GBytesHandle UnescapeBytes(string escaped_string, UIntPtr length, string illegal_characters)
	{
		var externCallResult = GUriExterns.g_uri_unescape_bytes(escaped_string, length, illegal_characters, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
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
