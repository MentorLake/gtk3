namespace MentorLake.Gtk3.GLib;

public class GHookListHandle : BaseSafeHandle
{
}


public static class GHookListHandleExtensions
{
	public static T Clear<T>(this T hook_list) where T : GHookListHandle
	{
		GHookListExterns.g_hook_list_clear(hook_list);
		return hook_list;
	}

	public static T Init<T>(this T hook_list, uint hook_size) where T : GHookListHandle
	{
		GHookListExterns.g_hook_list_init(hook_list, hook_size);
		return hook_list;
	}

	public static T Invoke<T>(this T hook_list, bool may_recurse) where T : GHookListHandle
	{
		GHookListExterns.g_hook_list_invoke(hook_list, may_recurse);
		return hook_list;
	}

	public static T InvokeCheck<T>(this T hook_list, bool may_recurse) where T : GHookListHandle
	{
		GHookListExterns.g_hook_list_invoke_check(hook_list, may_recurse);
		return hook_list;
	}

	public static T Marshal<T>(this T hook_list, bool may_recurse, GHookMarshaller marshaller, IntPtr marshal_data) where T : GHookListHandle
	{
		GHookListExterns.g_hook_list_marshal(hook_list, may_recurse, marshaller, marshal_data);
		return hook_list;
	}

	public static T MarshalCheck<T>(this T hook_list, bool may_recurse, GHookCheckMarshaller marshaller, IntPtr marshal_data) where T : GHookListHandle
	{
		GHookListExterns.g_hook_list_marshal_check(hook_list, may_recurse, marshaller, marshal_data);
		return hook_list;
	}

}
internal class GHookListExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_list_clear(GHookListHandle hook_list);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_list_init(GHookListHandle hook_list, uint hook_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_list_invoke(GHookListHandle hook_list, bool may_recurse);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_list_invoke_check(GHookListHandle hook_list, bool may_recurse);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_list_marshal(GHookListHandle hook_list, bool may_recurse, GHookMarshaller marshaller, IntPtr marshal_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_list_marshal_check(GHookListHandle hook_list, bool may_recurse, GHookCheckMarshaller marshaller, IntPtr marshal_data);

}

public struct GHookList
{
	public ulong seq_id;
	public uint hook_size;
	public uint is_setup;
	public GHookHandle hooks;
	public IntPtr dummy3;
	public GHookFinalizeFunc finalize_hook;
	public None dummy;
}
