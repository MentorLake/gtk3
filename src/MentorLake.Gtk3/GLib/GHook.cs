namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GHook struct represents a single hook function in a #GHookList.
/// </para>
/// </summary>

public class GHookHandle : BaseSafeHandle
{
}


public static class GHookExtensions
{
/// <summary>
/// <para>
/// Compares the ids of two #GHook elements, returning a negative value
/// if the second id is greater than the first.
/// </para>
/// </summary>

/// <param name="new_hook">
/// a #GHook
/// </param>
/// <param name="sibling">
/// a #GHook to compare with @new_hook
/// </param>
/// <return>
/// a value <= 0 if the id of @sibling is >= the id of @new_hook
/// </return>

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

/// <summary>
/// <para>
/// The #GHook struct represents a single hook function in a #GHookList.
/// </para>
/// </summary>

public struct GHook
{
	/// <summary>
/// <para>
/// data which is passed to func when this hook is invoked
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// pointer to the next hook in the list
/// </para>
/// </summary>

public IntPtr next;
	/// <summary>
/// <para>
/// pointer to the previous hook in the list
/// </para>
/// </summary>

public IntPtr prev;
	/// <summary>
/// <para>
/// the reference count of this hook
/// </para>
/// </summary>

public uint ref_count;
	/// <summary>
/// <para>
/// the id of this hook, which is unique within its list
/// </para>
/// </summary>

public ulong hook_id;
	/// <summary>
/// <para>
/// flags which are set for this hook. See #GHookFlagMask for
///     predefined flags
/// </para>
/// </summary>

public uint flags;
	/// <summary>
/// <para>
/// the function to call when this hook is invoked. The possible
///     signatures for this function are #GHookFunc and #GHookCheckFunc
/// </para>
/// </summary>

public IntPtr func;
	/// <summary>
/// <para>
/// the default @finalize_hook function of a #GHookList calls
///     this member of the hook that is being finalized
/// </para>
/// </summary>

public GDestroyNotify destroy;
/// <summary>
/// <para>
/// Allocates space for a #GHook and initializes it.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <return>
/// a new #GHook
/// </return>

	public static MentorLake.GLib.GHookHandle Alloc(MentorLake.GLib.GHookListHandle hook_list)
	{
		return GHookExterns.g_hook_alloc(hook_list);
	}

/// <summary>
/// <para>
/// Destroys a #GHook, given its ID.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook_id">
/// a hook ID
/// </param>
/// <return>
/// %TRUE if the #GHook was found in the #GHookList and destroyed
/// </return>

	public static bool Destroy(MentorLake.GLib.GHookListHandle hook_list, ulong hook_id)
	{
		return GHookExterns.g_hook_destroy(hook_list, hook_id);
	}

/// <summary>
/// <para>
/// Removes one #GHook from a #GHookList, marking it
/// inactive and calling g_hook_unref() on it.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to remove
/// </param>

	public static void DestroyLink(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_destroy_link(hook_list, hook);
	}

/// <summary>
/// <para>
/// Finds a #GHook in a #GHookList using the given function to
/// test for a match.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="need_valids">
/// %TRUE if #GHook elements which have been destroyed
///     should be skipped
/// </param>
/// <param name="func">
/// the function to call for each #GHook, which should return
///     %TRUE when the #GHook has been found
/// </param>
/// <param name="data">
/// the data to pass to @func
/// </param>
/// <return>
/// the found #GHook or %NULL if no matching #GHook is found
/// </return>

	public static MentorLake.GLib.GHookHandle Find(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, MentorLake.GLib.GHookFindFunc func, IntPtr data)
	{
		return GHookExterns.g_hook_find(hook_list, need_valids, func, data);
	}

/// <summary>
/// <para>
/// Finds a #GHook in a #GHookList with the given data.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="need_valids">
/// %TRUE if #GHook elements which have been destroyed
///     should be skipped
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the #GHook with the given @data or %NULL if no matching
///     #GHook is found
/// </return>

	public static MentorLake.GLib.GHookHandle FindData(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr data)
	{
		return GHookExterns.g_hook_find_data(hook_list, need_valids, data);
	}

/// <summary>
/// <para>
/// Finds a #GHook in a #GHookList with the given function.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="need_valids">
/// %TRUE if #GHook elements which have been destroyed
///     should be skipped
/// </param>
/// <param name="func">
/// the function to find
/// </param>
/// <return>
/// the #GHook with the given @func or %NULL if no matching
///     #GHook is found
/// </return>

	public static MentorLake.GLib.GHookHandle FindFunc(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr func)
	{
		return GHookExterns.g_hook_find_func(hook_list, need_valids, func);
	}

/// <summary>
/// <para>
/// Finds a #GHook in a #GHookList with the given function and data.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="need_valids">
/// %TRUE if #GHook elements which have been destroyed
///     should be skipped
/// </param>
/// <param name="func">
/// the function to find
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the #GHook with the given @func and @data or %NULL if
///     no matching #GHook is found
/// </return>

	public static MentorLake.GLib.GHookHandle FindFuncData(MentorLake.GLib.GHookListHandle hook_list, bool need_valids, IntPtr func, IntPtr data)
	{
		return GHookExterns.g_hook_find_func_data(hook_list, need_valids, func, data);
	}

/// <summary>
/// <para>
/// Returns the first #GHook in a #GHookList which has not been destroyed.
/// The reference count for the #GHook is incremented, so you must call
/// g_hook_unref() to restore it when no longer needed. (Or call
/// g_hook_next_valid() if you are stepping through the #GHookList.)
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="may_be_in_call">
/// %TRUE if hooks which are currently running
///     (e.g. in another thread) are considered valid. If set to %FALSE,
///     these are skipped
/// </param>
/// <return>
/// the first valid #GHook, or %NULL if none are valid
/// </return>

	public static MentorLake.GLib.GHookHandle FirstValid(MentorLake.GLib.GHookListHandle hook_list, bool may_be_in_call)
	{
		return GHookExterns.g_hook_first_valid(hook_list, may_be_in_call);
	}

/// <summary>
/// <para>
/// Calls the #GHookList @finalize_hook function if it exists,
/// and frees the memory allocated for the #GHook.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to free
/// </param>

	public static void Free(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_free(hook_list, hook);
	}

/// <summary>
/// <para>
/// Returns the #GHook with the given id, or %NULL if it is not found.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook_id">
/// a hook id
/// </param>
/// <return>
/// the #GHook with the given id, or %NULL if it is not found
/// </return>

	public static MentorLake.GLib.GHookHandle Get(MentorLake.GLib.GHookListHandle hook_list, ulong hook_id)
	{
		return GHookExterns.g_hook_get(hook_list, hook_id);
	}

/// <summary>
/// <para>
/// Inserts a #GHook into a #GHookList, before a given #GHook.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="sibling">
/// the #GHook to insert the new #GHook before
/// </param>
/// <param name="hook">
/// the #GHook to insert
/// </param>

	public static void InsertBefore(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle sibling, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_insert_before(hook_list, sibling, hook);
	}

/// <summary>
/// <para>
/// Inserts a #GHook into a #GHookList, sorted by the given function.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to insert
/// </param>
/// <param name="func">
/// the comparison function used to sort the #GHook elements
/// </param>

	public static void InsertSorted(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func)
	{
		GHookExterns.g_hook_insert_sorted(hook_list, hook, func);
	}

/// <summary>
/// <para>
/// Returns the next #GHook in a #GHookList which has not been destroyed.
/// The reference count for the #GHook is incremented, so you must call
/// g_hook_unref() to restore it when no longer needed. (Or continue to call
/// g_hook_next_valid() until %NULL is returned.)
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the current #GHook
/// </param>
/// <param name="may_be_in_call">
/// %TRUE if hooks which are currently running
///     (e.g. in another thread) are considered valid. If set to %FALSE,
///     these are skipped
/// </param>
/// <return>
/// the next valid #GHook, or %NULL if none are valid
/// </return>

	public static MentorLake.GLib.GHookHandle NextValid(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook, bool may_be_in_call)
	{
		return GHookExterns.g_hook_next_valid(hook_list, hook, may_be_in_call);
	}

/// <summary>
/// <para>
/// Prepends a #GHook on the start of a #GHookList.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to add to the start of @hook_list
/// </param>

	public static void Prepend(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_prepend(hook_list, hook);
	}

/// <summary>
/// <para>
/// Increments the reference count for a #GHook.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to increment the reference count of
/// </param>
/// <return>
/// the @hook that was passed in (since 2.6)
/// </return>

	public static MentorLake.GLib.GHookHandle Ref(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		return GHookExterns.g_hook_ref(hook_list, hook);
	}

/// <summary>
/// <para>
/// Decrements the reference count of a #GHook.
/// If the reference count falls to 0, the #GHook is removed
/// from the #GHookList and g_hook_free() is called to free it.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to unref
/// </param>

	public static void Unref(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GHookExterns.g_hook_unref(hook_list, hook);
	}

}
