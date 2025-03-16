namespace MentorLake.GLib;

public class GOptionGroupHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GOptionGroupHandle New(string name, string description, string help_description, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy)
	{
		return GOptionGroupExterns.g_option_group_new(name, description, help_description, user_data, destroy);
	}

}


public static class GOptionGroupExtensions
{
	public static void AddEntries(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionEntry[] entries)
	{
		GOptionGroupExterns.g_option_group_add_entries(group, entries);
	}

	public static void Free(this MentorLake.GLib.GOptionGroupHandle group)
	{
		GOptionGroupExterns.g_option_group_free(group);
	}

	public static MentorLake.GLib.GOptionGroupHandle Ref(this MentorLake.GLib.GOptionGroupHandle group)
	{
		return GOptionGroupExterns.g_option_group_ref(group);
	}

	public static void SetErrorHook(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionErrorFunc error_func)
	{
		GOptionGroupExterns.g_option_group_set_error_hook(group, error_func);
	}

	public static void SetParseHooks(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionParseFunc pre_parse_func, MentorLake.GLib.GOptionParseFunc post_parse_func)
	{
		GOptionGroupExterns.g_option_group_set_parse_hooks(group, pre_parse_func, post_parse_func);
	}

	public static void SetTranslateFunc(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify)
	{
		GOptionGroupExterns.g_option_group_set_translate_func(group, func, data, destroy_notify);
	}

	public static void SetTranslationDomain(this MentorLake.GLib.GOptionGroupHandle group, string domain)
	{
		GOptionGroupExterns.g_option_group_set_translation_domain(group, domain);
	}

	public static void Unref(this MentorLake.GLib.GOptionGroupHandle group)
	{
		GOptionGroupExterns.g_option_group_unref(group);
	}


	public static GOptionGroup Dereference(this GOptionGroupHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOptionGroup>(x.DangerousGetHandle());
}
internal class GOptionGroupExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GOptionGroupHandle g_option_group_new(string name, string description, string help_description, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_add_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionEntry[] entries);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GOptionGroupHandle g_option_group_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_error_hook([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionErrorFunc error_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_parse_hooks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionParseFunc pre_parse_func, MentorLake.GLib.GOptionParseFunc post_parse_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_translate_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, string domain);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

}

public struct GOptionGroup
{
}
