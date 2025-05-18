namespace MentorLake.GLib;

public class GMainLoopHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GMainLoopHandle New(MentorLake.GLib.GMainContextHandle context, bool is_running)
	{
		return GMainLoopExterns.g_main_loop_new(context, is_running);
	}

}


public static class GMainLoopExtensions
{
	public static MentorLake.GLib.GMainContextHandle GetContext(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		return GMainLoopExterns.g_main_loop_get_context(loop);
	}

	public static bool IsRunning(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		return GMainLoopExterns.g_main_loop_is_running(loop);
	}

	public static void Quit(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		GMainLoopExterns.g_main_loop_quit(loop);
	}

	public static MentorLake.GLib.GMainLoopHandle Ref(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		return GMainLoopExterns.g_main_loop_ref(loop);
	}

	public static void Run(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		GMainLoopExterns.g_main_loop_run(loop);
	}

	public static void Unref(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		GMainLoopExterns.g_main_loop_unref(loop);
	}


	public static GMainLoop Dereference(this GMainLoopHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMainLoop>(x.DangerousGetHandle());
}
internal class GMainLoopExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))]
	internal static extern MentorLake.GLib.GMainLoopHandle g_main_loop_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, bool is_running);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_loop_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))] MentorLake.GLib.GMainLoopHandle loop);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_loop_is_running([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))] MentorLake.GLib.GMainLoopHandle loop);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_loop_quit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))] MentorLake.GLib.GMainLoopHandle loop);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))]
	internal static extern MentorLake.GLib.GMainLoopHandle g_main_loop_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))] MentorLake.GLib.GMainLoopHandle loop);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_loop_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))] MentorLake.GLib.GMainLoopHandle loop);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_loop_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainLoopHandle>))] MentorLake.GLib.GMainLoopHandle loop);

}

public struct GMainLoop
{
}
