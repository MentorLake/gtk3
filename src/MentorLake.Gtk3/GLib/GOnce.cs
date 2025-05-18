namespace MentorLake.GLib;

public class GOnceHandle : BaseSafeHandle
{
}


public static class GOnceExtensions
{
	public static IntPtr Impl(this MentorLake.GLib.GOnceHandle once, MentorLake.GLib.GThreadFunc func, IntPtr arg)
	{
		if (once.IsInvalid) throw new Exception("Invalid handle (GOnce)");
		return GOnceExterns.g_once_impl(once, func, arg);
	}


	public static GOnce Dereference(this GOnceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOnce>(x.DangerousGetHandle());
}
internal class GOnceExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_once_impl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOnceHandle>))] MentorLake.GLib.GOnceHandle once, MentorLake.GLib.GThreadFunc func, IntPtr arg);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter(ref IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_impl(UIntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_pointer(IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave(ref IntPtr location, UIntPtr result);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave_pointer(IntPtr location, IntPtr result);

}

public struct GOnce
{
	public GOnceStatus status;
	public IntPtr retval;
	public static bool InitEnter(ref IntPtr location)
	{
		return GOnceExterns.g_once_init_enter(ref location);
	}

	public static bool InitEnterImpl(UIntPtr location)
	{
		return GOnceExterns.g_once_init_enter_impl(location);
	}

	public static bool InitEnterPointer(IntPtr location)
	{
		return GOnceExterns.g_once_init_enter_pointer(location);
	}

	public static void InitLeave(ref IntPtr location, UIntPtr result)
	{
		GOnceExterns.g_once_init_leave(ref location, result);
	}

	public static void InitLeavePointer(IntPtr location, IntPtr result)
	{
		GOnceExterns.g_once_init_leave_pointer(location, result);
	}

}
