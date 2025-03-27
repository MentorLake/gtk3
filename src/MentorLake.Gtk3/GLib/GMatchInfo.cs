namespace MentorLake.GLib;

public class GMatchInfoHandle : BaseSafeHandle
{
}


public static class GMatchInfoExtensions
{
	public static string ExpandReferences(this MentorLake.GLib.GMatchInfoHandle match_info, string string_to_expand)
	{
		return GMatchInfoExterns.g_match_info_expand_references(match_info, string_to_expand);
	}

	public static string Fetch(this MentorLake.GLib.GMatchInfoHandle match_info, int match_num)
	{
		return GMatchInfoExterns.g_match_info_fetch(match_info, match_num);
	}

	public static string[] FetchAll(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_fetch_all(match_info);
	}

	public static string FetchNamed(this MentorLake.GLib.GMatchInfoHandle match_info, string name)
	{
		return GMatchInfoExterns.g_match_info_fetch_named(match_info, name);
	}

	public static bool FetchNamedPos(this MentorLake.GLib.GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos)
	{
		return GMatchInfoExterns.g_match_info_fetch_named_pos(match_info, name, out start_pos, out end_pos);
	}

	public static bool FetchPos(this MentorLake.GLib.GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos)
	{
		return GMatchInfoExterns.g_match_info_fetch_pos(match_info, match_num, out start_pos, out end_pos);
	}

	public static void Free(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		GMatchInfoExterns.g_match_info_free(match_info);
	}

	public static int GetMatchCount(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_get_match_count(match_info);
	}

	public static MentorLake.GLib.GRegexHandle GetRegex(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_get_regex(match_info);
	}

	public static string GetString(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_get_string(match_info);
	}

	public static bool IsPartialMatch(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_is_partial_match(match_info);
	}

	public static bool Matches(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_matches(match_info);
	}

	public static bool Next(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_next(match_info);
	}

	public static MentorLake.GLib.GMatchInfoHandle Ref(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		return GMatchInfoExterns.g_match_info_ref(match_info);
	}

	public static void Unref(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		GMatchInfoExterns.g_match_info_unref(match_info);
	}


	public static GMatchInfo Dereference(this GMatchInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMatchInfo>(x.DangerousGetHandle());
}
internal class GMatchInfoExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_expand_references([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, string string_to_expand);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_fetch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, int match_num);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_match_info_fetch_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_fetch_named([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_fetch_named_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_fetch_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_match_info_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_match_info_get_match_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexHandle g_match_info_get_regex([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_is_partial_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMatchInfoHandle g_match_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_match_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

}

public struct GMatchInfo
{
}
