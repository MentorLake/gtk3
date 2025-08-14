namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GHookList struct represents a list of hook functions.
/// </para>
/// </summary>

public class GHookListHandle : BaseSafeHandle
{
}


public static class GHookListExtensions
{
/// <summary>
/// <para>
/// Removes all the #GHook elements from a #GHookList.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>

	public static void Clear(this MentorLake.GLib.GHookListHandle hook_list)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_clear(hook_list);
	}

/// <summary>
/// <para>
/// Initializes a #GHookList.
/// This must be called before the #GHookList is used.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook_size">
/// the size of each element in the #GHookList,
///     typically `sizeof (GHook)`.
/// </param>

	public static void Init(this MentorLake.GLib.GHookListHandle hook_list, uint hook_size)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_init(hook_list, hook_size);
	}

/// <summary>
/// <para>
/// Calls all of the #GHook functions in a #GHookList.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="may_recurse">
/// %TRUE if functions which are already running
///     (e.g. in another thread) can be called. If set to %FALSE,
///     these are skipped
/// </param>

	public static void Invoke(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_invoke(hook_list, may_recurse);
	}

/// <summary>
/// <para>
/// Calls all of the #GHook functions in a #GHookList.
/// Any function which returns %FALSE is removed from the #GHookList.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="may_recurse">
/// %TRUE if functions which are already running
///     (e.g. in another thread) can be called. If set to %FALSE,
///     these are skipped
/// </param>

	public static void InvokeCheck(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_invoke_check(hook_list, may_recurse);
	}

/// <summary>
/// <para>
/// Calls a function on each valid #GHook.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="may_recurse">
/// %TRUE if hooks which are currently running
///     (e.g. in another thread) are considered valid. If set to %FALSE,
///     these are skipped
/// </param>
/// <param name="marshaller">
/// the function to call for each #GHook
/// </param>
/// <param name="marshal_data">
/// data to pass to @marshaller
/// </param>

	public static void Marshal(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse, MentorLake.GLib.GHookMarshaller marshaller, IntPtr marshal_data)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_marshal(hook_list, may_recurse, marshaller, marshal_data);
	}

/// <summary>
/// <para>
/// Calls a function on each valid #GHook and destroys it if the
/// function returns %FALSE.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="may_recurse">
/// %TRUE if hooks which are currently running
///     (e.g. in another thread) are considered valid. If set to %FALSE,
///     these are skipped
/// </param>
/// <param name="marshaller">
/// the function to call for each #GHook
/// </param>
/// <param name="marshal_data">
/// data to pass to @marshaller
/// </param>

	public static void MarshalCheck(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse, MentorLake.GLib.GHookCheckMarshaller marshaller, IntPtr marshal_data)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_marshal_check(hook_list, may_recurse, marshaller, marshal_data);
	}


	public static GHookList Dereference(this GHookListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GHookList>(x.DangerousGetHandle());
}
internal class GHookListExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_list_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_list_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, uint hook_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_list_invoke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool may_recurse);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_list_invoke_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool may_recurse);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_list_marshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool may_recurse, MentorLake.GLib.GHookMarshaller marshaller, IntPtr marshal_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_list_marshal_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, bool may_recurse, MentorLake.GLib.GHookCheckMarshaller marshaller, IntPtr marshal_data);

}

/// <summary>
/// <para>
/// The #GHookList struct represents a list of hook functions.
/// </para>
/// </summary>

public struct GHookList
{
	/// <summary>
/// <para>
/// the next free #GHook id
/// </para>
/// </summary>

public ulong seq_id;
	/// <summary>
/// <para>
/// the size of the #GHookList elements, in bytes
/// </para>
/// </summary>

public uint hook_size;
	/// <summary>
/// <para>
/// 1 if the #GHookList has been initialized
/// </para>
/// </summary>

public uint is_setup;
	/// <summary>
/// <para>
/// the first #GHook element in the list
/// </para>
/// </summary>

public IntPtr hooks;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public IntPtr dummy3;
	/// <summary>
/// <para>
/// the function to call to finalize a #GHook element.
///     The default behaviour is to call the hooks @destroy function
/// </para>
/// </summary>

public GHookFinalizeFunc finalize_hook;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public IntPtr dummy;
}
