namespace MentorLake.GLib;

public class GHookListHandle : BaseSafeHandle
{
}


public static class GHookListExtensions
{
	public static void Clear(this MentorLake.GLib.GHookListHandle hook_list)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_clear(hook_list);
	}

	public static void Init(this MentorLake.GLib.GHookListHandle hook_list, uint hook_size)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_init(hook_list, hook_size);
	}

	public static void Invoke(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_invoke(hook_list, may_recurse);
	}

	public static void InvokeCheck(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_invoke_check(hook_list, may_recurse);
	}

	public static void Marshal(this MentorLake.GLib.GHookListHandle hook_list, bool may_recurse, MentorLake.GLib.GHookMarshaller marshaller, IntPtr marshal_data)
	{
		if (hook_list.IsInvalid) throw new Exception("Invalid handle (GHookList)");
		GHookListExterns.g_hook_list_marshal(hook_list, may_recurse, marshaller, marshal_data);
	}

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

public struct GHookList
{
	public ulong seq_id;
	public uint hook_size;
	public uint is_setup;
	public IntPtr hooks;
	public IntPtr dummy3;
	public GHookFinalizeFunc finalize_hook;
	public IntPtr dummy;
}
