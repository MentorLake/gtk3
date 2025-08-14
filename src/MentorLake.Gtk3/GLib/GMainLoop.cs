namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GMainLoop` struct is an opaque data type
/// representing the main event loop of a GLib or GTK application.
/// </para>
/// </summary>

public class GMainLoopHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@GLib.MainLoop] structure.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMainContext  (if %NULL, the global-default
///   main context will be used).
/// </param>
/// <param name="is_running">
/// set to %TRUE to indicate that the loop is running. This
/// is not very important since calling [method@GLib.MainLoop.run] will set this
/// to %TRUE anyway.
/// </param>
/// <return>
/// a new #GMainLoop.
/// </return>

	public static MentorLake.GLib.GMainLoopHandle New(MentorLake.GLib.GMainContextHandle context, bool is_running)
	{
		return GMainLoopExterns.g_main_loop_new(context, is_running);
	}

}


public static class GMainLoopExtensions
{
/// <summary>
/// <para>
/// Returns the [struct@GLib.MainContext] of @loop.
/// </para>
/// </summary>

/// <param name="loop">
/// a #GMainLoop.
/// </param>
/// <return>
/// the [struct@GLib.MainContext] of @loop
/// </return>

	public static MentorLake.GLib.GMainContextHandle GetContext(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		return GMainLoopExterns.g_main_loop_get_context(loop);
	}

/// <summary>
/// <para>
/// Checks to see if the main loop is currently being run via
/// [method@GLib.MainLoop.run].
/// </para>
/// </summary>

/// <param name="loop">
/// a #GMainLoop.
/// </param>
/// <return>
/// %TRUE if the mainloop is currently being run.
/// </return>

	public static bool IsRunning(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		return GMainLoopExterns.g_main_loop_is_running(loop);
	}

/// <summary>
/// <para>
/// Stops a [struct@GLib.MainLoop] from running. Any calls to
/// [method@GLib.MainLoop.run] for the loop will return.
/// </para>
/// <para>
/// Note that sources that have already been dispatched when
/// [method@GLib.MainLoop.quit] is called will still be executed.
/// </para>
/// </summary>

/// <param name="loop">
/// a #GMainLoop
/// </param>

	public static void Quit(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		GMainLoopExterns.g_main_loop_quit(loop);
	}

/// <summary>
/// <para>
/// Increases the reference count on a [struct@GLib.MainLoop] object by one.
/// </para>
/// </summary>

/// <param name="loop">
/// a #GMainLoop
/// </param>
/// <return>
/// @loop
/// </return>

	public static MentorLake.GLib.GMainLoopHandle Ref(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		return GMainLoopExterns.g_main_loop_ref(loop);
	}

/// <summary>
/// <para>
/// Runs a main loop until [method@GLib.MainLoop.quit] is called on the loop.
/// If this is called for the thread of the loop's #GMainContext,
/// it will process events from the loop, otherwise it will
/// simply wait.
/// </para>
/// </summary>

/// <param name="loop">
/// a #GMainLoop
/// </param>

	public static void Run(this MentorLake.GLib.GMainLoopHandle loop)
	{
		if (loop.IsInvalid) throw new Exception("Invalid handle (GMainLoop)");
		GMainLoopExterns.g_main_loop_run(loop);
	}

/// <summary>
/// <para>
/// Decreases the reference count on a [struct@GLib.MainLoop] object by one. If
/// the result is zero, free the loop and free all associated memory.
/// </para>
/// </summary>

/// <param name="loop">
/// a #GMainLoop
/// </param>

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

/// <summary>
/// <para>
/// The `GMainLoop` struct is an opaque data type
/// representing the main event loop of a GLib or GTK application.
/// </para>
/// </summary>

public struct GMainLoop
{
}
