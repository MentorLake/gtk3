namespace MentorLake.GLib;

public class GCompletionHandle : BaseSafeHandle
{
}


public static class GCompletionExtensions
{
	public static void AddItems(this MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GListHandle items)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
		GCompletionExterns.g_completion_add_items(cmp, items);
	}

	public static void ClearItems(this MentorLake.GLib.GCompletionHandle cmp)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
		GCompletionExterns.g_completion_clear_items(cmp);
	}

	public static MentorLake.GLib.GListHandle Complete(this MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
		return GCompletionExterns.g_completion_complete(cmp, prefix, new_prefix);
	}

	public static MentorLake.GLib.GListHandle CompleteUtf8(this MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
		return GCompletionExterns.g_completion_complete_utf8(cmp, prefix, new_prefix);
	}

	public static void Free(this MentorLake.GLib.GCompletionHandle cmp)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
		GCompletionExterns.g_completion_free(cmp);
	}

	public static void RemoveItems(this MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GListHandle items)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
		GCompletionExterns.g_completion_remove_items(cmp, items);
	}

	public static void SetCompare(this MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GCompletionStrncmpFunc strncmp_func)
	{
		if (cmp.IsInvalid || cmp.IsClosed) throw new Exception("Invalid or closed handle (GCompletion)");
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
	internal static extern MentorLake.GLib.GListHandle g_completion_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_completion_complete_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, string prefix, string new_prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_remove_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle items);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_completion_set_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCompletionHandle>))] MentorLake.GLib.GCompletionHandle cmp, MentorLake.GLib.GCompletionStrncmpFunc strncmp_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GCompletionHandle g_completion_new(MentorLake.GLib.GCompletionFunc func);

}

public struct GCompletion
{
	public IntPtr items;
	public GCompletionFunc func;
	public string prefix;
	public IntPtr cache;
	public GCompletionStrncmpFunc strncmp_func;
	public static MentorLake.GLib.GCompletionHandle New(MentorLake.GLib.GCompletionFunc func)
	{
		return GCompletionExterns.g_completion_new(func);
	}

}
