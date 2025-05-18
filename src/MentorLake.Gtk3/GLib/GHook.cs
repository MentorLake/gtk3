namespace MentorLake.GLib;

public class GHookHandle : BaseSafeHandle
{
}


public static class GHookExtensions
{
	public static int CompareIds(this MentorLake.GLib.GHookHandle new_hook, MentorLake.GLib.GHookHandle sibling)
	{
		if (new_hook.IsInvalid) throw new Exception("Invalid handle (GHook)");
		return GHookExterns.g_hook_compare_ids(new_hook, sibling);
	}


	public static GHook Dereference(this GHookHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GHook>(x.DangerousGetHandle());
}
internal class GHookExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_hook_compare_ids([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle new_hook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle sibling);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_alloc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hook_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, ulong hook_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_destroy_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool need_valids, MentorLake.GLib.GHookFindFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_find_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_find_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_find_func_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_first_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool may_be_in_call);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, ulong hook_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_next_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, bool may_be_in_call);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))]
	internal static extern MentorLake.GLib.GHookHandle g_hook_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

}

public struct GHook
{
	public IntPtr data;
	public IntPtr next;
	public IntPtr prev;
	public uint ref_count;
	public ulong hook_id;
	public uint flags;
	public IntPtr func;
	public GDestroyNotify destroy;
	public static MentorLake.GLib.GHookHandle Alloc(MentorLake.GLib.GHookListHandle hook_list)
	{
		return GHookExterns.g_hook_alloc(hook_list);
	}

	public static bool Destroy(MentorLake.GLib.GHookListHandle hook_list, ulong hook_id)
	{
		return GHookExterns.g_hook_destroy(hook_list, hook_id);
	}

	public static void DestroyLink(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_destroy_link(hook_list, hook);
	}

	public static MentorLake.GLib.GHookHandle Find(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, MentorLake.GLib.GHookFindFunc func, IntPtr data)
	{
		return GHookExterns.g_hook_find(hook_list, need_valids, func, data);
	}

	public static MentorLake.GLib.GHookHandle FindData(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr data)
	{
		return GHookExterns.g_hook_find_data(hook_list, need_valids, data);
	}

	public static MentorLake.GLib.GHookHandle FindFunc(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr func)
	{
		return GHookExterns.g_hook_find_func(hook_list, need_valids, func);
	}

	public static MentorLake.GLib.GHookHandle FindFuncData(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr func, IntPtr data)
	{
		return GHookExterns.g_hook_find_func_data(hook_list, need_valids, func, data);
	}

	public static MentorLake.GLib.GHookHandle FirstValid(MentorLake.GLib.GHookListHandle hook_list, bool may_be_in_call)
	{
		return GHookExterns.g_hook_first_valid(hook_list, may_be_in_call);
	}

	public static void Free(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_free(hook_list, hook);
	}

	public static MentorLake.GLib.GHookHandle Get(MentorLake.GLib.GHookListHandle hook_list, ulong hook_id)
	{
		return GHookExterns.g_hook_get(hook_list, hook_id);
	}

	public static void InsertBefore(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle sibling, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_insert_before(hook_list, sibling, hook);
	}

	public static void InsertSorted(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func)
	{
		GHookExterns.g_hook_insert_sorted(hook_list, hook, func);
	}

	public static MentorLake.GLib.GHookHandle NextValid(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook, bool may_be_in_call)
	{
		return GHookExterns.g_hook_next_valid(hook_list, hook, may_be_in_call);
	}

	public static void Prepend(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_prepend(hook_list, hook);
	}

	public static MentorLake.GLib.GHookHandle Ref(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		return GHookExterns.g_hook_ref(hook_list, hook);
	}

	public static void Unref(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_unref(hook_list, hook);
	}

}
