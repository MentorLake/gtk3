namespace MentorLake.Gio;

public class GAppLaunchContextClassHandle : BaseSafeHandle
{
}


public static class GAppLaunchContextClassExtensions
{

	public static GAppLaunchContextClass Dereference(this GAppLaunchContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAppLaunchContextClass>(x.DangerousGetHandle());
}
internal class GAppLaunchContextClassExterns
{
}

public struct GAppLaunchContextClass
{
	public GObjectClass parent_class;
	public IntPtr get_display;
	public IntPtr get_startup_notify_id;
	public IntPtr launch_failed;
	public IntPtr launched;
	public IntPtr launch_started;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
}
