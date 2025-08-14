namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GCompletion` provides support for automatic completion of a string
/// using any group of target strings. It is typically used for file
/// name completion as is common in many UNIX shells.
/// </para>
/// <para>
/// A `GCompletion` is created using [func@GLib.Completion.new]. Target items are
/// added and removed with [method@GLib.Completion.add_items],
/// [method@GLib.Completion.remove_items] and
/// [method@GLib.Completion.clear_items]. A completion attempt is requested with
/// [method@GLib.Completion.complete] or [method@GLib.Completion.complete_utf8].
/// When no longer needed, the `GCompletion` is freed with
/// [method@GLib.Completion.free].
/// </para>
/// <para>
/// Items in the completion can be simple strings (e.g. filenames), or
/// pointers to arbitrary data structures. If data structures are used
/// you must provide a [type@GLib.CompletionFunc] in [func@GLib.Completion.new],
/// which retrieves the item’s string from the data structure. You can change
/// the way in which strings are compared by setting a different
/// [type@GLib.CompletionStrncmpFunc] in [method@GLib.Completion.set_compare].
/// </para>
/// <para>
/// `GCompletion` has been marked as deprecated, since this API is rarely
/// used and not very actively maintained.
/// </para>
/// </summary>

public class GCompletionHandle : BaseSafeHandle
{
}


public static class GCompletionExtensions
{
/// <summary>
/// <para>
/// Adds items to the #GCompletion.
/// </para>
/// </summary>

/// <param name="cmp">
/// the #GCompletion.
/// </param>
/// <param name="items">
/// the list of items to add.
/// </param>

	public static void AddItems(this MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GListHandle items)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		GCompletionExterns.g_completion_add_items(cmp, items);
	}

/// <summary>
/// <para>
/// Removes all items from the #GCompletion. The items are not freed, so if the
/// memory was dynamically allocated, it should be freed after calling this
/// function.
/// </para>
/// </summary>

/// <param name="cmp">
/// the #GCompletion.
/// </param>

	public static void ClearItems(this MentorLake.GLib.GCompletionHandle cmp)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		GCompletionExterns.g_completion_clear_items(cmp);
	}

/// <summary>
/// <para>
/// Attempts to complete the string @prefix using the #GCompletion
/// target items.
/// </para>
/// </summary>

/// <param name="cmp">
/// the #GCompletion.
/// </param>
/// <param name="prefix">
/// the prefix string, typically typed by the user, which is
///          compared with each of the items.
/// </param>
/// <param name="new_prefix">
/// if non-%NULL, returns the longest prefix which is
///              common to all items that matched @prefix, or %NULL if
///              no items matched @prefix.  This string should be freed
///              when no longer needed.
/// </param>
/// <return>
/// the list of items whose strings begin with
///          @prefix. This should not be changed.
/// </return>

	public static MentorLake.GLib.GListHandle Complete(this MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		return GCompletionExterns.g_completion_complete(cmp, prefix, new_prefix);
	}

/// <summary>
/// <para>
/// Attempts to complete the string @prefix using the #GCompletion target items.
/// In contrast to g_completion_complete(), this function returns the largest common
/// prefix that is a valid UTF-8 string, omitting a possible common partial
/// character.
/// </para>
/// <para>
/// You should use this function instead of g_completion_complete() if your
/// items are UTF-8 strings.
/// </para>
/// </summary>

/// <param name="cmp">
/// the #GCompletion
/// </param>
/// <param name="prefix">
/// the prefix string, typically used by the user, which is compared
///    with each of the items
/// </param>
/// <param name="new_prefix">
/// if non-%NULL, returns the longest prefix which is common to all
///    items that matched @prefix, or %NULL if no items matched @prefix.
///    This string should be freed when no longer needed.
/// </param>
/// <return>
/// the list of items whose strings begin with @prefix. This should
/// not be changed.
/// </return>

	public static MentorLake.GLib.GListHandle CompleteUtf8(this MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		return GCompletionExterns.g_completion_complete_utf8(cmp, prefix, new_prefix);
	}

/// <summary>
/// <para>
/// Frees all memory used by the #GCompletion. The items are not freed, so if
/// the memory was dynamically allocated, it should be freed after calling this
/// function.
/// </para>
/// </summary>

/// <param name="cmp">
/// the #GCompletion.
/// </param>

	public static void Free(this MentorLake.GLib.GCompletionHandle cmp)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		GCompletionExterns.g_completion_free(cmp);
	}

/// <summary>
/// <para>
/// Removes items from a #GCompletion. The items are not freed, so if the memory
/// was dynamically allocated, free @items with g_list_free_full() after calling
/// this function.
/// </para>
/// </summary>

/// <param name="cmp">
/// the #GCompletion.
/// </param>
/// <param name="items">
/// the items to remove.
/// </param>

	public static void RemoveItems(this MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GListHandle items)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		GCompletionExterns.g_completion_remove_items(cmp, items);
	}

/// <summary>
/// <para>
/// Sets the function to use for string comparisons. The default string
/// comparison function is strncmp().
/// </para>
/// </summary>

/// <param name="cmp">
/// a #GCompletion.
/// </param>
/// <param name="strncmp_func">
/// the string comparison function.
/// </param>

	public static void SetCompare(this MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GCompletionStrncmpFunc strncmp_func)
	{
		if (cmp.IsInvalid) throw new Exception("Invalid handle (GCompletion)");
		GCompletionExterns.g_completion_set_compare(cmp, strncmp_func);
	}


	public static GCompletion Dereference(this GCompletionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCompletion>(x.DangerousGetHandle());
}
internal class GCompletionExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_add_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle items);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_clear_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_completion_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_completion_complete_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_remove_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle items);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_set_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GCompletionStrncmpFunc strncmp_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))]
	internal static extern MentorLake.GLib.GCompletionHandle g_completion_new(MentorLake.GLib.GCompletionFunc func);

}

/// <summary>
/// <para>
/// `GCompletion` provides support for automatic completion of a string
/// using any group of target strings. It is typically used for file
/// name completion as is common in many UNIX shells.
/// </para>
/// <para>
/// A `GCompletion` is created using [func@GLib.Completion.new]. Target items are
/// added and removed with [method@GLib.Completion.add_items],
/// [method@GLib.Completion.remove_items] and
/// [method@GLib.Completion.clear_items]. A completion attempt is requested with
/// [method@GLib.Completion.complete] or [method@GLib.Completion.complete_utf8].
/// When no longer needed, the `GCompletion` is freed with
/// [method@GLib.Completion.free].
/// </para>
/// <para>
/// Items in the completion can be simple strings (e.g. filenames), or
/// pointers to arbitrary data structures. If data structures are used
/// you must provide a [type@GLib.CompletionFunc] in [func@GLib.Completion.new],
/// which retrieves the item’s string from the data structure. You can change
/// the way in which strings are compared by setting a different
/// [type@GLib.CompletionStrncmpFunc] in [method@GLib.Completion.set_compare].
/// </para>
/// <para>
/// `GCompletion` has been marked as deprecated, since this API is rarely
/// used and not very actively maintained.
/// </para>
/// </summary>

public struct GCompletion
{
	/// <summary>
/// <para>
/// list of target items (strings or data structures).
/// </para>
/// </summary>

public IntPtr items;
	/// <summary>
/// <para>
/// function which is called to get the string associated with a
///        target item. It is %NULL if the target items are strings.
/// </para>
/// </summary>

public GCompletionFunc func;
	/// <summary>
/// <para>
/// the last prefix passed to g_completion_complete() or
///          g_completion_complete_utf8().
/// </para>
/// </summary>

public string prefix;
	/// <summary>
/// <para>
/// the list of items which begin with @prefix.
/// </para>
/// </summary>

public IntPtr cache;
	/// <summary>
/// <para>
/// The function to use when comparing strings.  Use
///                g_completion_set_compare() to modify this function.
/// </para>
/// </summary>

public GCompletionStrncmpFunc strncmp_func;
/// <summary>
/// <para>
/// Creates a new #GCompletion.
/// </para>
/// </summary>

/// <param name="func">
/// the function to be called to return the string representing
///        an item in the #GCompletion, or %NULL if strings are going to
///        be used as the #GCompletion items.
/// </param>
/// <return>
/// the new #GCompletion.
/// </return>

	public static MentorLake.GLib.GCompletionHandle New(MentorLake.GLib.GCompletionFunc func)
	{
		return GCompletionExterns.g_completion_new(func);
	}

}
