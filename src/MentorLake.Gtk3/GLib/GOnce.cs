namespace MentorLake.Gtk3.GLib;

public class GOnceHandle : BaseSafeHandle
{
}


public static class GOnceHandleExtensions
{
	public static IntPtr Impl(this GOnceHandle once, GThreadFunc func, IntPtr arg)
	{
		return GOnceExterns.g_once_impl(once, func, arg);
	}

	public static bool InitEnter(IntPtr location)
	{
		return GOnceExterns.g_once_init_enter(location);
	}

	public static bool InitEnterImpl(ref UIntPtr location)
	{
		return GOnceExterns.g_once_init_enter_impl(ref location);
	}

	public static bool InitEnterPointer(IntPtr location)
	{
		return GOnceExterns.g_once_init_enter_pointer(location);
	}

	public static void InitLeave(IntPtr location, UIntPtr result)
	{
		GOnceExterns.g_once_init_leave(location, result);
	}

	public static void InitLeavePointer(IntPtr location, IntPtr result)
	{
		GOnceExterns.g_once_init_leave_pointer(location, result);
	}

}
internal class GOnceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_once_impl(GOnceHandle once, GThreadFunc func, IntPtr arg);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_once_init_enter(IntPtr location);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_once_init_enter_impl(ref UIntPtr location);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_once_init_enter_pointer(IntPtr location);

	[DllImport(Libraries.GLib)]
	internal static extern void g_once_init_leave(IntPtr location, UIntPtr result);

	[DllImport(Libraries.GLib)]
	internal static extern void g_once_init_leave_pointer(IntPtr location, IntPtr result);

}

public struct GOnce
{
	public GOnceStatus status;
	public IntPtr retval;
}
