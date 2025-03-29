namespace MentorLake.GLib;

public class GRegexHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GRegexHandle New(string pattern, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		var externCallResult = GRegexExterns.g_regex_new(pattern, compile_options, match_options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GRegexExtensions
{
	public static int GetCaptureCount(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_capture_count(regex);
	}

	public static MentorLake.GLib.GRegexCompileFlags GetCompileFlags(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_compile_flags(regex);
	}

	public static bool GetHasCrOrLf(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_has_cr_or_lf(regex);
	}

	public static MentorLake.GLib.GRegexMatchFlags GetMatchFlags(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_match_flags(regex);
	}

	public static int GetMaxBackref(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_max_backref(regex);
	}

	public static int GetMaxLookbehind(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_max_lookbehind(regex);
	}

	public static string GetPattern(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_get_pattern(regex);
	}

	public static int GetStringNumber(this MentorLake.GLib.GRegexHandle regex, string name)
	{
		return GRegexExterns.g_regex_get_string_number(regex, name);
	}

	public static bool Match(this MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GRegexExterns.g_regex_match(regex, @string, match_options, out match_info);
	}

	public static bool MatchAll(this MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GRegexExterns.g_regex_match_all(regex, @string, match_options, out match_info);
	}

	public static bool MatchAllFull(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		var externCallResult = GRegexExterns.g_regex_match_all_full(regex, @string, string_len, start_position, match_options, out match_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool MatchFull(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		var externCallResult = GRegexExterns.g_regex_match_full(regex, @string, string_len, start_position, match_options, out match_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GRegexHandle Ref(this MentorLake.GLib.GRegexHandle regex)
	{
		return GRegexExterns.g_regex_ref(regex);
	}

	public static string Replace(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		var externCallResult = GRegexExterns.g_regex_replace(regex, @string, string_len, start_position, replacement, match_options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ReplaceEval(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, MentorLake.GLib.GRegexEvalCallback eval, IntPtr user_data)
	{
		var externCallResult = GRegexExterns.g_regex_replace_eval(regex, @string, string_len, start_position, match_options, eval, user_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ReplaceLiteral(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		var externCallResult = GRegexExterns.g_regex_replace_literal(regex, @string, string_len, start_position, replacement, match_options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string[] Split(this MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_split(regex, @string, match_options);
	}

	public static string[] SplitFull(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, int max_tokens)
	{
		var externCallResult = GRegexExterns.g_regex_split_full(regex, @string, string_len, start_position, match_options, max_tokens, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void Unref(this MentorLake.GLib.GRegexHandle regex)
	{
		GRegexExterns.g_regex_unref(regex);
	}


	public static GRegex Dereference(this GRegexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRegex>(x.DangerousGetHandle());
}
internal class GRegexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexHandle g_regex_new(string pattern, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_capture_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexCompileFlags g_regex_get_compile_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_get_has_cr_or_lf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexMatchFlags g_regex_get_match_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_max_backref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_max_lookbehind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_get_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_string_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_all_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexHandle g_regex_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_replace_eval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, MentorLake.GLib.GRegexEvalCallback eval, IntPtr user_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_replace_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, int max_tokens, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_regex_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_check_replacement(string replacement, out bool has_references, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_regex_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_nul(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_string(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

}

public struct GRegex
{
	public static bool CheckReplacement(string replacement, out bool has_references)
	{
		var externCallResult = GRegexExterns.g_regex_check_replacement(replacement, out has_references, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GRegexExterns.g_regex_error_quark();
	}

	public static string EscapeNul(string @string, int length)
	{
		return GRegexExterns.g_regex_escape_nul(@string, length);
	}

	public static string EscapeString(string @string, int length)
	{
		return GRegexExterns.g_regex_escape_string(@string, length);
	}

	public static bool MatchSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_match_simple(pattern, @string, compile_options, match_options);
	}

	public static string[] SplitSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_split_simple(pattern, @string, compile_options, match_options);
	}

}
